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
    public partial class ColonistQualification : Form
    {
        Colonist_Qualification_Class CQC = new Colonist_Qualification_Class();
        public ColonistQualification()
        {
            InitializeComponent();
        }

        private void colonistqprevious_Click(object sender, EventArgs e)
        {
            Colonist previousForm = new Colonist();


            previousForm.Show();

            this.Hide();
        }




        private void colonistqnext_Click(object sender, EventArgs e)
        {
            ColonistContact ESpace = new ColonistContact();
            ESpace.Show();

            this.Hide();
        }

        private void colonistqtodashboard_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();

            previousForm.Show();

            this.Hide();
        }

        private void colonistqtxtqualificationid_TextChanged(object sender, EventArgs e)
        {
            CQC.ColonistQualificationID = int.Parse(colonistqtxtqualificationid.Text);
        }

        private void colonistqtxtcolonistid_TextChanged(object sender, EventArgs e)
        {
            CQC.ColonistId = int.Parse(colonistqtxtcolonistid.Text);
        }

        private void colonistqtxtqualification_TextChanged(object sender, EventArgs e)
        {
            CQC.ColonistQualification = colonistqtxtqualification.Text;
        }









        private void colonistqbtninsert_Click(object sender, EventArgs e)
        {
            CQC.insert();
            CQC.View();
        }

        private void colonistqbtnupdate_Click(object sender, EventArgs e)
        {
            CQC.update();
            CQC.View();
        }

        private void colonistqbtndelete_Click(object sender, EventArgs e)
        {
            CQC.delete();
            CQC.View();
        }

        private void colonistqdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                string ColonistQualificationID = colonistqdgv.Rows[rowindex].Cells["COLONIST_QUALIFICATION_ID"].Value.ToString();
                string ColonistQualification = colonistqdgv.Rows[rowindex].Cells["COLONIST_QUALIFICATION"].Value.ToString();
                string ColonistID = colonistqdgv.Rows[rowindex].Cells["COLONIST_ID"].Value.ToString();
                
                colonistqtxtcolonistid.Text = ColonistQualificationID;
                colonistqtxtqualification.Text = ColonistQualification;
                colonistqtxtcolonistid.Text = ColonistID;
                
            }
        }





        private void Colonist_Qualification_Load(object sender, EventArgs e)
        {
            CQC.DataGridView = colonistqdgv;
            CQC.View();
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            colonistqdgv.BackgroundColor = Color.White;
            colonistqdgv.GridColor = Color.Gray;
            colonistqdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            colonistqdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            colonistqdgv.RowHeadersVisible = false;

            colonistqdgv.AllowUserToAddRows = false;
            colonistqdgv.AllowUserToDeleteRows = false;
            colonistqdgv.AllowUserToResizeRows = false;
            colonistqdgv.AllowUserToResizeColumns = true;

            colonistqdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            colonistqdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            colonistqdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            colonistqdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            colonistqdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colonistqdgv.MultiSelect = true;

            colonistqdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
