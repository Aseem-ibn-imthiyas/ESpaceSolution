namespace E_SPACE
{
    partial class Astromomer_Qualification
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
            this.colonistqbtndelete = new System.Windows.Forms.Button();
            this.colonistqbtnupdate = new System.Windows.Forms.Button();
            this.colonistqbtninsert = new System.Windows.Forms.Button();
            this.astronomerqdgv = new System.Windows.Forms.DataGridView();
            this.astronomerqtxtastronomerQualification = new System.Windows.Forms.TextBox();
            this.astronomerqtxtastroqualiID = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.astronomerqtxtAstronomerID = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.astronomerqdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // colonistqbtndelete
            // 
            this.colonistqbtndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colonistqbtndelete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.colonistqbtndelete.Location = new System.Drawing.Point(797, 554);
            this.colonistqbtndelete.Name = "colonistqbtndelete";
            this.colonistqbtndelete.Size = new System.Drawing.Size(140, 40);
            this.colonistqbtndelete.TabIndex = 48;
            this.colonistqbtndelete.Text = "Delete";
            this.colonistqbtndelete.UseVisualStyleBackColor = false;
            this.colonistqbtndelete.Click += new System.EventHandler(this.colonistqbtndelete_Click);
            // 
            // colonistqbtnupdate
            // 
            this.colonistqbtnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colonistqbtnupdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.colonistqbtnupdate.Location = new System.Drawing.Point(629, 554);
            this.colonistqbtnupdate.Name = "colonistqbtnupdate";
            this.colonistqbtnupdate.Size = new System.Drawing.Size(140, 40);
            this.colonistqbtnupdate.TabIndex = 45;
            this.colonistqbtnupdate.Text = "Update";
            this.colonistqbtnupdate.UseVisualStyleBackColor = false;
            this.colonistqbtnupdate.Click += new System.EventHandler(this.colonistqbtnupdate_Click);
            // 
            // colonistqbtninsert
            // 
            this.colonistqbtninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colonistqbtninsert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.colonistqbtninsert.Location = new System.Drawing.Point(461, 554);
            this.colonistqbtninsert.Name = "colonistqbtninsert";
            this.colonistqbtninsert.Size = new System.Drawing.Size(140, 40);
            this.colonistqbtninsert.TabIndex = 44;
            this.colonistqbtninsert.Text = "Insert";
            this.colonistqbtninsert.UseVisualStyleBackColor = false;
            this.colonistqbtninsert.Click += new System.EventHandler(this.colonistqbtninsert_Click);
            // 
            // astronomerqdgv
            // 
            this.astronomerqdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.astronomerqdgv.Location = new System.Drawing.Point(27, 251);
            this.astronomerqdgv.Name = "astronomerqdgv";
            this.astronomerqdgv.RowHeadersWidth = 51;
            this.astronomerqdgv.RowTemplate.Height = 24;
            this.astronomerqdgv.Size = new System.Drawing.Size(910, 275);
            this.astronomerqdgv.TabIndex = 43;
            this.astronomerqdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.astronomerqdgv_CellClick);
            // 
            // astronomerqtxtastronomerQualification
            // 
            this.astronomerqtxtastronomerQualification.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomerqtxtastronomerQualification.Location = new System.Drawing.Point(391, 104);
            this.astronomerqtxtastronomerQualification.Multiline = true;
            this.astronomerqtxtastronomerQualification.Name = "astronomerqtxtastronomerQualification";
            this.astronomerqtxtastronomerQualification.Size = new System.Drawing.Size(191, 30);
            this.astronomerqtxtastronomerQualification.TabIndex = 42;
            this.astronomerqtxtastronomerQualification.TextChanged += new System.EventHandler(this.astronomerqtxtastronomerQualification_TextChanged);
            // 
            // astronomerqtxtastroqualiID
            // 
            this.astronomerqtxtastroqualiID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomerqtxtastroqualiID.Location = new System.Drawing.Point(391, 27);
            this.astronomerqtxtastroqualiID.Multiline = true;
            this.astronomerqtxtastroqualiID.Name = "astronomerqtxtastroqualiID";
            this.astronomerqtxtastroqualiID.Size = new System.Drawing.Size(191, 30);
            this.astronomerqtxtastroqualiID.TabIndex = 40;
            this.astronomerqtxtastroqualiID.TextChanged += new System.EventHandler(this.astronomerqtxtastronomerid_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Cyan;
            this.lbl1.Location = new System.Drawing.Point(20, 104);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(305, 31);
            this.lbl1.TabIndex = 38;
            this.lbl1.Text = "Astronomer Qualification";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.lbl3.ForeColor = System.Drawing.Color.Cyan;
            this.lbl3.Location = new System.Drawing.Point(21, 27);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(338, 31);
            this.lbl3.TabIndex = 37;
            this.lbl3.Text = "Astronomer Qualification ID";
            // 
            // astronomerqtxtAstronomerID
            // 
            this.astronomerqtxtAstronomerID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astronomerqtxtAstronomerID.Location = new System.Drawing.Point(391, 181);
            this.astronomerqtxtAstronomerID.Multiline = true;
            this.astronomerqtxtAstronomerID.Name = "astronomerqtxtAstronomerID";
            this.astronomerqtxtAstronomerID.Size = new System.Drawing.Size(191, 30);
            this.astronomerqtxtAstronomerID.TabIndex = 50;
            this.astronomerqtxtAstronomerID.TextChanged += new System.EventHandler(this.astronomerqtxtAstronomerID_TextChanged_1);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.lbl2.ForeColor = System.Drawing.Color.Cyan;
            this.lbl2.Location = new System.Drawing.Point(20, 181);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(184, 31);
            this.lbl2.TabIndex = 49;
            this.lbl2.Text = "Astronomer ID";
            // 
            // Astromomer_Qualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(961, 615);
            this.Controls.Add(this.astronomerqtxtAstronomerID);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.colonistqbtndelete);
            this.Controls.Add(this.colonistqbtnupdate);
            this.Controls.Add(this.colonistqbtninsert);
            this.Controls.Add(this.astronomerqdgv);
            this.Controls.Add(this.astronomerqtxtastronomerQualification);
            this.Controls.Add(this.astronomerqtxtastroqualiID);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl3);
            this.Name = "Astromomer_Qualification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomer Qualification";
            this.Load += new System.EventHandler(this.Astromomer_Qualification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.astronomerqdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button colonistqbtndelete;
        private System.Windows.Forms.Button colonistqbtnupdate;
        private System.Windows.Forms.Button colonistqbtninsert;
        private System.Windows.Forms.DataGridView astronomerqdgv;
        private System.Windows.Forms.TextBox astronomerqtxtastronomerQualification;
        private System.Windows.Forms.TextBox astronomerqtxtastroqualiID;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox astronomerqtxtAstronomerID;
        private System.Windows.Forms.Label lbl2;
    }
}