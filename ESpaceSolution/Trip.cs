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
    public partial class Trip : Form
    {   
        Trip_Class Trips = new Trip_Class();
        public Trip()
        {
            InitializeComponent();
        }

        private void tripprevious_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();


            previousForm.Show();


            this.Hide();
        }

        private void triptxttid_TextChanged(object sender, EventArgs e)
        {
            Trips.TripId = int.Parse(triptxttid.Text);
        }




        private void triptxtjetcode_TextChanged(object sender, EventArgs e)
        {
            Trips.JetCode = int.Parse(triptxtjetcode.Text);
        }

        private void triptxtlnchdate_ValueChanged(object sender, EventArgs e)
        {
            Trips.LaunchDate = triptxtlnchdate.Value;
        }

        private void triptxtrtrndate_ValueChanged(object sender, EventArgs e)
        {
            Trips.ReturnDate = triptxtrtrndate.Value;
        }

        private void tripbtninsert_Click(object sender, EventArgs e)
        {
            Trips.insert();
            Trips.View();
        }

        private void tripbtnupdate_Click(object sender, EventArgs e)
        {
            Trips.update(); 
            Trips.View();
        }

        private void tripbtndelete_Click(object sender, EventArgs e)
        {
            Trips.delete();
            Trips.View();
        }







        private void tripdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                string TripID = tripdgv.Rows[rowindex].Cells["TRIP_ID"].Value.ToString();
                string Launchdate = tripdgv.Rows[rowindex].Cells["LAUNCH_DATE"].Value.ToString();
                string Returndate = tripdgv.Rows[rowindex].Cells["RETURN_DATE"].Value.ToString();
                string Jetcode = tripdgv.Rows[rowindex].Cells["JET_CODE"].Value.ToString();

                triptxttid.Text = TripID;

                triptxtlnchdate.Text = DateTime.TryParse(Launchdate, out DateTime parsedLaunchDate)
                    ? parsedLaunchDate.ToString("MM/dd/yyyy")
                    : DateTime.Today.ToString("MM/dd/yyyy");

                triptxtrtrndate.Text = DateTime.TryParse(Returndate, out DateTime parsedReturnDate)
                    ? parsedReturnDate.ToString("MM/dd/yyyy")
                    : DateTime.Today.ToString("MM/dd/yyyy");

                triptxtjetcode.Text = Jetcode;
            }
        }

        private void Trip_Load(object sender, EventArgs e)
        {
            Trips.DataGridView = tripdgv;
            Trips.View();

            CustomizeDataGridView();
        }





        private void CustomizeDataGridView()
        {
            tripdgv.BackgroundColor = Color.White;
            tripdgv.GridColor = Color.Gray;
            tripdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            tripdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            tripdgv.RowHeadersVisible = false;

            tripdgv.AllowUserToAddRows = false;
            tripdgv.AllowUserToDeleteRows = false;
            tripdgv.AllowUserToResizeRows = false;
            tripdgv.AllowUserToResizeColumns = true;


            tripdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            tripdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            tripdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            tripdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            tripdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tripdgv.MultiSelect = true;


            tripdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
