namespace StockManagementWinApp
{
    partial class ItemReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorCompany = new System.Windows.Forms.Label();
            this.errorCategory = new System.Windows.Forms.Label();
            this.ExportPdfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(394, 28);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(179, 21);
            this.companyComboBox.TabIndex = 0;
            this.companyComboBox.ValueMember = "CompanyId";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementWinApp.Model.Company);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "CategoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(394, 68);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(179, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "CategoryId";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementWinApp.Model.Category);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(498, 108);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AutoGenerateColumns = false;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.itemNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.reOrderQuantityDataGridViewTextBoxColumn});
            this.displayDataGridView.DataSource = this.itemBindingSource;
            this.displayDataGridView.Location = new System.Drawing.Point(134, 180);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.Size = new System.Drawing.Size(643, 274);
            this.displayDataGridView.TabIndex = 4;
            this.displayDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = " Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // reOrderQuantityDataGridViewTextBoxColumn
            // 
            this.reOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReOrderQuantity";
            this.reOrderQuantityDataGridViewTextBoxColumn.HeaderText = "ReOrder Level";
            this.reOrderQuantityDataGridViewTextBoxColumn.Name = "reOrderQuantityDataGridViewTextBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementWinApp.Model.Item);
            // 
            // errorCompany
            // 
            this.errorCompany.AutoSize = true;
            this.errorCompany.Location = new System.Drawing.Point(593, 31);
            this.errorCompany.Name = "errorCompany";
            this.errorCompany.Size = new System.Drawing.Size(0, 13);
            this.errorCompany.TabIndex = 11;
            // 
            // errorCategory
            // 
            this.errorCategory.AutoSize = true;
            this.errorCategory.Location = new System.Drawing.Point(593, 71);
            this.errorCategory.Name = "errorCategory";
            this.errorCategory.Size = new System.Drawing.Size(0, 13);
            this.errorCategory.TabIndex = 11;
            // 
            // ExportPdfButton
            // 
            this.ExportPdfButton.Location = new System.Drawing.Point(807, 180);
            this.ExportPdfButton.Name = "ExportPdfButton";
            this.ExportPdfButton.Size = new System.Drawing.Size(75, 23);
            this.ExportPdfButton.TabIndex = 3;
            this.ExportPdfButton.Text = "Export PDF";
            this.ExportPdfButton.UseVisualStyleBackColor = true;
            this.ExportPdfButton.Click += new System.EventHandler(this.ExportPdfButton_Click);
            // 
            // ItemReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 551);
            this.ControlBox = false;
            this.Controls.Add(this.ExportPdfButton);
            this.Controls.Add(this.errorCategory);
            this.Controls.Add(this.errorCompany);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Location = new System.Drawing.Point(235, 135);
            this.Name = "ItemReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ItemReportForm";
            this.Load += new System.EventHandler(this.ItemReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reOrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label errorCompany;
        private System.Windows.Forms.Label errorCategory;
        private System.Windows.Forms.Button ExportPdfButton;
    }
}