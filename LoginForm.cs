using StockManagementWinApp.BLL;
using StockManagementWinApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementWinApp
{
    public partial class LoginForm : Form
    {
        public static string userName;

        UserManager _userManager = new UserManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = userNameTextBox.Text;
            user.Password = passwordTextBox.Text;
            bool isAuth = _userManager.UserAuth(user);
            if (isAuth)
            {
                userName = user.UserName;
                this.Hide();

                //Home home = new Home();
                HomeUpdatedForm home = new HomeUpdatedForm(user);
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //this.Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Focus();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
            userNameTextBox.Focus();
        }
    }
}
