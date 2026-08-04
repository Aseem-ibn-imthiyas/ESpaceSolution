using E_SPACE.User_Class;
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
    public partial class Astronomer : Form
    {
        Astronomer_Class AC = new Astronomer_Class();    

        public Astronomer()
        {
            InitializeComponent();
        }

        private void astronomerprevious_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();


            previousForm.Show();


            this.Hide();
        }

        private void astronomernext_Click(object sender, EventArgs e)
        {
            Astromomer_Qualification ESpace = new Astromomer_Qualification();
            ESpace.Show();

            this.Hide();
        }













        private void Astronomer_Load(object sender, EventArgs e)
        {
            AC.DataGridView = astronomerdgv;
            AC.View();

            CustomizeDataGridView();

        }

        private void astronomertxtaid_TextChanged(object sender, EventArgs e)
        {
            AC.AstronomerID = int.Parse(astronomertxtaid.Text);
        }

        private void astronomertxtjetcode_TextChanged(object sender, EventArgs e)
        {
            AC.Jet_Code = int.Parse(astronomertxtjetcode.Text);
        }

        private void astronomertxtname_TextChanged(object sender, EventArgs e)
        {
            AC.AstronomerName = astronomertxtname.Text;
        }

        private void astronomertxtdesignation_TextChanged(object sender, EventArgs e)
        {
            AC.Designation = astronomertxtdesignation.Text;
        }

        private void astronomertxtexperience_TextChanged(object sender, EventArgs e)
        {
            AC.Experience = int.Parse(astronomertxtexperience.Text);
        }













        private void astronomerbtninsert_Click(object sender, EventArgs e)
        {
            AC.insert();
            AC.View();

        }

        private void astronomerbtnupdate_Click(object sender, EventArgs e)
        {
            AC.update();
            AC.View();
        }

        private void astronomerbtndelete_Click(object sender, EventArgs e)
        {
            AC.delete();
            AC.View();
        }

        private void astronomerdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                string AstronomerID  = astronomerdgv.Rows[rowindex].Cells["ASTRONOMER_ID"].Value.ToString();
                string AstronomerName = astronomerdgv.Rows[rowindex].Cells["ASTRONOMER_NAME"].Value.ToString();
                string Designation = astronomerdgv.Rows[rowindex].Cells["DESIGNATION"].Value.ToString();
                string Experience = astronomerdgv.Rows[rowindex].Cells["EXPERIENCE"].Value.ToString();
                string JetCode = astronomerdgv.Rows[rowindex].Cells["JET_CODE"].Value.ToString();

                astronomertxtaid.Text = AstronomerID;
                astronomertxtname.Text = AstronomerName;
                astronomertxtdesignation.Text = Designation;
                astronomertxtexperience.Text = Experience;
                astronomertxtjetcode.Text = JetCode;
            }
        }








        private void CustomizeDataGridView()
        {
            astronomerdgv.BackgroundColor = Color.White;
            astronomerdgv.GridColor = Color.Gray;
            astronomerdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            astronomerdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            astronomerdgv.RowHeadersVisible = false;

            astronomerdgv.AllowUserToAddRows = false;
            astronomerdgv.AllowUserToDeleteRows = false;
            astronomerdgv.AllowUserToResizeRows = false;
            astronomerdgv.AllowUserToResizeColumns = true;

            
            astronomerdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            
            astronomerdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            astronomerdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            astronomerdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            
            astronomerdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            astronomerdgv.MultiSelect = true;

            
            astronomerdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
