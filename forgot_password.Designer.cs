namespace inv
{
    partial class forgot_password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
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
            this.verify_code_panel = new System.Windows.Forms.Panel();
            this.verification_code_textBox = new System.Windows.Forms.TextBox();
            this.verify_code_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.new_details_panel = new System.Windows.Forms.Panel();
            this.disabled_new_details_label = new System.Windows.Forms.Label();
            this.new_password_textBox = new System.Windows.Forms.TextBox();
            this.new_password_label = new System.Windows.Forms.Label();
            this.save_new_details_button = new System.Windows.Forms.Button();
            this.new_username_textBox = new System.Windows.Forms.TextBox();
            this.new_username_label = new System.Windows.Forms.Label();
            this.enter_email_address_panel = new System.Windows.Forms.Panel();
            this.current_username_textBox_forgot_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.other_radioButton = new System.Windows.Forms.RadioButton();
            this.admin_radioButton = new System.Windows.Forms.RadioButton();
            this.email_address_label = new System.Windows.Forms.Label();
            this.send_code_button = new System.Windows.Forms.Button();
            this.email_address_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.left_panel.SuspendLayout();
            this.left_top_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.verify_code_panel.SuspendLayout();
            this.new_details_panel.SuspendLayout();
            this.enter_email_address_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(400, 877);
            // 
            // left_top_panel
            // 
            this.left_top_panel.Controls.Add(this.back_button);
            this.left_top_panel.Size = new System.Drawing.Size(400, 102);
            this.left_top_panel.Controls.SetChildIndex(this.welcome_label, 0);
            this.left_top_panel.Controls.SetChildIndex(this.back_button, 0);
            // 
            // top_panel
            // 
            this.top_panel.Location = new System.Drawing.Point(400, 0);
            this.top_panel.Size = new System.Drawing.Size(1141, 102);
            // 
            // welcome_label
            // 
            this.welcome_label.Location = new System.Drawing.Point(211, 32);
            // 
            // verify_code_panel
            // 
            this.verify_code_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.verify_code_panel.Controls.Add(this.verification_code_textBox);
            this.verify_code_panel.Controls.Add(this.verify_code_button);
            this.verify_code_panel.Controls.Add(this.label1);
            this.verify_code_panel.Location = new System.Drawing.Point(766, 386);
            this.verify_code_panel.Name = "verify_code_panel";
            this.verify_code_panel.Size = new System.Drawing.Size(693, 171);
            this.verify_code_panel.TabIndex = 27;
            // 
            // verification_code_textBox
            // 
            this.verification_code_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verification_code_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.verification_code_textBox.Location = new System.Drawing.Point(214, 41);
            this.verification_code_textBox.MaxLength = 32;
            this.verification_code_textBox.Name = "verification_code_textBox";
            this.verification_code_textBox.Size = new System.Drawing.Size(311, 27);
            this.verification_code_textBox.TabIndex = 2;
            // 
            // verify_code_button
            // 
            this.verify_code_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verify_code_button.FlatAppearance.BorderSize = 2;
            this.verify_code_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify_code_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_code_button.ForeColor = System.Drawing.Color.White;
            this.verify_code_button.Location = new System.Drawing.Point(214, 74);
            this.verify_code_button.Name = "verify_code_button";
            this.verify_code_button.Size = new System.Drawing.Size(311, 46);
            this.verify_code_button.TabIndex = 3;
            this.verify_code_button.Text = "VERIFY CODE";
            this.verify_code_button.UseVisualStyleBackColor = true;
            this.verify_code_button.Click += new System.EventHandler(this.verify_code_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter code :";
            // 
            // new_details_panel
            // 
            this.new_details_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.new_details_panel.Controls.Add(this.disabled_new_details_label);
            this.new_details_panel.Controls.Add(this.new_password_textBox);
            this.new_details_panel.Controls.Add(this.new_password_label);
            this.new_details_panel.Controls.Add(this.save_new_details_button);
            this.new_details_panel.Controls.Add(this.new_username_textBox);
            this.new_details_panel.Controls.Add(this.new_username_label);
            this.new_details_panel.Enabled = false;
            this.new_details_panel.Location = new System.Drawing.Point(766, 563);
            this.new_details_panel.Name = "new_details_panel";
            this.new_details_panel.Size = new System.Drawing.Size(693, 213);
            this.new_details_panel.TabIndex = 25;
            // 
            // disabled_new_details_label
            // 
            this.disabled_new_details_label.AutoSize = true;
            this.disabled_new_details_label.BackColor = System.Drawing.Color.ForestGreen;
            this.disabled_new_details_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disabled_new_details_label.ForeColor = System.Drawing.Color.White;
            this.disabled_new_details_label.Location = new System.Drawing.Point(40, 16);
            this.disabled_new_details_label.Name = "disabled_new_details_label";
            this.disabled_new_details_label.Size = new System.Drawing.Size(89, 20);
            this.disabled_new_details_label.TabIndex = 16;
            this.disabled_new_details_label.Text = "DISABLED :";
            // 
            // new_password_textBox
            // 
            this.new_password_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.new_password_textBox.Location = new System.Drawing.Point(214, 105);
            this.new_password_textBox.MaxLength = 32;
            this.new_password_textBox.Name = "new_password_textBox";
            this.new_password_textBox.Size = new System.Drawing.Size(311, 27);
            this.new_password_textBox.TabIndex = 5;
            this.new_password_textBox.UseSystemPasswordChar = true;
            // 
            // new_password_label
            // 
            this.new_password_label.AutoSize = true;
            this.new_password_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password_label.ForeColor = System.Drawing.Color.White;
            this.new_password_label.Location = new System.Drawing.Point(40, 107);
            this.new_password_label.Name = "new_password_label";
            this.new_password_label.Size = new System.Drawing.Size(158, 20);
            this.new_password_label.TabIndex = 18;
            this.new_password_label.Text = "Enter new password :";
            // 
            // save_new_details_button
            // 
            this.save_new_details_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_new_details_button.FlatAppearance.BorderSize = 2;
            this.save_new_details_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_new_details_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_new_details_button.ForeColor = System.Drawing.Color.White;
            this.save_new_details_button.Location = new System.Drawing.Point(214, 138);
            this.save_new_details_button.Name = "save_new_details_button";
            this.save_new_details_button.Size = new System.Drawing.Size(311, 46);
            this.save_new_details_button.TabIndex = 6;
            this.save_new_details_button.Text = "SAVE";
            this.save_new_details_button.UseVisualStyleBackColor = true;
            this.save_new_details_button.Click += new System.EventHandler(this.save_new_details_button_Click);
            // 
            // new_username_textBox
            // 
            this.new_username_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_username_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.new_username_textBox.Location = new System.Drawing.Point(214, 70);
            this.new_username_textBox.MaxLength = 32;
            this.new_username_textBox.Name = "new_username_textBox";
            this.new_username_textBox.Size = new System.Drawing.Size(311, 27);
            this.new_username_textBox.TabIndex = 4;
            // 
            // new_username_label
            // 
            this.new_username_label.AutoSize = true;
            this.new_username_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_username_label.ForeColor = System.Drawing.Color.White;
            this.new_username_label.Location = new System.Drawing.Point(40, 70);
            this.new_username_label.Name = "new_username_label";
            this.new_username_label.Size = new System.Drawing.Size(160, 20);
            this.new_username_label.TabIndex = 15;
            this.new_username_label.Text = "Enter new username :";
            // 
            // enter_email_address_panel
            // 
            this.enter_email_address_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.enter_email_address_panel.Controls.Add(this.current_username_textBox_forgot_password);
            this.enter_email_address_panel.Controls.Add(this.label2);
            this.enter_email_address_panel.Controls.Add(this.other_radioButton);
            this.enter_email_address_panel.Controls.Add(this.admin_radioButton);
            this.enter_email_address_panel.Controls.Add(this.email_address_label);
            this.enter_email_address_panel.Controls.Add(this.send_code_button);
            this.enter_email_address_panel.Controls.Add(this.email_address_textBox);
            this.enter_email_address_panel.Location = new System.Drawing.Point(766, 132);
            this.enter_email_address_panel.Name = "enter_email_address_panel";
            this.enter_email_address_panel.Size = new System.Drawing.Size(693, 248);
            this.enter_email_address_panel.TabIndex = 26;
            // 
            // current_username_textBox_forgot_password
            // 
            this.current_username_textBox_forgot_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_username_textBox_forgot_password.ForeColor = System.Drawing.Color.ForestGreen;
            this.current_username_textBox_forgot_password.Location = new System.Drawing.Point(214, 77);
            this.current_username_textBox_forgot_password.MaxLength = 32;
            this.current_username_textBox_forgot_password.Name = "current_username_textBox_forgot_password";
            this.current_username_textBox_forgot_password.Size = new System.Drawing.Size(311, 27);
            this.current_username_textBox_forgot_password.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter current username :";
            // 
            // other_radioButton
            // 
            this.other_radioButton.AutoSize = true;
            this.other_radioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other_radioButton.ForeColor = System.Drawing.Color.White;
            this.other_radioButton.Location = new System.Drawing.Point(364, 37);
            this.other_radioButton.Name = "other_radioButton";
            this.other_radioButton.Size = new System.Drawing.Size(70, 24);
            this.other_radioButton.TabIndex = 3;
            this.other_radioButton.TabStop = true;
            this.other_radioButton.Text = "Other";
            this.other_radioButton.UseVisualStyleBackColor = true;
            // 
            // admin_radioButton
            // 
            this.admin_radioButton.AutoSize = true;
            this.admin_radioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_radioButton.ForeColor = System.Drawing.Color.White;
            this.admin_radioButton.Location = new System.Drawing.Point(256, 37);
            this.admin_radioButton.Name = "admin_radioButton";
            this.admin_radioButton.Size = new System.Drawing.Size(77, 24);
            this.admin_radioButton.TabIndex = 2;
            this.admin_radioButton.TabStop = true;
            this.admin_radioButton.Text = "Admin";
            this.admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // email_address_label
            // 
            this.email_address_label.AutoSize = true;
            this.email_address_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_address_label.ForeColor = System.Drawing.Color.White;
            this.email_address_label.Location = new System.Drawing.Point(27, 113);
            this.email_address_label.Name = "email_address_label";
            this.email_address_label.Size = new System.Drawing.Size(154, 20);
            this.email_address_label.TabIndex = 0;
            this.email_address_label.Text = "Enter email address :";
            // 
            // send_code_button
            // 
            this.send_code_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_code_button.FlatAppearance.BorderSize = 2;
            this.send_code_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_code_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_code_button.ForeColor = System.Drawing.Color.White;
            this.send_code_button.Location = new System.Drawing.Point(214, 143);
            this.send_code_button.Name = "send_code_button";
            this.send_code_button.Size = new System.Drawing.Size(311, 46);
            this.send_code_button.TabIndex = 1;
            this.send_code_button.Text = "SEND CODE";
            this.send_code_button.UseVisualStyleBackColor = true;
            this.send_code_button.Click += new System.EventHandler(this.send_code_button_Click);
            // 
            // email_address_textBox
            // 
            this.email_address_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_address_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.email_address_textBox.Location = new System.Drawing.Point(214, 110);
            this.email_address_textBox.MaxLength = 32;
            this.email_address_textBox.Name = "email_address_textBox";
            this.email_address_textBox.Size = new System.Drawing.Size(311, 27);
            this.email_address_textBox.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.BackgroundImage = global::inv.Properties.Resources.back;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(0, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(94, 94);
            this.back_button.TabIndex = 8;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // forgot_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 877);
            this.Controls.Add(this.verify_code_panel);
            this.Controls.Add(this.new_details_panel);
            this.Controls.Add(this.enter_email_address_panel);
            this.Name = "forgot_password";
            this.Text = "FORGOT PASSWORD";
            this.Controls.SetChildIndex(this.left_panel, 0);
            this.Controls.SetChildIndex(this.top_panel, 0);
            this.Controls.SetChildIndex(this.enter_email_address_panel, 0);
            this.Controls.SetChildIndex(this.new_details_panel, 0);
            this.Controls.SetChildIndex(this.verify_code_panel, 0);
            this.left_panel.ResumeLayout(false);
            this.left_top_panel.ResumeLayout(false);
            this.left_top_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.verify_code_panel.ResumeLayout(false);
            this.verify_code_panel.PerformLayout();
            this.new_details_panel.ResumeLayout(false);
            this.new_details_panel.PerformLayout();
            this.enter_email_address_panel.ResumeLayout(false);
            this.enter_email_address_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel verify_code_panel;
        private System.Windows.Forms.TextBox verification_code_textBox;
        private System.Windows.Forms.Button verify_code_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel new_details_panel;
        private System.Windows.Forms.Label disabled_new_details_label;
        private System.Windows.Forms.TextBox new_password_textBox;
        private System.Windows.Forms.Label new_password_label;
        private System.Windows.Forms.Button save_new_details_button;
        private System.Windows.Forms.TextBox new_username_textBox;
        private System.Windows.Forms.Label new_username_label;
        private System.Windows.Forms.Panel enter_email_address_panel;
        private System.Windows.Forms.Label email_address_label;
        private System.Windows.Forms.Button send_code_button;
        private System.Windows.Forms.TextBox email_address_textBox;
        protected System.Windows.Forms.Button back_button;
        private System.Windows.Forms.RadioButton other_radioButton;
        private System.Windows.Forms.RadioButton admin_radioButton;
        private System.Windows.Forms.TextBox current_username_textBox_forgot_password;
        private System.Windows.Forms.Label label2;
    }
}