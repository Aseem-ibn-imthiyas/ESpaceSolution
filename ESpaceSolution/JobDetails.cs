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
    public partial class JobDetails : Form
    {
        Job_Details_Class JDC = new Job_Details_Class();
        public JobDetails()
        {
            InitializeComponent();
        }

        private void jobdtodashboard_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();


            previousForm.Show();

            this.Hide();
        }

        private void jobdtxtjobid_TextChanged(object sender, EventArgs e)
        {
            JDC.JobID = int.Parse(jobdtxtjobid.Text);
        }

        private void jobdtxtcolonistid_TextChanged(object sender, EventArgs e)
        {
            JDC.ColonistID = int.Parse(jobdtxtcolonistid.Text);
        }








        private void jobdbtninsert_Click(object sender, EventArgs e)
        {
            JDC.insert();
            JDC.View();
        }

        private void jobdbtnupdate_Click(object sender, EventArgs e)
        {
            JDC.update();
            JDC.View();
        }

        private void jobdbtndelete_Click(object sender, EventArgs e)
        {
            JDC.delete();
            JDC.View();
        }

        private void jobddgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)

            {
                string JobID = jobddgv.Rows[rowindex].Cells["JOB_ID"].Value.ToString();
                string ColonistID = jobddgv.Rows[rowindex].Cells["ASTRONOMER_ID"].Value.ToString();

                jobdtxtjobid.Text = JobID;
                jobdtxtcolonistid.Text = ColonistID;
            
            }

        }
        private void Job_Details_Load(object sender, EventArgs e)
        {
            JDC.DataGridView = jobddgv;
            JDC.View();

            CustomizeDataGridView();
        }











        private void CustomizeDataGridView()
        {
            jobddgv.BackgroundColor = Color.White;
            jobddgv.GridColor = Color.Gray;
            jobddgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            jobddgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            jobddgv.RowHeadersVisible = false;

            jobddgv.AllowUserToAddRows = false;
            jobddgv.AllowUserToDeleteRows = false;
            jobddgv.AllowUserToResizeRows = false;
            jobddgv.AllowUserToResizeColumns = true;

            jobddgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            jobddgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            jobddgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            jobddgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            jobddgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jobddgv.MultiSelect = true;

            jobddgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

        private void jobdprevious_Click(object sender, EventArgs e)
        {
            ColonistContact CC = new ColonistContact();
            CC.Show();
            this.Close();
        }
    }
}
