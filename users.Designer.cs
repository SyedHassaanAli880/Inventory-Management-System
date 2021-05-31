namespace inv
{
    partial class users
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
            this.name_label = new System.Windows.Forms.Label();
            this.phone_number_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.phone_number_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.status_label = new System.Windows.Forms.Label();
            this.users_dataGridView = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_textBox = new System.Windows.Forms.TextBox();
            this.role_label = new System.Windows.Forms.Label();
            this.not_found_label = new System.Windows.Forms.Label();
            this.left_panel_sample2.SuspendLayout();
            this.top_left_panel_sample2.SuspendLayout();
            this.top_panel_sample2.SuspendLayout();
            this.middle_panel_sample2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel_sample2
            // 
            this.left_panel_sample2.Controls.Add(this.role_textBox);
            this.left_panel_sample2.Controls.Add(this.role_label);
            this.left_panel_sample2.Controls.Add(this.status_label);
            this.left_panel_sample2.Controls.Add(this.status_comboBox);
            this.left_panel_sample2.Controls.Add(this.email_textBox);
            this.left_panel_sample2.Controls.Add(this.password_textBox);
            this.left_panel_sample2.Controls.Add(this.phone_number_textBox);
            this.left_panel_sample2.Controls.Add(this.name_textBox);
            this.left_panel_sample2.Controls.Add(this.email_label);
            this.left_panel_sample2.Controls.Add(this.phone_number_label);
            this.left_panel_sample2.Controls.Add(this.password_label);
            this.left_panel_sample2.Controls.Add(this.name_label);
            this.left_panel_sample2.Size = new System.Drawing.Size(400, 757);
            this.left_panel_sample2.Controls.SetChildIndex(this.top_left_panel_sample2, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.name_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.password_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.phone_number_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.email_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.name_textBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.phone_number_textBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.password_textBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.email_textBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.status_comboBox, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.status_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.role_label, 0);
            this.left_panel_sample2.Controls.SetChildIndex(this.role_textBox, 0);
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
            this.middle_panel_sample2.Controls.Add(this.not_found_label);
            this.middle_panel_sample2.Controls.Add(this.users_dataGridView);
            this.middle_panel_sample2.Location = new System.Drawing.Point(400, 84);
            this.middle_panel_sample2.Size = new System.Drawing.Size(971, 673);
            this.middle_panel_sample2.Controls.SetChildIndex(this.users_dataGridView, 0);
            this.middle_panel_sample2.Controls.SetChildIndex(this.not_found_label, 0);
            // 
            // search_textBox
            // 
            this.search_textBox.Size = new System.Drawing.Size(131, 23);
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged_1);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(3, 192);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(59, 20);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name :";
            // 
            // phone_number_label
            // 
            this.phone_number_label.AutoSize = true;
            this.phone_number_label.Location = new System.Drawing.Point(3, 399);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(234, 20);
            this.phone_number_label.TabIndex = 6;
            this.phone_number_label.Text = "Phonenumber(03XXX-XXXXXX)";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(3, 332);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(84, 20);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password :";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(3, 262);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(55, 20);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Email :";
            // 
            // name_textBox
            // 
            this.name_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.name_textBox.Location = new System.Drawing.Point(7, 215);
            this.name_textBox.MaxLength = 40;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(389, 27);
            this.name_textBox.TabIndex = 8;
            // 
            // phone_number_textBox
            // 
            this.phone_number_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.phone_number_textBox.Location = new System.Drawing.Point(7, 422);
            this.phone_number_textBox.MaxLength = 11;
            this.phone_number_textBox.Name = "phone_number_textBox";
            this.phone_number_textBox.Size = new System.Drawing.Size(389, 27);
            this.phone_number_textBox.TabIndex = 10;
            // 
            // password_textBox
            // 
            this.password_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.password_textBox.Location = new System.Drawing.Point(7, 355);
            this.password_textBox.MaxLength = 40;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(389, 27);
            this.password_textBox.TabIndex = 11;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // email_textBox
            // 
            this.email_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.email_textBox.Location = new System.Drawing.Point(7, 285);
            this.email_textBox.MaxLength = 40;
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(389, 27);
            this.email_textBox.TabIndex = 12;
            // 
            // status_comboBox
            // 
            this.status_comboBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.status_comboBox.Location = new System.Drawing.Point(7, 495);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(389, 28);
            this.status_comboBox.TabIndex = 13;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(3, 472);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(61, 20);
            this.status_label.TabIndex = 14;
            this.status_label.Text = "Status :";
            // 
            // users_dataGridView
            // 
            this.users_dataGridView.AllowUserToAddRows = false;
            this.users_dataGridView.AllowUserToDeleteRows = false;
            this.users_dataGridView.AllowUserToResizeColumns = false;
            this.users_dataGridView.AllowUserToResizeRows = false;
            this.users_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.users_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.useridGV,
            this.nameGV,
            this.emailGV,
            this.passwordGV,
            this.phonenumberGV,
            this.statusGV,
            this.roleGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.users_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.users_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_dataGridView.Location = new System.Drawing.Point(0, 55);
            this.users_dataGridView.Name = "users_dataGridView";
            this.users_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.users_dataGridView.RowHeadersVisible = false;
            this.users_dataGridView.RowHeadersWidth = 51;
            this.users_dataGridView.RowTemplate.Height = 24;
            this.users_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.users_dataGridView.Size = new System.Drawing.Size(971, 618);
            this.users_dataGridView.TabIndex = 1;
            this.users_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dataGridView_CellClick);
            this.users_dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.users_dataGridView_RowPostPaint);
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
            // useridGV
            // 
            this.useridGV.HeaderText = "UserID";
            this.useridGV.MinimumWidth = 6;
            this.useridGV.Name = "useridGV";
            this.useridGV.ReadOnly = true;
            this.useridGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Name";
            this.nameGV.MinimumWidth = 6;
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            this.nameGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emailGV
            // 
            this.emailGV.HeaderText = "Email";
            this.emailGV.MinimumWidth = 6;
            this.emailGV.Name = "emailGV";
            this.emailGV.ReadOnly = true;
            // 
            // passwordGV
            // 
            this.passwordGV.HeaderText = "Password";
            this.passwordGV.MinimumWidth = 6;
            this.passwordGV.Name = "passwordGV";
            this.passwordGV.ReadOnly = true;
            this.passwordGV.Visible = false;
            // 
            // phonenumberGV
            // 
            this.phonenumberGV.HeaderText = "Phone#";
            this.phonenumberGV.MinimumWidth = 6;
            this.phonenumberGV.Name = "phonenumberGV";
            this.phonenumberGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // roleGV
            // 
            this.roleGV.HeaderText = "Role";
            this.roleGV.MinimumWidth = 6;
            this.roleGV.Name = "roleGV";
            this.roleGV.ReadOnly = true;
            // 
            // role_textBox
            // 
            this.role_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.role_textBox.Location = new System.Drawing.Point(7, 566);
            this.role_textBox.MaxLength = 40;
            this.role_textBox.Name = "role_textBox";
            this.role_textBox.Size = new System.Drawing.Size(389, 27);
            this.role_textBox.TabIndex = 16;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(3, 547);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(48, 20);
            this.role_label.TabIndex = 15;
            this.role_label.Text = "Role :";
            // 
            // not_found_label
            // 
            this.not_found_label.AutoSize = true;
            this.not_found_label.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold);
            this.not_found_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.not_found_label.Location = new System.Drawing.Point(573, 263);
            this.not_found_label.Name = "not_found_label";
            this.not_found_label.Size = new System.Drawing.Size(298, 46);
            this.not_found_label.TabIndex = 2;
            this.not_found_label.Text = "No record found!";
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 757);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "users";
            this.Text = "USERS";
            this.Load += new System.EventHandler(this.users_Load);
            this.left_panel_sample2.ResumeLayout(false);
            this.left_panel_sample2.PerformLayout();
            this.top_left_panel_sample2.ResumeLayout(false);
            this.top_left_panel_sample2.PerformLayout();
            this.top_panel_sample2.ResumeLayout(false);
            this.top_panel_sample2.PerformLayout();
            this.middle_panel_sample2.ResumeLayout(false);
            this.middle_panel_sample2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_number_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox phone_number_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.DataGridView users_dataGridView;
        private System.Windows.Forms.TextBox role_textBox;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleGV;
        private System.Windows.Forms.Label not_found_label;
    }
}