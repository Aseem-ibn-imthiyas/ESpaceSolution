using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{

    internal class House_Class : CommonClass
    {
        public int ColonyLotNumber { get; set; }
        public int NumberOfRooms { get; set; }
        public int SquareFeet { get; set; }
        public DataGridView DataGridView { get; set; }

        public void insert()
        {
            try
            {
                string sql = "Insert Into HOUSE (COLONY_LOT_NUMBER,NUMBER_OF_ROOMS,SQUARE_FEET) " +
                             "Values('" + ColonyLotNumber + "','" + NumberOfRooms + "','" + SquareFeet + "')";

                if (ExecuteQuery(sql, functiontype.insert))
                {
                    view();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update()
        {
            try
            {
                string sql = "Update HOUSE set NUMBER_OF_ROOMS = '" + NumberOfRooms +
                             "', SQUARE_FEET = '" + SquareFeet +
                             "' where COLONY_LOT_NUMBER = '" + ColonyLotNumber + "'";

                if (ExecuteQuery(sql, functiontype.update))
                {
                    view();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete()
        {
            try
            {
                string sql = "Delete from HOUSE where COLONY_LOT_NUMBER = '" + ColonyLotNumber + "'";

                if (ExecuteQuery(sql, functiontype.delete))
                {
                    view();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void view()
        {
            try
            {
                string sql = "Select * from HOUSE";
                ShowingDataFromGridView(sql, DataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while viewing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
