namespace E_SPACE
{
    partial class Astronomer
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
            this.astronomerdgv = new System.Windows.Forms.DataGridView();
            this.astronomertxtexperience = new System.Windows.Forms.TextBox();
            this.astronomertxtdesignation = new System.Windows.Forms.TextBox();
            this.astronomertxtname = new System.Windows.Forms.TextBox();
            this.astronomertxtjetcode = new System.Windows.Forms.TextBox();
            this.astronomertxtaid = new System.Windows.Forms.TextBox();
            this.astronomerlblexperience = new System.Windows.Forms.Label();
            this.astronomerlbldesignation = new System.Windows.Forms.Label();
            this.astronomerlblname = new System.Windows.Forms.Label();
            this.astronomerlbljetcode = new System.Windows.Forms.Label();
            this.astronomerlblaid = new System.Windows.Forms.Label();
            this.astronomerbtndelete = new System.Windows.Forms.Button();
            this.astronomerbtnupdate = new System.Windows.Forms.Button();
            this.astronomerbtninsert = new System.Windows.Forms.Button();
            this.astronomerprevious = new System.Windows.Forms.Button();
            this.astronomernext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.astronomerdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // astronomerdgv
            // 
            this.astronomerdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.astronomerdgv.Location = new System.Drawing.Point(21, 325);
            this.astronomerdgv.Name = "astronomerdgv";
            this.astronomerdgv.RowHeadersWidth = 51;
            this.astronomerdgv.RowTemplate.Height = 24;
            this.astronomerdgv.Size = new System.Drawing.Size(921, 210);
            this.astronomerdgv.TabIndex = 23;
            this.astronomerdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.astronomerdgv_CellClick);
            // 
            // astronomertxtexperience
            // 
            this.astronomertxtexperience.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomertxtexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.astronomertxtexperience.Location = new System.Drawing.Point(229, 272);
            this.astronomertxtexperience.Multiline = true;
            this.astronomertxtexperience.Name = "astronomertxtexperience";
            this.astronomertxtexperience.Size = new System.Drawing.Size(191, 30);
            this.astronomertxtexperience.TabIndex = 22;
            this.astronomertxtexperience.TextChanged += new System.EventHandler(this.astronomertxtexperience_TextChanged);
            // 
            // astronomertxtdesignation
            // 
            this.astronomertxtdesignation.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomertxtdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.astronomertxtdesignation.Location = new System.Drawing.Point(229, 210);
            this.astronomertxtdesignation.Multiline = true;
            this.astronomertxtdesignation.Name = "astronomertxtdesignation";
            this.astronomertxtdesignation.Size = new System.Drawing.Size(191, 30);
            this.astronomertxtdesignation.TabIndex = 21;
            this.astronomertxtdesignation.TextChanged += new System.EventHandler(this.astronomertxtdesignation_TextChanged);
            // 
            // astronomertxtname
            // 
            this.astronomertxtname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomertxtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.astronomertxtname.Location = new System.Drawing.Point(229, 151);
            this.astronomertxtname.Multiline = true;
            this.astronomertxtname.Name = "astronomertxtname";
            this.astronomertxtname.Size = new System.Drawing.Size(191, 30);
            this.astronomertxtname.TabIndex = 20;
            this.astronomertxtname.TextChanged += new System.EventHandler(this.astronomertxtname_TextChanged);
            // 
            // astronomertxtjetcode
            // 
            this.astronomertxtjetcode.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomertxtjetcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.astronomertxtjetcode.Location = new System.Drawing.Point(229, 91);
            this.astronomertxtjetcode.Multiline = true;
            this.astronomertxtjetcode.Name = "astronomertxtjetcode";
            this.astronomertxtjetcode.Size = new System.Drawing.Size(191, 30);
            this.astronomertxtjetcode.TabIndex = 19;
            this.astronomertxtjetcode.TextChanged += new System.EventHandler(this.astronomertxtjetcode_TextChanged);
            // 
            // astronomertxtaid
            // 
            this.astronomertxtaid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomertxtaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.astronomertxtaid.Location = new System.Drawing.Point(229, 32);
            this.astronomertxtaid.Multiline = true;
            this.astronomertxtaid.Name = "astronomertxtaid";
            this.astronomertxtaid.Size = new System.Drawing.Size(191, 30);
            this.astronomertxtaid.TabIndex = 18;
            this.astronomertxtaid.TextChanged += new System.EventHandler(this.astronomertxtaid_TextChanged);
            // 
            // astronomerlblexperience
            // 
            this.astronomerlblexperience.AutoSize = true;
            this.astronomerlblexperience.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.astronomerlblexperience.ForeColor = System.Drawing.Color.Cyan;
            this.astronomerlblexperience.Location = new System.Drawing.Point(22, 268);
            this.astronomerlblexperience.Name = "astronomerlblexperience";
            this.astronomerlblexperience.Size = new System.Drawing.Size(138, 31);
            this.astronomerlblexperience.TabIndex = 17;
            this.astronomerlblexperience.Text = "Experience";
            // 
            // astronomerlbldesignation
            // 
            this.astronomerlbldesignation.AutoSize = true;
            this.astronomerlbldesignation.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.astronomerlbldesignation.ForeColor = System.Drawing.Color.Cyan;
            this.astronomerlbldesignation.Location = new System.Drawing.Point(22, 206);
            this.astronomerlbldesignation.Name = "astronomerlbldesignation";
            this.astronomerlbldesignation.Size = new System.Drawing.Size(152, 31);
            this.astronomerlbldesignation.TabIndex = 16;
            this.astronomerlbldesignation.Text = "Designation";
            // 
            // astronomerlblname
            // 
            this.astronomerlblname.AutoSize = true;
            this.astronomerlblname.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.astronomerlblname.ForeColor = System.Drawing.Color.Cyan;
            this.astronomerlblname.Location = new System.Drawing.Point(22, 147);
            this.astronomerlblname.Name = "astronomerlblname";
            this.astronomerlblname.Size = new System.Drawing.Size(81, 31);
            this.astronomerlblname.TabIndex = 15;
            this.astronomerlblname.Text = "Name";
            // 
            // astronomerlbljetcode
            // 
            this.astronomerlbljetcode.AutoSize = true;
            this.astronomerlbljetcode.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.astronomerlbljetcode.ForeColor = System.Drawing.Color.Cyan;
            this.astronomerlbljetcode.Location = new System.Drawing.Point(22, 87);
            this.astronomerlbljetcode.Name = "astronomerlbljetcode";
            this.astronomerlbljetcode.Size = new System.Drawing.Size(112, 31);
            this.astronomerlbljetcode.TabIndex = 14;
            this.astronomerlbljetcode.Text = "Jet Code";
            // 
            // astronomerlblaid
            // 
            this.astronomerlblaid.AutoSize = true;
            this.astronomerlblaid.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.astronomerlblaid.ForeColor = System.Drawing.Color.Cyan;
            this.astronomerlblaid.Location = new System.Drawing.Point(22, 28);
            this.astronomerlblaid.Name = "astronomerlblaid";
            this.astronomerlblaid.Size = new System.Drawing.Size(184, 31);
            this.astronomerlblaid.TabIndex = 13;
            this.astronomerlblaid.Text = "Astronomer ID";
            // 
            // astronomerbtndelete
            // 
            this.astronomerbtndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.astronomerbtndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.astronomerbtndelete.Location = new System.Drawing.Point(803, 554);
            this.astronomerbtndelete.Name = "astronomerbtndelete";
            this.astronomerbtndelete.Size = new System.Drawing.Size(140, 40);
            this.astronomerbtndelete.TabIndex = 33;
            this.astronomerbtndelete.Text = "Delete";
            this.astronomerbtndelete.UseVisualStyleBackColor = false;
            this.astronomerbtndelete.Click += new System.EventHandler(this.astronomerbtndelete_Click);
            // 
            // astronomerbtnupdate
            // 
            this.astronomerbtnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.astronomerbtnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.astronomerbtnupdate.Location = new System.Drawing.Point(643, 554);
            this.astronomerbtnupdate.Name = "astronomerbtnupdate";
            this.astronomerbtnupdate.Size = new System.Drawing.Size(140, 40);
            this.astronomerbtnupdate.TabIndex = 32;
            this.astronomerbtnupdate.Text = "Update";
            this.astronomerbtnupdate.UseVisualStyleBackColor = false;
            this.astronomerbtnupdate.Click += new System.EventHandler(this.astronomerbtnupdate_Click);
            // 
            // astronomerbtninsert
            // 
            this.astronomerbtninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.astronomerbtninsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.astronomerbtninsert.Location = new System.Drawing.Point(489, 554);
            this.astronomerbtninsert.Name = "astronomerbtninsert";
            this.astronomerbtninsert.Size = new System.Drawing.Size(140, 40);
            this.astronomerbtninsert.TabIndex = 31;
            this.astronomerbtninsert.Text = "Insert";
            this.astronomerbtninsert.UseVisualStyleBackColor = false;
            this.astronomerbtninsert.Click += new System.EventHandler(this.astronomerbtninsert_Click);
            // 
            // astronomerprevious
            // 
            this.astronomerprevious.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.astronomerprevious.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.astronomerprevious.Location = new System.Drawing.Point(1182, 417);
            this.astronomerprevious.Name = "astronomerprevious";
            this.astronomerprevious.Size = new System.Drawing.Size(90, 35);
            this.astronomerprevious.TabIndex = 34;
            this.astronomerprevious.Text = "Previous";
            this.astronomerprevious.UseVisualStyleBackColor = false;
            this.astronomerprevious.Click += new System.EventHandler(this.astronomerprevious_Click);
            // 
            // astronomernext
            // 
            this.astronomernext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.astronomernext.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.astronomernext.Location = new System.Drawing.Point(1338, 417);
            this.astronomernext.Name = "astronomernext";
            this.astronomernext.Size = new System.Drawing.Size(90, 35);
            this.astronomernext.TabIndex = 35;
            this.astronomernext.Text = "Next";
            this.astronomernext.UseVisualStyleBackColor = false;
            this.astronomernext.Click += new System.EventHandler(this.astronomernext_Click);
            // 
            // Astronomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(961, 615);
            this.Controls.Add(this.astronomerprevious);
            this.Controls.Add(this.astronomernext);
            this.Controls.Add(this.astronomerbtndelete);
            this.Controls.Add(this.astronomerbtnupdate);
            this.Controls.Add(this.astronomerbtninsert);
            this.Controls.Add(this.astronomerdgv);
            this.Controls.Add(this.astronomertxtexperience);
            this.Controls.Add(this.astronomertxtdesignation);
            this.Controls.Add(this.astronomertxtname);
            this.Controls.Add(this.astronomertxtjetcode);
            this.Controls.Add(this.astronomertxtaid);
            this.Controls.Add(this.astronomerlblexperience);
            this.Controls.Add(this.astronomerlbldesignation);
            this.Controls.Add(this.astronomerlblname);
            this.Controls.Add(this.astronomerlbljetcode);
            this.Controls.Add(this.astronomerlblaid);
            this.Name = "Astronomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomer";
            this.Load += new System.EventHandler(this.Astronomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.astronomerdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView astronomerdgv;
        private System.Windows.Forms.TextBox astronomertxtexperience;
        private System.Windows.Forms.TextBox astronomertxtdesignation;
        private System.Windows.Forms.TextBox astronomertxtname;
        private System.Windows.Forms.TextBox astronomertxtjetcode;
        private System.Windows.Forms.TextBox astronomertxtaid;
        private System.Windows.Forms.Label astronomerlblexperience;
        private System.Windows.Forms.Label astronomerlbldesignation;
        private System.Windows.Forms.Label astronomerlblname;
        private System.Windows.Forms.Label astronomerlbljetcode;
        private System.Windows.Forms.Label astronomerlblaid;
        private System.Windows.Forms.Button astronomerbtndelete;
        private System.Windows.Forms.Button astronomerbtnupdate;
        private System.Windows.Forms.Button astronomerbtninsert;
        private System.Windows.Forms.Button astronomerprevious;
        private System.Windows.Forms.Button astronomernext;
    }
}