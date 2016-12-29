using DepartStoreManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartStoreManagementSystem.DAL
{
    class UserDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        //SELECT, INSERT, UPDATE AND DELETE OPERATIONS

        //SELECT HERE
        public DataTable Select_User()
        {
            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);
            //Create DataTable to hold the records from database
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Writing SQL
                String sql = "SELECT UserID,FullName,Username,Email,Contact,UserType FROM tbl_User";

                //Step 3: Create SqlCommand Using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Create Sql Data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Use adapter to fill dt
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return dt;
        }

        //Insert Data
        public bool Insert_User(User u)
        {
            //define the return value and set it false by default
            bool isSuccess = false;

            return isSuccess;
        }
    }
}
