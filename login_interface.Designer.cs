namespace inv
{
    partial class login_interface
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
            this.forgot_password_button = new System.Windows.Forms.Button();
            this.change_password_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.admin_radioButton = new System.Windows.Forms.RadioButton();
            this.other_radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.left_panel.SuspendLayout();
            this.left_top_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.other_radioButton);
            this.left_panel.Controls.Add(this.admin_radioButton);
            this.left_panel.Controls.Add(this.forgot_password_button);
            this.left_panel.Controls.Add(this.change_password_button);
            this.left_panel.Controls.Add(this.login_button);
            this.left_panel.Controls.Add(this.password_textBox);
            this.left_panel.Controls.Add(this.username_textBox);
            this.left_panel.Controls.Add(this.password_label);
            this.left_panel.Controls.Add(this.username_label);
            this.left_panel.Size = new System.Drawing.Size(400, 991);
            this.left_panel.Controls.SetChildIndex(this.left_top_panel, 0);
            this.left_panel.Controls.SetChildIndex(this.username_label, 0);
            this.left_panel.Controls.SetChildIndex(this.password_label, 0);
            this.left_panel.Controls.SetChildIndex(this.username_textBox, 0);
            this.left_panel.Controls.SetChildIndex(this.password_textBox, 0);
            this.left_panel.Controls.SetChildIndex(this.login_button, 0);
            this.left_panel.Controls.SetChildIndex(this.change_password_button, 0);
            this.left_panel.Controls.SetChildIndex(this.forgot_password_button, 0);
            this.left_panel.Controls.SetChildIndex(this.admin_radioButton, 0);
            this.left_panel.Controls.SetChildIndex(this.other_radioButton, 0);
            // 
            // left_top_panel
            // 
            this.left_top_panel.Size = new System.Drawing.Size(400, 102);
            // 
            // top_panel
            // 
            this.top_panel.Location = new System.Drawing.Point(400, 0);
            this.top_panel.Size = new System.Drawing.Size(1367, 102);
            // 
            // forgot_password_button
            // 
            this.forgot_password_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_password_button.FlatAppearance.BorderSize = 2;
            this.forgot_password_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgot_password_button.ForeColor = System.Drawing.Color.White;
            this.forgot_password_button.Location = new System.Drawing.Point(7, 492);
            this.forgot_password_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.forgot_password_button.Name = "forgot_password_button";
            this.forgot_password_button.Size = new System.Drawing.Size(389, 38);
            this.forgot_password_button.TabIndex = 14;
            this.forgot_password_button.Text = "FORGOT PASSWORD?";
            this.forgot_password_button.UseVisualStyleBackColor = true;
            this.forgot_password_button.Click += new System.EventHandler(this.forgot_password_button_Click);
            // 
            // change_password_button
            // 
            this.change_password_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_password_button.FlatAppearance.BorderSize = 2;
            this.change_password_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_password_button.ForeColor = System.Drawing.Color.White;
            this.change_password_button.Location = new System.Drawing.Point(7, 446);
            this.change_password_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.change_password_button.Name = "change_password_button";
            this.change_password_button.Size = new System.Drawing.Size(389, 38);
            this.change_password_button.TabIndex = 13;
            this.change_password_button.Text = "CHANGE PASSWORD";
            this.change_password_button.UseVisualStyleBackColor = true;
            this.change_password_button.Click += new System.EventHandler(this.change_password_button_Click);
            // 
            // login_button
            // 
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderSize = 2;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(7, 399);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(389, 38);
            this.login_button.TabIndex = 12;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.password_textBox.Location = new System.Drawing.Point(3, 336);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_textBox.MaxLength = 30;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(389, 30);
            this.password_textBox.TabIndex = 11;
            this.password_textBox.Text = "123";
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // username_textBox
            // 
            this.username_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.username_textBox.Location = new System.Drawing.Point(3, 245);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_textBox.MaxLength = 30;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(389, 30);
            this.username_textBox.TabIndex = 10;
            this.username_textBox.Text = "Hassan@gmail";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(-1, 309);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(95, 23);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password :";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(3, 218);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(64, 23);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "Email :";
            // 
            // admin_radioButton
            // 
            this.admin_radioButton.AutoSize = true;
            this.admin_radioButton.Location = new System.Drawing.Point(12, 172);
            this.admin_radioButton.Name = "admin_radioButton";
            this.admin_radioButton.Size = new System.Drawing.Size(85, 27);
            this.admin_radioButton.TabIndex = 15;
            this.admin_radioButton.Text = "Admin";
            this.admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // other_radioButton
            // 
            this.other_radioButton.AutoSize = true;
            this.other_radioButton.Checked = true;
            this.other_radioButton.Location = new System.Drawing.Point(120, 172);
            this.other_radioButton.Name = "other_radioButton";
            this.other_radioButton.Size = new System.Drawing.Size(77, 27);
            this.other_radioButton.TabIndex = 16;
            this.other_radioButton.TabStop = true;
            this.other_radioButton.Text = "Other";
            this.other_radioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 37F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(733, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 73);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(1054, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email: syedhassanali880@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(1088, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "WhatsApp: +92-315-2529838";
            // 
            // login_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 991);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login_interface";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.login_interface_Load);
            this.Controls.SetChildIndex(this.left_panel, 0);
            this.Controls.SetChildIndex(this.top_panel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.left_top_panel.ResumeLayout(false);
            this.left_top_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgot_password_button;
        private System.Windows.Forms.Button change_password_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.RadioButton admin_radioButton;
        private System.Windows.Forms.RadioButton other_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}