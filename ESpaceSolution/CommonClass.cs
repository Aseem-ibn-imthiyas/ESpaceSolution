using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace E_SPACE
{

    public enum functiontype
    {
        insert,
        update,
        delete
    }

    internal class CommonClass
    {
        public SqlConnection connectionString = new SqlConnection ("Data Source=VICTUS\\SQLEXPRESS;Initial Catalog=ESPACESOLUTION;Integrated Security=True;Encrypt=False");

        public bool ExecuteQuery(string sql, functiontype funct)
        { bool FunctionRunStatus = false;
            string message = "";
            bool FunctionStatus = false;

            try
            {
                if (funct == functiontype.update)
                {
                    if (MessageBox.Show("Want To Update This Data?", "Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        FunctionRunStatus = true;
                        message = "Upadation Succesful";


                    }
                }
                else if (funct == functiontype.delete)
                {
                    if (MessageBox.Show("Want To Delete This Data?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        FunctionRunStatus = true;
                        message = "Deletion Succesful";


                    }
                }
                else if (funct == functiontype.insert)
                {
                    FunctionRunStatus = true;
                    message = "Insertion Succesfully";


                }

                if (FunctionRunStatus)
                {
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand(sql, connectionString);
                    int RowsCount = cmd.ExecuteNonQuery();

                    if (RowsCount > 0)
                    {
                        MessageBox.Show(message);
                        FunctionStatus = true;

                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            finally
            {
                if (connectionString.State == ConnectionState.Open)

                {
                    connectionString.Close();
                }
            }


            return FunctionStatus;
            }
        




        public void ShowingDataFromGridView(string sql, DataGridView DataLoad)
        {


            SqlDataAdapter SDA = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DataLoad.DataSource = dt;
        }

        public bool CheckLogin(string username, string password)
        {
            bool loginStatus = false;

            try
            {
                connectionString.Open();

                string sql = @"SELECT COUNT(*) 
                       FROM LOGIN 
                       WHERE USERNAME = @username 
                       AND PASSWORD = @password";

                SqlCommand cmd = new SqlCommand(sql, connectionString);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    loginStatus = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connectionString.State == ConnectionState.Open)
                {
                    connectionString.Close();
                }
            }

            return loginStatus;
        }



    }

}
