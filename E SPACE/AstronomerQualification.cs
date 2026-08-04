using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_SPACE;
using E_SPACE.User_Class;

namespace E_SPACE
{
    
    public partial class Astromomer_Qualification : Form
    {
        Astronomer_Qualification_Class AQC = new Astronomer_Qualification_Class();
        public Astromomer_Qualification()
        {
            InitializeComponent();
        }

        private void astronomerqtodashboard_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();


            previousForm.Show();

            this.Hide();
        }


        private void astronomerqprevious_Click(object sender, EventArgs e)
        {
            Astronomer previousForm = new Astronomer();


            previousForm.Show();

            this.Hide();
        }
        

        private void astronomerqtxtastronomerid_TextChanged(object sender, EventArgs e)
        {
            AQC.AstronomerID = int.Parse(astronomerqtxtastroqualiID.Text);
        }
        

        private void astronomerqtxtastronomerQualification_TextChanged(object sender, EventArgs e)
        {
            AQC.AstronomerQualification = astronomerqtxtAstronomerID.Text;
        }

        private void astronomerqtxtAstronomerID_TextChanged_1(object sender, EventArgs e)
        {
            AQC.AstronomerID = int.Parse(astronomerqtxtAstronomerID.Text);
        }

        private void colonistqbtninsert_Click(object sender, EventArgs e)
        {
            AQC.insert();
            AQC.View();
        }












        private void colonistqbtnupdate_Click(object sender, EventArgs e)
        {
            AQC.update();
            AQC.View();
        }

        private void colonistqbtndelete_Click(object sender, EventArgs e)
        {
            AQC.delete();
            AQC.View();
        }

        private void astronomerqdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)

            {
                string AstronomerQualificationID = astronomerqdgv.Rows[rowindex].Cells["ASTRONOMER_QUALIFICATION_ID"].Value.ToString();
                string AstronomerQualfication = astronomerqdgv.Rows[rowindex].Cells["QUALIFICATION_NAME"].Value.ToString();
                string AstronomerID = astronomerqdgv.Rows[rowindex].Cells["ASTRONOMER_ID"].Value.ToString();

                astronomerqtxtastroqualiID.Text = AstronomerQualificationID;
                astronomerqtxtastronomerQualification.Text = AstronomerQualfication;
                astronomerqtxtAstronomerID.Text = AstronomerID;
            }
            
        }








        private void Astromomer_Qualification_Load(object sender, EventArgs e)
        {
            AQC.DataGridView = astronomerqdgv;
            AQC.View();

            CustomizeDataGridView();
        }


        private void CustomizeDataGridView()
        {
            astronomerqdgv.BackgroundColor = Color.White;
            astronomerqdgv.GridColor = Color.Gray;
            astronomerqdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            astronomerqdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            astronomerqdgv.RowHeadersVisible = false;

            astronomerqdgv.AllowUserToAddRows = false;
            astronomerqdgv.AllowUserToDeleteRows = false;
            astronomerqdgv.AllowUserToResizeRows = false;
            astronomerqdgv.AllowUserToResizeColumns = true;

            astronomerqdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            astronomerqdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            astronomerqdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            astronomerqdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            astronomerqdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            astronomerqdgv.MultiSelect = true;

            astronomerqdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
