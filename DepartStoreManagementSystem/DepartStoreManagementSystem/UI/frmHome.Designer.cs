namespace DepartStoreManagementSystem.UI
{
    partial class frmHome
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
            this.panelProduct = new System.Windows.Forms.Panel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCountProduct = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCountUser = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProduct.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.panelProduct.Controls.Add(this.labelProductName);
            this.panelProduct.Controls.Add(this.labelCountProduct);
            this.panelProduct.Location = new System.Drawing.Point(683, 258);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(255, 55);
            this.panelProduct.TabIndex = 8;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductName.Location = new System.Drawing.Point(3, 13);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(178, 24);
            this.labelProductName.TabIndex = 3;
            this.labelProductName.Text = "Total Product Types";
            // 
            // labelCountProduct
            // 
            this.labelCountProduct.AutoSize = true;
            this.labelCountProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCountProduct.Location = new System.Drawing.Point(187, 9);
            this.labelCountProduct.Name = "labelCountProduct";
            this.labelCountProduct.Size = new System.Drawing.Size(55, 29);
            this.labelCountProduct.TabIndex = 2;
            this.labelCountProduct.Text = "189";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.SteelBlue;
            this.panelUser.Controls.Add(this.labelName);
            this.panelUser.Controls.Add(this.labelCountUser);
            this.panelUser.Location = new System.Drawing.Point(392, 258);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(185, 55);
            this.panelUser.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelName.Location = new System.Drawing.Point(3, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Total Users";
            // 
            // labelCountUser
            // 
            this.labelCountUser.AutoSize = true;
            this.labelCountUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCountUser.Location = new System.Drawing.Point(113, 13);
            this.labelCountUser.Name = "labelCountUser";
            this.labelCountUser.Size = new System.Drawing.Size(55, 29);
            this.labelCountUser.TabIndex = 0;
            this.labelCountUser.Text = "100";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUser.Location = new System.Drawing.Point(605, 215);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(49, 24);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "User";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.userToolStripMenuItem,
            this.productToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.salesToolStripMenuItem.Text = "Sale";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(331, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "DEPARTMENT STORE MANAGEMENT SYSTEM";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCountProduct;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCountUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}