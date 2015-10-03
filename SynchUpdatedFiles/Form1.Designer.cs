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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.XuTable = new System.Windows.Forms.DataGridView();
            this.XcFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcLeftVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XcRightVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuTest1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.XuTable)).BeginInit();
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
            this.XuTable.Location = new System.Drawing.Point(45, 51);
            this.XuTable.Name = "XuTable";
            this.XuTable.Size = new System.Drawing.Size(443, 150);
            this.XuTable.TabIndex = 0;
            this.XuTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XuTable_CellContentClick);
            this.XuTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XuTable_CellContentDoubleClick);
            this.XuTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XuTable_CellDoubleClick);
            this.XuTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.XuTable_CellMouseClick);
            this.XuTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.XuTable_CellMouseDoubleClick);
            // 
            // XcFilename
            // 
            this.XcFilename.DataPropertyName = "Filename";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.XcFilename.DefaultCellStyle = dataGridViewCellStyle1;
            this.XcFilename.HeaderText = "Filename";
            this.XcFilename.MinimumWidth = 100;
            this.XcFilename.Name = "XcFilename";
            this.XcFilename.ReadOnly = true;
            // 
            // XcLeftVersion
            // 
            this.XcLeftVersion.DataPropertyName = "LeftVersion";
            this.XcLeftVersion.HeaderText = "LeftVersion";
            this.XcLeftVersion.MinimumWidth = 100;
            this.XcLeftVersion.Name = "XcLeftVersion";
            this.XcLeftVersion.ReadOnly = true;
            // 
            // XcDirection
            // 
            this.XcDirection.DataPropertyName = "Direction";
            this.XcDirection.HeaderText = "Direction";
            this.XcDirection.MinimumWidth = 100;
            this.XcDirection.Name = "XcDirection";
            // 
            // XcRightVersion
            // 
            this.XcRightVersion.DataPropertyName = "RightVersion";
            this.XcRightVersion.HeaderText = "RightVersion";
            this.XcRightVersion.MinimumWidth = 100;
            this.XcRightVersion.Name = "XcRightVersion";
            this.XcRightVersion.ReadOnly = true;
            // 
            // XuTest1
            // 
            this.XuTest1.Location = new System.Drawing.Point(587, 350);
            this.XuTest1.Name = "XuTest1";
            this.XuTest1.Size = new System.Drawing.Size(75, 23);
            this.XuTest1.TabIndex = 1;
            this.XuTest1.Text = "XuTest1";
            this.XuTest1.UseVisualStyleBackColor = true;
            this.XuTest1.Click += new System.EventHandler(this.XuTest1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 607);
            this.Controls.Add(this.XuTest1);
            this.Controls.Add(this.XuTable);
            this.Name = "Form1";
            this.Text = "SynchUpdatedFiles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XuTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView XuTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcLeftVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn XcRightVersion;
        private System.Windows.Forms.Button XuTest1;

    }
}

