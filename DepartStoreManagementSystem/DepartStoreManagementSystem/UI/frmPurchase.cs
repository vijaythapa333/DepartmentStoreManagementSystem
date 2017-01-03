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
    public partial class frmPurchase : Form
    {
        ProductDAL productDAL = new ProductDAL();
        UserDAL userDAL = new UserDAL();

        //Data TAble for Gridview
        DataTable dtPurchase = new DataTable();

        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            //Add Columns to dataTable dtPurchase
            dtPurchase.Columns.Add("Product_ID");
            dtPurchase.Columns.Add("Product_Name");
            dtPurchase.Columns.Add("Rate");
            dtPurchase.Columns.Add("Quantity");
            dtPurchase.Columns.Add("Discount");
            dtPurchase.Columns.Add("Tax");
            dtPurchase.Columns.Add("Total");
        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {
            //Get Value from Text Box
            string value = textBoxProductID.Text.Trim();

            if(value=="")
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
            decimal sp = (Rate * Qty)-DiscountAmount;
            decimal Tax = decimal.Parse(textBoxTax.Text.Trim());
            decimal TaxAmount = (13 * sp) / 100;
            decimal Total = sp+TaxAmount;

            //Show Grand Total
            decimal grandtotal = decimal.Parse(labelGrandTotal.Text);
            grandtotal = grandtotal + Total;
            //MessageBox.Show(grandtotal + "Check");
            labelGrandTotal.Text = grandtotal.ToString();

            //Add Rows to DAta Table
            dtPurchase.Rows.Add(Product_ID,Product_Name,Rate,Qty,DiscountAmount,TaxAmount,Total);

            //Show dtPurchase to gridview
            dataGridViewPurchase.DataSource = dtPurchase;

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
    }
}
