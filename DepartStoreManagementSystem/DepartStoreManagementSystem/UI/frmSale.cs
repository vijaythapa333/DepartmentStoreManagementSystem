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
using System.Transactions;
using System.Windows.Forms;

namespace DepartStoreManagementSystem.UI
{
    public partial class frmSale : Form
    {
        ProductDAL productDAL = new ProductDAL();
        UserDAL userDAL = new UserDAL();
        TransactionDAL transactionDAL = new TransactionDAL();
        InventoryDAL invDAL = new InventoryDAL();

        //Data TAble for Gridview
        DataTable dtTransaction = new DataTable();
        public frmSale()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            //Add Columns to dataTable dtPurchase
            dtTransaction.Columns.Add("Product_ID");
            dtTransaction.Columns.Add("Product_Name");
            dtTransaction.Columns.Add("Rate");
            dtTransaction.Columns.Add("Quantity");
            dtTransaction.Columns.Add("Discount");
            dtTransaction.Columns.Add("Tax");
            dtTransaction.Columns.Add("Total");
        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {
            //Get Value from Text Box
            string value = textBoxProductID.Text.Trim();

            if (value == "")
            {
                labelProductName.Text = "";
                textBoxRate.Text = "";
                return;
            }

            Product p = productDAL.Select_Product(int.Parse(value));
            labelProductName.Text = p.ProductName;
            textBoxRate.Text = p.Rate.ToString();
        }

        private void buttonAddnew_Click(object sender, EventArgs e)
        {
            //Get VAlues from UI
            int Product_ID = int.Parse(textBoxProductID.Text.Trim());
            string Product_Name = labelProductName.Text.Trim();
            decimal Rate = decimal.Parse(textBoxRate.Text.Trim());
            decimal Qty = decimal.Parse(textBoxQuantity.Text.Trim());
            decimal Discount = decimal.Parse(textBoxDiscount.Text.Trim());
            decimal DiscountAmount = (Rate * Qty * 20) / 100;
            decimal sp = (Rate * Qty) - DiscountAmount;
            decimal Tax = decimal.Parse(textBoxTax.Text.Trim());
            decimal TaxAmount = (13 * sp) / 100;
            decimal Total = sp + TaxAmount;

            //Show Grand Total
            decimal grandtotal = decimal.Parse(labelGrandTotal.Text);
            grandtotal = grandtotal + Total;
            //MessageBox.Show(grandtotal + "Check");
            labelGrandTotal.Text = grandtotal.ToString();

            //Add Rows to DAta Table
            dtTransaction.Rows.Add(Product_ID, Product_Name, Rate, Qty, DiscountAmount, TaxAmount, Total);

            //Show dtPurchase to gridview
            dataGridViewSale.DataSource = dtTransaction;

            //Clear for Next Add
            clear();
        }
        void clear()
        {
            textBoxProductID.Text = "";
            labelProductName.Text = "";
            textBoxRate.Text = "";
            textBoxQuantity.Text = "";
            textBoxTotal.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("I am Clicked");
            TransactionClass transaction = new TransactionClass();
            transaction.TransactionType = labelSale.Text.Trim();
            transaction.TransactioDate = DateTime.Now;
            transaction.SysUser = "Admin";
            transaction.GrandTotal = decimal.Parse(labelGrandTotal.Text);
            transaction.TransactionDetails = dtTransaction;

            bool success = false;
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                bool w = transactionDAL.Insert_Transaction(transaction, out transactionID);//Error in this section

                for (int i = 0; i < dtTransaction.Rows.Count; i++)
                {
                    int ProductID = int.Parse(dtTransaction.Rows[i][0].ToString());
                    //string ProductName = dtTransaction.Rows[i][1].ToString();
                    decimal Rate = decimal.Parse(dtTransaction.Rows[i][2].ToString());
                    decimal Quantity = decimal.Parse(dtTransaction.Rows[i][3].ToString());
                    decimal Discount = decimal.Parse(dtTransaction.Rows[i][4].ToString());
                    decimal Tax = decimal.Parse(dtTransaction.Rows[i][5].ToString());
                    decimal Total = decimal.Parse(dtTransaction.Rows[i][6].ToString());

                    TransactionDetails td = new TransactionDetails();
                    td.ProductID = ProductID;
                    td.Rate = Rate;
                    td.Quantity = Quantity;
                    td.Discount = Discount;
                    td.Tax = Tax;
                    td.Total = Total;
                    bool x = invDAL.Decrease_Inventory(ProductID, Quantity); //For Decreasing Product Quantity
                    bool y = transactionDAL.Insert_TransactionDetails(td);
                    success = w && x && y; // DO this after solving error
                                      //success = y; //Comment this after solving error

                }
                if (success == true)
                {
                    scope.Complete();
                    MessageBox.Show("Sale Transaction Completed.");
                }
                else
                {
                    MessageBox.Show("Sale Transaction Failed.");
                }
            }
            //Print Function Here
            //MessageBox.Show("Print Me");
        }

        private void dataGridViewSale_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            int ProductId = int.Parse(dataGridViewSale.Rows[rowIndex].Cells[0].Value.ToString());
            string ProductName = dataGridViewSale.Rows[rowIndex].Cells[1].Value.ToString();
            decimal Rate = decimal.Parse(dataGridViewSale.Rows[rowIndex].Cells[2].Value.ToString());
            decimal Quantity = decimal.Parse(dataGridViewSale.Rows[rowIndex].Cells[3].Value.ToString());
            decimal Discount = decimal.Parse(dataGridViewSale.Rows[rowIndex].Cells[4].Value.ToString());
            decimal Tax = decimal.Parse(dataGridViewSale.Rows[rowIndex].Cells[5].Value.ToString());
            decimal Total = decimal.Parse(dataGridViewSale.Rows[rowIndex].Cells[6].Value.ToString());

            //Showing to UI
            textBoxProductID.Text = ProductId.ToString();
            labelProductName.Text = ProductName;
            textBoxRate.Text = Rate.ToString();
            textBoxQuantity.Text = Quantity.ToString();
            textBoxTotal.Text = Total.ToString();

            //Decrease from Grand Total
            decimal GrandTotal = decimal.Parse(labelGrandTotal.Text);
            GrandTotal = GrandTotal - Total;
            labelGrandTotal.Text = GrandTotal.ToString();
            //Remove from Data Gridview
            dtTransaction.Rows.RemoveAt(rowIndex);
            //Gridview Bind
            dataGridViewSale.DataSource = dtTransaction;
        }

        Bitmap bmp;
        private void printDocumentSale_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialogSale.ShowDialog();
        }
    }
}
