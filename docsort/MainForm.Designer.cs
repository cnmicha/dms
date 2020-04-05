namespace docsort
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.btnStartProcessing = new System.Windows.Forms.Button();
            this.btnRemoveFinished = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detectedCorrespondentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowDrop = true;
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AutoGenerateColumns = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.detectedCorrespondentDataGridViewTextBoxColumn,
            this.Date,
            this.Subject,
            this.statusTextDataGridViewTextBoxColumn,
            this.trainButtonColumn});
            this.dgvDocuments.DataSource = this.documentBindingSource;
            this.dgvDocuments.Location = new System.Drawing.Point(12, 28);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.Size = new System.Drawing.Size(1035, 275);
            this.dgvDocuments.TabIndex = 0;
            this.dgvDocuments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellClick);
            this.dgvDocuments.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_RowEnter);
            this.dgvDocuments.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragDrop);
            this.dgvDocuments.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragEnter);
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.Location = new System.Drawing.Point(12, 309);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(115, 23);
            this.btnStartProcessing.TabIndex = 1;
            this.btnStartProcessing.Text = "Start processing";
            this.btnStartProcessing.UseVisualStyleBackColor = true;
            this.btnStartProcessing.Click += new System.EventHandler(this.btnStartProcessing_Click);
            // 
            // btnRemoveFinished
            // 
            this.btnRemoveFinished.Location = new System.Drawing.Point(262, 309);
            this.btnRemoveFinished.Name = "btnRemoveFinished";
            this.btnRemoveFinished.Size = new System.Drawing.Size(98, 23);
            this.btnRemoveFinished.TabIndex = 2;
            this.btnRemoveFinished.Text = "Remove finished";
            this.btnRemoveFinished.UseVisualStyleBackColor = true;
            this.btnRemoveFinished.Click += new System.EventHandler(this.btnRemoveFinished_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Enabled = false;
            this.btnMoveFiles.Location = new System.Drawing.Point(133, 309);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(123, 23);
            this.btnMoveFiles.TabIndex = 1;
            this.btnMoveFiles.Text = "Move documents";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drop a file to start";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(972, 309);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Location = new System.Drawing.Point(12, 338);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(1035, 590);
            this.pdfViewer.TabIndex = 5;
            this.pdfViewer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "File name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 200;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Width = 200;
            // 
            // trainButtonColumn
            // 
            this.trainButtonColumn.HeaderText = "Aktionen";
            this.trainButtonColumn.MinimumWidth = 6;
            this.trainButtonColumn.Name = "trainButtonColumn";
            this.trainButtonColumn.ReadOnly = true;
            this.trainButtonColumn.Text = "Analyze";
            this.trainButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // detectedCorrespondentDataGridViewTextBoxColumn
            // 
            this.detectedCorrespondentDataGridViewTextBoxColumn.DataPropertyName = "DetectedCorrespondent";
            this.detectedCorrespondentDataGridViewTextBoxColumn.HeaderText = "Correspondent";
            this.detectedCorrespondentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detectedCorrespondentDataGridViewTextBoxColumn.Name = "detectedCorrespondentDataGridViewTextBoxColumn";
            this.detectedCorrespondentDataGridViewTextBoxColumn.ReadOnly = true;
            this.detectedCorrespondentDataGridViewTextBoxColumn.Width = 250;
            // 
            // statusTextDataGridViewTextBoxColumn
            // 
            this.statusTextDataGridViewTextBoxColumn.DataPropertyName = "StatusText";
            this.statusTextDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusTextDataGridViewTextBoxColumn.Name = "statusTextDataGridViewTextBoxColumn";
            this.statusTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(docsort.Document);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 940);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveFinished);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.dgvDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DMS - Document Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnStartProcessing;
        private System.Windows.Forms.Button btnRemoveFinished;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn detectedCorrespondentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn trainButtonColumn;
    }
}

