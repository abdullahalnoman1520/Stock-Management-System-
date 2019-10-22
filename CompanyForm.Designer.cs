namespace StockManagementWinApp
{
    partial class CompanyForm
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
            this.companyShowDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.updateIdCompanyTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.companyShowDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyShowDataGridView
            // 
            this.companyShowDataGridView.AllowUserToAddRows = false;
            this.companyShowDataGridView.AllowUserToDeleteRows = false;
            this.companyShowDataGridView.AutoGenerateColumns = false;
            this.companyShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.idDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.Action});
            this.companyShowDataGridView.DataSource = this.companyBindingSource;
            this.companyShowDataGridView.Location = new System.Drawing.Point(145, 151);
            this.companyShowDataGridView.Name = "companyShowDataGridView";
            this.companyShowDataGridView.ReadOnly = true;
            this.companyShowDataGridView.Size = new System.Drawing.Size(744, 280);
            this.companyShowDataGridView.TabIndex = 3;
            this.companyShowDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyShowDataGridView_CellContentClick);
            this.companyShowDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.companyShowDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 500;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementWinApp.Model.Company);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(670, 81);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(411, 84);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.companyNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Company Name";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(411, 65);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "label2";
            // 
            // updateIdCompanyTextBox
            // 
            this.updateIdCompanyTextBox.Location = new System.Drawing.Point(49, 31);
            this.updateIdCompanyTextBox.Name = "updateIdCompanyTextBox";
            this.updateIdCompanyTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateIdCompanyTextBox.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(751, 81);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 551);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.updateIdCompanyTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.companyShowDataGridView);
            this.Location = new System.Drawing.Point(235, 135);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyShowDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView companyShowDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.TextBox updateIdCompanyTextBox;
        private System.Windows.Forms.Button CancelButton;
    }
}