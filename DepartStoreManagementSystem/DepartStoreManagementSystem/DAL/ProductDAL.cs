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
                string sql = "INSERT INTO tbl_Product (ProductName,Category,Rate,Quantity) VALUES (@ProductName,@Category,@Rate,@Quantity)";

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
                string sql = "UPDATE tbl_Product SET ProductName=@ProductName,Category=@Category,Rate=@Rate,Quantity=@Quantity WHERE ProductID=@ProductID";

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
                string sql = "DELETE FROM tbl_Product WHERE ProductID=@ProductID";
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
    }
}
