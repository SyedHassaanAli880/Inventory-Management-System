namespace inv
{
    partial class Purchase_Invoice_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_invoicedetails = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.select_purchase_invoice_label = new System.Windows.Forms.Label();
            this.purchaseinvoice_comboBox = new System.Windows.Forms.ComboBox();
            this.purchaseinvoice_dataGridView = new System.Windows.Forms.DataGridView();
            this.purchaseinvoiceIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productquantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunitpriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gross_total_price_label = new System.Windows.Forms.Label();
            this.gross_total_label_display = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.left_panel_sample2.SuspendLayout();
            this.top_left_panel_sample2.SuspendLayout();
            this.top_panel_sample2.SuspendLayout();
            this.middle_panel_sample2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseinvoice_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel_sample2
            // 
            this.left_panel_sample2.Controls.Add(this.refresh_button);
            this.left_panel_sample2.Controls.Add(this.gross_total_price_label);
            this.left_panel_sample2.Controls.Add(this.gross_total_label_display);
            this.left_panel_sample2.Controls.Add(this.purchaseinvoice_comboBox);
            this.left_panel_sample2.Controls.Add(this.select_purchase_invoice_label);
            this.left_panel_sample2.Controls.Add(this.label1);
            this.left_panel_sample2.Controls.Add(this.dateTimePicker_invoicedetails);
            this.left_panel_sample2.Size = new System.Drawing.Size(400, 746);
            this.left_panel_sample2.Controls.SetChildIndex(this.top_left_panel_sample2, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.dateTimePicker_invoicedetails, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.label1, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.select_purchase_invoice_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.purchaseinvoice_comboBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.gross_total_label_display, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.gross_total_price_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.refresh_button, 0);
            // 
            // top_left_panel_sample2
            // 
            this.top_left_panel_sample2.Size = new System.Drawing.Size(400, 84);
            // 
            // top_panel_sample2
            // 
            this.top_panel_sample2.Location = new System.Drawing.Point(400, 0);
            this.top_panel_sample2.Size = new System.Drawing.Size(1065, 84);
            // 
            // middle_panel_sample2
            // 
            this.middle_panel_sample2.Controls.Add(this.purchaseinvoice_dataGridView);
            this.middle_panel_sample2.Location = new System.Drawing.Point(400, 84);
            this.middle_panel_sample2.Size = new System.Drawing.Size(1065, 662);
            this.middle_panel_sample2.Controls.SetChildIndex(this.purchaseinvoice_dataGridView, 0);
            // 
            // search_textBox
            // 
            this.search_textBox.Size = new System.Drawing.Size(141, 23);
            // 
            // dateTimePicker_invoicedetails
            // 
            this.dateTimePicker_invoicedetails.CustomFormat = "MMM - yyyy";
            this.dateTimePicker_invoicedetails.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_invoicedetails.Location = new System.Drawing.Point(3, 183);
            this.dateTimePicker_invoicedetails.Name = "dateTimePicker_invoicedetails";
            this.dateTimePicker_invoicedetails.ShowUpDown = true;
            this.dateTimePicker_invoicedetails.Size = new System.Drawing.Size(389, 27);
            this.dateTimePicker_invoicedetails.TabIndex = 3;
            this.dateTimePicker_invoicedetails.ValueChanged += new System.EventHandler(this.dateTimePicker_invoicedetails_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Date :";
            // 
            // select_purchase_invoice_label
            // 
            this.select_purchase_invoice_label.AutoSize = true;
            this.select_purchase_invoice_label.Location = new System.Drawing.Point(3, 231);
            this.select_purchase_invoice_label.Name = "select_purchase_invoice_label";
            this.select_purchase_invoice_label.Size = new System.Drawing.Size(179, 20);
            this.select_purchase_invoice_label.TabIndex = 5;
            this.select_purchase_invoice_label.Text = "Select Purchase Invoice :";
            // 
            // purchaseinvoice_comboBox
            // 
            this.purchaseinvoice_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchaseinvoice_comboBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.purchaseinvoice_comboBox.FormattingEnabled = true;
            this.purchaseinvoice_comboBox.Location = new System.Drawing.Point(3, 254);
            this.purchaseinvoice_comboBox.Name = "purchaseinvoice_comboBox";
            this.purchaseinvoice_comboBox.Size = new System.Drawing.Size(389, 28);
            this.purchaseinvoice_comboBox.TabIndex = 32;
            this.purchaseinvoice_comboBox.SelectedIndexChanged += new System.EventHandler(this.purchaseinvoice_comboBox_SelectedIndexChanged);
            // 
            // purchaseinvoice_dataGridView
            // 
            this.purchaseinvoice_dataGridView.AllowUserToAddRows = false;
            this.purchaseinvoice_dataGridView.AllowUserToDeleteRows = false;
            this.purchaseinvoice_dataGridView.AllowUserToResizeColumns = false;
            this.purchaseinvoice_dataGridView.AllowUserToResizeRows = false;
            this.purchaseinvoice_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseinvoice_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purchaseinvoice_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseinvoice_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseinvoice_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseinvoice_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseinvoiceIDGV,
            this.productIDGV,
            this.productnameGV,
            this.productquantityGV,
            this.perunitpriceGV,
            this.totalGV,
            this.deleteGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseinvoice_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.purchaseinvoice_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseinvoice_dataGridView.Location = new System.Drawing.Point(0, 55);
            this.purchaseinvoice_dataGridView.Name = "purchaseinvoice_dataGridView";
            this.purchaseinvoice_dataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseinvoice_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.purchaseinvoice_dataGridView.RowHeadersVisible = false;
            this.purchaseinvoice_dataGridView.RowHeadersWidth = 51;
            this.purchaseinvoice_dataGridView.RowTemplate.Height = 24;
            this.purchaseinvoice_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseinvoice_dataGridView.Size = new System.Drawing.Size(1065, 607);
            this.purchaseinvoice_dataGridView.TabIndex = 4;
            this.purchaseinvoice_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseinvoice_dataGridView_CellClick);
            // 
            // purchaseinvoiceIDGV
            // 
            this.purchaseinvoiceIDGV.HeaderText = "Purchase Invoice ID";
            this.purchaseinvoiceIDGV.MinimumWidth = 6;
            this.purchaseinvoiceIDGV.Name = "purchaseinvoiceIDGV";
            this.purchaseinvoiceIDGV.ReadOnly = true;
            this.purchaseinvoiceIDGV.Visible = false;
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "Product ID";
            this.productIDGV.MinimumWidth = 6;
            this.productIDGV.Name = "productIDGV";
            this.productIDGV.ReadOnly = true;
            this.productIDGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productIDGV.Visible = false;
            // 
            // productnameGV
            // 
            this.productnameGV.HeaderText = "Product Name";
            this.productnameGV.MinimumWidth = 6;
            this.productnameGV.Name = "productnameGV";
            this.productnameGV.ReadOnly = true;
            this.productnameGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productquantityGV
            // 
            this.productquantityGV.HeaderText = "Product Quantity";
            this.productquantityGV.MinimumWidth = 6;
            this.productquantityGV.Name = "productquantityGV";
            this.productquantityGV.ReadOnly = true;
            this.productquantityGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // perunitpriceGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.perunitpriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.perunitpriceGV.HeaderText = "Per Unit Price";
            this.perunitpriceGV.MinimumWidth = 6;
            this.perunitpriceGV.Name = "perunitpriceGV";
            this.perunitpriceGV.ReadOnly = true;
            this.perunitpriceGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalGV.HeaderText = "Total Amount";
            this.totalGV.MinimumWidth = 6;
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            this.totalGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.MinimumWidth = 6;
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // gross_total_price_label
            // 
            this.gross_total_price_label.AutoSize = true;
            this.gross_total_price_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gross_total_price_label.Location = new System.Drawing.Point(8, 336);
            this.gross_total_price_label.Name = "gross_total_price_label";
            this.gross_total_price_label.Size = new System.Drawing.Size(89, 46);
            this.gross_total_price_label.TabIndex = 35;
            this.gross_total_price_label.Text = "0.00";
            // 
            // gross_total_label_display
            // 
            this.gross_total_label_display.AutoSize = true;
            this.gross_total_label_display.Location = new System.Drawing.Point(9, 303);
            this.gross_total_label_display.Name = "gross_total_label_display";
            this.gross_total_label_display.Size = new System.Drawing.Size(96, 20);
            this.gross_total_label_display.TabIndex = 34;
            this.gross_total_label_display.Text = "Gross Total :";
            // 
            // refresh_button
            // 
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 2;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.ForeColor = System.Drawing.Color.White;
            this.refresh_button.Location = new System.Drawing.Point(3, 463);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(389, 48);
            this.refresh_button.TabIndex = 37;
            this.refresh_button.Text = "&REFRESH INVOICES";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // Purchase_Invoice_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 746);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Purchase_Invoice_Details";
            this.Text = "PURCHASE INVOICE DETAILS";
            this.Load += new System.EventHandler(this.Purchase_Invoice_Details_Load);
            this.left_panel_sample2.ResumeLayout(false);
            this.left_panel_sample2.PerformLayout();
            this.top_left_panel_sample2.ResumeLayout(false);
            this.top_left_panel_sample2.PerformLayout();
            this.top_panel_sample2.ResumeLayout(false);
            this.top_panel_sample2.PerformLayout();
            this.middle_panel_sample2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseinvoice_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_invoicedetails;
        private System.Windows.Forms.Label select_purchase_invoice_label;
        private System.Windows.Forms.ComboBox purchaseinvoice_comboBox;
        private System.Windows.Forms.DataGridView purchaseinvoice_dataGridView;
        private System.Windows.Forms.Label gross_total_price_label;
        private System.Windows.Forms.Label gross_total_label_display;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseinvoiceIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productquantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunitpriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}