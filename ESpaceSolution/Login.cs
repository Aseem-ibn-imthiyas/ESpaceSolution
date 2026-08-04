using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static E_SPACE.CommonClass;

namespace E_SPACE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void lgnbtnlogin_Click(object sender, EventArgs e)
        {

            string username = lgntxtusna.Text;
            string password = lgntxtpw.Text;

            CommonClass common = new CommonClass();

            if (common.CheckLogin(username, password))
            {
                MessageBox.Show("Welcome To Espace Portal");

                Dashboard ESpace = new Dashboard();
                ESpace.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            RoundPanel(panel2, 30); // 30 = corner roundness
        }



        public void RoundPanel(Panel pnl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path);

        }

    }
}




