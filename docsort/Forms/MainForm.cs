using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using docsort.Models;
using ikvm.extensions;
using PdfiumViewer;
using TikaOnDotNet.TextExtraction;

namespace docsort.Forms
{
    public partial class MainForm : Form
    {
        private BindingList<Document> _documents = new BindingList<Document>();
        private Stream _pdfViewerFileStream;

        public MainForm()
        {
            InitializeComponent();
            InitializeConfiguration();

            dgvDocuments.DataSource = _documents;
        }

        private static void InitializeConfiguration()
        {
            Configuration.Values = ConfigValues.ReadFromFile();

            // ReSharper disable once ConvertIfStatementToNullCoalescingExpression
            if (Configuration.Values == null)
            {
                // File did not exist
                Configuration.Values = new ConfigValues();
            }
        }

        private void dgvFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dgvFiles_DragDrop(object sender, DragEventArgs e)
        {
            var filePaths = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < filePaths.Length; i++)
            {
                var path = filePaths[i];
                Console.WriteLine($@"Adding {path}");

                dgvDocuments.DataSource = null;
                _documents.Add(new Document()
                {
                    Path = path
                });
                dgvDocuments.DataSource = _documents;
            }
        }

        private async void btnStartProcessing_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.Rows.Count == 0) return;

            btnStartProcessing.Enabled = false;
            btnMoveFiles.Enabled = false;

            await Task.Run(() =>
            {
                Console.WriteLine(@"Start processing");
                foreach (var document in _documents)
                {
                    document.StatusText = "";
                    document.DetectedCorrespondent = null;
                }

                foreach (var document in _documents)
                {
                    Console.WriteLine($@"Processing {document.Path}");
                    document.StatusText = "Processing...";

                    if (!CheckFileExtensionAllowed(document.Path))
                    {
                        document.StatusText = "Unsupported file extension";
                        continue;
                    }

                    var correspondent = GetCorrespondentFromPdfFile(document.Path);
                    if (correspondent == null)
                    {
                        Console.WriteLine($@"Detected correspondent: null");
                        document.StatusText = "Couldn't detect";
                        continue;
                    }

                    Console.WriteLine($@"Detected correspondent: {correspondent.Name}");


                    document.DetectedCorrespondent = correspondent;

                    document.StatusText = "OK";
                }

                Console.WriteLine(@"Processing all files finished");
            });

            btnStartProcessing.Enabled = true;
            btnMoveFiles.Enabled = true;
        }

        private bool CheckFileExtensionAllowed(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            return Path.GetExtension(path).ToLower() == ".pdf";
        }

        private string GetPdfFileText(string path)
        {
            return new TextExtractor().Extract(path).Text;
        }

        private Correspondent GetCorrespondentFromPdfFile(string path)
        {
            var text = GetPdfFileText(path);
            //Console.WriteLine($@"Got text: {text}");

            Correspondent matchingCorrespondent = null;
            foreach (var correspondent in Configuration.Values.Correspondents)
            {
                if (correspondent.MatchesText(text))
                {
                    matchingCorrespondent = correspondent;
                    break;
                }
            }

            return matchingCorrespondent;
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            foreach (var document in _documents)
            {
                if (document.DetectedCorrespondent == null)
                {
                    continue;
                }

                if (string.IsNullOrWhiteSpace(document.Date) || string.IsNullOrWhiteSpace(document.Subject))
                {
                    document.StatusText = "Fill out please";
                    continue;
                }

                document.StatusText = "Moving...";
                try
                {
                    var sourcePath = document.Path;
                    var fileName = document.Date + "_" + document.Subject + Path.GetExtension(document.Path);
                    var destinationPath = document.DetectedCorrespondent.SavePath + "\\" + fileName;

                    if (File.Exists(destinationPath))
                    {
                        document.StatusText = "Error: Destination exists";
                    }
                    else
                    {
                        Console.WriteLine($@"Moving {sourcePath} to {destinationPath}...");
                        File.Move(sourcePath, destinationPath);

                        document.StatusText = "Finished";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($@"Exception: {ex}");
                    ex.printStackTrace();
                    Console.WriteLine($@"Inner ex: {ex.InnerException}");
                    ex.InnerException?.printStackTrace();

                    document.StatusText = "Error moving";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration.Values.Save();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void btnRemoveFinished_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _documents.Count;)
            {
                var document = _documents[i];
                if (document.StatusText == "Finished")
                {
                    _documents.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void dgvDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                // Button column clicked
                if (e.RowIndex >= 0)
                    HandleDataGridViewButtonClicked(_documents[e.RowIndex]);
            }
        }

        private void HandleDataGridViewButtonClicked(Document document)
        {
            Console.WriteLine($@"Analysis: {document}");
            MessageBox.Show($@"Press Ctrl+C to copy...
 Document {document.Path} with content:
{GetPdfFileText(document.Path)}");
        }

        private void dgvDocuments_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var document = _documents[e.RowIndex];
            Console.WriteLine($@"Preview: {document}");

            if (CheckFileExtensionAllowed(document.Path))
            {
                try
                {
                    var oldStream = _pdfViewerFileStream;
                    oldStream?.Close();

                    _pdfViewerFileStream =
                        new FileStream(document.Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    pdfViewer.Document = PdfDocument.Load(_pdfViewerFileStream);

                    oldStream?.Dispose();
                }
                catch (FileNotFoundException)
                {
                    // Nothing, file does not exist (maybe it was moved by this program)
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}