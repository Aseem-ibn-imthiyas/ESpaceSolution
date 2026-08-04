using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dbbtncolonist_Click(object sender, EventArgs e)
        {
            LoadForm(new Colonist());

        }

        private void dbbtndependents_Click(object sender, EventArgs e)
        {
            LoadForm(new Dependent());
        }

        private void dbbtnhouse_Click(object sender, EventArgs e)
        {
            LoadForm(new House());
        }

        private void dbbtntrip_Click(object sender, EventArgs e)
        {
            LoadForm(new Trip());
        }   


        private void dbbtnastronomer_Click(object sender, EventArgs e)
        {
            LoadForm(new Astronomer());
        }

        private void dbbtnejet_Click(object sender, EventArgs e)
        {
            LoadForm(new EJet());
        }

        private void dbbtnjob_Click(object sender, EventArgs e)
        {
            LoadForm(new Job());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void LoadForm(object form)
        {
            Main_Panel.Controls.Clear();

            Form f = form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            Main_Panel.Controls.Add(f);
            f.Show();
        }

        private void Main_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JobDetails_Click(object sender, EventArgs e)
        {
            LoadForm(new JobDetails());
        }

        private void ColonistContact_Click(object sender, EventArgs e)
        {
            LoadForm(new ColonistContact());
        }

        private void ColonistQualification_Click(object sender, EventArgs e)
        {
            LoadForm(new ColonistQualification());
        }

        private void AstronomerQualification_Click(object sender, EventArgs e)
        {

            LoadForm(new Astromomer_Qualification());
        }
    }
}
