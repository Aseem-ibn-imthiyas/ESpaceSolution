using E_SPACE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_SPACE.User_Class
{
    internal class Job_Class : CommonClass
    {
        public int Job_ID { get; set; }
        public string Job_Name { get; set; }
        public string JobDescription { get; set; }
        public DataGridView dataGridView { get; set; }


        public void insert()
        {
            string sql = "Insert Into JOB (JOB_ID,JOB_NAME,JOB_DESCRIPTION)" +
            "Values('" + Job_ID + "','" + Job_Name + "','" + JobDescription + "')";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                view();
            }
        }

        public void update()
        {
            string sql = "Update JOB set (JOB_NAME,JOB_DESCRIPTION) = " + "('" + Job_Name + "','" + JobDescription + "')" + "where JOB_ID = '" + Job_ID + "'";

            if (ExecuteQuery(sql, functiontype.update))

            {
                view();
            }


        }

        public void delete() 
        {
            string sql = "Delete from JOB where JOB_ID = " + Job_ID;

            if (ExecuteQuery(sql, functiontype.delete))

            {
                view();
            }
        }

        public void view()
        {
            string sql = "Select*from JOB ";
            ShowingDataFromGridView(sql,dataGridView);
        
        }
    }
}


