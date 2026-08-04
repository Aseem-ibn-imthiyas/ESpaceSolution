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
    public partial class ColonistContact : Form
    {   
        Colonist_Contact_Class CCC = new Colonist_Contact_Class();
        public ColonistContact()
        {
            InitializeComponent();
        }
       

        private void colonistctodashboard_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();


            previousForm.Show();

            this.Hide();
        }        

        private void colonistctxtcontactid_TextChanged(object sender, EventArgs e)
        {
            CCC.ColonistContactID = int.Parse(colonistctxtcontactid.Text);
        }

        private void colonistctxtcolonistid_TextChanged(object sender, EventArgs e)
        {
            CCC.ColonistID = int.Parse(colonistctxtcolonistid.Text);
        }

        private void colonistctxtcontactnum_TextChanged(object sender, EventArgs e)
        {
            CCC.ColonistContactNumber = int.Parse(colonistctxtcontactnum.Text);
        }

        private void colonistcbtninsert_Click(object sender, EventArgs e)
        {
            CCC.insert();
            CCC.View();
        }

        private void colonistcbtnupdate_Click(object sender, EventArgs e)
        {
            CCC.update();
            CCC.View();
        }











        private void colonistcbtndelete_Click(object sender, EventArgs e)
        {
            CCC.delete();
            CCC.View();
        }

        private void colonistcdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                string ColonistContactID = colonistcdgv.Rows[rowindex].Cells["COLONIST_CONTACT_ID"].Value.ToString();
                string ColonistContactNumber = colonistcdgv.Rows[rowindex].Cells["COLONIST_CONTACT_NUMBER"].Value.ToString();
                string ColonistID = colonistcdgv.Rows[rowindex].Cells["COLONIST_ID"].Value.ToString();


                colonistctxtcontactid.Text = ColonistContactID;
                colonistctxtcontactnum.Text = ColonistContactNumber;
                colonistctxtcolonistid.Text = ColonistContactID;
            }
        }

        private void Colonist_Contact_Load(object sender, EventArgs e)
        {
            CCC.DataGridView = colonistcdgv;
            CCC.View();

            CustomizeDataGridView();
        }







        private void CustomizeDataGridView()
        {
            colonistcdgv.BackgroundColor = Color.White;
            colonistcdgv.GridColor = Color.Gray;
            colonistcdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            colonistcdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            colonistcdgv.RowHeadersVisible = false;

            colonistcdgv.AllowUserToAddRows = false;
            colonistcdgv.AllowUserToDeleteRows = false;
            colonistcdgv.AllowUserToResizeRows = false;
            colonistcdgv.AllowUserToResizeColumns = true;

            colonistcdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            colonistcdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            colonistcdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            colonistcdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            colonistcdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colonistcdgv.MultiSelect = true;

            colonistcdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

        private void Colonistcontactnext_Click(object sender, EventArgs e)
        {
            JobDetails JD = new JobDetails();
            JD.Show();
            this.Close();
        }

        private void colonistcprevious_Click(object sender, EventArgs e)
        {
            ColonistQualification CQ = new ColonistQualification();
            CQ.Show();
            this.Close();
        }
    }
}
