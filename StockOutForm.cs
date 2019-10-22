using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWinApp.BLL;
using StockManagementWinApp.Model;


namespace StockManagementWinApp
{
    public partial class errorStockOut : Form
    {
        private Item item;

        //private Stock stock;
        List<Stock> stocks = new List<Stock>();

        public errorStockOut()
        {
            InitializeComponent();
            item = new Item();
            errorLabel1.Text = "";
            //   stocks = new List<Stock>();
            //  stock = new Stock();

        }

        StockOutManager _stockOutManager = new StockOutManager();


        private void StockOutForm_Load(object sender, EventArgs e)
        {
            companyComboBox.DataSource = _stockOutManager.LoadCompany();
            categoryComboBox.Enabled = false;
            itemComboBox.Enabled = false;

        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.displayDataGridView.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();

        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companyComboBox.SelectedValue.ToString() != null)
            {
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue.ToString());
                categoryComboBox.DataSource = _stockOutManager.LoadCategory(item);
                categoryComboBox.Enabled = true;
                itemComboBox.Enabled = false;
            }

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedValue.ToString() != null)
            {
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
                itemComboBox.DataSource = _stockOutManager.LoadItem(item);
                itemComboBox.Enabled = true;
            }
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedValue.ToString() != null)
            {
                item.Id = Convert.ToInt32(itemComboBox.SelectedValue.ToString());
                reorderLevelTextBox.Text = _stockOutManager.LoadReorderLevel(item).ToString();
                availableQuantityTextBox.Text = _stockOutManager.LoadAvailableQuantity(item).ToString();
                reorderLevelTextBox.Enabled = false;
                availableQuantityTextBox.Enabled = false;
            }
        }

        public DataTable ShowStocks()
        {
            DataTable dataTable = new DataTable();

            //Define columns\
            dataTable.Columns.Add("itemname");
            dataTable.Columns.Add("companyname");
            dataTable.Columns.Add("categoryname");
            dataTable.Columns.Add("quantity");

            foreach (Stock stock in stocks)
            {

                dataTable.Rows.Add(stock.ItemName, stock.CompanyName, stock.CategoryName, stock.Quantity);

            }

            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(companyComboBox.SelectedValue) < 1)
                {
                    errorLabel1.Text = "Please Select a Company!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
                if (Convert.ToInt32(categoryComboBox.SelectedValue) < 1)
                {
                    errorLabel1.Text = "Please Select a Category!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
                if (Convert.ToInt32(itemComboBox.SelectedValue) < 1)
                {
                    errorLabel1.Text = "Please Select a Item!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
                if (stockOutQuantityTextBox.Text == string.Empty)
                {
                    errorLabel1.Text = "Please Enter Stock Out Quantity.";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
          
                if (System.Text.RegularExpressions.Regex.IsMatch(stockOutQuantityTextBox.Text, "[^0-9]"))
                {
                    errorLabel1.Text = "Stock Out Quantity must a valid Number!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }

                if (Convert.ToInt32(stockOutQuantityTextBox.Text) > Convert.ToInt32(availableQuantityTextBox.Text))
                {
                    errorLabel1.Text = "Not enough Item in Stock!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }

                if (Convert.ToInt32(itemComboBox.SelectedValue) > 0)
                {

                    Stock stock = new Stock();
                    stock.CompanyName = companyComboBox.Text;
                    stock.CategoryName = categoryComboBox.Text;
                    stock.ItemName = itemComboBox.Text;
                    stock.ItemID = Convert.ToInt32(itemComboBox.SelectedValue.ToString());
                    stock.Quantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
                    stock.StockStatus = "Sold";

                    stocks.Add(stock);
                    availableQuantityTextBox.Text = (Convert.ToInt32(availableQuantityTextBox.Text) - Convert.ToInt32(stockOutQuantityTextBox.Text)).ToString();
                    stockOutQuantityTextBox.Text = "";
                    displayDataGridView.DataSource = ShowStocks();

                }
            }
            catch (Exception ex)
            {
                errorLabel1.Text = "Exception found!";
            }

        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (System.Text.RegularExpressions.Regex.IsMatch(stockOutQuantityTextBox.Text, "[^0-9]"))
                {
                    errorLabel1.Text = "Stock Out Quantity must be Number!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }

                if (Convert.ToInt32(availableQuantityTextBox.Text) <= Convert.ToInt32(reorderLevelTextBox.Text))
                {
                    errorLabel1.Text = "Not Possible Stock Out ! Please Stock in the Quantity ";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }

                if(stocks.Count < 1)
                {
                    errorLabel1.Text = "No data In the Cart! Please add first.";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }

                if (itemComboBox.SelectedValue.ToString() != null)
                {
                    bool IsError = false;
                    foreach (Stock stock in stocks)
                    {
                        stock.StockStatus = "Sold";

                        int isExecuted;
                        isExecuted = _stockOutManager.SellItem(stock);
                        if (isExecuted > 0)
                        {
                            
                        }
                        else
                        {
                            IsError = true;
                        }
                    }

                    if (IsError)
                    {
                        errorLabel1.Text = "Sold Failed!";
                        errorLabel1.ForeColor = Color.Red;
                    }
                    else
                    {

                        errorLabel1.Text = "Sold Successfully!";
                        errorLabel1.ForeColor = Color.Green;
                        int length = stocks.Count;
                        for (int index = length - 1; index >= 0; index--)
                        {
                            stocks.RemoveAt(index);
                        }

                        displayDataGridView.DataSource = ShowStocks();

                    }

                  availableQuantityTextBox.Text = _stockOutManager.LoadAvailableQuantity(item).ToString();
                }
            }

        
            catch (Exception )
            {
                errorLabel1.Text = "Exception found!";
                errorLabel1.ForeColor = Color.Red;
            }


        }

        private void LostButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(stockOutQuantityTextBox.Text, "[^0-9]"))
                {
                    errorLabel1.Text = "Stock Out Quantity must be Number!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
                if (Convert.ToInt32(availableQuantityTextBox.Text) <= Convert.ToInt32(reorderLevelTextBox.Text))
                {
                    errorLabel1.Text = "Not Possible Stock Out ! Please Stock in the Quantity ";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }


                if (stocks.Count < 1)
                {
                    errorLabel1.Text = "No data In the Cart! Please add first.";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
                if (itemComboBox.SelectedValue.ToString() != null)
                {
                    bool IsError = false;
                    foreach (Stock stock in stocks)
                    {
                        stock.StockStatus = "Lost";

                        int isExecuted;
                        isExecuted = _stockOutManager.LostItem(stock);
                        if (isExecuted > 0)
                        {

                        }
                        else
                        {
                            IsError = true;
                        }
                    }

                    if (IsError)
                    {
                        errorLabel1.Text = "Lost Failed!";
                        errorLabel1.ForeColor = Color.Red;
                    }
                    else
                    {
                        errorLabel1.Text = "Lost Successfully!";
                        errorLabel1.ForeColor = Color.Green;
                        int length = stocks.Count;
                        for (int index = length - 1; index >= 0; index--)
                        {
                            stocks.RemoveAt(index);
                        }

                        displayDataGridView.DataSource = ShowStocks();

                    }

                    availableQuantityTextBox.Text = _stockOutManager.LoadAvailableQuantity(item).ToString();
                }
            }

            catch (Exception)
            {
                errorLabel1.Text = "Exception found!";
                errorLabel1.ForeColor = Color.Red;
            }


        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(stockOutQuantityTextBox.Text, "[^0-9]"))
                {
                    errorLabel1.Text = "Stock Out Quantity must be  Number!";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
                if (Convert.ToInt32(availableQuantityTextBox.Text) <= Convert.ToInt32(reorderLevelTextBox.Text))
                {
                    errorLabel1.Text = "Not Possible Stock Out ! Please Stock in the Quantity ";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }

                if (stocks.Count < 1)
                {
                    errorLabel1.Text = "No data In the Cart! Please add first.";
                    errorLabel1.ForeColor = Color.Red;
                    return;
                }
                if (itemComboBox.SelectedValue.ToString() != null)
                {
                    bool IsError = false;
                    foreach (Stock stock in stocks)
                    {
                        stock.StockStatus = "Damaged";

                        int isExecuted;
                        isExecuted = _stockOutManager.DamagedItem(stock);
                        if (isExecuted > 0)
                        {

                        }
                        else
                        {
                            IsError = true;
                        }
                    }

                    if (IsError)
                    {
                        errorLabel1.Text =  "Damaged Failed!";
                        errorLabel1.ForeColor = Color.Red;
                    }
                    else
                    {
                        errorLabel1.Text =  "Damaged Successfully!";
                        errorLabel1.ForeColor = Color.Green;
                        int length = stocks.Count;
                        for (int index = length - 1; index >= 0; index--)
                        {
                            stocks.RemoveAt(index);
                        }

                        displayDataGridView.DataSource = ShowStocks();

                    }

                    availableQuantityTextBox.Text = _stockOutManager.LoadAvailableQuantity(item).ToString();
                }
            }
            catch (Exception)
            {
                errorLabel1.Text ="Exception found!";
                errorLabel1.ForeColor = Color.Red;
            }


        }

    }
}
