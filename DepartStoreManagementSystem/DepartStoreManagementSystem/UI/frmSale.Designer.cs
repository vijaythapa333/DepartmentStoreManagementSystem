namespace DepartStoreManagementSystem.UI
{
    partial class frmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.buttonAddnew = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQty = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.printDocumentSale = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogSale = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(507, 375);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(40, 20);
            this.labelGrandTotal.TabIndex = 64;
            this.labelGrandTotal.Text = "0.00";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(384, 375);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(104, 20);
            this.labelname.TabIndex = 63;
            this.labelname.Text = "Grand Total";
            // 
            // buttonAddnew
            // 
            this.buttonAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddnew.Location = new System.Drawing.Point(388, 55);
            this.buttonAddnew.Name = "buttonAddnew";
            this.buttonAddnew.Size = new System.Drawing.Size(75, 33);
            this.buttonAddnew.TabIndex = 62;
            this.buttonAddnew.Text = "Add New";
            this.buttonAddnew.UseVisualStyleBackColor = true;
            this.buttonAddnew.Click += new System.EventHandler(this.buttonAddnew_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(116, 333);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(209, 22);
            this.textBoxTotal.TabIndex = 61;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(113, 134);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(108, 16);
            this.labelProductName.TabIndex = 60;
            this.labelProductName.Text = "[ Product Name ]";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Firebrick;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(347, 413);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(209, 44);
            this.buttonPrint.TabIndex = 58;
            this.buttonPrint.Text = "PRINT";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(116, 413);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(209, 44);
            this.buttonSave.TabIndex = 57;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(16, 336);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(39, 16);
            this.labelTotal.TabIndex = 56;
            this.labelTotal.Text = "Total";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTax.Location = new System.Drawing.Point(116, 288);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(209, 22);
            this.textBoxTax.TabIndex = 55;
            this.textBoxTax.Text = "13";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(16, 327);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(31, 16);
            this.labelTax.TabIndex = 54;
            this.labelTax.Text = "Tax";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(116, 241);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(209, 22);
            this.textBoxDiscount.TabIndex = 53;
            this.textBoxDiscount.Text = "20";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(16, 247);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(60, 16);
            this.labelDiscount.TabIndex = 52;
            this.labelDiscount.Text = "Discount";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(116, 205);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(209, 22);
            this.textBoxQuantity.TabIndex = 51;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(16, 205);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(56, 16);
            this.labelQty.TabIndex = 50;
            this.labelQty.Text = "Quantity";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRate.Location = new System.Drawing.Point(116, 166);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(209, 22);
            this.textBoxRate.TabIndex = 49;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.Location = new System.Drawing.Point(16, 205);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(37, 16);
            this.labelRate.TabIndex = 48;
            this.labelRate.Text = "Rate";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductID.Location = new System.Drawing.Point(116, 94);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(209, 22);
            this.textBoxProductID.TabIndex = 47;
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBoxProductID_TextChanged);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(16, 94);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(70, 16);
            this.labelProductID.TabIndex = 46;
            this.labelProductID.Text = "Product ID";
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSale.Location = new System.Drawing.Point(383, 13);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(55, 25);
            this.labelSale.TabIndex = 43;
            this.labelSale.Text = "Sale";
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.Location = new System.Drawing.Point(388, 94);
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.Size = new System.Drawing.Size(529, 261);
            this.dataGridViewSale.TabIndex = 42;
            this.dataGridViewSale.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSale_RowHeaderMouseDoubleClick);
            // 
            // printDocumentSale
            // 
            this.printDocumentSale.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSale_PrintPage);
            // 
            // printPreviewDialogSale
            // 
            this.printPreviewDialogSale.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSale.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSale.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogSale.Document = this.printDocumentSale;
            this.printPreviewDialogSale.Enabled = true;
            this.printPreviewDialogSale.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogSale.Icon")));
            this.printPreviewDialogSale.Name = "printPreviewDialogSale";
            this.printPreviewDialogSale.Visible = false;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 474);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.buttonAddnew);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelSale);
            this.Controls.Add(this.dataGridViewSale);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonAddnew;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.DataGridView dataGridViewSale;
        private System.Drawing.Printing.PrintDocument printDocumentSale;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSale;
    }
}