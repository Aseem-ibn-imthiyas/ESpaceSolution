namespace E_SPACE
{
    partial class House
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
            this.housetxtsqreft = new System.Windows.Forms.TextBox();
            this.housetxtrooms = new System.Windows.Forms.TextBox();
            this.housetxtcolonylotnumber = new System.Windows.Forms.TextBox();
            this.houselblsqreft = new System.Windows.Forms.Label();
            this.houselblrooms = new System.Windows.Forms.Label();
            this.houselblhid = new System.Windows.Forms.Label();
            this.housebtndelete = new System.Windows.Forms.Button();
            this.housebtnupdate = new System.Windows.Forms.Button();
            this.housebtninsert = new System.Windows.Forms.Button();
            this.housedgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.housedgv)).BeginInit();
            this.SuspendLayout();
            // 
            // housetxtsqreft
            // 
            this.housetxtsqreft.BackColor = System.Drawing.Color.PaleTurquoise;
            this.housetxtsqreft.Location = new System.Drawing.Point(285, 155);
            this.housetxtsqreft.Multiline = true;
            this.housetxtsqreft.Name = "housetxtsqreft";
            this.housetxtsqreft.Size = new System.Drawing.Size(191, 30);
            this.housetxtsqreft.TabIndex = 21;
            this.housetxtsqreft.TextChanged += new System.EventHandler(this.housetxtsqreft_TextChanged);
            // 
            // housetxtrooms
            // 
            this.housetxtrooms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.housetxtrooms.Location = new System.Drawing.Point(285, 96);
            this.housetxtrooms.Multiline = true;
            this.housetxtrooms.Name = "housetxtrooms";
            this.housetxtrooms.Size = new System.Drawing.Size(191, 30);
            this.housetxtrooms.TabIndex = 20;
            this.housetxtrooms.TextChanged += new System.EventHandler(this.housetxtrooms_TextChanged);
            // 
            // housetxtcolonylotnumber
            // 
            this.housetxtcolonylotnumber.BackColor = System.Drawing.Color.PaleTurquoise;
            this.housetxtcolonylotnumber.Location = new System.Drawing.Point(285, 37);
            this.housetxtcolonylotnumber.Multiline = true;
            this.housetxtcolonylotnumber.Name = "housetxtcolonylotnumber";
            this.housetxtcolonylotnumber.Size = new System.Drawing.Size(191, 30);
            this.housetxtcolonylotnumber.TabIndex = 18;
            this.housetxtcolonylotnumber.TextChanged += new System.EventHandler(this.housetxtcolonylotnumber_TextChanged);
            // 
            // houselblsqreft
            // 
            this.houselblsqreft.AutoSize = true;
            this.houselblsqreft.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.houselblsqreft.ForeColor = System.Drawing.Color.Cyan;
            this.houselblsqreft.Location = new System.Drawing.Point(27, 151);
            this.houselblsqreft.Name = "houselblsqreft";
            this.houselblsqreft.Size = new System.Drawing.Size(147, 31);
            this.houselblsqreft.TabIndex = 16;
            this.houselblsqreft.Text = "Square Feet";
            // 
            // houselblrooms
            // 
            this.houselblrooms.AutoSize = true;
            this.houselblrooms.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.houselblrooms.ForeColor = System.Drawing.Color.Cyan;
            this.houselblrooms.Location = new System.Drawing.Point(27, 92);
            this.houselblrooms.Name = "houselblrooms";
            this.houselblrooms.Size = new System.Drawing.Size(165, 31);
            this.houselblrooms.TabIndex = 15;
            this.houselblrooms.Text = "No of Rooms";
            // 
            // houselblhid
            // 
            this.houselblhid.AutoSize = true;
            this.houselblhid.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.houselblhid.ForeColor = System.Drawing.Color.Cyan;
            this.houselblhid.Location = new System.Drawing.Point(27, 37);
            this.houselblhid.Name = "houselblhid";
            this.houselblhid.Size = new System.Drawing.Size(238, 31);
            this.houselblhid.TabIndex = 13;
            this.houselblhid.Text = "Colony Lot Number";
            // 
            // housebtndelete
            // 
            this.housebtndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.housebtndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.housebtndelete.Location = new System.Drawing.Point(795, 556);
            this.housebtndelete.Name = "housebtndelete";
            this.housebtndelete.Size = new System.Drawing.Size(140, 40);
            this.housebtndelete.TabIndex = 30;
            this.housebtndelete.Text = "Delete";
            this.housebtndelete.UseVisualStyleBackColor = false;
            this.housebtndelete.Click += new System.EventHandler(this.housebtndelete_Click);
            // 
            // housebtnupdate
            // 
            this.housebtnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.housebtnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.housebtnupdate.Location = new System.Drawing.Point(640, 556);
            this.housebtnupdate.Name = "housebtnupdate";
            this.housebtnupdate.Size = new System.Drawing.Size(140, 40);
            this.housebtnupdate.TabIndex = 29;
            this.housebtnupdate.Text = "Update";
            this.housebtnupdate.UseVisualStyleBackColor = false;
            this.housebtnupdate.Click += new System.EventHandler(this.housebtnupdate_Click);
            // 
            // housebtninsert
            // 
            this.housebtninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.housebtninsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.housebtninsert.Location = new System.Drawing.Point(485, 556);
            this.housebtninsert.Name = "housebtninsert";
            this.housebtninsert.Size = new System.Drawing.Size(140, 40);
            this.housebtninsert.TabIndex = 28;
            this.housebtninsert.Text = "Insert";
            this.housebtninsert.UseVisualStyleBackColor = false;
            this.housebtninsert.Click += new System.EventHandler(this.housebtninsert_Click);
            // 
            // housedgv
            // 
            this.housedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.housedgv.Location = new System.Drawing.Point(29, 218);
            this.housedgv.Name = "housedgv";
            this.housedgv.RowHeadersWidth = 51;
            this.housedgv.RowTemplate.Height = 24;
            this.housedgv.Size = new System.Drawing.Size(906, 312);
            this.housedgv.TabIndex = 32;
            // 
            // House
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(961, 615);
            this.Controls.Add(this.housedgv);
            this.Controls.Add(this.housebtndelete);
            this.Controls.Add(this.housebtnupdate);
            this.Controls.Add(this.housebtninsert);
            this.Controls.Add(this.housetxtsqreft);
            this.Controls.Add(this.housetxtrooms);
            this.Controls.Add(this.housetxtcolonylotnumber);
            this.Controls.Add(this.houselblsqreft);
            this.Controls.Add(this.houselblrooms);
            this.Controls.Add(this.houselblhid);
            this.Name = "House";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House";
            this.Load += new System.EventHandler(this.House_Load);
            ((System.ComponentModel.ISupportInitialize)(this.housedgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox housetxtsqreft;
        private System.Windows.Forms.TextBox housetxtrooms;
        private System.Windows.Forms.TextBox housetxtcolonylotnumber;
        private System.Windows.Forms.Label houselblsqreft;
        private System.Windows.Forms.Label houselblrooms;
        private System.Windows.Forms.Label houselblhid;
        private System.Windows.Forms.Button housebtndelete;
        private System.Windows.Forms.Button housebtnupdate;
        private System.Windows.Forms.Button housebtninsert;
        private System.Windows.Forms.DataGridView housedgv;
    }
}