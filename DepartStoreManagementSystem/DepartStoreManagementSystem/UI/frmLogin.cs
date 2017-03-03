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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string username;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Getting data from User Input
            User user = new User();
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            user.UserType = comboBox1.Text;
            //Now Login Check
            UserDAL dal = new UserDAL();
            bool success = dal.Login(user.Username, user.Password, user.UserType);
            if(success==true)
            {
                username = user.Username;
                frmHome home = new frmHome();
                home.Show();
                this.Hide();
                
            }
            else
            {
                lblError.Text = "Username or Password or UserType did not Match.";
            }
        }
    }
}
