namespace E_SPACE
{
    partial class JobDetails
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
            this.jobdbtndelete = new System.Windows.Forms.Button();
            this.jobdbtnupdate = new System.Windows.Forms.Button();
            this.jobdbtninsert = new System.Windows.Forms.Button();
            this.jobddgv = new System.Windows.Forms.DataGridView();
            this.jobdtxtcolonistid = new System.Windows.Forms.TextBox();
            this.jobdtxtjobid = new System.Windows.Forms.TextBox();
            this.jobdlblcolonistid = new System.Windows.Forms.Label();
            this.jobdlbljobid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobddgv)).BeginInit();
            this.SuspendLayout();
            // 
            // jobdbtndelete
            // 
            this.jobdbtndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.jobdbtndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.jobdbtndelete.Location = new System.Drawing.Point(593, 444);
            this.jobdbtndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobdbtndelete.Name = "jobdbtndelete";
            this.jobdbtndelete.Size = new System.Drawing.Size(105, 32);
            this.jobdbtndelete.TabIndex = 48;
            this.jobdbtndelete.Text = "Delete";
            this.jobdbtndelete.UseVisualStyleBackColor = false;
            this.jobdbtndelete.Click += new System.EventHandler(this.jobdbtndelete_Click);
            // 
            // jobdbtnupdate
            // 
            this.jobdbtnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.jobdbtnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.jobdbtnupdate.Location = new System.Drawing.Point(478, 444);
            this.jobdbtnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobdbtnupdate.Name = "jobdbtnupdate";
            this.jobdbtnupdate.Size = new System.Drawing.Size(105, 32);
            this.jobdbtnupdate.TabIndex = 45;
            this.jobdbtnupdate.Text = "Update";
            this.jobdbtnupdate.UseVisualStyleBackColor = false;
            this.jobdbtnupdate.Click += new System.EventHandler(this.jobdbtnupdate_Click);
            // 
            // jobdbtninsert
            // 
            this.jobdbtninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.jobdbtninsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.jobdbtninsert.Location = new System.Drawing.Point(362, 444);
            this.jobdbtninsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobdbtninsert.Name = "jobdbtninsert";
            this.jobdbtninsert.Size = new System.Drawing.Size(105, 32);
            this.jobdbtninsert.TabIndex = 44;
            this.jobdbtninsert.Text = "Insert";
            this.jobdbtninsert.UseVisualStyleBackColor = false;
            this.jobdbtninsert.Click += new System.EventHandler(this.jobdbtninsert_Click);
            // 
            // jobddgv
            // 
            this.jobddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobddgv.Location = new System.Drawing.Point(22, 127);
            this.jobddgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobddgv.Name = "jobddgv";
            this.jobddgv.RowHeadersWidth = 51;
            this.jobddgv.RowTemplate.Height = 24;
            this.jobddgv.Size = new System.Drawing.Size(676, 285);
            this.jobddgv.TabIndex = 43;
            this.jobddgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobddgv_CellClick);
            // 
            // jobdtxtcolonistid
            // 
            this.jobdtxtcolonistid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.jobdtxtcolonistid.Location = new System.Drawing.Point(146, 72);
            this.jobdtxtcolonistid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobdtxtcolonistid.Multiline = true;
            this.jobdtxtcolonistid.Name = "jobdtxtcolonistid";
            this.jobdtxtcolonistid.Size = new System.Drawing.Size(144, 25);
            this.jobdtxtcolonistid.TabIndex = 41;
            this.jobdtxtcolonistid.TextChanged += new System.EventHandler(this.jobdtxtcolonistid_TextChanged);
            // 
            // jobdtxtjobid
            // 
            this.jobdtxtjobid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.jobdtxtjobid.Location = new System.Drawing.Point(146, 26);
            this.jobdtxtjobid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobdtxtjobid.Multiline = true;
            this.jobdtxtjobid.Name = "jobdtxtjobid";
            this.jobdtxtjobid.Size = new System.Drawing.Size(144, 25);
            this.jobdtxtjobid.TabIndex = 40;
            this.jobdtxtjobid.TextChanged += new System.EventHandler(this.jobdtxtjobid_TextChanged);
            // 
            // jobdlblcolonistid
            // 
            this.jobdlblcolonistid.AutoSize = true;
            this.jobdlblcolonistid.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.jobdlblcolonistid.ForeColor = System.Drawing.Color.Cyan;
            this.jobdlblcolonistid.Location = new System.Drawing.Point(20, 72);
            this.jobdlblcolonistid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jobdlblcolonistid.Name = "jobdlblcolonistid";
            this.jobdlblcolonistid.Size = new System.Drawing.Size(108, 23);
            this.jobdlblcolonistid.TabIndex = 39;
            this.jobdlblcolonistid.Text = "Colonist ID";
            // 
            // jobdlbljobid
            // 
            this.jobdlbljobid.AutoSize = true;
            this.jobdlbljobid.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.jobdlbljobid.ForeColor = System.Drawing.Color.Cyan;
            this.jobdlbljobid.Location = new System.Drawing.Point(20, 26);
            this.jobdlbljobid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jobdlbljobid.Name = "jobdlbljobid";
            this.jobdlbljobid.Size = new System.Drawing.Size(67, 23);
            this.jobdlbljobid.TabIndex = 37;
            this.jobdlbljobid.Text = "Job ID";
            // 
            // JobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(721, 500);
            this.Controls.Add(this.jobdbtndelete);
            this.Controls.Add(this.jobdbtnupdate);
            this.Controls.Add(this.jobdbtninsert);
            this.Controls.Add(this.jobddgv);
            this.Controls.Add(this.jobdtxtcolonistid);
            this.Controls.Add(this.jobdtxtjobid);
            this.Controls.Add(this.jobdlblcolonistid);
            this.Controls.Add(this.jobdlbljobid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JobDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Details";
            this.Load += new System.EventHandler(this.Job_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobddgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button jobdbtndelete;
        private System.Windows.Forms.Button jobdbtnupdate;
        private System.Windows.Forms.Button jobdbtninsert;
        private System.Windows.Forms.DataGridView jobddgv;
        private System.Windows.Forms.TextBox jobdtxtcolonistid;
        private System.Windows.Forms.TextBox jobdtxtjobid;
        private System.Windows.Forms.Label jobdlblcolonistid;
        private System.Windows.Forms.Label jobdlbljobid;
    }
}