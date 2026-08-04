using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{   

    internal class Colonist_Contact_Class : CommonClass
    {
        public int ColonistContactID { get; set; }
        public int ColonistContactNumber { get; set; }
        public int ColonistID { get; set; }
        public DataGridView DataGridView {  get; set; }

        public void insert()
        {
            string sql = "insert into COLONIST_CONTACT(COLONIST_CONTACT_ID,COLONIST_CONTACT_NUMBER,COLONIST_ID) " +
                "values('" + ColonistContactID + "','" + ColonistContactNumber + "','" + ColonistID + "')";

            if (ExecuteQuery(sql, functiontype.insert))
            {
                View();
            }
        }






        public void update()
        { 
            string sql = "update COLONIST_CONTACT set " + "(COLONIST_CONTACT_NUMBER,COLONIST_ID)" +
                "values ('"+ColonistContactNumber+"','"+ColonistID+"') " + "where COLONIST_CONTACT_ID = '"+ColonistContactID+"'";

            if (ExecuteQuery(sql, functiontype.update))
            {
                View();
            
            }             
        }

        public void delete()
        {
            string sql = "Delete From COLONIST_CONTACT where COLONIST_CONTACT_ID =" + ColonistContactID;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }
        }

        public void View()
        {
            string sql = "select * from COLONIST_CONTACT";
            ShowingDataFromGridView(sql, DataGridView);
        }
        
    }
}
