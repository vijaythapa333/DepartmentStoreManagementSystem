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
                String sql = "SELECT UserID,FullName,Username,Email,Contact,Password,UserType FROM tbl_User";

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

            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Write SQL Query
                String sql = "INSERT INTO tbl_User (FullName,Username,Email,Contact,Password,UserType) VALUES (@FullName,@Username,@Email,@Contact,@Password,@UserType)";

                //Step 3: Create Sql Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //STep 4: Pass value to Parameters via cmd
                cmd.Parameters.AddWithValue("@FullName", u.FullName);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Contact", u.Contact);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@UserType", u.UserType);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();

                //If Data is inserted then the row is greater than 0 
                // and the bool value o isSucess becomes true
                //else the value is false
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }
        //Update User Here
        public bool Update_User(User u)
        {
            //declare the return value and set its default value to false
            bool isSuccess = false;

            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                // Step 2: Write SQL Query
                String sql = "UPDATE tbl_User SET FullName=@FullName,Username=@Username,Email=@Email,Contact=@Contact,Password=@Password,UserType=@UserType WHERE UserID=@UserID";

                //Step 3: Create SQL Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pass value to Parameters via cmd
                cmd.Parameters.AddWithValue("@UserID", u.UserID);
                cmd.Parameters.AddWithValue("@FullName",u.FullName);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Contact", u.Contact);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@UserType", u.UserType);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: execute cmd
                int rows = cmd.ExecuteNonQuery();

                //If the data is inserted then the values will be greater than 0 and the bool value will be true
                //else the bool value will be false
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }
        //DELETE Here
        public bool Delete_User(User u)
        {
            //Declare the return value and set its default value to false
            bool isSuccess = false;

            //Step 1: Create SQL Connection Here
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Write SQL Query Here
                string sql = "DELETE FROM tbl_User WHERE UserID=@UserID";

                //Step 3: Create Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Step 4: Pass value to parametes via cmd
                cmd.Parameters.AddWithValue("@UserID", u.UserID);

                //Step 5:Open Connection
                conn.Open();

                //STep 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
