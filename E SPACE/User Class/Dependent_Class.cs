using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{
    internal class Dependent_Class : CommonClass
    {
        public int DependentID { get; set; }
        public string DependentName { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Relationship { get; set; }
        public int ColonistID { get; set; }
        public DataGridView DataGridView { get; set; }


        public void insert()
        {
            string sql = "Insert Into DEPENDENTS (DEPENDENT_ID,DEPENDENT_NAME,DOB,AGE,RELATIONSHIP,COLONIST_ID)" +
                "Values('" + DependentID + "','" + DependentName + "','" + DOB + "','" + Age + "','"+Relationship+"','"+ColonistID+"')";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                View();
            }
        }









        public void update()
        {
            string sql = "Update DEPENDENTS set " + "(DEPENDENT_NAME,DOB,AGE,RELATIONSHIP,COLONIST_ID) = " +
            "('" + DependentName + "','" + DOB + "','" + Age + "','" + Relationship + "','" + ColonistID + "') " +
            "Where DEPENDENT_ID = '" + DependentID + "'";

            if (ExecuteQuery(sql, functiontype.update))
            {
                View();
            }


        }

        public void delete()
        {
            string sql = "Delete From DEPENDENTS Where DEPENDENT_ID = " + DependentID;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }
        }

       public void View()
        {
            string sql = "select*from COLONIST ";
            ShowingDataFromGridView(sql, DataGridView);
        }

    }
}
