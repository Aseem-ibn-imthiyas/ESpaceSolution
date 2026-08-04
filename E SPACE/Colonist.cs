using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_SPACE;
using E_SPACE.User_Class;

namespace E_SPACE
{
    public partial class Colonist : Form
    {
        Colonist_Class Clnst = new Colonist_Class();

        public Colonist()
        {
            InitializeComponent();
        }

        private void Colonist_Load(object sender, EventArgs e)
        {
            Clnst.dataGridView = colonistdgv;
            Clnst.View();

            CustomizeDataGridView();
        }





        private void colonistprevious_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();


            previousForm.Show();

            this.Hide();
        }

        private void colonistnext_Click(object sender, EventArgs e)
        {
            ColonistQualification ESpace = new ColonistQualification();
            ESpace.Show();

            this.Hide();
        }



        private void colonisttxtclnstid_TextChanged(object sender, EventArgs e)
        {
            Clnst.ColonistId = int.Parse(colonisttxtclnstid.Text);

        }



        private void colonisttxtfn_TextChanged(object sender, EventArgs e)
        {
            Clnst.FirstName = colonisttxtfn.Text;
        }


















        private void colonisttxtmn_TextChanged(object sender, EventArgs e)
        {
            Clnst.MiddleName = colonisttxtmn.Text;
        }


        private void colonisttxtaddress_TextChanged(object sender, EventArgs e)
        {
            Clnst.HomeAddress = colonisttxtaddress.Text;
        }

        private void colonisttxtgender_TextChanged(object sender, EventArgs e)
        {
            Clnst.Gender = colonisttxtgender.Text;
        }


        private void colonisttxtstatus_TextChanged(object sender, EventArgs e)
        {
            Clnst.CivilStatus = colonisttxtstatus.Text;
        }

        private void colonisttxtmembers_TextChanged(object sender, EventArgs e)
        {
            Clnst.FamilyMembers = colonisttxtmembers.Text;
        }

        private void colonistbtninsert_Click(object sender, EventArgs e)
        {
            Clnst.insert();
            Clnst.View();

        }









        private void colonistbtnupdate_Click(object sender, EventArgs e)
        {
            Clnst.update();
            Clnst.View();
        }

        private void colonistbtndelete_Click(object sender, EventArgs e)
        {
            Clnst.delete();
            Clnst.View();
        }

        private void colonistdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {


                string ColonistID = colonistdgv.Rows[rowIndex].Cells["COLONIST_ID"].Value.ToString();
                string FirstName = colonistdgv.Rows[rowIndex].Cells["FIRST_NAME"].Value.ToString();
                string MiddleName = colonistdgv.Rows[rowIndex].Cells["MIDDLE_NAME"].Value.ToString();
                string SureName = colonistdgv.Rows[rowIndex].Cells["SURNAME"].Value.ToString();
                string DOB = colonistdgv.Rows[rowIndex].Cells["DOB"].Value.ToString();
                string Age = colonistdgv.Rows[rowIndex].Cells["AGE"].Value.ToString();
                string HomeAddress = colonistdgv.Rows[rowIndex].Cells["HOME_ADDRESS"].Value.ToString();
                string Gender = colonistdgv.Rows[rowIndex].Cells["GENDER"].Value.ToString();
                string CivilStatus = colonistdgv.Rows[rowIndex].Cells["CIVIL_STATUS"].Value.ToString();
                string NumberFamilyMembers = colonistdgv.Rows[rowIndex].Cells["NUMBER_FAMILY_MEMBERS"].Value.ToString();
                string ColonyLotNumber = colonistdgv.Rows[rowIndex].Cells["COLONY_LOT_NUMBER"].Value.ToString();
                string TripID = colonistdgv.Rows[rowIndex].Cells["TRIP_ID"].Value.ToString();

                colonisttxtclnstid.Text = ColonistID;
                colonisttxtfn.Text = FirstName;
                colonisttxtmn.Text = MiddleName;
                colonisttxtsn.Text = SureName;

                if (DateTime.TryParse(DOB, out DateTime parsedDOB) && parsedDOB >= dateTimePicker1.MinDate && parsedDOB <= dateTimePicker1.MaxDate)
                {
                    dateTimePicker1.Value = parsedDOB;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Today;
                }

                colonisttxtage.Text = Age;
                colonisttxtaddress.Text = HomeAddress;
                colonisttxtgender.Text = Gender;
                colonisttxtstatus.Text = CivilStatus;
                colonisttxtmembers.Text = NumberFamilyMembers;
                colonisttxtcolonylotnumber.Text = ColonyLotNumber;
                colonisttxttripid.Text = TripID;

            }



        }

        private void colonisttxtcolonylotnumber_TextChanged(object sender, EventArgs e)
        {
            Clnst.Colony_Lot_Number = int.Parse(colonisttxtcolonylotnumber.Text);
        }

        private void colonisttxttripid_TextChanged(object sender, EventArgs e)
        {
            Clnst.TripId = int.Parse(colonisttxttripid.Text);
        }











        private void colonisttxtage_TextChanged(object sender, EventArgs e)
        {
            Clnst.Age = int.Parse(colonisttxtage.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Clnst.DOB = dateTimePicker1.Value;

        }

        private void colonisttxtsn_TextChanged(object sender, EventArgs e)
        {
            Clnst.Surname = colonisttxtsn.Text;
        }

        private void CustomizeDataGridView()
        {
            colonistdgv.BackgroundColor = Color.White;
            colonistdgv.GridColor = Color.Gray;
            colonistdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            colonistdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            colonistdgv.RowHeadersVisible = false;

            colonistdgv.AllowUserToAddRows = false;
            colonistdgv.AllowUserToDeleteRows = false;
            colonistdgv.AllowUserToResizeRows = false;
            colonistdgv.AllowUserToResizeColumns = true;

            colonistdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            colonistdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            colonistdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            colonistdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            colonistdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colonistdgv.MultiSelect = true;

            colonistdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
