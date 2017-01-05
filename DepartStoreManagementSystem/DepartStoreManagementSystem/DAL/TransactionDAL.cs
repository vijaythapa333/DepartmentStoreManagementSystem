using DepartStoreManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartStoreManagementSystem.DAL
{
    class TransactionDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public bool Insert_Transaction(TransactionClass transaction,out int transactionID)
        {
            //Out -->-1
            transactionID = -1;
            //define the return value and set its default value to false
            bool isSuccess = false;

            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);
            try
            {
                //Step 2: Write SQL Query
                string sql = "INSERT INTO tbl_Transaction (TransactionType,SysUser,GrandTotal,TransactionDate) VALUES (@TransactionType,@SysUser,@GrandTotal,@TransactionDate); SELECT @@IDENTITY;";

                //Step 3: Craete SQL Command sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@TransactionType", transaction.TransactionType);
                cmd.Parameters.AddWithValue("@SysUser", transaction.SysUser);
                cmd.Parameters.AddWithValue("@GrandTotal", transaction.GrandTotal);
                cmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactioDate);
                //Step 4: Connection Open
                conn.Open();
                //Step 5: Execute Command
                object o = cmd.ExecuteScalar();//Error Here
                //if inserted rows is greater than zero,
                //in this case, set success to true
                //otherwise, set success to false
                if(o!=null)
                {
                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        public bool Insert_TransactionDetails(TransactionDetails transactionDetails)
        {
            //define the return value and set its default value to false
            bool isSuccess = false;

            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Write SQL
                string sql = "INSERT INTO tbl_TransactionDetails (ProductID,Tax,Discount,Rate,Quantity,Total) VALUES (@ProductID,@Tax,@Discount,@Rate,@Quantity,@Total)";
                //Step 3: Create SAL command using conn and sql
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pass value to Parameters via cmd
                cmd.Parameters.AddWithValue("@ProductID", transactionDetails.ProductID);
                cmd.Parameters.AddWithValue("@Tax", transactionDetails.Tax);
                cmd.Parameters.AddWithValue("@Discount", transactionDetails.Discount);
                cmd.Parameters.AddWithValue("@Rate", transactionDetails.Rate);
                cmd.Parameters.AddWithValue("@Quantity", transactionDetails.Quantity);
                cmd.Parameters.AddWithValue("@Total", transactionDetails.Total);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute Command
                int rows=cmd.ExecuteNonQuery();
                //If the data is inserted then the rows value will be more than 1 and the bool is Success will be true
                //Else the rows will be less than 1 and isSuccess will be false
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
