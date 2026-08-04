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
    public partial class House : Form
    {
        House_Class house = new House_Class();
        public House()
        {
            InitializeComponent();
        }

        private void houseprevious_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();

            
            previousForm.Show();

            
            this.Hide();
        }





        private void housetxtcolonylotnumber_TextChanged(object sender, EventArgs e)
        {
            house.ColonyLotNumber = int.Parse(housetxtcolonylotnumber.Text);
        }

        private void housetxtrooms_TextChanged(object sender, EventArgs e)
        {
            house.NumberOfRooms = int.Parse(housetxtrooms.Text);
        }

        private void housetxtsqreft_TextChanged(object sender, EventArgs e)
        {
            house.SquareFeet = int.Parse(housetxtsqreft.Text);
        }

        private void housebtninsert_Click(object sender, EventArgs e)
        {
            house.insert();
            house.view();
        }

        private void housebtnupdate_Click(object sender, EventArgs e)
        {
            house.update();
            house.view();
        }






        private void housebtndelete_Click(object sender, EventArgs e)
        {
            house.delete();
            house.view();
        }

        private void housedgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                string colonylotnumber = housedgv.Rows[rowindex].Cells["COLONY_LOT_NUMBER"].Value.ToString();
                string numberofrooms = housedgv.Rows[rowindex].Cells["NUMBER_OF_ROOMS"].Value.ToString();
                string squarefeet = housedgv.Rows[rowindex].Cells["SQUARE_FEET"].Value.ToString();

                housetxtcolonylotnumber.Text = colonylotnumber;
                housetxtrooms.Text = numberofrooms;
                housetxtsqreft.Text = squarefeet;
            }
        }

        private void House_Load(object sender, EventArgs e)
        {
            house.DataGridView = housedgv;
            house.view();

            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            housedgv.BackgroundColor = Color.White;
            housedgv.GridColor = Color.Gray;
            housedgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            housedgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            housedgv.RowHeadersVisible = false;

            housedgv.AllowUserToAddRows = false;
            housedgv.AllowUserToDeleteRows = false;
            housedgv.AllowUserToResizeRows = false;
            housedgv.AllowUserToResizeColumns = true;

            housedgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            housedgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            housedgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            housedgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            housedgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            housedgv.MultiSelect = true;

            housedgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
