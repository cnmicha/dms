namespace docsort
{
    partial class SettingsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvCorrespondents = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detectPatternsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correspondentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(632, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvCorrespondents
            // 
            this.dgvCorrespondents.AutoGenerateColumns = false;
            this.dgvCorrespondents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrespondents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.detectPatternsDataGridViewTextBoxColumn,
            this.savePathDataGridViewTextBoxColumn});
            this.dgvCorrespondents.DataSource = this.correspondentBindingSource;
            this.dgvCorrespondents.Location = new System.Drawing.Point(12, 12);
            this.dgvCorrespondents.Name = "dgvCorrespondents";
            this.dgvCorrespondents.Size = new System.Drawing.Size(776, 397);
            this.dgvCorrespondents.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 250F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // detectPatternsDataGridViewTextBoxColumn
            // 
            this.detectPatternsDataGridViewTextBoxColumn.DataPropertyName = "DetectPatterns";
            this.detectPatternsDataGridViewTextBoxColumn.HeaderText = "Search patterns (semicolon separated)";
            this.detectPatternsDataGridViewTextBoxColumn.Name = "detectPatternsDataGridViewTextBoxColumn";
            this.detectPatternsDataGridViewTextBoxColumn.Width = 350;
            // 
            // savePathDataGridViewTextBoxColumn
            // 
            this.savePathDataGridViewTextBoxColumn.DataPropertyName = "SavePath";
            this.savePathDataGridViewTextBoxColumn.FillWeight = 250F;
            this.savePathDataGridViewTextBoxColumn.HeaderText = "Save path";
            this.savePathDataGridViewTextBoxColumn.Name = "savePathDataGridViewTextBoxColumn";
            // 
            // correspondentBindingSource
            // 
            this.correspondentBindingSource.DataSource = typeof(docsort.Correspondent);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCorrespondents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvCorrespondents;
        private System.Windows.Forms.BindingSource correspondentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detectPatternsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savePathDataGridViewTextBoxColumn;
    }
}