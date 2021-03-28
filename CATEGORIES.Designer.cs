namespace inv
{
    partial class CATEGORIES
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
            this.category_name_textBox = new System.Windows.Forms.TextBox();
            this.active_label = new System.Windows.Forms.Label();
            this.category_name_label = new System.Windows.Forms.Label();
            this.is_active_category_comboBox = new System.Windows.Forms.ComboBox();
            this.categories_dataGridView = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorystatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left_panel_sample2.SuspendLayout();
            this.top_left_panel_sample2.SuspendLayout();
            this.top_panel_sample2.SuspendLayout();
            this.middle_panel_sample2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categories_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel_sample2
            // 
            this.left_panel_sample2.Controls.Add(this.is_active_category_comboBox);
            this.left_panel_sample2.Controls.Add(this.category_name_textBox);
            this.left_panel_sample2.Controls.Add(this.active_label);
            this.left_panel_sample2.Controls.Add(this.category_name_label);
            this.left_panel_sample2.Size = new System.Drawing.Size(400, 757);
            this.left_panel_sample2.Controls.SetChildIndex(this.top_left_panel_sample2, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.category_name_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.active_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.category_name_textBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.is_active_category_comboBox, 0);
            // 
            // top_left_panel_sample2
            // 
            this.top_left_panel_sample2.Size = new System.Drawing.Size(400, 84);
            // 
            // top_panel_sample2
            // 
            this.top_panel_sample2.Location = new System.Drawing.Point(400, 0);
            this.top_panel_sample2.Size = new System.Drawing.Size(971, 84);
            // 
            // middle_panel_sample2
            // 
            this.middle_panel_sample2.Controls.Add(this.categories_dataGridView);
            this.middle_panel_sample2.Location = new System.Drawing.Point(400, 84);
            this.middle_panel_sample2.Size = new System.Drawing.Size(971, 673);
            this.middle_panel_sample2.Controls.SetChildIndex(this.categories_dataGridView, 0);
            // 
            // search_textBox
            // 
            this.search_textBox.Size = new System.Drawing.Size(131, 23);
            // 
            // category_name_textBox
            // 
            this.category_name_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.category_name_textBox.Location = new System.Drawing.Point(7, 221);
            this.category_name_textBox.MaxLength = 40;
            this.category_name_textBox.Name = "category_name_textBox";
            this.category_name_textBox.Size = new System.Drawing.Size(389, 27);
            this.category_name_textBox.TabIndex = 16;
            // 
            // active_label
            // 
            this.active_label.AutoSize = true;
            this.active_label.Location = new System.Drawing.Point(3, 268);
            this.active_label.Name = "active_label";
            this.active_label.Size = new System.Drawing.Size(77, 20);
            this.active_label.TabIndex = 15;
            this.active_label.Text = "Is Active :";
            // 
            // category_name_label
            // 
            this.category_name_label.AutoSize = true;
            this.category_name_label.Location = new System.Drawing.Point(3, 198);
            this.category_name_label.Name = "category_name_label";
            this.category_name_label.Size = new System.Drawing.Size(127, 20);
            this.category_name_label.TabIndex = 14;
            this.category_name_label.Text = "Category Name :";
            // 
            // is_active_category_comboBox
            // 
            this.is_active_category_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.is_active_category_comboBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.is_active_category_comboBox.FormattingEnabled = true;
            this.is_active_category_comboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.is_active_category_comboBox.Location = new System.Drawing.Point(7, 291);
            this.is_active_category_comboBox.Name = "is_active_category_comboBox";
            this.is_active_category_comboBox.Size = new System.Drawing.Size(389, 28);
            this.is_active_category_comboBox.TabIndex = 17;
            // 
            // categories_dataGridView
            // 
            this.categories_dataGridView.AllowUserToAddRows = false;
            this.categories_dataGridView.AllowUserToDeleteRows = false;
            this.categories_dataGridView.AllowUserToResizeColumns = false;
            this.categories_dataGridView.AllowUserToResizeRows = false;
            this.categories_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categories_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.categories_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categories_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categories_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categories_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.categoryidGV,
            this.categorynameGV,
            this.categorystatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categories_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categories_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categories_dataGridView.Location = new System.Drawing.Point(0, 55);
            this.categories_dataGridView.Name = "categories_dataGridView";
            this.categories_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categories_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categories_dataGridView.RowHeadersVisible = false;
            this.categories_dataGridView.RowHeadersWidth = 51;
            this.categories_dataGridView.RowTemplate.Height = 24;
            this.categories_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categories_dataGridView.Size = new System.Drawing.Size(971, 618);
            this.categories_dataGridView.TabIndex = 2;
            this.categories_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categories_dataGridView_CellClick);
            this.categories_dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.categories_dataGridView_RowPostPaint);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.Frozen = true;
            this.snoGV.HeaderText = "#";
            this.snoGV.MinimumWidth = 6;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.snoGV.Width = 45;
            // 
            // categoryidGV
            // 
            this.categoryidGV.HeaderText = "categoryID";
            this.categoryidGV.MinimumWidth = 6;
            this.categoryidGV.Name = "categoryidGV";
            this.categoryidGV.ReadOnly = true;
            this.categoryidGV.Visible = false;
            // 
            // categorynameGV
            // 
            this.categorynameGV.FillWeight = 18.4492F;
            this.categorynameGV.HeaderText = "Name";
            this.categorynameGV.MinimumWidth = 6;
            this.categorynameGV.Name = "categorynameGV";
            this.categorynameGV.ReadOnly = true;
            // 
            // categorystatusGV
            // 
            this.categorystatusGV.FillWeight = 18.4492F;
            this.categorystatusGV.HeaderText = "Status";
            this.categorystatusGV.MinimumWidth = 6;
            this.categorystatusGV.Name = "categorystatusGV";
            this.categorystatusGV.ReadOnly = true;
            // 
            // CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 757);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CATEGORIES";
            this.Text = "CATEGORIES";
            this.Load += new System.EventHandler(this.CATEGORIES_Load);
            this.left_panel_sample2.ResumeLayout(false);
            this.left_panel_sample2.PerformLayout();
            this.top_left_panel_sample2.ResumeLayout(false);
            this.top_left_panel_sample2.PerformLayout();
            this.top_panel_sample2.ResumeLayout(false);
            this.top_panel_sample2.PerformLayout();
            this.middle_panel_sample2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categories_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox category_name_textBox;
        private System.Windows.Forms.Label active_label;
        private System.Windows.Forms.Label category_name_label;
        private System.Windows.Forms.ComboBox is_active_category_comboBox;
        private System.Windows.Forms.DataGridView categories_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorystatusGV;
    }
}