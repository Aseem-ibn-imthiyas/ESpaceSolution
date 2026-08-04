using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{
    internal class Astronomer_Class : CommonClass
    {
        public int AstronomerID { get; set; }

        public string AstronomerName { get; set; }

        public string Designation { get; set; }

        public int Experience { get; set; }

        public int Jet_Code { get; set; }

        public DataGridView DataGridView { get; set; }




        public void insert()
        {
            string sql = "insert into ASTRONOMER (ASTRONOMER_ID,ASTRONOMER_NAME,DESIGNATION,EXPERIENCE,JET_CODE)" +
                "Values('" + AstronomerID + ",'" + AstronomerName + "','" + Designation + "','" + Experience + "','" + Jet_Code + "',)";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                View();
            }
        }


        public void update()
        {
            string sql = "Update ASTRONOMER set " + "( ASTRONOMER_NAME, DESIGNATION, EXPERIENCE,JET_CODE) = " +
            "('" + AstronomerName + "', '" + Designation + "', '" + Experience + "','"+ Jet_Code + "') " +
            "Where ASTRONOMER_ID = '" + AstronomerID + "'";

            if (ExecuteQuery(sql, functiontype.update))
            {
                View();
            }


        }


        public void delete()
        {
            string sql = "Delete From ASTRONOMER Where ASTRONOMER_ID = " + AstronomerID;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }
        }


        public void View()
        {
            string sql = "select*from ASTRONOMER ";
            ShowingDataFromGridView(sql, DataGridView);
        }


    }
}
