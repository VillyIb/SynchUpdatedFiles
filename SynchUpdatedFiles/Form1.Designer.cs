namespace SynchUpdatedFiles
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.XuTable = new System.Windows.Forms.DataGridView();
            this.XuTest1 = new System.Windows.Forms.Button();
            this.XuFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.XuTargetFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XuSourceFolder = new System.Windows.Forms.TextBox();
            this.XuTargetFolderBrowse = new System.Windows.Forms.Button();
            this.XuSourceFolderBrowse = new System.Windows.Forms.Button();
            this.XuSynch = new System.Windows.Forms.Button();
            this.XuClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.XuShowNewer = new System.Windows.Forms.CheckBox();
            this.XuShowEqual = new System.Windows.Forms.CheckBox();
            this.XuShowOlder = new System.Windows.Forms.CheckBox();
            this.XcFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcLeftVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcRightVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.XuTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XuTable
            // 
            this.XuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XuTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XcFilename,
            this.XcLeftVersion,
            this.XcDirection,
            this.XcRightVersion});
            this.XuTable.Location = new System.Drawing.Point(47, 330);
            this.XuTable.Name = "XuTable";
            this.XuTable.Size = new System.Drawing.Size(772, 371);
            this.XuTable.TabIndex = 0;
            this.XuTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XuTable_CellContentClick);
            this.XuTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XuTable_CellContentDoubleClick);
            this.XuTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XuTable_CellDoubleClick);
            this.XuTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.XuTable_CellMouseClick);
            this.XuTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.XuTable_CellMouseDoubleClick);
            // 
            // XuTest1
            // 
            this.XuTest1.Location = new System.Drawing.Point(573, 177);
            this.XuTest1.Name = "XuTest1";
            this.XuTest1.Size = new System.Drawing.Size(75, 23);
            this.XuTest1.TabIndex = 1;
            this.XuTest1.Text = "Compare";
            this.XuTest1.UseVisualStyleBackColor = true;
            this.XuTest1.Click += new System.EventHandler(this.XuTest1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target folder";
            // 
            // XuTargetFolder
            // 
            this.XuTargetFolder.Location = new System.Drawing.Point(145, 59);
            this.XuTargetFolder.Name = "XuTargetFolder";
            this.XuTargetFolder.Size = new System.Drawing.Size(390, 20);
            this.XuTargetFolder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source folder";
            // 
            // XuSourceFolder
            // 
            this.XuSourceFolder.Location = new System.Drawing.Point(145, 113);
            this.XuSourceFolder.Name = "XuSourceFolder";
            this.XuSourceFolder.Size = new System.Drawing.Size(390, 20);
            this.XuSourceFolder.TabIndex = 5;
            // 
            // XuTargetFolderBrowse
            // 
            this.XuTargetFolderBrowse.Location = new System.Drawing.Point(573, 59);
            this.XuTargetFolderBrowse.Name = "XuTargetFolderBrowse";
            this.XuTargetFolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.XuTargetFolderBrowse.TabIndex = 6;
            this.XuTargetFolderBrowse.Text = "Browse";
            this.XuTargetFolderBrowse.UseVisualStyleBackColor = true;
            this.XuTargetFolderBrowse.Click += new System.EventHandler(this.XuTargetFolderBrowse_Click);
            // 
            // XuSourceFolderBrowse
            // 
            this.XuSourceFolderBrowse.Location = new System.Drawing.Point(573, 113);
            this.XuSourceFolderBrowse.Name = "XuSourceFolderBrowse";
            this.XuSourceFolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.XuSourceFolderBrowse.TabIndex = 7;
            this.XuSourceFolderBrowse.Text = "Browse";
            this.XuSourceFolderBrowse.UseVisualStyleBackColor = true;
            this.XuSourceFolderBrowse.Click += new System.EventHandler(this.XuSourceFolderBrowse_Click);
            // 
            // XuSynch
            // 
            this.XuSynch.Location = new System.Drawing.Point(573, 745);
            this.XuSynch.Name = "XuSynch";
            this.XuSynch.Size = new System.Drawing.Size(75, 23);
            this.XuSynch.TabIndex = 8;
            this.XuSynch.Text = "<<<---";
            this.XuSynch.UseVisualStyleBackColor = true;
            this.XuSynch.Click += new System.EventHandler(this.XuSynch_Click);
            // 
            // XuClose
            // 
            this.XuClose.Location = new System.Drawing.Point(573, 1002);
            this.XuClose.Name = "XuClose";
            this.XuClose.Size = new System.Drawing.Size(75, 23);
            this.XuClose.TabIndex = 9;
            this.XuClose.Text = "Close";
            this.XuClose.UseVisualStyleBackColor = true;
            this.XuClose.Click += new System.EventHandler(this.XuClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product / File version";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.XuShowNewer);
            this.groupBox1.Controls.Add(this.XuShowEqual);
            this.groupBox1.Controls.Add(this.XuShowOlder);
            this.groupBox1.Location = new System.Drawing.Point(289, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show the following ";
            // 
            // XuShowNewer
            // 
            this.XuShowNewer.AutoSize = true;
            this.XuShowNewer.Checked = true;
            this.XuShowNewer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XuShowNewer.Location = new System.Drawing.Point(377, 20);
            this.XuShowNewer.Name = "XuShowNewer";
            this.XuShowNewer.Size = new System.Drawing.Size(53, 17);
            this.XuShowNewer.TabIndex = 3;
            this.XuShowNewer.Text = "<<<---";
            this.XuShowNewer.UseVisualStyleBackColor = true;
            this.XuShowNewer.CheckedChanged += new System.EventHandler(this.XuTest1_Click);
            // 
            // XuShowEqual
            // 
            this.XuShowEqual.AutoSize = true;
            this.XuShowEqual.Checked = true;
            this.XuShowEqual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XuShowEqual.Location = new System.Drawing.Point(192, 20);
            this.XuShowEqual.Name = "XuShowEqual";
            this.XuShowEqual.Size = new System.Drawing.Size(38, 17);
            this.XuShowEqual.TabIndex = 1;
            this.XuShowEqual.Text = "==";
            this.XuShowEqual.UseVisualStyleBackColor = true;
            this.XuShowEqual.CheckedChanged += new System.EventHandler(this.XuTest1_Click);
            // 
            // XuShowOlder
            // 
            this.XuShowOlder.AutoSize = true;
            this.XuShowOlder.Checked = true;
            this.XuShowOlder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XuShowOlder.Location = new System.Drawing.Point(21, 20);
            this.XuShowOlder.Name = "XuShowOlder";
            this.XuShowOlder.Size = new System.Drawing.Size(53, 17);
            this.XuShowOlder.TabIndex = 0;
            this.XuShowOlder.Text = "--->>>";
            this.XuShowOlder.UseVisualStyleBackColor = true;
            this.XuShowOlder.CheckedChanged += new System.EventHandler(this.XuTest1_Click);
            // 
            // XcFilename
            // 
            this.XcFilename.DataPropertyName = "Filename";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.XcFilename.DefaultCellStyle = dataGridViewCellStyle2;
            this.XcFilename.HeaderText = "Filename";
            this.XcFilename.MinimumWidth = 250;
            this.XcFilename.Name = "XcFilename";
            this.XcFilename.ReadOnly = true;
            this.XcFilename.Width = 300;
            // 
            // XcLeftVersion
            // 
            this.XcLeftVersion.DataPropertyName = "TargetVersion";
            this.XcLeftVersion.HeaderText = "Target";
            this.XcLeftVersion.MinimumWidth = 150;
            this.XcLeftVersion.Name = "XcLeftVersion";
            this.XcLeftVersion.ReadOnly = true;
            this.XcLeftVersion.Width = 150;
            // 
            // XcDirection
            // 
            this.XcDirection.DataPropertyName = "Direction";
            this.XcDirection.HeaderText = "Direction";
            this.XcDirection.MinimumWidth = 110;
            this.XcDirection.Name = "XcDirection";
            this.XcDirection.ReadOnly = true;
            this.XcDirection.Width = 110;
            // 
            // XcRightVersion
            // 
            this.XcRightVersion.DataPropertyName = "SourceVersion";
            this.XcRightVersion.HeaderText = "Source";
            this.XcRightVersion.MinimumWidth = 150;
            this.XcRightVersion.Name = "XcRightVersion";
            this.XcRightVersion.ReadOnly = true;
            this.XcRightVersion.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 779);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XuClose);
            this.Controls.Add(this.XuSynch);
            this.Controls.Add(this.XuSourceFolderBrowse);
            this.Controls.Add(this.XuTargetFolderBrowse);
            this.Controls.Add(this.XuSourceFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XuTargetFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XuTest1);
            this.Controls.Add(this.XuTable);
            this.Name = "Form1";
            this.Text = "SynchUpdatedFiles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XuTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView XuTable;
        private System.Windows.Forms.Button XuTest1;
        private System.Windows.Forms.FolderBrowserDialog XuFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XuTargetFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XuSourceFolder;
        private System.Windows.Forms.Button XuTargetFolderBrowse;
        private System.Windows.Forms.Button XuSourceFolderBrowse;
        private System.Windows.Forms.Button XuSynch;
        private System.Windows.Forms.Button XuClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox XuShowNewer;
        private System.Windows.Forms.CheckBox XuShowEqual;
        private System.Windows.Forms.CheckBox XuShowOlder;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcLeftVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcRightVersion;

    }
}

