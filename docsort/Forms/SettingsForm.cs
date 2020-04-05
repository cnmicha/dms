using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using docsort.Models;

namespace docsort.Forms
{
    public partial class SettingsForm : Form
    {
        private BindingList<Correspondent> _correspondents = new BindingList<Correspondent>();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (var correspondent in Configuration.Values.Correspondents)
            {
                _correspondents.Add(correspondent.Clone());
            }

            dgvCorrespondents.DataSource = _correspondents;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ProcessChanges())
            {
                Close();
            }
        }

        private bool ProcessChanges()
        {
            if (ValidateUserInput())
            {
                Configuration.Values.Correspondents = _correspondents.ToList();
                Configuration.Values.Save();
                return true;
            }

            return false;
        }

        private bool ValidateUserInput()
        {
            foreach (var correspondent in _correspondents)
            {
                if (string.IsNullOrWhiteSpace(correspondent.Name))
                {
                    MessageBox.Show(@"Correspondent: Name must not be empty.", @"Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(correspondent.DetectRegex))
                {
                    MessageBox.Show(@"Correspondent: Detection regex must not be empty.", @"Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                if (string.IsNullOrWhiteSpace(correspondent.SavePath))
                {
                    MessageBox.Show(@"Correspondent: Save path must not be empty.", @"Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
    }
}