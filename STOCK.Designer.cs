namespace inv
{
    partial class STOCK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stocks_dataGridView = new System.Windows.Forms.DataGridView();
            this.search_stock_textBox = new System.Windows.Forms.TextBox();
            this.search_products_label = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.total_records_label = new System.Windows.Forms.Label();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productbarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productbuyingpriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availablestockGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left_panel.SuspendLayout();
            this.left_top_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocks_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(234, 742);
            // 
            // left_top_panel
            // 
            this.left_top_panel.Size = new System.Drawing.Size(234, 102);
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.total_records_label);
            this.top_panel.Controls.Add(this.refresh_button);
            this.top_panel.Controls.Add(this.search_products_label);
            this.top_panel.Controls.Add(this.search_stock_textBox);
            this.top_panel.Location = new System.Drawing.Point(234, 0);
            this.top_panel.Size = new System.Drawing.Size(1553, 102);
            this.top_panel.Controls.SetChildIndex(this.user_label, 0);
            this.top_panel.Controls.SetChildIndex(this.search_stock_textBox, 0);
            this.top_panel.Controls.SetChildIndex(this.search_products_label, 0);
            this.top_panel.Controls.SetChildIndex(this.refresh_button, 0);
            this.top_panel.Controls.SetChildIndex(this.total_records_label, 0);
            // 
            // welcome_label
            // 
            this.welcome_label.Location = new System.Drawing.Point(103, 28);
            // 
            // user_label
            // 
            this.user_label.Location = new System.Drawing.Point(7, 28);
            // 
            // stocks_dataGridView
            // 
            this.stocks_dataGridView.AllowUserToAddRows = false;
            this.stocks_dataGridView.AllowUserToDeleteRows = false;
            this.stocks_dataGridView.AllowUserToResizeColumns = false;
            this.stocks_dataGridView.AllowUserToResizeRows = false;
            this.stocks_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocks_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.stocks_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stocks_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stocks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocks_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.productidGV,
            this.productnameGV,
            this.productbarcodeGV,
            this.PerUnitPriceGV,
            this.productbuyingpriceGV,
            this.BuyingDateGV,
            this.expirydateGV,
            this.productcategoryGV,
            this.availablestockGV,
            this.statusGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stocks_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.stocks_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocks_dataGridView.Location = new System.Drawing.Point(234, 102);
            this.stocks_dataGridView.Name = "stocks_dataGridView";
            this.stocks_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stocks_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stocks_dataGridView.RowHeadersVisible = false;
            this.stocks_dataGridView.RowHeadersWidth = 51;
            this.stocks_dataGridView.RowTemplate.Height = 24;
            this.stocks_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stocks_dataGridView.Size = new System.Drawing.Size(1553, 640);
            this.stocks_dataGridView.TabIndex = 3;
            this.stocks_dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.stocks_dataGridView_RowPostPaint);
            // 
            // search_stock_textBox
            // 
            this.search_stock_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.search_stock_textBox.ForeColor = System.Drawing.Color.DarkGray;
            this.search_stock_textBox.Location = new System.Drawing.Point(626, 34);
            this.search_stock_textBox.Name = "search_stock_textBox";
            this.search_stock_textBox.Size = new System.Drawing.Size(563, 30);
            this.search_stock_textBox.TabIndex = 1;
            this.search_stock_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search_products_label
            // 
            this.search_products_label.AutoSize = true;
            this.search_products_label.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_products_label.Location = new System.Drawing.Point(441, 32);
            this.search_products_label.Name = "search_products_label";
            this.search_products_label.Size = new System.Drawing.Size(167, 28);
            this.search_products_label.TabIndex = 2;
            this.search_products_label.Text = "Search products:";
            // 
            // refresh_button
            // 
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.refresh_button.Location = new System.Drawing.Point(1217, 32);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(121, 37);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.Text = "REFRESH";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // total_records_label
            // 
            this.total_records_label.AutoSize = true;
            this.total_records_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.total_records_label.Location = new System.Drawing.Point(1354, 34);
            this.total_records_label.Name = "total_records_label";
            this.total_records_label.Size = new System.Drawing.Size(163, 28);
            this.total_records_label.TabIndex = 4;
            this.total_records_label.Text = "Total Records: 0";
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.MinimumWidth = 6;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 45;
            // 
            // productidGV
            // 
            this.productidGV.HeaderText = "Product ID";
            this.productidGV.MinimumWidth = 6;
            this.productidGV.Name = "productidGV";
            this.productidGV.ReadOnly = true;
            this.productidGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productidGV.Visible = false;
            // 
            // productnameGV
            // 
            this.productnameGV.HeaderText = "Name";
            this.productnameGV.MinimumWidth = 6;
            this.productnameGV.Name = "productnameGV";
            this.productnameGV.ReadOnly = true;
            this.productnameGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productbarcodeGV
            // 
            this.productbarcodeGV.HeaderText = "Barcode";
            this.productbarcodeGV.MinimumWidth = 6;
            this.productbarcodeGV.Name = "productbarcodeGV";
            this.productbarcodeGV.ReadOnly = true;
            this.productbarcodeGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PerUnitPriceGV
            // 
            this.PerUnitPriceGV.HeaderText = "Per Unit Price";
            this.PerUnitPriceGV.MinimumWidth = 6;
            this.PerUnitPriceGV.Name = "PerUnitPriceGV";
            this.PerUnitPriceGV.ReadOnly = true;
            // 
            // productbuyingpriceGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productbuyingpriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.productbuyingpriceGV.HeaderText = "Total Buying Price";
            this.productbuyingpriceGV.MinimumWidth = 6;
            this.productbuyingpriceGV.Name = "productbuyingpriceGV";
            this.productbuyingpriceGV.ReadOnly = true;
            this.productbuyingpriceGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BuyingDateGV
            // 
            this.BuyingDateGV.HeaderText = "Buying Date";
            this.BuyingDateGV.MinimumWidth = 6;
            this.BuyingDateGV.Name = "BuyingDateGV";
            this.BuyingDateGV.ReadOnly = true;
            // 
            // expirydateGV
            // 
            this.expirydateGV.HeaderText = "Expiry Date";
            this.expirydateGV.MinimumWidth = 6;
            this.expirydateGV.Name = "expirydateGV";
            this.expirydateGV.ReadOnly = true;
            this.expirydateGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productcategoryGV
            // 
            this.productcategoryGV.HeaderText = "Category";
            this.productcategoryGV.MinimumWidth = 6;
            this.productcategoryGV.Name = "productcategoryGV";
            this.productcategoryGV.ReadOnly = true;
            this.productcategoryGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // availablestockGV
            // 
            this.availablestockGV.HeaderText = "Available Stock";
            this.availablestockGV.MinimumWidth = 6;
            this.availablestockGV.Name = "availablestockGV";
            this.availablestockGV.ReadOnly = true;
            this.availablestockGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            this.statusGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // STOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 742);
            this.Controls.Add(this.stocks_dataGridView);
            this.Name = "STOCK";
            this.Text = "STOCK";
            this.Load += new System.EventHandler(this.STOCK_Load);
            this.Controls.SetChildIndex(this.left_panel, 0);
            this.Controls.SetChildIndex(this.top_panel, 0);
            this.Controls.SetChildIndex(this.stocks_dataGridView, 0);
            this.left_panel.ResumeLayout(false);
            this.left_top_panel.ResumeLayout(false);
            this.left_top_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocks_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stocks_dataGridView;
        private System.Windows.Forms.TextBox search_stock_textBox;
        private System.Windows.Forms.Label search_products_label;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Label total_records_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productbarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productbuyingpriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcategoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn availablestockGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}