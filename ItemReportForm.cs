using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWinApp.BLL;
using StockManagementWinApp.Model;
using iTextSharp.text.pdf;
using System.IO;
using System.Configuration;
using iTextSharp.text;

namespace StockManagementWinApp
{
    public partial class ItemReportForm : Form
    {
        private Item item;
        public ItemReportForm()
        {
            InitializeComponent();
            item=new Item();
        }

        ItemReportManager _itemReportManager = new ItemReportManager();
        private void ItemReportForm_Load(object sender, EventArgs e)
        {
            companyComboBox.DataSource = _itemReportManager.LoadCompany();
            categoryComboBox.DataSource = _itemReportManager.LoadCategory(item);
            // categoryComboBox.Enabled = false;

        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companyComboBox.SelectedValue.ToString() != null)
            {
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue.ToString());
                //categoryComboBox.DataSource = _itemReportManager.LoadCategory(item);
                //categoryComboBox.Enabled = true;
             
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.displayDataGridView.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock();
                if (Convert.ToInt32(companyComboBox.SelectedValue) < 1 && Convert.ToInt32(categoryComboBox.SelectedValue) < 1)
                {
                    errorCompany.Text = "Please Select a Company or Category !";
                    errorCompany.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                stock.CompanyName = companyComboBox.Text;
                stock.CategoryName = categoryComboBox.Text;
                if (Convert.ToInt32(categoryComboBox.SelectedValue) < 1)
                {
                    //errorCategory.Text = "Please Select a Category!";
                    //errorCategory.ForeColor = Color.Red;
                    //return;
                    stock.CategoryName = "";
                }
                if (Convert.ToInt32(companyComboBox.SelectedValue) < 1)
                {
                    //errorCompany.Text = "Please Select a Company!";
                    //errorCompany.ForeColor = Color.Red;
                    //return;
                    stock.CompanyName = "";
                }
            

                   
                   // stock.CompanyName = companyComboBox.Text;
                    //stock.CategoryName = categoryComboBox.Text;

                    displayDataGridView.DataSource = _itemReportManager.Search(stock);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured! ");
            }
            

        }


        public void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Author : Stock Manager", fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        public DataTable GenerateReport(DataTable dataTable)
        {
            DataTable data = new DataTable();

            data.Columns.Add("Sl NO");
            data.Columns.Add("item name");
            data.Columns.Add("company name");
            data.Columns.Add("category name");
            data.Columns.Add("Re-Order Level");
            data.Columns.Add("quantity");

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                data.Rows.Add(index+1, dataTable.Rows[index].ItemArray[0], dataTable.Rows[index].ItemArray[1], dataTable.Rows[index].ItemArray[2], dataTable.Rows[index].ItemArray[3], dataTable.Rows[index].ItemArray[4]);
            }

            return data;
        }

        private void ExportPdfButton_Click(object sender, EventArgs e)
        {

            try
            {
                Stock stock = new Stock();
                if (Convert.ToInt32(companyComboBox.SelectedValue) < 1 && Convert.ToInt32(categoryComboBox.SelectedValue) < 1)
                {
                    errorCompany.Text = "Please Select a Company or Category !";
                    errorCompany.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                stock.CompanyName = companyComboBox.Text;
                stock.CategoryName = categoryComboBox.Text;
                if (Convert.ToInt32(categoryComboBox.SelectedValue) < 1)
                {
                    //errorCategory.Text = "Please Select a Category!";
                    //errorCategory.ForeColor = Color.Red;
                    //return;
                    stock.CategoryName = "";
                }
                if (Convert.ToInt32(companyComboBox.SelectedValue) < 1)
                {
                    //errorCompany.Text = "Please Select a Company!";
                    //errorCompany.ForeColor = Color.Red;
                    //return;
                    stock.CompanyName = "";
                }
                    displayDataGridView.DataSource = _itemReportManager.Search(stock);

                    DataTable dataTable = GenerateReport(_itemReportManager.Search(stock));
                    //     DataTable dtbl = MakeDataTable();
                    //string reortPath = ConfigurationManager.AppSettings["ReportPath"];
                    var path = @"D:\BitmCode\projectbitm\Reports\ItemReport_" + DateTime.Now.ToString("dd'-'MM'-'yyyy'T'HH'-'mm'-'ss'GMT'") + ".pdf";
                    ExportDataTableToPdf(dataTable, path, "Item Report");
                    System.Diagnostics.Process.Start(path);
                    this.ParentForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }



        }
    }
}
