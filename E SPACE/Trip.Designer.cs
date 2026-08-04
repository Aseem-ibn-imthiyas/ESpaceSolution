namespace E_SPACE
{
    partial class Trip
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
            this.tripdgv = new System.Windows.Forms.DataGridView();
            this.triptxtjetcode = new System.Windows.Forms.TextBox();
            this.triptxttid = new System.Windows.Forms.TextBox();
            this.triplblrtrndate = new System.Windows.Forms.Label();
            this.triplbllnchdate = new System.Windows.Forms.Label();
            this.triplbljetcode = new System.Windows.Forms.Label();
            this.triplbltid = new System.Windows.Forms.Label();
            this.tripbtndelete = new System.Windows.Forms.Button();
            this.tripbtnupdate = new System.Windows.Forms.Button();
            this.tripbtninsert = new System.Windows.Forms.Button();
            this.triptxtlnchdate = new System.Windows.Forms.DateTimePicker();
            this.triptxtrtrndate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tripdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tripdgv
            // 
            this.tripdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripdgv.Location = new System.Drawing.Point(22, 198);
            this.tripdgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tripdgv.Name = "tripdgv";
            this.tripdgv.RowHeadersWidth = 51;
            this.tripdgv.RowTemplate.Height = 24;
            this.tripdgv.Size = new System.Drawing.Size(676, 225);
            this.tripdgv.TabIndex = 23;
            this.tripdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tripdgv_CellClick);
            // 
            // triptxtjetcode
            // 
            this.triptxtjetcode.BackColor = System.Drawing.Color.PaleTurquoise;
            this.triptxtjetcode.Location = new System.Drawing.Point(158, 62);
            this.triptxtjetcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triptxtjetcode.Multiline = true;
            this.triptxtjetcode.Name = "triptxtjetcode";
            this.triptxtjetcode.Size = new System.Drawing.Size(144, 25);
            this.triptxtjetcode.TabIndex = 20;
            this.triptxtjetcode.TextChanged += new System.EventHandler(this.triptxtjetcode_TextChanged);
            // 
            // triptxttid
            // 
            this.triptxttid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.triptxttid.Location = new System.Drawing.Point(158, 18);
            this.triptxttid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triptxttid.Multiline = true;
            this.triptxttid.Name = "triptxttid";
            this.triptxttid.Size = new System.Drawing.Size(144, 25);
            this.triptxttid.TabIndex = 18;
            this.triptxttid.TextChanged += new System.EventHandler(this.triptxttid_TextChanged);
            // 
            // triplblrtrndate
            // 
            this.triplblrtrndate.AutoSize = true;
            this.triplblrtrndate.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.triplblrtrndate.ForeColor = System.Drawing.Color.Cyan;
            this.triplblrtrndate.Location = new System.Drawing.Point(18, 149);
            this.triplblrtrndate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.triplblrtrndate.Name = "triplblrtrndate";
            this.triplblrtrndate.Size = new System.Drawing.Size(117, 23);
            this.triplblrtrndate.TabIndex = 17;
            this.triplblrtrndate.Text = "Return Date";
            // 
            // triplbllnchdate
            // 
            this.triplbllnchdate.AutoSize = true;
            this.triplbllnchdate.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.triplbllnchdate.ForeColor = System.Drawing.Color.Cyan;
            this.triplbllnchdate.Location = new System.Drawing.Point(18, 105);
            this.triplbllnchdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.triplbllnchdate.Name = "triplbllnchdate";
            this.triplbllnchdate.Size = new System.Drawing.Size(120, 23);
            this.triplbllnchdate.TabIndex = 16;
            this.triplbllnchdate.Text = "Launch Date";
            // 
            // triplbljetcode
            // 
            this.triplbljetcode.AutoSize = true;
            this.triplbljetcode.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.triplbljetcode.ForeColor = System.Drawing.Color.Cyan;
            this.triplbljetcode.Location = new System.Drawing.Point(18, 61);
            this.triplbljetcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.triplbljetcode.Name = "triplbljetcode";
            this.triplbljetcode.Size = new System.Drawing.Size(86, 23);
            this.triplbljetcode.TabIndex = 15;
            this.triplbljetcode.Text = "Jet Code";
            // 
            // triplbltid
            // 
            this.triplbltid.AutoSize = true;
            this.triplbltid.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.triplbltid.ForeColor = System.Drawing.Color.Cyan;
            this.triplbltid.Location = new System.Drawing.Point(18, 17);
            this.triplbltid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.triplbltid.Name = "triplbltid";
            this.triplbltid.Size = new System.Drawing.Size(71, 23);
            this.triplbltid.TabIndex = 13;
            this.triplbltid.Text = "Trip ID";
            // 
            // tripbtndelete
            // 
            this.tripbtndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tripbtndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.tripbtndelete.Location = new System.Drawing.Point(592, 450);
            this.tripbtndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tripbtndelete.Name = "tripbtndelete";
            this.tripbtndelete.Size = new System.Drawing.Size(105, 32);
            this.tripbtndelete.TabIndex = 30;
            this.tripbtndelete.Text = "Delete";
            this.tripbtndelete.UseVisualStyleBackColor = false;
            this.tripbtndelete.Click += new System.EventHandler(this.tripbtndelete_Click);
            // 
            // tripbtnupdate
            // 
            this.tripbtnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tripbtnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.tripbtnupdate.Location = new System.Drawing.Point(473, 450);
            this.tripbtnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tripbtnupdate.Name = "tripbtnupdate";
            this.tripbtnupdate.Size = new System.Drawing.Size(105, 32);
            this.tripbtnupdate.TabIndex = 29;
            this.tripbtnupdate.Text = "Update";
            this.tripbtnupdate.UseVisualStyleBackColor = false;
            this.tripbtnupdate.Click += new System.EventHandler(this.tripbtnupdate_Click);
            // 
            // tripbtninsert
            // 
            this.tripbtninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tripbtninsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.tripbtninsert.Location = new System.Drawing.Point(354, 450);
            this.tripbtninsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tripbtninsert.Name = "tripbtninsert";
            this.tripbtninsert.Size = new System.Drawing.Size(105, 32);
            this.tripbtninsert.TabIndex = 28;
            this.tripbtninsert.Text = "Insert";
            this.tripbtninsert.UseVisualStyleBackColor = false;
            this.tripbtninsert.Click += new System.EventHandler(this.tripbtninsert_Click);
            // 
            // triptxtlnchdate
            // 
            this.triptxtlnchdate.CustomFormat = "yyyy-MM-dd";
            this.triptxtlnchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.triptxtlnchdate.Location = new System.Drawing.Point(158, 109);
            this.triptxtlnchdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triptxtlnchdate.Name = "triptxtlnchdate";
            this.triptxtlnchdate.Size = new System.Drawing.Size(144, 20);
            this.triptxtlnchdate.TabIndex = 34;
            this.triptxtlnchdate.ValueChanged += new System.EventHandler(this.triptxtlnchdate_ValueChanged);
            // 
            // triptxtrtrndate
            // 
            this.triptxtrtrndate.CustomFormat = "yyyy-MM-dd";
            this.triptxtrtrndate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.triptxtrtrndate.Location = new System.Drawing.Point(158, 151);
            this.triptxtrtrndate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triptxtrtrndate.Name = "triptxtrtrndate";
            this.triptxtrtrndate.Size = new System.Drawing.Size(144, 20);
            this.triptxtrtrndate.TabIndex = 35;
            this.triptxtrtrndate.ValueChanged += new System.EventHandler(this.triptxtrtrndate_ValueChanged);
            // 
            // Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(721, 500);
            this.Controls.Add(this.triptxtrtrndate);
            this.Controls.Add(this.triptxtlnchdate);
            this.Controls.Add(this.tripbtndelete);
            this.Controls.Add(this.tripbtnupdate);
            this.Controls.Add(this.tripbtninsert);
            this.Controls.Add(this.tripdgv);
            this.Controls.Add(this.triptxtjetcode);
            this.Controls.Add(this.triptxttid);
            this.Controls.Add(this.triplblrtrndate);
            this.Controls.Add(this.triplbllnchdate);
            this.Controls.Add(this.triplbljetcode);
            this.Controls.Add(this.triplbltid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Trip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip";
            this.Load += new System.EventHandler(this.Trip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tripdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tripdgv;
        private System.Windows.Forms.TextBox triptxtjetcode;
        private System.Windows.Forms.TextBox triptxttid;
        private System.Windows.Forms.Label triplblrtrndate;
        private System.Windows.Forms.Label triplbllnchdate;
        private System.Windows.Forms.Label triplbljetcode;
        private System.Windows.Forms.Label triplbltid;
        private System.Windows.Forms.Button tripbtndelete;
        private System.Windows.Forms.Button tripbtnupdate;
        private System.Windows.Forms.Button tripbtninsert;
        private System.Windows.Forms.DateTimePicker triptxtlnchdate;
        private System.Windows.Forms.DateTimePicker triptxtrtrndate;
    }
}