using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{
    internal class Job_Details_Class : CommonClass
    {
        public int JobID {get; set;}
        public int ColonistID { get; set; }
        public DataGridView DataGridView {get; set;}


        public void insert()
        {
            string sql = "insert into COLONIST_JOB_DETAILS(JOB_ID,COLONIST_ID)" +
                "VALUES ('" + JobID + "','" + ColonistID + "')";

            if (ExecuteQuery(sql,functiontype.insert))
            {
                View();
            }

        }

        public void update()
        {
            string sql = "update COLONIST_JOB_DETAILS set" + "(COLONIST_ID) = " +
                "('" + ColonistID + "')" +
                "where JOB_ID = '" + JobID + "'";

            if (ExecuteQuery(sql, functiontype.update))

            {
                View();
            }
        }



        public void delete()
        {
            string sql = "Delete from COLONIST_JOB_DETAILS where JOB_ID = " + JobID;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }
        }


        public void View()
        {
            string sql = "select*from COLONIST_JOB_DETAILS";
            ShowingDataFromGridView(sql, DataGridView);
        }
    }
}
