namespace E_SPACE
{
    partial class Job
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
            this.jobdgv = new System.Windows.Forms.DataGridView();
            this.jobtxtjobdescription = new System.Windows.Forms.TextBox();
            this.jobtxtjobname = new System.Windows.Forms.TextBox();
            this.jobtxtjobid = new System.Windows.Forms.TextBox();
            this.joblbljobdescription = new System.Windows.Forms.Label();
            this.joblbljobname = new System.Windows.Forms.Label();
            this.joblbljobid = new System.Windows.Forms.Label();
            this.jobbtndelete = new System.Windows.Forms.Button();
            this.jobbtnupdate = new System.Windows.Forms.Button();
            this.jobbtninsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // jobdgv
            // 
            this.jobdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobdgv.Location = new System.Drawing.Point(27, 232);
            this.jobdgv.Name = "jobdgv";
            this.jobdgv.RowHeadersWidth = 51;
            this.jobdgv.RowTemplate.Height = 24;
            this.jobdgv.Size = new System.Drawing.Size(909, 294);
            this.jobdgv.TabIndex = 33;
            this.jobdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobdgv_CellClick);
            // 
            // jobtxtjobdescription
            // 
            this.jobtxtjobdescription.BackColor = System.Drawing.Color.PaleTurquoise;
            this.jobtxtjobdescription.Location = new System.Drawing.Point(234, 160);
            this.jobtxtjobdescription.Multiline = true;
            this.jobtxtjobdescription.Name = "jobtxtjobdescription";
            this.jobtxtjobdescription.Size = new System.Drawing.Size(191, 30);
            this.jobtxtjobdescription.TabIndex = 31;
            this.jobtxtjobdescription.TextChanged += new System.EventHandler(this.jobtxtjobdescription_TextChanged);
            // 
            // jobtxtjobname
            // 
            this.jobtxtjobname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.jobtxtjobname.Location = new System.Drawing.Point(234, 95);
            this.jobtxtjobname.Multiline = true;
            this.jobtxtjobname.Name = "jobtxtjobname";
            this.jobtxtjobname.Size = new System.Drawing.Size(191, 30);
            this.jobtxtjobname.TabIndex = 30;
            this.jobtxtjobname.TextChanged += new System.EventHandler(this.jobtxtjobname_TextChanged);
            // 
            // jobtxtjobid
            // 
            this.jobtxtjobid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.jobtxtjobid.Location = new System.Drawing.Point(234, 29);
            this.jobtxtjobid.Multiline = true;
            this.jobtxtjobid.Name = "jobtxtjobid";
            this.jobtxtjobid.Size = new System.Drawing.Size(191, 30);
            this.jobtxtjobid.TabIndex = 29;
            this.jobtxtjobid.TextChanged += new System.EventHandler(this.jobtxtjobid_TextChanged);
            // 
            // joblbljobdescription
            // 
            this.joblbljobdescription.AutoSize = true;
            this.joblbljobdescription.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.joblbljobdescription.ForeColor = System.Drawing.Color.Cyan;
            this.joblbljobdescription.Location = new System.Drawing.Point(21, 159);
            this.joblbljobdescription.Name = "joblbljobdescription";
            this.joblbljobdescription.Size = new System.Drawing.Size(194, 31);
            this.joblbljobdescription.TabIndex = 27;
            this.joblbljobdescription.Text = "Job Description";
            // 
            // joblbljobname
            // 
            this.joblbljobname.AutoSize = true;
            this.joblbljobname.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.joblbljobname.ForeColor = System.Drawing.Color.Cyan;
            this.joblbljobname.Location = new System.Drawing.Point(21, 94);
            this.joblbljobname.Name = "joblbljobname";
            this.joblbljobname.Size = new System.Drawing.Size(129, 31);
            this.joblbljobname.TabIndex = 26;
            this.joblbljobname.Text = "Job Name";
            // 
            // joblbljobid
            // 
            this.joblbljobid.AutoSize = true;
            this.joblbljobid.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.joblbljobid.ForeColor = System.Drawing.Color.Cyan;
            this.joblbljobid.Location = new System.Drawing.Point(21, 28);
            this.joblbljobid.Name = "joblbljobid";
            this.joblbljobid.Size = new System.Drawing.Size(88, 31);
            this.joblbljobid.TabIndex = 25;
            this.joblbljobid.Text = "Job ID";
            // 
            // jobbtndelete
            // 
            this.jobbtndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.jobbtndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.jobbtndelete.Location = new System.Drawing.Point(796, 556);
            this.jobbtndelete.Name = "jobbtndelete";
            this.jobbtndelete.Size = new System.Drawing.Size(140, 40);
            this.jobbtndelete.TabIndex = 36;
            this.jobbtndelete.Text = "Delete";
            this.jobbtndelete.UseVisualStyleBackColor = false;
            this.jobbtndelete.Click += new System.EventHandler(this.jobbtndelete_Click);
            // 
            // jobbtnupdate
            // 
            this.jobbtnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.jobbtnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.jobbtnupdate.Location = new System.Drawing.Point(637, 556);
            this.jobbtnupdate.Name = "jobbtnupdate";
            this.jobbtnupdate.Size = new System.Drawing.Size(140, 40);
            this.jobbtnupdate.TabIndex = 35;
            this.jobbtnupdate.Text = "Update";
            this.jobbtnupdate.UseVisualStyleBackColor = false;
            this.jobbtnupdate.Click += new System.EventHandler(this.jobbtnupdate_Click);
            // 
            // jobbtninsert
            // 
            this.jobbtninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.jobbtninsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.jobbtninsert.Location = new System.Drawing.Point(485, 556);
            this.jobbtninsert.Name = "jobbtninsert";
            this.jobbtninsert.Size = new System.Drawing.Size(140, 40);
            this.jobbtninsert.TabIndex = 34;
            this.jobbtninsert.Text = "Insert";
            this.jobbtninsert.UseVisualStyleBackColor = false;
            this.jobbtninsert.Click += new System.EventHandler(this.jobbtninsert_Click);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(961, 615);
            this.Controls.Add(this.jobbtndelete);
            this.Controls.Add(this.jobbtnupdate);
            this.Controls.Add(this.jobbtninsert);
            this.Controls.Add(this.jobdgv);
            this.Controls.Add(this.jobtxtjobdescription);
            this.Controls.Add(this.jobtxtjobname);
            this.Controls.Add(this.jobtxtjobid);
            this.Controls.Add(this.joblbljobdescription);
            this.Controls.Add(this.joblbljobname);
            this.Controls.Add(this.joblbljobid);
            this.Name = "Job";
            this.Text = "Job";
            this.Load += new System.EventHandler(this.Job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jobdgv;
        private System.Windows.Forms.TextBox jobtxtjobdescription;
        private System.Windows.Forms.TextBox jobtxtjobname;
        private System.Windows.Forms.TextBox jobtxtjobid;
        private System.Windows.Forms.Label joblbljobdescription;
        private System.Windows.Forms.Label joblbljobname;
        private System.Windows.Forms.Label joblbljobid;
        private System.Windows.Forms.Button jobbtndelete;
        private System.Windows.Forms.Button jobbtnupdate;
        private System.Windows.Forms.Button jobbtninsert;
    }
}