using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using StockManagementWinApp.Model;
using StockManagementWinApp.BLL;

namespace StockManagementWinApp
{
    public partial class CompanyForm : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        private Company company;
        public CompanyForm()
        {
            InitializeComponent();
            company = new Company();
            CancelButton.Visible = false;
            updateIdCompanyTextBox.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(companyNameTextBox.Text))
                {
                    errorLabel.Text = "Please Enter Company Name!";
                    errorLabel.ForeColor = Color.Red;
                    return;
                }
               

                company.CompanyName = companyNameTextBox.Text;

                if (SaveButton.Text == "Save")
                {
                    bool IsExists = _companyManager.IsExists(companyNameTextBox.Text);
                    if (IsExists)
                    {
                        errorLabel.Text = companyNameTextBox.Text + " Company Already Exists!";
                        errorLabel.ForeColor = Color.Red;
                        return;
                    }

                    bool flag = _companyManager.Insert(company);

                    if (flag)
                    {
                        errorLabel.Text = "Company Successfully Added!";
                        errorLabel.ForeColor = Color.Green;
                        companyNameTextBox.Text = "";
                        companyShowDataGridView.DataSource = _companyManager.ShowCompany();
                        // MessageBox.Show("Data Insertted!");
                    }
                }
                else
                {
                    company.Id = Convert.ToInt32(updateIdCompanyTextBox.Text);
                    bool IsExists = _companyManager.IsExistsUpdate(companyNameTextBox.Text, updateIdCompanyTextBox.Text);
                    if (IsExists)
                    {
                        errorLabel.Text = companyNameTextBox.Text + " Company Already Exists!You cant update duplicate Name";
                        errorLabel.ForeColor = Color.Red;
                        return;
                    }
                    bool flag = _companyManager.Update(company);
                    if (flag)
                    {
                        CancelButton_Click(sender, e);
                        errorLabel.Text = "Company Successfully Updated!";
                        errorLabel.ForeColor = Color.Green;
                        companyShowDataGridView.DataSource = _companyManager.ShowCompany();

                    }
                    else
                    {
                        errorLabel.Text = "Company Update Failed!";
                        errorLabel.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.ForeColor = Color.Red;
            }
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            try
            {
                companyShowDataGridView.DataSource = _companyManager.ShowCompany();
                errorLabel.Text = "";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.ForeColor = Color.Red;
            }
        }

        private void companyShowDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.companyShowDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }

        private void companyShowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                errorLabel.Text = "";
                companyShowDataGridView.CurrentRow.Selected = true;
                updateIdCompanyTextBox.Text = companyShowDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                companyNameTextBox.Text = companyShowDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                SaveButton.Text = "Update";
                CancelButton.Visible = true;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SaveButton.Text = "Save";
            updateIdCompanyTextBox.Text = "";
            companyNameTextBox.Text = "";
            CancelButton.Visible = false;
            errorLabel.Text = "";

        }
    }
}
