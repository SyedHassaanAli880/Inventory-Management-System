
namespace inv
{
    partial class Sales_Invoice_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_sales = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.sales_details_dataGridView = new System.Windows.Forms.DataGridView();
            this.saleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountReturnedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.top_left_panel.SuspendLayout();
            this.center_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_details_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.loadButton);
            this.left_panel.Controls.Add(this.date_label);
            this.left_panel.Controls.Add(this.dateTimePicker_sales);
            this.left_panel.Size = new System.Drawing.Size(404, 817);
            this.left_panel.Controls.SetChildIndex(this.top_left_panel, 0);
            this.left_panel.Controls.SetChildIndex(this.dateTimePicker_sales, 0);
            this.left_panel.Controls.SetChildIndex(this.date_label, 0);
            this.left_panel.Controls.SetChildIndex(this.loadButton, 0);
            // 
            // top_panel
            // 
            this.top_panel.Size = new System.Drawing.Size(1063, 92);
            // 
            // center_panel
            // 
            this.center_panel.Controls.Add(this.sales_details_dataGridView);
            this.center_panel.Size = new System.Drawing.Size(1063, 725);
            // 
            // dateTimePicker_sales
            // 
            this.dateTimePicker_sales.Location = new System.Drawing.Point(3, 145);
            this.dateTimePicker_sales.Name = "dateTimePicker_sales";
            this.dateTimePicker_sales.Size = new System.Drawing.Size(389, 27);
            this.dateTimePicker_sales.TabIndex = 13;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(3, 122);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(93, 20);
            this.date_label.TabIndex = 17;
            this.date_label.Text = "Select date :";
            // 
            // loadButton
            // 
            this.loadButton.FlatAppearance.BorderSize = 2;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(3, 179);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(389, 52);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "&LOAD";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // sales_details_dataGridView
            // 
            this.sales_details_dataGridView.AllowUserToAddRows = false;
            this.sales_details_dataGridView.AllowUserToDeleteRows = false;
            this.sales_details_dataGridView.AllowUserToResizeColumns = false;
            this.sales_details_dataGridView.AllowUserToResizeRows = false;
            this.sales_details_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sales_details_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sales_details_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sales_details_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sales_details_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_details_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDGV,
            this.TotalAmountGV,
            this.AmountGivenGV,
            this.AmountReturnedGV,
            this.UserGV,
            this.TotalDiscountGV,
            this.UserIDGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sales_details_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.sales_details_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sales_details_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.sales_details_dataGridView.Name = "sales_details_dataGridView";
            this.sales_details_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sales_details_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sales_details_dataGridView.RowHeadersVisible = false;
            this.sales_details_dataGridView.RowHeadersWidth = 51;
            this.sales_details_dataGridView.RowTemplate.Height = 24;
            this.sales_details_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales_details_dataGridView.Size = new System.Drawing.Size(1063, 725);
            this.sales_details_dataGridView.TabIndex = 5;
            this.sales_details_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sales_details_dataGridView_CellDoubleClick);
            // 
            // saleIDGV
            // 
            this.saleIDGV.HeaderText = "Sale ID";
            this.saleIDGV.MinimumWidth = 6;
            this.saleIDGV.Name = "saleIDGV";
            this.saleIDGV.ReadOnly = true;
            // 
            // TotalAmountGV
            // 
            this.TotalAmountGV.HeaderText = "Total Amount";
            this.TotalAmountGV.MinimumWidth = 6;
            this.TotalAmountGV.Name = "TotalAmountGV";
            this.TotalAmountGV.ReadOnly = true;
            // 
            // AmountGivenGV
            // 
            this.AmountGivenGV.HeaderText = "Amount Given";
            this.AmountGivenGV.MinimumWidth = 6;
            this.AmountGivenGV.Name = "AmountGivenGV";
            this.AmountGivenGV.ReadOnly = true;
            // 
            // AmountReturnedGV
            // 
            this.AmountReturnedGV.HeaderText = "Amount Returned";
            this.AmountReturnedGV.MinimumWidth = 6;
            this.AmountReturnedGV.Name = "AmountReturnedGV";
            this.AmountReturnedGV.ReadOnly = true;
            // 
            // UserGV
            // 
            this.UserGV.HeaderText = "User";
            this.UserGV.MinimumWidth = 6;
            this.UserGV.Name = "UserGV";
            this.UserGV.ReadOnly = true;
            // 
            // TotalDiscountGV
            // 
            this.TotalDiscountGV.HeaderText = "Total Discount";
            this.TotalDiscountGV.MinimumWidth = 6;
            this.TotalDiscountGV.Name = "TotalDiscountGV";
            this.TotalDiscountGV.ReadOnly = true;
            // 
            // UserIDGV
            // 
            this.UserIDGV.HeaderText = "User ID";
            this.UserIDGV.MinimumWidth = 6;
            this.UserIDGV.Name = "UserIDGV";
            this.UserIDGV.ReadOnly = true;
            // 
            // Sales_Invoice_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 817);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Sales_Invoice_Details";
            this.Text = "Sales_Invoice_Details";
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.top_left_panel.ResumeLayout(false);
            this.top_left_panel.PerformLayout();
            this.center_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sales_details_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_sales;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView sales_details_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountReturnedGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDGV;
    }
}