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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int UserID = 0;
            //Getting Values from UI
            if(textBoxUserID.Text.Trim()!="")
            {
                UserID = int.Parse(textBoxUserID.Text.Trim());
            }
            string FullName = textBoxFullName.Text.Trim();
            string Username = textBoxUsername.Text.Trim();
            string Email = textBoxEmail.Text.Trim();
            string Contact = textBoxContact.Text.Trim();
            string Password = textBoxPassword.Text.Trim();
            string UserType = comboBoxUserType.Text.Trim();

            //Declare and Assign Object
            User U = new User();
            U.UserID = UserID;
            U.FullName = FullName;
            U.Username = Username;
            U.Email = Email;
            U.Contact = Contact;
            U.Password = Password;
            U.UserType = UserType;

            //Create Object for User DAL
            UserDAL dal = new UserDAL();
            //Identify the Case for Insert or Update
            if(U.UserID==0)
            {
                //Case for Insert
                bool success = dal.Insert_User(U);
                if(success==true)
                {
                    MessageBox.Show("New User Successfully Added");
                    //Refreshing the DAta Grid view
                    DataTable dt = dal.Select_User();
                    dataGridViewUsers.DataSource = dt;

                    //Clear the fields
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add new user. Try Again.");

                }
            }
            else
            {
                //Case for Update
                bool success = dal.Update_User(U);
                if(success==true)
                {
                    MessageBox.Show("User Successfully Updated.");
                    //Refreshing the DAta Grid view
                    DataTable dt = dal.Select_User();
                    dataGridViewUsers.DataSource = dt;

                    //Clear the Testfields
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update User. Try Again.");
                }
            }
        }

        private void dataGridViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Find index of the row clicked
            int index = e.RowIndex;
            //Get VAlues from Row Clicked
            string UserID = dataGridViewUsers.Rows[index].Cells[0].Value.ToString();
            string FullName = dataGridViewUsers.Rows[index].Cells[1].Value.ToString();
            string Username = dataGridViewUsers.Rows[index].Cells[2].Value.ToString();
            string Email = dataGridViewUsers.Rows[index].Cells[3].Value.ToString();
            string Contact = dataGridViewUsers.Rows[index].Cells[4].Value.ToString();
            string Password = dataGridViewUsers.Rows[index].Cells[5].Value.ToString();
            string UserType = dataGridViewUsers.Rows[index].Cells[6].Value.ToString();

            //Write These Values to the Textbox
            textBoxUserID.Text = UserID;
            textBoxFullName.Text = FullName;
            textBoxUsername.Text = Username;
            textBoxEmail.Text = Email;
            textBoxContact.Text = Contact;
            textBoxPassword.Text = Password;
            comboBoxUserType.Text = UserType;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            UserDAL dal = new UserDAL();
            DataTable dt = dal.Select_User();
            dataGridViewUsers.DataSource = dt;
        }
        void Clear()
        {
            textBoxUserID.Text = "";
            textBoxFullName.Text = "";
            textBoxUsername.Text = "";
            textBoxEmail.Text = "";
            textBoxContact.Text = "";
            textBoxPassword.Text = "";
            comboBoxUserType.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(textBoxUserID.Text.Trim());
            if(UserID!=0 || textBoxUserID.Text!=null)
            {
                User U = new User();
                U.UserID = UserID;

                UserDAL dal = new UserDAL();
                bool success = dal.Delete_User(U);
                if(success==true)
                {
                    MessageBox.Show("User Successfully Deleted.");
                    //Refresh
                    DataTable dt = dal.Select_User();
                    dataGridViewUsers.DataSource = dt;

                    //Clear
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Delete USer.");
                }
            }
            else
            {
                MessageBox.Show("Select User First.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get User Input
            string keyword = txtSearch.Text;

            if(keyword!=null)
            {
                UserDAL dal = new UserDAL();
                DataTable dt = dal.Select_User_By_Keywords(keyword);
                dataGridViewUsers.DataSource = dt;
            }
            else
            {
                UserDAL dal = new UserDAL();
                DataTable dt = dal.Select_User();
                dataGridViewUsers.DataSource = dt;
            }
        }
    }
}
