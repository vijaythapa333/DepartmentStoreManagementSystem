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
        #region SElect User by Keywords
        public DataTable Select_User_By_Keywords(string keywords)
        {
            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);
            //Create DataTable to hold the records from database
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Writing SQL
                String sql = "SELECT UserID,FullName,Username,Email,Contact,Password,UserType FROM tbl_User WHERE UserID Like '%"+keywords+"%' OR FullName Like '%"+keywords+"%' OR Username Like '%"+keywords+"%'";

                //Step 3: Create SqlCommand Using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Create Sql Data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Use adapter to fill dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return dt;
        }
        #endregion

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

        //Login User
        public bool Login(string username,string password, string usertype)
        {
            //Step 1: Define boolean variable for login successfull and set initial value to false
            bool isLogin = false;

            //Step 2: Create Connection String
            String connectionstring = myconnstr;

            //Step 3: Create SQL Connection
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                //STep 4: Writing T-SQL for login
                String sql = "SELECT * FROM tbl_USER WHERE Username=@Username AND Password=@Password AND UserType=@UserType";

                //Step 5: Creating Sql Command using sql and command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 5.1 Add Values to Parameters
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserType", usertype);

                //Step 6: Create Sql Data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 7: Create a datatable to hold the records from database
                DataTable dt = new DataTable();

                //Step 8: Open COnnection
                conn.Open();

                //Step 9: Use Adapter to fill dt
                adapter.Fill(dt);

                //..................................................................................
                //Step 10: use dt to find if log in is successful/failed
                if (dt.Rows.Count > 0)
                {
                    //Login SUccessful
                    isLogin = true;
                }
                else
                {
                    //Login Failed
                    isLogin = false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                //Step 11: Close Connection
                conn.Close();
            }
            return isLogin;
        }
        #region get total users
        public decimal Get_Users()
        {
            //STep 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create an Integer to return Stock
            decimal Stock = 0;
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Write T SQL Here
                string sql = "SELECT userID FROM tbl_User";

                //Step 3: Create SQL Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@Product_ID", ProductID);

                //Step 4: Create SQL Data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5: open Connection
                conn.Open();

                //Step 6: Use adapter to fill dt
                adapter.Fill(dt);
                //Get Quanityt from datatable dt
                if (dt.Rows.Count > 0)
                {
                    Stock = dt.Rows.Count;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return Stock;
        }
        #endregion
        #region get users full name
        public string Get_Users_FullName(string username)
        {
            //STep 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create an Integer to return Stock
            //decimal Stock = 0;
            string FullName = username;//Problem on getting fullname
            DataTable dtUser = new DataTable();

            try
            {
                //Step 2: Write T SQL Here
                string sql = "SELECT FullName FROM tbl_User WHERE Username="+username;

                //Step 3: Create SQL Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@Product_ID", ProductID);

                //Step 4: Create SQL Data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5: open Connection
                conn.Open();

                //Step 6: Use adapter to fill dt
                adapter.Fill(dtUser);
                //Get Quanityt from datatable dt
                if (dtUser.Rows.Count > 0)
                {
                    FullName = dtUser.Rows[0]["FullName"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            
            return FullName;
        }
        #endregion
    }
}
