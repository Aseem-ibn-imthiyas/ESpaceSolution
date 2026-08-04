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
    public partial class EJet : Form
    {
        E_Jet_Class E_Jets = new E_Jet_Class();
        public EJet()
        {
            InitializeComponent();
        }

        private void ejetprevious_Click(object sender, EventArgs e)
        {
            Dashboard previousForm = new Dashboard();


            previousForm.Show();

            this.Hide();
        }

        private void ejettxtjetcode_TextChanged(object sender, EventArgs e)
        {
            E_Jets.JetCode = int.Parse(ejettxtjetcode.Text);
        }





        private void ejettxtjettype_TextChanged(object sender, EventArgs e)
        {
            E_Jets.JetType = ejettxtjettype.Text;
        }

        private void ejettxtpwrsrc_TextChanged(object sender, EventArgs e)
        {
            E_Jets.PowerSource = ejettxtpwrsrc.Text;
        }
               

        private void ejettxtjetweight_TextChanged(object sender, EventArgs e)
        {
            E_Jets.JetWeight = int.Parse(ejettxtjetweight.Text);
        }

        
        private void ejettxtseats_TextChanged(object sender, EventArgs e)
        {
            E_Jets.NumberPassengerSeats = int.Parse(ejettxtseats.Text);
        }

        private void ejettxtmadeyear_ValueChanged(object sender, EventArgs e)
        {
            E_Jets.MadeYear = ejettxtmadeyear.Value;
        }

        private void ejetbtninsert_Click(object sender, EventArgs e)
        {
            E_Jets.insert();
            E_Jets.view();
        }



        private void ejetbtnupdate_Click(object sender, EventArgs e)
        {
            E_Jets.update();
            E_Jets.view();
        }

        private void ejetbtndelete_Click(object sender, EventArgs e)
        {
            E_Jets.delete();
            E_Jets.view();
        }

        private void ejetdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                string JetCode = ejetdgv.Rows[rowindex].Cells["JET_CODE"].Value.ToString();
                string JetType = ejetdgv.Rows[rowindex].Cells["JET_TYPE"].Value.ToString();
                string PowerSource = ejetdgv.Rows[rowindex].Cells["POWER_SOURCE"].Value.ToString();
                string JetWeight = ejetdgv.Rows[rowindex].Cells["JET_WEIGHT"].Value.ToString();
                string Madeyear = ejetdgv.Rows[rowindex].Cells["MADE_YEAR"].Value.ToString();
                string NumberPassenger = ejetdgv.Rows[rowindex].Cells["NUMBER_PASSENGER_SEATS"].Value.ToString();

                ejettxtjetcode.Text = JetCode;
                ejettxtjettype.Text = JetType;
                ejettxtpwrsrc.Text = PowerSource;
                ejettxtjetweight.Text = JetWeight;
                ejettxtmadeyear.Text = Madeyear;
                ejettxtseats.Text = NumberPassenger;
            }
        }

        private void E_Jet_Load(object sender, EventArgs e)
        {
            E_Jets.dataGridView = ejetdgv;
            E_Jets.view();

            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            ejetdgv.BackgroundColor = Color.White;
            ejetdgv.GridColor = Color.Gray;
            ejetdgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            ejetdgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            ejetdgv.RowHeadersVisible = false;

            ejetdgv.AllowUserToAddRows = false;
            ejetdgv.AllowUserToDeleteRows = false;
            ejetdgv.AllowUserToResizeRows = false;
            ejetdgv.AllowUserToResizeColumns = true;

            ejetdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            ejetdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            ejetdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            ejetdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ejetdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ejetdgv.MultiSelect = true;

            ejetdgv.CellToolTipTextNeeded += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    e.ToolTipText = "Cell Info";
                }
            };
        }

    }
}
