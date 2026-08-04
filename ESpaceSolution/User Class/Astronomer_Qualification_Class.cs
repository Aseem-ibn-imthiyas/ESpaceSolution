using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_SPACE.User_Class
{
    internal class Astronomer_Qualification_Class : CommonClass
    {
        public int AstronomerQualificationID { get; set; }
        public string AstronomerQualification { get; set; }
        public int AstronomerID { get; set; }
        public DataGridView DataGridView { get; set; }

        public void insert()
        {
            string sql = "insert into ASTRONOMER_QUALIFICATION (ASTRONOMER_QUALIFICATION_ID,QUALIFICATION_NAME,ASTRONOMER_ID)" +
                "values ('" + AstronomerQualificationID + "','" + AstronomerQualification + "','" + AstronomerID + "',)";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                View();
            }
        }











        public void update()

        {

            string sql = "Update ASTRONOMER_QUALIFICATION set " + "(QUALIFICATION_NAME,ASTRONOMER_ID)" +
                "values('" + AstronomerQualification + "','" + AstronomerID + "',)" + "where ASTRONOMER_QUALIFICATION_ID = '" + AstronomerQualificationID + "'";

            if (ExecuteQuery(sql, functiontype.update))
            {
                View();
            }
        }

        public void delete()
        { 
            string sql = "delete from ASTRONOMER_QUALIFICATION where ASTRONOMER_QUALIFICATIONS_ID = " + AstronomerQualificationID;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }


        }

        public void View ()
        {
            string sql = "select * from ASTRONOMER_QUALIFICATION";
            ShowingDataFromGridView(sql, DataGridView);


        }
        
    }
}
