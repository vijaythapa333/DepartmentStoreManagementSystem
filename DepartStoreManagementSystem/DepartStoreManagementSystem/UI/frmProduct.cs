using DepartStoreManagementSystem.Class;
using DepartStoreManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartStoreManagementSystem.UI
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int ProductID = 0;
            //Get VAlues from UI
            if(textBoxProductID.Text!="")
            {
                ProductID = int.Parse(textBoxProductID.Text.Trim());
            }
            string ProductName = textBoxProductName.Text.Trim();
            string Category = comboBoxCategory.Text.Trim();
            decimal Rate = Convert.ToDecimal(textBoxRate.Text.Trim());
            decimal Quantity = 0;

            //Declare and Assign object for Product Class
            Product P = new Product();
            P.ProductID = ProductID;
            P.ProductName = ProductName;
            P.Category = Category;
            P.Rate = Rate;
            P.Quantity = Quantity;

            //Create Object for Product Dal
            ProductDAL dal = new ProductDAL();

            //Identify the Case for Isnert or Update
            if(P.ProductID==0)
            {
                //Case for Insert
                bool success = dal.Insert_Product(P);
                if(success==true)
                {
                    MessageBox.Show("New Product Successfully Added.");
                    //Refresh
                    DataTable dt = dal.Select_Product();
                    dataGridViewProduct.DataSource = dt;

                    //Clear
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Add New Product.");
                }
            }
            else
            {
                //Case for Update
                bool success = dal.Update_Product(P);
                if (success == true)
                {
                    MessageBox.Show("Product Successfully Updated.");
                    //Refresh
                    DataTable dt = dal.Select_Product();
                    dataGridViewProduct.DataSource = dt;

                    //Clear
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update Product.");
                }
            }
        }
        void clear()
        {
            textBoxProductID.Text = "";
            textBoxProductName.Text = "";
            comboBoxCategory.Text = "";
            textBoxRate.Text = "";
            textBoxQuantity.Text = "";
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            ProductDAL dal = new ProductDAL();
            DataTable dt = dal.Select_Product();
            dataGridViewProduct.DataSource = dt;
        }

        private void dataGridViewProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Current Indes
            int index = e.RowIndex;
            //Get Values From Row Clicked
            string ProductID = dataGridViewProduct.Rows[index].Cells[0].Value.ToString();
            string ProductName = dataGridViewProduct.Rows[index].Cells[1].Value.ToString();
            string Category = dataGridViewProduct.Rows[index].Cells[2].Value.ToString();
            string Rate = dataGridViewProduct.Rows[index].Cells[3].Value.ToString();
            string Quantity = dataGridViewProduct.Rows[index].Cells[4].Value.ToString();

            //Write These Values to the textbox
            textBoxProductID.Text = ProductID;
            textBoxProductName.Text = ProductName;
            comboBoxCategory.Text = Category;
            textBoxRate.Text = Rate;
            textBoxQuantity.Text = Quantity;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Get Product ID
            int Product_ID = int.Parse(textBoxProductID.Text.Trim());
            if(Product_ID!=0 || textBoxProductID.Text != null)
            {
                Product P = new Product();
                P.ProductID = Product_ID;
                //Create Object of ProductDAL
                ProductDAL dal = new ProductDAL();
                bool success = dal.Delete_Product(P);
                if(success==true)
                {
                    MessageBox.Show("Product Successfully Deleted.");
                    //Refresh
                    DataTable dt = dal.Select_Product();
                    dataGridViewProduct.DataSource = dt;
                    //Clear
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Delete Product. Try Again.");
                }
            }
            else
            {
                MessageBox.Show("Please Select the Product FIrst.");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get User Input
            string keywords = textBoxSearch.Text;
            if(keywords!=null)
            {
                ProductDAL dal = new ProductDAL();
                DataTable dt = dal.Select_Produc_By_Keywordst(keywords);
                dataGridViewProduct.DataSource = dt;
            }
            else
            {
                ProductDAL dal = new ProductDAL();
                DataTable dt = dal.Select_Product();
                dataGridViewProduct.DataSource = dt;
            }
            
        }
    }
}
