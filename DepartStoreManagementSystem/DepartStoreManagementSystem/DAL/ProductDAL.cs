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
    class ProductDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        //SELECT,INSERT, UPDATE and DELETE 

        //SELECT PRODUCT HERE
        public DataTable Select_Product()
        {
            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);
            //Create Datatable to hold the records from the database
            DataTable dt = new DataTable();
            try
            {
                //Step 2; Writing SQL Query
                string sql = "SELECT * FROM tbl_Product";
                //Step 3: Create Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Step 4: Create SQL DAta Adapter Using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Step 5: Open Connection
                conn.Open();
                //Step 6: Use Adapter to Fill dt
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //STep 7:Close Connection
                conn.Close();
            }
            return dt;
        }

        //SElect Specific Product
        public Product Select_Product(int productID)
        {
            Product prod = new Product();
            //Step 1: Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Step 2: Create DataTAble to hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //STep 3: Writing SQL Query
                string sql = "SELECT Product_ID,Product_Name,Category,Rate FROM tbl_Product WHERE Product_ID=@Product_ID";

                //Step 4: Create Sql Command Using Sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Product_ID",productID);

                //Step 5: Create sql data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 6: Open Connection
                conn.Open();

                //Step 7: Use Adapter to fill dt
                adapter.Fill(dt);

                //Check if dataTable has records
                if(dt.Rows.Count>0)
                {
                    prod.ProductID = int.Parse(dt.Rows[0]["Product_ID"].ToString());
                    prod.ProductName = dt.Rows[0]["Product_Name"].ToString();
                    prod.Category = dt.Rows[0]["Category"].ToString();
                    prod.Rate = decimal.Parse(dt.Rows[0]["Rate"].ToString());
                }
            }
            catch ( Exception ex)
            {

            }
            finally
            {
                //Step 7: CLose Connection
                conn.Close();
            }
            return prod;
        }
        //Insert Product
        public bool Insert_Product(Product p)
        {
            //Create a return value and set its default value to false
            bool isSuccess = false;

            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Write SQL Query
                string sql = "INSERT INTO tbl_Product (Product_Name,Category,Rate,Quantity) VALUES (@ProductName,@Category,@Rate,@Quantity)";

                //Step 3: Create SQL Command Using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pass value to parameters using cmd
                cmd.Parameters.AddWithValue("@ProductName", p.ProductName);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Rate", p.Rate);
                cmd.Parameters.AddWithValue("@Quantity", p.Quantity);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();

                //If the Data is inserted the the rows value will be more than 1
                //In this case the bool value of isSuccess will be true
                //Else the bool value will be false
                if(rows>0)
                {
                    isSuccess=true;
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
                //Step 7: CLose Connection
                conn.Close();
            }
            return isSuccess;
        }
        //Update Product Here
        public bool Update_Product(Product p)
        {
            //Declare return value and set its default value false
            bool isSuccess = false;

            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STep 2: Write SQL to Update
                string sql = "UPDATE tbl_Product SET Product_Name=@ProductName,Category=@Category,Rate=@Rate,Quantity=@Quantity WHERE Product_ID=@ProductID";

                //Step 3: Create Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pass value to parameters via cmd
                cmd.Parameters.AddWithValue("@ProductName", p.ProductName);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Rate", p.Rate);
                cmd.Parameters.AddWithValue("@Quantity", p.Quantity);
                cmd.Parameters.AddWithValue("@ProductID", p.ProductID);

                //STep 5: open Connection
                conn.Open();

                //STep 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();
                //if the query is executed then the value of rows will be greater than 0 and the bool value will be true
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
                //Step 7: CLose Connection
                conn.Close();
            }
            return isSuccess;
        }
        //Delete Product
        public bool Delete_Product(Product p)
        {
            //Declare the return value and set its default value to false
            bool isSuccess = false;
            //Step 1: Create SqlConnection
            SqlConnection conn = new SqlConnection(myconnstr);
            try
            {
                //Step 2: Write Sql Query
                string sql = "DELETE FROM tbl_Product WHERE Product_ID=@ProductID";
                //STep 3: Create Sql Command Using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Step 4: Pass value to parameters via cmd
                cmd.Parameters.AddWithValue("@ProductID",p.ProductID);
                //Step 5: Open Connection
                conn.Open();
                //Step 6: Execute cmd
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
                //Step 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }

        //Get Total Product Types
        public decimal Get_Products()
        {
            //STep 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create an Integer to return Stock
            decimal Stock = 0;
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Write T SQL Here
                string sql = "SELECT Product_ID,Quantity FROM tbl_Product";

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
        #region Get Products By Keywords
        public DataTable Select_Produc_By_Keywordst(string keyword)
        {
            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);
            //Create Datatable to hold the records from the database
            DataTable dt = new DataTable();
            try
            {
                //Step 2; Writing SQL Query
                string sql = "SELECT * FROM tbl_Product WHERE Product_ID LIKE '%"+keyword+"%' OR Product_Name Like '%"+keyword+"%'";
                //Step 3: Create Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Step 4: Create SQL DAta Adapter Using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Step 5: Open Connection
                conn.Open();
                //Step 6: Use Adapter to Fill dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //STep 7:Close Connection
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
