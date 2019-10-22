namespace StockManagementWinApp
{
    partial class StockInForm
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
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.stockInTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.availableQtyTextBox = new System.Windows.Forms.TextBox();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.hiddenIdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.prevQtyTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.itemBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(419, 35);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(179, 21);
            this.companyComboBox.TabIndex = 0;
            this.companyComboBox.ValueMember = "CompanyId";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged_1);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementWinApp.Model.Item);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.itemBindingSource;
            this.categoryComboBox.DisplayMember = "CategoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(419, 75);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(179, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "CategoryId";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged_1);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "ItemName";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(419, 112);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(179, 21);
            this.itemComboBox.TabIndex = 2;
            this.itemComboBox.ValueMember = "Id";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // stockInTextBox
            // 
            this.stockInTextBox.Location = new System.Drawing.Point(419, 230);
            this.stockInTextBox.Name = "stockInTextBox";
            this.stockInTextBox.Size = new System.Drawing.Size(179, 20);
            this.stockInTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(631, 228);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.dataGridViewTextBoxColumn2,
            this.StockDate,
            this.Quantity,
            this.Action,
            this.StockId});
            this.itemDataGridView.DataSource = this.stockBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(74, 269);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.Size = new System.Drawing.Size(857, 244);
            this.itemDataGridView.TabIndex = 6;
            this.itemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellContentClick);
            this.itemDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.itemDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.DataPropertyName = "Id";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // StockDate
            // 
            this.StockDate.DataPropertyName = "StockDate";
            this.StockDate.HeaderText = "Date";
            this.StockDate.Name = "StockDate";
            this.StockDate.ReadOnly = true;
            this.StockDate.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Id";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // StockId
            // 
            this.StockId.DataPropertyName = "StockId";
            this.StockId.HeaderText = "StockId";
            this.StockId.Name = "StockId";
            this.StockId.ReadOnly = true;
            this.StockId.Visible = false;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(StockManagementWinApp.Model.Stock);
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(419, 150);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.ReadOnly = true;
            this.reorderTextBox.Size = new System.Drawing.Size(179, 20);
            this.reorderTextBox.TabIndex = 3;
            // 
            // availableQtyTextBox
            // 
            this.availableQtyTextBox.Location = new System.Drawing.Point(419, 187);
            this.availableQtyTextBox.Name = "availableQtyTextBox";
            this.availableQtyTextBox.ReadOnly = true;
            this.availableQtyTextBox.Size = new System.Drawing.Size(179, 20);
            this.availableQtyTextBox.TabIndex = 4;
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(475, 211);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(0, 13);
            this.SaveLabel.TabIndex = 7;
            // 
            // hiddenIdLabel
            // 
            this.hiddenIdLabel.AutoSize = true;
            this.hiddenIdLabel.Location = new System.Drawing.Point(498, 60);
            this.hiddenIdLabel.Name = "hiddenIdLabel";
            this.hiddenIdLabel.Size = new System.Drawing.Size(0, 13);
            this.hiddenIdLabel.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(725, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 9;
            this.idTextBox.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(419, 13);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "label4";
            // 
            // prevQtyTextBox
            // 
            this.prevQtyTextBox.Location = new System.Drawing.Point(725, 60);
            this.prevQtyTextBox.Name = "prevQtyTextBox";
            this.prevQtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.prevQtyTextBox.TabIndex = 11;
            this.prevQtyTextBox.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(712, 228);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock Out Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Available Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Reorder Level";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(337, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(334, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Company";
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 551);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.prevQtyTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.hiddenIdLabel);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.availableQtyTextBox);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.stockInTextBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.companyComboBox);
            this.Location = new System.Drawing.Point(235, 135);
            this.Name = "StockInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.StockInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.TextBox stockInTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.TextBox availableQtyTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Label hiddenIdLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox prevQtyTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockId;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}