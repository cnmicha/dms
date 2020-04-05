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
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detectedCorrespondentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.pathDataGridViewTextBoxColumn,
            this.detectedCorrespondentDataGridViewTextBoxColumn,
            this.statusTextDataGridViewTextBoxColumn,
            this.trainButtonColumn});
            this.dgvDocuments.DataSource = this.documentBindingSource;
            this.dgvDocuments.Location = new System.Drawing.Point(16, 34);
            this.dgvDocuments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.Size = new System.Drawing.Size(1380, 460);
            this.dgvDocuments.TabIndex = 0;
            this.dgvDocuments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellClick);
            this.dgvDocuments.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragDrop);
            this.dgvDocuments.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragEnter);
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.Location = new System.Drawing.Point(16, 511);
            this.btnStartProcessing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(153, 28);
            this.btnStartProcessing.TabIndex = 1;
            this.btnStartProcessing.Text = "Start processing";
            this.btnStartProcessing.UseVisualStyleBackColor = true;
            this.btnStartProcessing.Click += new System.EventHandler(this.btnStartProcessing_Click);
            // 
            // btnRemoveFinished
            // 
            this.btnRemoveFinished.Location = new System.Drawing.Point(349, 511);
            this.btnRemoveFinished.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFinished.Name = "btnRemoveFinished";
            this.btnRemoveFinished.Size = new System.Drawing.Size(130, 28);
            this.btnRemoveFinished.TabIndex = 2;
            this.btnRemoveFinished.Text = "Remove finished";
            this.btnRemoveFinished.UseVisualStyleBackColor = true;
            this.btnRemoveFinished.Click += new System.EventHandler(this.btnRemoveFinished_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Enabled = false;
            this.btnMoveFiles.Location = new System.Drawing.Point(177, 511);
            this.btnMoveFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(164, 28);
            this.btnMoveFiles.TabIndex = 1;
            this.btnMoveFiles.Text = "Move files";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drop a file to start";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1296, 511);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 28);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(docsort.Document);
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Width = 425;
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
            this.statusTextDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainButtonColumn
            // 
            this.trainButtonColumn.HeaderText = "Aktionen";
            this.trainButtonColumn.MinimumWidth = 6;
            this.trainButtonColumn.Name = "trainButtonColumn";
            this.trainButtonColumn.ReadOnly = true;
            this.trainButtonColumn.Text = "Analyze";
            this.trainButtonColumn.UseColumnTextForButtonValue = true;
            this.trainButtonColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 554);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveFinished);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.dgvDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detectedCorrespondentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn trainButtonColumn;
    }
}

