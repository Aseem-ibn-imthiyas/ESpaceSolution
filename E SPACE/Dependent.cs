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

    public partial class Dependent : Form
    {
        Dependent_Class Depe = new Dependent_Class();
        public Dependent()
        {
            InitializeComponent();
        }

        private void dependentprevious_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();

            
            previousForm.Show();

            
            this.Hide();
        }


        private void dependenttxtdid_TextChanged(object sender, EventArgs e)
        {
            Depe.DependentID = int.Parse(dependenttxtdid.Text);
        }

        private void dependenttxtclnstid_TextChanged(object sender, EventArgs e)
        {
            Depe.ColonistID = int.Parse(dependenttxtclnstid.Text);
        }

        private void dependenttxtname_TextChanged(object sender, EventArgs e)
        {
            Depe.DependentName = dependenttxtname.Text;
        }

        private void dependenttxtrltnship_TextChanged(object sender, EventArgs e)
        {
            Depe.Relationship = dependenttxtage.Text;
        }

        private void dependenttxtdob_ValueChanged(object sender, EventArgs e)
        {
            Depe.DOB = dependenttxtdob.Value;
        }

        private void dependentbtninsert_Click(object sender, EventArgs e)
        {
            Depe.insert();
            Depe.View();
        }








        private void dependentbtnupdate_Click(object sender, EventArgs e)
        {
            Depe.update();
            Depe.View();
        }

        private void dependentbtndelete_Click(object sender, EventArgs e)
        {
            Depe.delete();
            Depe.View();
        }

        private void dependentdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                string DependentID = dependentdgv.Rows[rowindex].Cells["DEPENDENT_ID"].Value.ToString();
                string DependentName = dependentdgv.Rows[rowindex].Cells["DEPENDENT_NAME"].Value.ToString();
                string DOB = dependentdgv.Rows[rowindex].Cells["DOB"].Value.ToString();
                string AGE = dependentdgv.Rows[rowindex].Cells["AGE"].Value.ToString();
                string Relationship = dependentdgv.Rows[rowindex].Cells["RELATIONSHIP"].Value.ToString();
                string ColonistID = dependentdgv.Rows[rowindex].Cells["COLONIST_ID"].Value.ToString();

                dependenttxtdid.Text = DependentID;
                dependenttxtname.Text = DependentName;
                dependenttxtdob.Text = DOB;
                dependenttxtage.Text = AGE;
                dependenttxtrltnship.Text = Relationship;
                dependenttxtclnstid.Text = ColonistID;
            }
        }












        private void Dependent_Load(object sender, EventArgs e)
        {
            Depe.DataGridView = dependentdgv;
            Depe.View();

            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            dependentdgv.BackgroundColor = Color.White;
            dependentdgv.GridColor = Color.Gray;
            dependentdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dependentdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dependentdgv.RowHeadersVisible = false;

            dependentdgv.AllowUserToAddRows = false;
            dependentdgv.AllowUserToDeleteRows = false;
            dependentdgv.AllowUserToResizeRows = false;
            dependentdgv.AllowUserToResizeColumns = true;

            dependentdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dependentdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dependentdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dependentdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dependentdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dependentdgv.MultiSelect = true;

            dependentdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
