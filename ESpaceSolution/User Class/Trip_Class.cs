using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_SPACE.User_Class
{
    internal class Trip_Class : CommonClass
    {
        public int TripId { get; set; }
        public DateTime LaunchDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int JetCode { get; set; }
        public DataGridView DataGridView { get; set; }


        public void insert()
        {
            string sql = "Insert Into TRIP (TRIP_ID,LAUNCH_DATE,RETURN_DATE,JET_CODE)" +
                "Values('" + TripId + "','" + LaunchDate + "','" + ReturnDate + "','" + JetCode + "')";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                View();
            }
        }









        public void update()
        {
            
            
            string sql = "UPDATE TRIP SET " + "LAUNCH_DATE = '" + LaunchDate + "', " + "RETURN_DATE = '" + ReturnDate + "', " + "JET_CODE = '" + JetCode + "' " + "WHERE TRIP_ID = '" + TripId + "'";


            if (ExecuteQuery(sql, functiontype.update))
            {
                View();
            }


        }



        public void delete()
        {
            string sql = "Delete From TRIP Where TRIP_ID = " + TripId;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }
        }


        public void View()
        {
            string sql = "select*from TRIP ";
            ShowingDataFromGridView(sql, DataGridView);
        }

    }
}
