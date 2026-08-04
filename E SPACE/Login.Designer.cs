namespace E_SPACE
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.lgnlblun = new System.Windows.Forms.Label();
            this.lgnlblpw = new System.Windows.Forms.Label();
            this.lgntxtpw = new System.Windows.Forms.TextBox();
            this.lgnbtnlogin = new System.Windows.Forms.Button();
            this.lgntxtusna = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNExt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Espace Login Portal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lgnlblun
            // 
            this.lgnlblun.AutoSize = true;
            this.lgnlblun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.lgnlblun.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lgnlblun.ForeColor = System.Drawing.Color.Cyan;
            this.lgnlblun.Location = new System.Drawing.Point(62, 181);
            this.lgnlblun.Name = "lgnlblun";
            this.lgnlblun.Size = new System.Drawing.Size(95, 23);
            this.lgnlblun.TabIndex = 1;
            this.lgnlblun.Text = "Username";
            // 
            // lgnlblpw
            // 
            this.lgnlblpw.AutoSize = true;
            this.lgnlblpw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.lgnlblpw.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lgnlblpw.ForeColor = System.Drawing.Color.Cyan;
            this.lgnlblpw.Location = new System.Drawing.Point(62, 320);
            this.lgnlblpw.Name = "lgnlblpw";
            this.lgnlblpw.Size = new System.Drawing.Size(90, 23);
            this.lgnlblpw.TabIndex = 3;
            this.lgnlblpw.Text = "Password";
            // 
            // lgntxtpw
            // 
            this.lgntxtpw.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lgntxtpw.Location = new System.Drawing.Point(101, 376);
            this.lgntxtpw.Multiline = true;
            this.lgntxtpw.Name = "lgntxtpw";
            this.lgntxtpw.PasswordChar = '*';
            this.lgntxtpw.Size = new System.Drawing.Size(294, 31);
            this.lgntxtpw.TabIndex = 5;
            // 
            // lgnbtnlogin
            // 
            this.lgnbtnlogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lgnbtnlogin.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lgnbtnlogin.Location = new System.Drawing.Point(348, 543);
            this.lgnbtnlogin.Name = "lgnbtnlogin";
            this.lgnbtnlogin.Size = new System.Drawing.Size(110, 35);
            this.lgnbtnlogin.TabIndex = 6;
            this.lgnbtnlogin.Text = "Login";
            this.lgnbtnlogin.UseVisualStyleBackColor = false;
            this.lgnbtnlogin.Click += new System.EventHandler(this.lgnbtnlogin_Click);
            // 
            // lgntxtusna
            // 
            this.lgntxtusna.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lgntxtusna.Location = new System.Drawing.Point(101, 232);
            this.lgntxtusna.Multiline = true;
            this.lgntxtusna.Name = "lgntxtusna";
            this.lgntxtusna.Size = new System.Drawing.Size(294, 31);
            this.lgntxtusna.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::E_SPACE.Properties.Resources.Astro_Wallpepr;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 670);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTNExt
            // 
            this.BTNExt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNExt.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.BTNExt.Location = new System.Drawing.Point(42, 543);
            this.BTNExt.Name = "BTNExt";
            this.BTNExt.Size = new System.Drawing.Size(110, 35);
            this.BTNExt.TabIndex = 6;
            this.BTNExt.Text = "Exit";
            this.BTNExt.UseVisualStyleBackColor = false;
            this.BTNExt.Click += new System.EventHandler(this.BTNExt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lgntxtusna);
            this.panel2.Controls.Add(this.lgnlblun);
            this.panel2.Controls.Add(this.lgntxtpw);
            this.panel2.Controls.Add(this.BTNExt);
            this.panel2.Controls.Add(this.lgnbtnlogin);
            this.panel2.Controls.Add(this.lgnlblpw);
            this.panel2.Location = new System.Drawing.Point(26, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 613);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(49)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1165, 663);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lgnlblun;
        private System.Windows.Forms.Label lgnlblpw;
        private System.Windows.Forms.TextBox lgntxtpw;
        private System.Windows.Forms.Button lgnbtnlogin;
        private System.Windows.Forms.TextBox lgntxtusna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNExt;
        private System.Windows.Forms.Panel panel2;
    }
}