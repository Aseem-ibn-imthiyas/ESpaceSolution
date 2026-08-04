using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{   
    internal class Colonist_Qualification_Class : CommonClass
    {
        public int ColonistQualificationID { get; set; }
        public string ColonistQualification { get; set; }
        public int ColonistId { get; set; }
        public DataGridView DataGridView { get; set; }


        public void insert()
        {
            string sql = "Insert Into COLONIST_QUALIFICATION (COLONIST_QUALIFICATION_ID,COLONIST_QUALIFICATIOIN,COLONIST_ID)" +
                "Values('" + ColonistQualificationID + "','" + ColonistQualification + "','" + ColonistId + "')";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                View();
            }
        }









        public void update()
        {
            string sql = "Update COLONIST_QUALIFICATION set " + "( COLONIST_QUALIFICATIOIN, COLONIST_ID) = " +
            "('" + ColonistQualification + "', '" + ColonistId + "') " +
            "Where COLONIST_QUALIFICATION_ID = '" + ColonistQualificationID + "'";

            if (ExecuteQuery(sql, functiontype.update))
            {
                View();
            }


        }

        public void delete()
        {
            string sql = "Delete From COLONIST_QUALIFICATION Where COLONIST_QUALIFICATION_ID = " + ColonistQualificationID;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }
        }

        public void View()
        {
            string sql = "select*from COLONIST_QUALIFICATION ";
            ShowingDataFromGridView(sql, DataGridView);
        }

    }
}
