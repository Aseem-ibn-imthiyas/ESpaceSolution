namespace E_SPACE
{
    partial class EJet
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
            this.ejetlblpwrsrc = new System.Windows.Forms.Label();
            this.ejetlbljettype = new System.Windows.Forms.Label();
            this.ejetdgv = new System.Windows.Forms.DataGridView();
            this.ejettxtseats = new System.Windows.Forms.TextBox();
            this.ejettxtjetweight = new System.Windows.Forms.TextBox();
            this.ejettxtpwrsrc = new System.Windows.Forms.TextBox();
            this.ejettxtjettype = new System.Windows.Forms.TextBox();
            this.ejettxtjetcode = new System.Windows.Forms.TextBox();
            this.ejetlblseats = new System.Windows.Forms.Label();
            this.ejetlbljetweight = new System.Windows.Forms.Label();
            this.ejetlblmadeyear = new System.Windows.Forms.Label();
            this.ejetlbljetcode = new System.Windows.Forms.Label();
            this.ejetbtndelete = new System.Windows.Forms.Button();
            this.ejetbtnupdate = new System.Windows.Forms.Button();
            this.ejetbtninsert = new System.Windows.Forms.Button();
            this.ejettxtmadeyear = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ejetdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ejetlblpwrsrc
            // 
            this.ejetlblpwrsrc.AutoSize = true;
            this.ejetlblpwrsrc.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.ejetlblpwrsrc.ForeColor = System.Drawing.Color.Cyan;
            this.ejetlblpwrsrc.Location = new System.Drawing.Point(18, 103);
            this.ejetlblpwrsrc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ejetlblpwrsrc.Name = "ejetlblpwrsrc";
            this.ejetlblpwrsrc.Size = new System.Drawing.Size(134, 23);
            this.ejetlblpwrsrc.TabIndex = 45;
            this.ejetlblpwrsrc.Text = "Power Source";
            // 
            // ejetlbljettype
            // 
            this.ejetlbljettype.AutoSize = true;
            this.ejetlbljettype.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.ejetlbljettype.ForeColor = System.Drawing.Color.Cyan;
            this.ejetlbljettype.Location = new System.Drawing.Point(19, 65);
            this.ejetlbljettype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ejetlbljettype.Name = "ejetlbljettype";
            this.ejetlbljettype.Size = new System.Drawing.Size(83, 23);
            this.ejetlbljettype.TabIndex = 44;
            this.ejetlbljettype.Text = "Jet Type";
            // 
            // ejetdgv
            // 
            this.ejetdgv.AllowUserToAddRows = false;
            this.ejetdgv.AllowUserToDeleteRows = false;
            this.ejetdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ejetdgv.Location = new System.Drawing.Point(23, 198);
            this.ejetdgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejetdgv.Name = "ejetdgv";
            this.ejetdgv.ReadOnly = true;
            this.ejetdgv.RowHeadersWidth = 51;
            this.ejetdgv.RowTemplate.Height = 24;
            this.ejetdgv.Size = new System.Drawing.Size(679, 231);
            this.ejetdgv.TabIndex = 43;
            this.ejetdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ejetdgv_CellClick);
            // 
            // ejettxtseats
            // 
            this.ejettxtseats.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ejettxtseats.Location = new System.Drawing.Point(532, 67);
            this.ejettxtseats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejettxtseats.Multiline = true;
            this.ejettxtseats.Name = "ejettxtseats";
            this.ejettxtseats.Size = new System.Drawing.Size(144, 25);
            this.ejettxtseats.TabIndex = 39;
            this.ejettxtseats.TextChanged += new System.EventHandler(this.ejettxtseats_TextChanged);
            // 
            // ejettxtjetweight
            // 
            this.ejettxtjetweight.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ejettxtjetweight.Location = new System.Drawing.Point(532, 28);
            this.ejettxtjetweight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejettxtjetweight.Multiline = true;
            this.ejettxtjetweight.Name = "ejettxtjetweight";
            this.ejettxtjetweight.Size = new System.Drawing.Size(144, 25);
            this.ejettxtjetweight.TabIndex = 37;
            this.ejettxtjetweight.TextChanged += new System.EventHandler(this.ejettxtjetweight_TextChanged);
            // 
            // ejettxtpwrsrc
            // 
            this.ejettxtpwrsrc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ejettxtpwrsrc.Location = new System.Drawing.Point(169, 105);
            this.ejettxtpwrsrc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejettxtpwrsrc.Multiline = true;
            this.ejettxtpwrsrc.Name = "ejettxtpwrsrc";
            this.ejettxtpwrsrc.Size = new System.Drawing.Size(144, 25);
            this.ejettxtpwrsrc.TabIndex = 34;
            this.ejettxtpwrsrc.TextChanged += new System.EventHandler(this.ejettxtpwrsrc_TextChanged);
            // 
            // ejettxtjettype
            // 
            this.ejettxtjettype.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ejettxtjettype.Location = new System.Drawing.Point(169, 67);
            this.ejettxtjettype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejettxtjettype.Multiline = true;
            this.ejettxtjettype.Name = "ejettxtjettype";
            this.ejettxtjettype.Size = new System.Drawing.Size(144, 25);
            this.ejettxtjettype.TabIndex = 33;
            this.ejettxtjettype.TextChanged += new System.EventHandler(this.ejettxtjettype_TextChanged);
            // 
            // ejettxtjetcode
            // 
            this.ejettxtjetcode.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ejettxtjetcode.Location = new System.Drawing.Point(169, 28);
            this.ejettxtjetcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejettxtjetcode.Multiline = true;
            this.ejettxtjetcode.Name = "ejettxtjetcode";
            this.ejettxtjetcode.Size = new System.Drawing.Size(144, 25);
            this.ejettxtjetcode.TabIndex = 32;
            this.ejettxtjetcode.TextChanged += new System.EventHandler(this.ejettxtjetcode_TextChanged);
            // 
            // ejetlblseats
            // 
            this.ejetlblseats.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.ejetlblseats.ForeColor = System.Drawing.Color.Cyan;
            this.ejetlblseats.Location = new System.Drawing.Point(381, 67);
            this.ejetlblseats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ejetlblseats.Name = "ejetlblseats";
            this.ejetlblseats.Size = new System.Drawing.Size(146, 22);
            this.ejetlblseats.TabIndex = 28;
            this.ejetlblseats.Text = "Passenger Seats";
            // 
            // ejetlbljetweight
            // 
            this.ejetlbljetweight.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.ejetlbljetweight.ForeColor = System.Drawing.Color.Cyan;
            this.ejetlbljetweight.Location = new System.Drawing.Point(382, 28);
            this.ejetlbljetweight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ejetlbljetweight.Name = "ejetlbljetweight";
            this.ejetlbljetweight.Size = new System.Drawing.Size(108, 22);
            this.ejetlbljetweight.TabIndex = 26;
            this.ejetlbljetweight.Text = "Jet Weight";
            // 
            // ejetlblmadeyear
            // 
            this.ejetlblmadeyear.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.ejetlblmadeyear.ForeColor = System.Drawing.Color.Cyan;
            this.ejetlblmadeyear.Location = new System.Drawing.Point(18, 141);
            this.ejetlblmadeyear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ejetlblmadeyear.Name = "ejetlblmadeyear";
            this.ejetlblmadeyear.Size = new System.Drawing.Size(108, 22);
            this.ejetlblmadeyear.TabIndex = 25;
            this.ejetlblmadeyear.Text = "Made Year";
            // 
            // ejetlbljetcode
            // 
            this.ejetlbljetcode.AutoSize = true;
            this.ejetlbljetcode.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.ejetlbljetcode.ForeColor = System.Drawing.Color.Cyan;
            this.ejetlbljetcode.Location = new System.Drawing.Point(19, 27);
            this.ejetlbljetcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ejetlbljetcode.Name = "ejetlbljetcode";
            this.ejetlbljetcode.Size = new System.Drawing.Size(86, 23);
            this.ejetlbljetcode.TabIndex = 23;
            this.ejetlbljetcode.Text = "Jet Code";
            // 
            // ejetbtndelete
            // 
            this.ejetbtndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ejetbtndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.ejetbtndelete.Location = new System.Drawing.Point(597, 452);
            this.ejetbtndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejetbtndelete.Name = "ejetbtndelete";
            this.ejetbtndelete.Size = new System.Drawing.Size(105, 32);
            this.ejetbtndelete.TabIndex = 48;
            this.ejetbtndelete.Text = "Delete";
            this.ejetbtndelete.UseVisualStyleBackColor = false;
            this.ejetbtndelete.Click += new System.EventHandler(this.ejetbtndelete_Click);
            // 
            // ejetbtnupdate
            // 
            this.ejetbtnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ejetbtnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.ejetbtnupdate.Location = new System.Drawing.Point(480, 452);
            this.ejetbtnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejetbtnupdate.Name = "ejetbtnupdate";
            this.ejetbtnupdate.Size = new System.Drawing.Size(105, 32);
            this.ejetbtnupdate.TabIndex = 47;
            this.ejetbtnupdate.Text = "Update";
            this.ejetbtnupdate.UseVisualStyleBackColor = false;
            this.ejetbtnupdate.Click += new System.EventHandler(this.ejetbtnupdate_Click);
            // 
            // ejetbtninsert
            // 
            this.ejetbtninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ejetbtninsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.ejetbtninsert.Location = new System.Drawing.Point(362, 452);
            this.ejetbtninsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejetbtninsert.Name = "ejetbtninsert";
            this.ejetbtninsert.Size = new System.Drawing.Size(105, 32);
            this.ejetbtninsert.TabIndex = 46;
            this.ejetbtninsert.Text = "Insert";
            this.ejetbtninsert.UseVisualStyleBackColor = false;
            this.ejetbtninsert.Click += new System.EventHandler(this.ejetbtninsert_Click);
            // 
            // ejettxtmadeyear
            // 
            this.ejettxtmadeyear.CustomFormat = "yyyy-MM-dd";
            this.ejettxtmadeyear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ejettxtmadeyear.Location = new System.Drawing.Point(169, 143);
            this.ejettxtmadeyear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ejettxtmadeyear.Name = "ejettxtmadeyear";
            this.ejettxtmadeyear.Size = new System.Drawing.Size(144, 20);
            this.ejettxtmadeyear.TabIndex = 50;
            this.ejettxtmadeyear.ValueChanged += new System.EventHandler(this.ejettxtmadeyear_ValueChanged);
            // 
            // EJet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(721, 500);
            this.Controls.Add(this.ejettxtmadeyear);
            this.Controls.Add(this.ejetbtndelete);
            this.Controls.Add(this.ejetbtnupdate);
            this.Controls.Add(this.ejetbtninsert);
            this.Controls.Add(this.ejetlblpwrsrc);
            this.Controls.Add(this.ejetlbljettype);
            this.Controls.Add(this.ejetdgv);
            this.Controls.Add(this.ejettxtseats);
            this.Controls.Add(this.ejettxtjetweight);
            this.Controls.Add(this.ejettxtpwrsrc);
            this.Controls.Add(this.ejettxtjettype);
            this.Controls.Add(this.ejettxtjetcode);
            this.Controls.Add(this.ejetlblseats);
            this.Controls.Add(this.ejetlbljetweight);
            this.Controls.Add(this.ejetlblmadeyear);
            this.Controls.Add(this.ejetlbljetcode);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EJet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Jet";
            this.Load += new System.EventHandler(this.E_Jet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejetdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ejetlblpwrsrc;
        private System.Windows.Forms.Label ejetlbljettype;
        private System.Windows.Forms.DataGridView ejetdgv;
        private System.Windows.Forms.TextBox ejettxtseats;
        private System.Windows.Forms.TextBox ejettxtjetweight;
        private System.Windows.Forms.TextBox ejettxtpwrsrc;
        private System.Windows.Forms.TextBox ejettxtjettype;
        private System.Windows.Forms.TextBox ejettxtjetcode;
        private System.Windows.Forms.Label ejetlblseats;
        private System.Windows.Forms.Label ejetlbljetweight;
        private System.Windows.Forms.Label ejetlblmadeyear;
        private System.Windows.Forms.Label ejetlbljetcode;
        private System.Windows.Forms.Button ejetbtndelete;
        private System.Windows.Forms.Button ejetbtnupdate;
        private System.Windows.Forms.Button ejetbtninsert;
        private System.Windows.Forms.DateTimePicker ejettxtmadeyear;
    }
}