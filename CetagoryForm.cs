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
    public partial class CetagoryForm : Form
    {
        CategoryManager _categoryManager = new CategoryManager();

        private Category category;

        public CetagoryForm()
        {
            InitializeComponent();
            category = new Category();
            CancelButton.Visible = false;
            updateIdCategoryTextBox.Visible = false;


        }
        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(categoryName.Text))
                {
                    errorLabel.Text ="Please Enter Category Name!";
                    errorLabel.ForeColor = Color.Red;
                    return;
                }



                category.CategoryName = categoryName.Text;
                //Save Category Here
                if (saveBtn.Text == "Save")
                {
                    bool IsExists = _categoryManager.IsExists(categoryName.Text);
                    if (IsExists)
                    {
                        errorLabel.Text = categoryName.Text + " Category Already Exists!";
                        errorLabel.ForeColor = Color.Red;
                        return;
                    }

                    bool isExecuted;
                    isExecuted = _categoryManager.Insert(category);

                    if (isExecuted)
                    {
                        errorLabel.Text = "Category Successfully Added!";
                        errorLabel.ForeColor = Color.Green;
                        dataGridView.DataSource = _categoryManager.ShowCategory();
                    }
                    else
                    {
                        errorLabel.Text = "Category Added Fialed!";
                        errorLabel.ForeColor = Color.Red;
                    }

                }
                //update Category here
                else 
                {

                    category.Id = Convert.ToInt32(updateIdCategoryTextBox.Text);

                    bool IsExists = _categoryManager.IsExistsUpdate(categoryName.Text, updateIdCategoryTextBox.Text);
                    if (IsExists)
                    {
                        errorLabel.Text = categoryName.Text + " Category Already Exists!You can not update duplicate name";
                        errorLabel.ForeColor = Color.Red;
                        return;
                    }

                   
                    bool flag = _categoryManager.Update(category);
                    if (flag)
                    {
                        CancelButton_Click(sender, e);

                        errorLabel.Text = "Category Successfully Updated!";
                        errorLabel.ForeColor = Color.Green;
                        dataGridView.DataSource = _categoryManager.ShowCategory();
                    }
                    else
                    {
                        errorLabel.Text = "Category Update Failed!";
                        errorLabel.ForeColor = Color.Red;
                    }

                }
                
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.ForeColor = Color.Red;
            }
        }

        private void CetagoryForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                dataGridView.DataSource = _categoryManager.ShowCategory();
                errorLabel.Text = "";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.ForeColor = Color.Red;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {
                errorLabel.Text = "";
                dataGridView.CurrentRow.Selected = true;
                updateIdCategoryTextBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                saveBtn.Text = "Update";
                CancelButton.Visible = true;
            }
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            saveBtn.Text = "Save";
            updateIdCategoryTextBox.Text = "";
            categoryName.Text = "";
            CancelButton.Visible = false;
            errorLabel.Text = "";
        }
    }
}

