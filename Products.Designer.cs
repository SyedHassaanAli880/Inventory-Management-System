namespace inv
{
    partial class Products
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
            this.barcode_textBox = new System.Windows.Forms.TextBox();
            this.product_name_textBox = new System.Windows.Forms.TextBox();
            this.barcode_label = new System.Windows.Forms.Label();
            this.product_name_label = new System.Windows.Forms.Label();
            this.dateTimePicker_expiry_products = new System.Windows.Forms.DateTimePicker();
            this.expiry_date_label = new System.Windows.Forms.Label();
            this.categories_comboBox = new System.Windows.Forms.ComboBox();
            this.categories_label = new System.Windows.Forms.Label();
            this.products_dataGridView = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productbarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left_panel_sample2.SuspendLayout();
            this.top_left_panel_sample2.SuspendLayout();
            this.top_panel_sample2.SuspendLayout();
            this.middle_panel_sample2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel_sample2
            // 
            this.left_panel_sample2.Controls.Add(this.categories_label);
            this.left_panel_sample2.Controls.Add(this.categories_comboBox);
            this.left_panel_sample2.Controls.Add(this.expiry_date_label);
            this.left_panel_sample2.Controls.Add(this.dateTimePicker_expiry_products);
            this.left_panel_sample2.Controls.Add(this.barcode_textBox);
            this.left_panel_sample2.Controls.Add(this.product_name_textBox);
            this.left_panel_sample2.Controls.Add(this.barcode_label);
            this.left_panel_sample2.Controls.Add(this.product_name_label);
            this.left_panel_sample2.Size = new System.Drawing.Size(400, 757);
            this.left_panel_sample2.Controls.SetChildIndex(this.top_left_panel_sample2, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.product_name_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.barcode_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.product_name_textBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.barcode_textBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.dateTimePicker_expiry_products, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.expiry_date_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.categories_comboBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.categories_label, 0);
            // 
            // top_left_panel_sample2
            // 
            this.top_left_panel_sample2.Size = new System.Drawing.Size(400, 84);
            // 
            // top_panel_sample2
            // 
            this.top_panel_sample2.Location = new System.Drawing.Point(400, 0);
            this.top_panel_sample2.Size = new System.Drawing.Size(1205, 84);
            // 
            // middle_panel_sample2
            // 
            this.middle_panel_sample2.Controls.Add(this.products_dataGridView);
            this.middle_panel_sample2.Location = new System.Drawing.Point(400, 84);
            this.middle_panel_sample2.Size = new System.Drawing.Size(1205, 673);
            this.middle_panel_sample2.Controls.SetChildIndex(this.products_dataGridView, 0);
            // 
            // search_textBox
            // 
            this.search_textBox.Size = new System.Drawing.Size(161, 23);
            // 
            // barcode_textBox
            // 
            this.barcode_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.barcode_textBox.Location = new System.Drawing.Point(8, 262);
            this.barcode_textBox.MaxLength = 40;
            this.barcode_textBox.Name = "barcode_textBox";
            this.barcode_textBox.Size = new System.Drawing.Size(389, 27);
            this.barcode_textBox.TabIndex = 10;
            // 
            // product_name_textBox
            // 
            this.product_name_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.product_name_textBox.Location = new System.Drawing.Point(8, 203);
            this.product_name_textBox.MaxLength = 40;
            this.product_name_textBox.Name = "product_name_textBox";
            this.product_name_textBox.Size = new System.Drawing.Size(389, 27);
            this.product_name_textBox.TabIndex = 9;
            // 
            // barcode_label
            // 
            this.barcode_label.AutoSize = true;
            this.barcode_label.Location = new System.Drawing.Point(3, 239);
            this.barcode_label.Name = "barcode_label";
            this.barcode_label.Size = new System.Drawing.Size(74, 20);
            this.barcode_label.TabIndex = 11;
            this.barcode_label.Text = "Barcode :";
            // 
            // product_name_label
            // 
            this.product_name_label.AutoSize = true;
            this.product_name_label.Location = new System.Drawing.Point(3, 180);
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(118, 20);
            this.product_name_label.TabIndex = 10;
            this.product_name_label.Text = "Product Name :";
            // 
            // dateTimePicker_expiry_products
            // 
            this.dateTimePicker_expiry_products.Location = new System.Drawing.Point(7, 318);
            this.dateTimePicker_expiry_products.Name = "dateTimePicker_expiry_products";
            this.dateTimePicker_expiry_products.Size = new System.Drawing.Size(389, 27);
            this.dateTimePicker_expiry_products.TabIndex = 12;
            // 
            // expiry_date_label
            // 
            this.expiry_date_label.AutoSize = true;
            this.expiry_date_label.Location = new System.Drawing.Point(3, 295);
            this.expiry_date_label.Name = "expiry_date_label";
            this.expiry_date_label.Size = new System.Drawing.Size(98, 20);
            this.expiry_date_label.TabIndex = 16;
            this.expiry_date_label.Text = "Expiry Date :";
            // 
            // categories_comboBox
            // 
            this.categories_comboBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.categories_comboBox.FormattingEnabled = true;
            this.categories_comboBox.Location = new System.Drawing.Point(7, 377);
            this.categories_comboBox.MaxLength = 40;
            this.categories_comboBox.Name = "categories_comboBox";
            this.categories_comboBox.Size = new System.Drawing.Size(389, 28);
            this.categories_comboBox.TabIndex = 13;
            // 
            // categories_label
            // 
            this.categories_label.AutoSize = true;
            this.categories_label.Location = new System.Drawing.Point(3, 354);
            this.categories_label.Name = "categories_label";
            this.categories_label.Size = new System.Drawing.Size(91, 20);
            this.categories_label.TabIndex = 18;
            this.categories_label.Text = "Categories :";
            // 
            // products_dataGridView
            // 
            this.products_dataGridView.AllowUserToAddRows = false;
            this.products_dataGridView.AllowUserToDeleteRows = false;
            this.products_dataGridView.AllowUserToResizeColumns = false;
            this.products_dataGridView.AllowUserToResizeRows = false;
            this.products_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.products_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.products_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.products_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.productidGV,
            this.productnameGV,
            this.productbarcodeGV,
            this.expirydateGV,
            this.categoryIDGV,
            this.productcategoryGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.products_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.products_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products_dataGridView.GridColor = System.Drawing.Color.ForestGreen;
            this.products_dataGridView.Location = new System.Drawing.Point(0, 55);
            this.products_dataGridView.Name = "products_dataGridView";
            this.products_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.products_dataGridView.RowHeadersVisible = false;
            this.products_dataGridView.RowHeadersWidth = 51;
            this.products_dataGridView.RowTemplate.Height = 24;
            this.products_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_dataGridView.Size = new System.Drawing.Size(1205, 618);
            this.products_dataGridView.TabIndex = 2;
            this.products_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_dataGridView_CellClick_1);
            this.products_dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.products_dataGridView_RowPostPaint);
            // 
            // sno
            // 
            this.sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sno.HeaderText = "#";
            this.sno.MinimumWidth = 2;
            this.sno.Name = "sno";
            this.sno.ReadOnly = true;
            this.sno.Width = 45;
            // 
            // productidGV
            // 
            this.productidGV.HeaderText = "ProductID";
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
            // expirydateGV
            // 
            this.expirydateGV.HeaderText = "Expiry Date";
            this.expirydateGV.MinimumWidth = 6;
            this.expirydateGV.Name = "expirydateGV";
            this.expirydateGV.ReadOnly = true;
            this.expirydateGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // categoryIDGV
            // 
            this.categoryIDGV.HeaderText = "CategoryID";
            this.categoryIDGV.MinimumWidth = 6;
            this.categoryIDGV.Name = "categoryIDGV";
            this.categoryIDGV.ReadOnly = true;
            this.categoryIDGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryIDGV.Visible = false;
            // 
            // productcategoryGV
            // 
            this.productcategoryGV.HeaderText = "Product Category";
            this.productcategoryGV.MinimumWidth = 6;
            this.productcategoryGV.Name = "productcategoryGV";
            this.productcategoryGV.ReadOnly = true;
            this.productcategoryGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 757);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Products";
            this.Text = "PRODUCTS";
            this.Load += new System.EventHandler(this.Products_Load);
            this.left_panel_sample2.ResumeLayout(false);
            this.left_panel_sample2.PerformLayout();
            this.top_left_panel_sample2.ResumeLayout(false);
            this.top_left_panel_sample2.PerformLayout();
            this.top_panel_sample2.ResumeLayout(false);
            this.top_panel_sample2.PerformLayout();
            this.middle_panel_sample2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox barcode_textBox;
        private System.Windows.Forms.TextBox product_name_textBox;
        private System.Windows.Forms.Label barcode_label;
        private System.Windows.Forms.Label product_name_label;
        private System.Windows.Forms.Label expiry_date_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker_expiry_products;
        private System.Windows.Forms.Label categories_label;
        private System.Windows.Forms.ComboBox categories_comboBox;
        private System.Windows.Forms.DataGridView products_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productbarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcategoryGV;
    }
}