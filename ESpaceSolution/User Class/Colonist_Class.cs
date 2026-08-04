using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_SPACE.User_Class
{
    internal class Colonist_Class : CommonClass
    {
        public int ColonistId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string HomeAddress { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string FamilyMembers { get; set; }
        public int Colony_Lot_Number { get; set; }
        public int TripId { get; set; }
        public DataGridView dataGridView {  get; set; }


        public void insert() 
        {
            string sql = "Insert Into COLONIST (COLONIST_ID,FIRST_NAME,MIDDLE_NAME,SURNAME,DOB,AGE,HOME_ADDRESS,GENDER,CIVIL_STATUS,NUMBER_FAMILY_MEMBERS,COLONY_LOT_NUMBER,TRIP_ID)" +
                "Values('" + ColonistId + "','" + FirstName + "','" + MiddleName + "','" + Surname + "','" + DOB + "','" + Age + "','" + HomeAddress + "','" + Gender + "','" + CivilStatus 
                + "','" + FamilyMembers + "','" + Colony_Lot_Number + "','" + TripId + "')";

            if (ExecuteQuery(sql,functiontype.insert)) 
            {
                View();
            }
        }

        public void update()
        {
            string sql = "UPDATE colonist SET " +
             "first_name = '" + FirstName + "', " +
             "middle_name = '" + MiddleName + "', " +
             "surname = '" + Surname + "', " +
             "dob = '" + DOB + "', " +
             "age = '" + Age + "', " +
             "home_address = '" + HomeAddress + "', " +
             "gender = '" + Gender + "', " +
             "civil_status = '" + CivilStatus + "', " +
             "number_family_members = '" + FamilyMembers + "', " +
             "colony_lot_number = '" + Colony_Lot_Number + "', " +
             "trip_id = '" + TripId + "' " +
             "WHERE colonist_id = '" + ColonistId + "'";


            if (ExecuteQuery(sql, functiontype.update))
            {
                View();
            }


        }
        

        public void delete()
        {
            string sql = "Delete From COLONIST Where COLONIST_ID = " + ColonistId;

            if (ExecuteQuery(sql, functiontype.delete))
            {
                View();
            }
        }


        public void View()
        {
            string sql = "select*from COLONIST ";
            ShowingDataFromGridView(sql, dataGridView);
        }
    }


}
