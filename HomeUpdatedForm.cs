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
    public partial class HomeUpdatedForm : Form
    {
        public HomeUpdatedForm()
        {
            InitializeComponent();
            
        }

        public HomeUpdatedForm(User user)
        {
            InitializeComponent();
            userNameShowLabel.Text = user.UserName;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Logout?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide(); 

                LoginForm login = new LoginForm();
                login.Show();
            }
            else
            {
                // Do something  
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
 

            CetagoryForm cetagoryForm = new CetagoryForm();
            cetagoryForm.MdiParent = this;
            cetagoryForm.Hide();
            cetagoryForm.Show();

        }

        private void addCompanyButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            companyForm.MdiParent = this;
            companyForm.Show();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.MdiParent = this;
            itemForm.Show();
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInForm stockForm = new StockInForm();
            stockForm.MdiParent = this;
            stockForm.Show();
        }

        private void stockoutButton_Click(object sender, EventArgs e)
        {
            errorStockOut stockOutForm = new errorStockOut();
            stockOutForm.MdiParent = this;
            stockOutForm.Show();
        }

        private void searchItemButton_Click(object sender, EventArgs e)
        {
            ItemReportForm itemReportForm = new ItemReportForm();
            itemReportForm.MdiParent = this;
            itemReportForm.Show();
        }

        private void searchSalesButton_Click(object sender, EventArgs e)
        {
            StockReportForm stockReportForm = new StockReportForm();
            stockReportForm.MdiParent = this;
            stockReportForm.Show();
        }

        private void HomeUpdatedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
