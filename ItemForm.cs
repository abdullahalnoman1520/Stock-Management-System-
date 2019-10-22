using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWinApp.Model;
using StockManagementWinApp.BLL;


namespace StockManagementWinApp
{
    public partial class ItemForm : Form
    {
        ItemManager _ItemManager = new ItemManager();
        public ItemForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
            CancelButton.Visible = false;
            updateItemIdTextBox.Visible = false;
            companyComboBox.DataSource = _ItemManager.LoadCompany();
            categoryComboBox.DataSource = _ItemManager.LoadCategory();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(companyComboBox.SelectedValue) < 1)
                {
                    errorLabel.Text = "Please Select a Company!";
                    errorLabel.ForeColor = Color.Red;
                    return;
                }
                if (Convert.ToInt32(categoryComboBox.SelectedValue)<1)
                {
                    errorLabel.Text = "Please Select a Category!";
                    errorLabel.ForeColor = Color.Red;
                    return;
                }
                if (string.IsNullOrEmpty(ItemNameTextBox.Text))
                {
                    errorLabel.Text = "Please Enter Item Name!";
                    errorLabel.ForeColor = Color.Red;
                    return;
                }
                if (string.IsNullOrEmpty(reorderQuantitytextBox.Text))
                {
                    reorderQuantitytextBox.Text = "0";
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(reorderQuantitytextBox.Text, "[^0-9]"))
                {
                    errorLabel.Text = "Re-Order Quantity must be Number!";
                    errorLabel.ForeColor = Color.Red;
                    return;
                }
                if (Convert.ToInt32(reorderQuantitytextBox.Text) <0)
                {
                    errorLabel.Text = "Invalied Input in Re-Order Quantity!";
                    errorLabel.ForeColor = Color.Red;
                    return;
                }


                Item item = new Item();
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                item.ItemName = ItemNameTextBox.Text;
                item.ReOrderQuantity = Convert.ToInt32(reorderQuantitytextBox.Text);
                item.CompanyName = companyComboBox.Text;
                item.CategoryName = categoryComboBox.Text;


               
                //Item save here
                if (SaveButton.Text == "Save")
                {
                    bool isExists = _ItemManager.IsExists(item);
                    if (isExists)
                    {
                        errorLabel.Text = item.ItemName + " Item already Exists under " + item.CompanyName + " company and " + item.CategoryName + " category!";
                        errorLabel.ForeColor = Color.Red;
                        return;
                    }

                    bool flag = _ItemManager.Insert(item);
                    if (flag)
                    {
                        errorLabel.Text = item.ItemName + " successfully added!";
                        errorLabel.ForeColor = Color.Green;
                        ItemForm_Load(sender, e);
                    }
                    else
                    {
                        errorLabel.Text = item.ItemName + " added Failed!";
                        errorLabel.ForeColor = Color.Red;
                    }
                }
                //Item Update Here
                else
                {
                    item.Id = Convert.ToInt32(updateItemIdTextBox.Text);

                    bool isExists = _ItemManager.IsExistsItemName(item);
                    if (isExists)
                    {
                        errorLabel.Text = item.ItemName + " Item already Exists under " + item.CompanyName + " company and " + item.CategoryName + " category! Please enter Different Item Name.";
                        errorLabel.ForeColor = Color.Red;
                        return;
                    }

                    bool flag = _ItemManager.Update(item);
                    if (flag)
                    {

                        CancelButton_Click(sender, e);
                        errorLabel.Text = item.ItemName + "Item Update successfully!";
                        errorLabel.ForeColor = Color.Green;
                        ItemForm_Load(sender, e);
                    }
                    else
                    {
                        errorLabel.Text = item.ItemName + "Item Update Failed!";
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

        private void ItemForm_Load(object sender, EventArgs e)
        {
            try
            {
                itemDisplayDataGridView.DataSource = _ItemManager.ShowItem();
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.ForeColor = Color.Red;
            }
        }

        private void itemDisplayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            this.itemDisplayDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }

        private void itemDisplayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            { 

                errorLabel.Text = "";
                itemDisplayDataGridView.CurrentRow.Selected = true;
                updateItemIdTextBox.Text = itemDisplayDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ItemNameTextBox.Text = itemDisplayDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                companyComboBox.SelectedValue = itemDisplayDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                categoryComboBox.SelectedValue = itemDisplayDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                reorderQuantitytextBox.Text = itemDisplayDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                SaveButton.Text = "Update";
                CancelButton.Visible = true;
                companyComboBox.Enabled = false;
                categoryComboBox.Enabled = false;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SaveButton.Text = "Save";
            updateItemIdTextBox.Text = "";
            ItemNameTextBox.Text = "";
            CancelButton.Visible = false;
            errorLabel.Text = "";
            companyComboBox.SelectedValue = -1;
            categoryComboBox.SelectedValue = -1;
            reorderQuantitytextBox.Text = "0";
            companyComboBox.Enabled = true;
            categoryComboBox.Enabled = true;
        }


    }
}
