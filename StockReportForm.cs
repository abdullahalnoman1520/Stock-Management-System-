using StockManagementWinApp.BLL;
using StockManagementWinApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Text;
using System.Configuration;

namespace StockManagementWinApp
{
    public partial class StockReportForm : Form
    {
        private Stock stock;
        public StockReportForm()
        {
            InitializeComponent();

            stock = new Stock();
        }

        StockReportManager _stockReportManager = new StockReportManager();
        private void StockReportForm_Load(object sender, EventArgs e)
        {
            stockReportDataGridView.Rows.Clear();
            soldRadioButton.Checked = true;
        }

        private void soldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            stock.StockStatus = "Sold";
            stockReportDataGridView.Columns[5].HeaderText = "Sold Quantity";
        }

        private void damageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            stock.StockStatus = "Damaged";
            stockReportDataGridView.Columns[5].HeaderText = "Damaged Quantity";
            //stockReportDataGridView.DataSource = _stockReportManager.Search(stock);
        }

        private void lostRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            stock.StockStatus = "Lost";
            stockReportDataGridView.Columns[5].HeaderText = "Lost Quantity";
            //stockReportDataGridView.DataSource = _stockReportManager.Search(stock);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            stock.FromStockDate = Convert.ToDateTime(fromDateTimePicker.Text);
            stock.ToStockDate = Convert.ToDateTime(toDateTimePicker.Text);


            //stock.FromStockDate = fromDateTimePicker.Value.ToShortDateString();
            //stock.ToStockDate = toDateTimePicker.Value.ToShortDateString();
            if (stock.FromStockDate <= stock.ToStockDate)
            {
                bool flag = _stockReportManager.SearchExists(stock);
                if (flag)
                {

                    stockReportDataGridView.DataSource = _stockReportManager.Search(stock);

                }
                else
                {
                    MessageBox.Show("Data Not Found!", "Result");
                    stockReportDataGridView.DataSource = _stockReportManager.Search(stock);
                }
            }
            //bool flag = _stockReportManager.SearchExists(stock);
            //if (flag)
            //{

            //        stockReportDataGridView.DataSource = _stockReportManager.Search(stock);

            //}
            //else
            //{
            //    MessageBox.Show("Data Not Found!","Result");
            //    stockReportDataGridView.DataSource = _stockReportManager.Search(stock);
            //}

            else
            {
                MessageBox.Show("End date should be greater than Start date");
                stockReportDataGridView.DataSource = _stockReportManager.Search(stock);
            }

        }

        private void stockReportDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            stockReportDataGridView.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();
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
            
            data.Columns.Add("item name");
            data.Columns.Add("company name");
            data.Columns.Add("category name");
            data.Columns.Add("quantity");
            data.Columns.Add("stock date");
            data.Columns.Add("Status");

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                data.Rows.Add(dataTable.Rows[index].ItemArray[1], dataTable.Rows[index].ItemArray[2], dataTable.Rows[index].ItemArray[3], dataTable.Rows[index].ItemArray[5],Convert.ToDateTime(dataTable.Rows[index].ItemArray[6]).ToString("dd'-'MM'-'yyyy"), dataTable.Rows[index].ItemArray[7]);
            }

            return data;
        }

        private void ExportPdfButton_Click(object sender, EventArgs e)
        {
           
            try
            {

                stock.FromStockDate = Convert.ToDateTime(fromDateTimePicker.Text);
                stock.ToStockDate = Convert.ToDateTime(toDateTimePicker.Text);

                bool flagExists = _stockReportManager.SearchExists(stock);
                if (flagExists)
                {
                    stockReportDataGridView.DataSource = _stockReportManager.Search(stock);

                    DataTable dataTable = GenerateReport(_stockReportManager.Search(stock));
                    //     DataTable dtbl = MakeDataTable();
                    //string reortPath = ConfigurationManager.AppSettings["ReportPath"];
                    var path = @"D:\BitmCode\projectbitm\Reports\StockOutReport_" + DateTime.Now.ToString("dd'-'MM'-'yyyy'T'HH'-'mm'-'ss'GMT'") + ".pdf";
                    ExportDataTableToPdf(dataTable, path, "Stock Out Report");
                    System.Diagnostics.Process.Start(path);
                    this.ParentForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    
                }
                else
                {
                    MessageBox.Show("Data Not Found!", "Result");
                    stockReportDataGridView.DataSource = _stockReportManager.Search(stock);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }



        }
    }
}
