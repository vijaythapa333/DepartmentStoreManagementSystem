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
    class InventoryDAL
    {
        //Create Static Connection String
        static string myconnsctr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public decimal Get_Inventory(int ProductID)
        {
            //STep 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnsctr);

            //Create an Integer to return Stock
            decimal Stock = 0;
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Write T SQL Here
                string sql = "SELECT Product_ID,Quantity FROM tbl_Product WHERE Product_ID="+ProductID;

                //Step 3: Create SQL Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);
                //cmd.Parameters.AddWithValue("@Product_ID", ProductID);

                //Step 4: Create SQL Data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5: open Connection
                conn.Open();

                //Step 6: Use adapter to fill dt
                adapter.Fill(dt);
                //Get Quanityt from datatable dt
                if(dt.Rows.Count>0)
                {
                    Stock = decimal.Parse(dt.Rows[0]["Quantity"].ToString());
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
            return Stock;
        }

        public bool Increase_Inventory(int ProductID,decimal Increasestock)
        {
            //set return value and set its default value to false
            bool success = false;
            try
            {
                //Get Current Inventory of the Product
               decimal currentStock = Get_Inventory(ProductID);

                //Increase Current Inventory
                decimal newStock = currentStock + Increasestock;

                //define and Initialize inventory object
                Inventory inv = new Inventory();
                inv.ProductID = ProductID;
                inv.Quantity = newStock;

                //Update the inventory table and return true/false
                success = Update_Inventory(inv);
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            return success;
        }

        public bool Decrease_Inventory(int ProductID,decimal decreaseStock)
        {
            bool success = false;
            #region First MEthod
            try
            {
                //Get Current Inventory of the product
                decimal currentStock = Get_Inventory(ProductID);

                //Decrease Current Inventory
                decimal newStock = currentStock - decreaseStock;

                //Define and Initialize Inventory Object
                Inventory inv = new Inventory();
                inv.ProductID = ProductID;
                inv.Quantity = newStock;

                //Update the inventory and return the true or false
                success = Update_Inventory(inv);
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            #endregion
            return success;
        }

        public bool Update_Inventory(Inventory inv)
        {
            //define the return value and set its default value to false
            bool isSuccess = false;

            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnsctr);
            try
            {
                //Step 2: Writing T-SQL Here
                string sql = "UPDATE tbl_Product SET Quantity=@Quantity WHERE Product_ID=@Product_ID";

                //Step 3: Create SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: pass value to parameters via cmd
                cmd.Parameters.AddWithValue("@Product_ID", inv.ProductID);
                cmd.Parameters.AddWithValue("@Quantity", inv.Quantity);

                //Step 5: open Connection
                conn.Open();

                //Step 6: Execute Command cmd
                int rows = cmd.ExecuteNonQuery();
                //if the value of the rows is  greater than 1 the the bool value of isSuccess is true
                //Else the bool value is false
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
