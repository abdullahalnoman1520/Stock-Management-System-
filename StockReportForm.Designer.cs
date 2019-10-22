namespace StockManagementWinApp
{
    partial class StockReportForm
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
            this.stockReportDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.lostRadioButton = new System.Windows.Forms.RadioButton();
            this.damageRadioButton = new System.Windows.Forms.RadioButton();
            this.soldRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportPdfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockReportDataGridView
            // 
            this.stockReportDataGridView.AllowUserToAddRows = false;
            this.stockReportDataGridView.AllowUserToDeleteRows = false;
            this.stockReportDataGridView.AutoGenerateColumns = false;
            this.stockReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Id,
            this.CompanyName,
            this.CategoryName,
            this.itemNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.stockReportDataGridView.DataSource = this.stockBindingSource1;
            this.stockReportDataGridView.Location = new System.Drawing.Point(259, 320);
            this.stockReportDataGridView.Name = "stockReportDataGridView";
            this.stockReportDataGridView.ReadOnly = true;
            this.stockReportDataGridView.Size = new System.Drawing.Size(587, 156);
            this.stockReportDataGridView.TabIndex = 7;
            this.stockReportDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.stockReportDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataSource = typeof(StockManagementWinApp.Model.Stock);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(763, 277);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lostRadioButton
            // 
            this.lostRadioButton.AutoSize = true;
            this.lostRadioButton.Location = new System.Drawing.Point(607, 236);
            this.lostRadioButton.Name = "lostRadioButton";
            this.lostRadioButton.Size = new System.Drawing.Size(45, 17);
            this.lostRadioButton.TabIndex = 4;
            this.lostRadioButton.TabStop = true;
            this.lostRadioButton.Text = "Lost";
            this.lostRadioButton.UseVisualStyleBackColor = true;
            this.lostRadioButton.CheckedChanged += new System.EventHandler(this.lostRadioButton_CheckedChanged);
            // 
            // damageRadioButton
            // 
            this.damageRadioButton.AutoSize = true;
            this.damageRadioButton.Location = new System.Drawing.Point(443, 236);
            this.damageRadioButton.Name = "damageRadioButton";
            this.damageRadioButton.Size = new System.Drawing.Size(71, 17);
            this.damageRadioButton.TabIndex = 3;
            this.damageRadioButton.TabStop = true;
            this.damageRadioButton.Text = "Damaged";
            this.damageRadioButton.UseVisualStyleBackColor = true;
            this.damageRadioButton.CheckedChanged += new System.EventHandler(this.damageRadioButton_CheckedChanged);
            // 
            // soldRadioButton
            // 
            this.soldRadioButton.AutoSize = true;
            this.soldRadioButton.Location = new System.Drawing.Point(288, 236);
            this.soldRadioButton.Name = "soldRadioButton";
            this.soldRadioButton.Size = new System.Drawing.Size(46, 17);
            this.soldRadioButton.TabIndex = 2;
            this.soldRadioButton.TabStop = true;
            this.soldRadioButton.Text = "Sold";
            this.soldRadioButton.UseVisualStyleBackColor = true;
            this.soldRadioButton.CheckedChanged += new System.EventHandler(this.soldRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From Date";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(371, 174);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.toDateTimePicker.TabIndex = 1;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(371, 108);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.fromDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Between Two Dates Report";
            // 
            // ExportPdfButton
            // 
            this.ExportPdfButton.Location = new System.Drawing.Point(865, 320);
            this.ExportPdfButton.Name = "ExportPdfButton";
            this.ExportPdfButton.Size = new System.Drawing.Size(75, 23);
            this.ExportPdfButton.TabIndex = 6;
            this.ExportPdfButton.Text = "Export Pdf";
            this.ExportPdfButton.UseVisualStyleBackColor = true;
            this.ExportPdfButton.Click += new System.EventHandler(this.ExportPdfButton_Click);
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 551);
            this.ControlBox = false;
            this.Controls.Add(this.ExportPdfButton);
            this.Controls.Add(this.stockReportDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.lostRadioButton);
            this.Controls.Add(this.damageRadioButton);
            this.Controls.Add(this.soldRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(235, 135);
            this.Name = "StockReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StockReportForm";
            this.Load += new System.EventHandler(this.StockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockReportDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton lostRadioButton;
        private System.Windows.Forms.RadioButton damageRadioButton;
        private System.Windows.Forms.RadioButton soldRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportPdfButton;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}