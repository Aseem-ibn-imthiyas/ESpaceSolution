using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{
    internal class E_Jet_Class : CommonClass
    {
        public int JetCode { get; set; }
        public string JetType { get; set; }
        public string PowerSource { get; set; }
        public int JetWeight { get; set; }
        public DateTime MadeYear { get; set; }
        public int NumberPassengerSeats { get; set; }
        public DataGridView dataGridView { get; set; }


        public void insert()
        {
            string sql = "Insert Into EJET (JET_CODE,JET_TYPE,POWER_SOURCE,JET_WEIGHT,MADE_YEAR,NUMBER_PASSENGER_SEATS)" +
            "Values('" + JetCode + "','" + JetType + "','" + PowerSource + "','"+JetWeight+"','"+MadeYear+"','"+NumberPassengerSeats+"')";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                view();
            }
        }

        

        public void update()
        {
            string sql = "UPDATE EJET SET JET_TYPE = '" + JetType + "', " +
                         "POWER_SOURCE = '" + PowerSource + "', " +
                         "JET_WEIGHT = '" + JetWeight + "', " +
                         "MADE_YEAR = '" + MadeYear + "', " +
                         "NUMBER_PASSENGER_SEATS = '" + NumberPassengerSeats + "' " +
                         "WHERE JET_CODE = '" + JetCode + "'";

            if (ExecuteQuery(sql, functiontype.update))
            {
                view();
            }
        }




        public void delete()
        {
            string sql = "Delete from EJET where JET_CODE = " + JetCode;

            if (ExecuteQuery(sql, functiontype.delete))

            {
                view();
            }
        }

        public void view()
        {
            string sql = "Select*from EJET ";
            ShowingDataFromGridView(sql, dataGridView);

        }
    }
}
