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
using E_SPACE;
using System.Security.Cryptography;


namespace E_SPACE
{
    public partial class Job : Form
    {
        Job_Class job = new Job_Class();
                
        public Job()
        {
            InitializeComponent();
        }

        private void jobprevious_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();

            previousForm.Show();

            this.Hide();
        }

        

        private void jobtxtjobid_TextChanged(object sender, EventArgs e)
        {
            job.Job_ID = int.Parse(jobtxtjobid.Text);
        }

        private void jobtxtjobname_TextChanged(object sender, EventArgs e)
        {
            job.Job_Name = jobtxtjobname.Text;
        }

        private void jobtxtjobdescription_TextChanged(object sender, EventArgs e)
        {
            job.JobDescription = jobtxtjobdescription.Text;

        }

        private void Job_Load(object sender, EventArgs e)
        {
            job.dataGridView = jobdgv;
            job.view();

            CustomizeDataGridView();
        }

        private void jobbtninsert_Click(object sender, EventArgs e)
        {
            job.insert();
            job.view();
        }

        private void jobbtnupdate_Click(object sender, EventArgs e)
        {
            job.update();
            job.view();

        }

        private void jobbtndelete_Click(object sender, EventArgs e)
        {
            job.delete();
            job.view();
        }

        private void jobdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex < 0)
            { 
                string JobID = jobdgv.Rows[rowindex].Cells["JOB_ID"].Value.ToString();
                string JobName = jobdgv.Rows[rowindex].Cells["JOB_NAME"].Value.ToString();
                string JobDescription = jobdgv.Rows[rowindex].Cells["JOB_DESCRIPTION"].Value.ToString();

                jobtxtjobid.Text = JobID;
                jobtxtjobname.Text = JobName;
                jobtxtjobdescription.Text = JobDescription;
            }

            
        }




        private void CustomizeDataGridView()
        {
            jobdgv.BackgroundColor = Color.White;
            jobdgv.GridColor = Color.Gray;
            jobdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            jobdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            jobdgv.RowHeadersVisible = false;

            jobdgv.AllowUserToAddRows = false;
            jobdgv.AllowUserToDeleteRows = false;
            jobdgv.AllowUserToResizeRows = false;
            jobdgv.AllowUserToResizeColumns = true;

            jobdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            jobdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            jobdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            jobdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            jobdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jobdgv.MultiSelect = true;

            jobdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
