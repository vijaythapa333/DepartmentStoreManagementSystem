namespace DepartStoreManagementSystem.UI
{
    partial class frmPurchase
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
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.textBoxVendorID = new System.Windows.Forms.TextBox();
            this.labelVendorID = new System.Windows.Forms.Label();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonAddnew = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(346, 409);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(209, 44);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(115, 409);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(209, 44);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(15, 365);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(39, 16);
            this.labelTotal.TabIndex = 32;
            this.labelTotal.Text = "Total";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTax.Location = new System.Drawing.Point(115, 320);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(209, 22);
            this.textBoxTax.TabIndex = 31;
            this.textBoxTax.Text = "13";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(15, 320);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(31, 16);
            this.labelTax.TabIndex = 30;
            this.labelTax.Text = "Tax";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(115, 273);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(209, 22);
            this.textBoxDiscount.TabIndex = 29;
            this.textBoxDiscount.Text = "20";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(15, 279);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(60, 16);
            this.labelDiscount.TabIndex = 28;
            this.labelDiscount.Text = "Discount";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(115, 237);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(209, 22);
            this.textBoxQuantity.TabIndex = 27;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(15, 237);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(56, 16);
            this.labelQty.TabIndex = 26;
            this.labelQty.Text = "Quantity";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRate.Location = new System.Drawing.Point(115, 198);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(209, 22);
            this.textBoxRate.TabIndex = 25;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.Location = new System.Drawing.Point(15, 198);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(37, 16);
            this.labelRate.TabIndex = 24;
            this.labelRate.Text = "Rate";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductID.Location = new System.Drawing.Point(115, 126);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(209, 22);
            this.textBoxProductID.TabIndex = 23;
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBoxProductID_TextChanged);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(15, 126);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(70, 16);
            this.labelProductID.TabIndex = 22;
            this.labelProductID.Text = "Product ID";
            // 
            // textBoxVendorID
            // 
            this.textBoxVendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVendorID.Location = new System.Drawing.Point(115, 51);
            this.textBoxVendorID.Name = "textBoxVendorID";
            this.textBoxVendorID.Size = new System.Drawing.Size(209, 22);
            this.textBoxVendorID.TabIndex = 21;
            // 
            // labelVendorID
            // 
            this.labelVendorID.AutoSize = true;
            this.labelVendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendorID.Location = new System.Drawing.Point(15, 51);
            this.labelVendorID.Name = "labelVendorID";
            this.labelVendorID.Size = new System.Drawing.Size(68, 16);
            this.labelVendorID.TabIndex = 20;
            this.labelVendorID.Text = "Vendor ID";
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchase.Location = new System.Drawing.Point(382, 9);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(103, 25);
            this.labelPurchase.TabIndex = 19;
            this.labelPurchase.Text = "Purchase";
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(387, 90);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.Size = new System.Drawing.Size(529, 272);
            this.dataGridViewPurchase.TabIndex = 18;
            // 
            // labelVendorName
            // 
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendorName.Location = new System.Drawing.Point(112, 90);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(106, 16);
            this.labelVendorName.TabIndex = 36;
            this.labelVendorName.Text = "[ Vendor Name ]";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(112, 166);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(108, 16);
            this.labelProductName.TabIndex = 37;
            this.labelProductName.Text = "[ Product Name ]";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(115, 365);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(209, 22);
            this.textBoxTotal.TabIndex = 38;
            // 
            // buttonAddnew
            // 
            this.buttonAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddnew.Location = new System.Drawing.Point(387, 51);
            this.buttonAddnew.Name = "buttonAddnew";
            this.buttonAddnew.Size = new System.Drawing.Size(75, 33);
            this.buttonAddnew.TabIndex = 39;
            this.buttonAddnew.Text = "Add New";
            this.buttonAddnew.UseVisualStyleBackColor = true;
            this.buttonAddnew.Click += new System.EventHandler(this.buttonAddnew_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(383, 371);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(104, 20);
            this.labelname.TabIndex = 40;
            this.labelname.Text = "Grand Total";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(506, 371);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(40, 20);
            this.labelGrandTotal.TabIndex = 41;
            this.labelGrandTotal.Text = "0.00";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 467);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.buttonAddnew);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelVendorName);
            this.Controls.Add(this.buttonDelete);
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
            this.Controls.Add(this.textBoxVendorID);
            this.Controls.Add(this.labelVendorID);
            this.Controls.Add(this.labelPurchase);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Name = "frmPurchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
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
        private System.Windows.Forms.TextBox textBoxVendorID;
        private System.Windows.Forms.Label labelVendorID;
        private System.Windows.Forms.Label labelPurchase;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonAddnew;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelGrandTotal;
    }
}