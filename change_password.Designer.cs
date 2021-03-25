using System.Drawing;
using System.Windows.Forms;

namespace inv
{
    partial class change_password
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
            this.new_password_panel_change = new System.Windows.Forms.Panel();
            this.new_username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.new_password_textBox_change = new System.Windows.Forms.TextBox();
            this.enter_new_password_change = new System.Windows.Forms.Label();
            this.save_new_details_button_change = new System.Windows.Forms.Button();
            this.disabled_new_password_label = new System.Windows.Forms.Label();
            this.old_password_panel_change = new System.Windows.Forms.Panel();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.enter_username_label = new System.Windows.Forms.Label();
            this.other_radioButton = new System.Windows.Forms.RadioButton();
            this.admin_radioButton = new System.Windows.Forms.RadioButton();
            this.old_password_textBox = new System.Windows.Forms.TextBox();
            this.new_old_password_label = new System.Windows.Forms.Label();
            this.verify_oldpassword_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.left_panel.SuspendLayout();
            this.left_top_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.new_password_panel_change.SuspendLayout();
            this.old_password_panel_change.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(400, 881);
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
            this.top_panel.Size = new System.Drawing.Size(1159, 102);
            // 
            // welcome_label
            // 
            this.welcome_label.Location = new System.Drawing.Point(211, 32);
            // 
            // new_password_panel_change
            // 
            this.new_password_panel_change.BackColor = System.Drawing.Color.ForestGreen;
            this.new_password_panel_change.Controls.Add(this.new_username_textBox);
            this.new_password_panel_change.Controls.Add(this.label1);
            this.new_password_panel_change.Controls.Add(this.new_password_textBox_change);
            this.new_password_panel_change.Controls.Add(this.enter_new_password_change);
            this.new_password_panel_change.Controls.Add(this.save_new_details_button_change);
            this.new_password_panel_change.Controls.Add(this.disabled_new_password_label);
            this.new_password_panel_change.Enabled = false;
            this.new_password_panel_change.Location = new System.Drawing.Point(673, 536);
            this.new_password_panel_change.Name = "new_password_panel_change";
            this.new_password_panel_change.Size = new System.Drawing.Size(846, 207);
            this.new_password_panel_change.TabIndex = 21;
            // 
            // new_username_textBox
            // 
            this.new_username_textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_username_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.new_username_textBox.Location = new System.Drawing.Point(340, 63);
            this.new_username_textBox.MaxLength = 40;
            this.new_username_textBox.Name = "new_username_textBox";
            this.new_username_textBox.Size = new System.Drawing.Size(311, 30);
            this.new_username_textBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enter new username :";
            // 
            // new_password_textBox_change
            // 
            this.new_password_textBox_change.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password_textBox_change.ForeColor = System.Drawing.Color.ForestGreen;
            this.new_password_textBox_change.Location = new System.Drawing.Point(340, 99);
            this.new_password_textBox_change.MaxLength = 40;
            this.new_password_textBox_change.Name = "new_password_textBox_change";
            this.new_password_textBox_change.Size = new System.Drawing.Size(311, 30);
            this.new_password_textBox_change.TabIndex = 6;
            this.new_password_textBox_change.UseSystemPasswordChar = true;
            // 
            // enter_new_password_change
            // 
            this.enter_new_password_change.AutoSize = true;
            this.enter_new_password_change.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_new_password_change.ForeColor = System.Drawing.Color.White;
            this.enter_new_password_change.Location = new System.Drawing.Point(154, 99);
            this.enter_new_password_change.Name = "enter_new_password_change";
            this.enter_new_password_change.Size = new System.Drawing.Size(158, 20);
            this.enter_new_password_change.TabIndex = 25;
            this.enter_new_password_change.Text = "Enter new password :";
            // 
            // save_new_details_button_change
            // 
            this.save_new_details_button_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_new_details_button_change.FlatAppearance.BorderSize = 2;
            this.save_new_details_button_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_new_details_button_change.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_new_details_button_change.ForeColor = System.Drawing.Color.White;
            this.save_new_details_button_change.Location = new System.Drawing.Point(340, 135);
            this.save_new_details_button_change.Name = "save_new_details_button_change";
            this.save_new_details_button_change.Size = new System.Drawing.Size(311, 46);
            this.save_new_details_button_change.TabIndex = 7;
            this.save_new_details_button_change.Text = "SAVE";
            this.save_new_details_button_change.UseVisualStyleBackColor = true;
            this.save_new_details_button_change.Click += new System.EventHandler(this.save_new_details_button_change_Click);
            // 
            // disabled_new_password_label
            // 
            this.disabled_new_password_label.AutoSize = true;
            this.disabled_new_password_label.BackColor = System.Drawing.Color.ForestGreen;
            this.disabled_new_password_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disabled_new_password_label.ForeColor = System.Drawing.Color.White;
            this.disabled_new_password_label.Location = new System.Drawing.Point(433, 26);
            this.disabled_new_password_label.Name = "disabled_new_password_label";
            this.disabled_new_password_label.Size = new System.Drawing.Size(89, 20);
            this.disabled_new_password_label.TabIndex = 23;
            this.disabled_new_password_label.Text = "DISABLED :";
            // 
            // old_password_panel_change
            // 
            this.old_password_panel_change.BackColor = System.Drawing.Color.ForestGreen;
            this.old_password_panel_change.Controls.Add(this.username_textBox);
            this.old_password_panel_change.Controls.Add(this.enter_username_label);
            this.old_password_panel_change.Controls.Add(this.other_radioButton);
            this.old_password_panel_change.Controls.Add(this.admin_radioButton);
            this.old_password_panel_change.Controls.Add(this.old_password_textBox);
            this.old_password_panel_change.Controls.Add(this.new_old_password_label);
            this.old_password_panel_change.Controls.Add(this.verify_oldpassword_button);
            this.old_password_panel_change.Location = new System.Drawing.Point(673, 197);
            this.old_password_panel_change.Name = "old_password_panel_change";
            this.old_password_panel_change.Size = new System.Drawing.Size(846, 214);
            this.old_password_panel_change.TabIndex = 20;
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.username_textBox.Location = new System.Drawing.Point(340, 63);
            this.username_textBox.MaxLength = 40;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(311, 30);
            this.username_textBox.TabIndex = 2;
            // 
            // enter_username_label
            // 
            this.enter_username_label.AutoSize = true;
            this.enter_username_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_username_label.ForeColor = System.Drawing.Color.White;
            this.enter_username_label.Location = new System.Drawing.Point(134, 68);
            this.enter_username_label.Name = "enter_username_label";
            this.enter_username_label.Size = new System.Drawing.Size(127, 20);
            this.enter_username_label.TabIndex = 22;
            this.enter_username_label.Text = "Enter username :";
            // 
            // other_radioButton
            // 
            this.other_radioButton.AutoSize = true;
            this.other_radioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other_radioButton.ForeColor = System.Drawing.Color.White;
            this.other_radioButton.Location = new System.Drawing.Point(484, 16);
            this.other_radioButton.Name = "other_radioButton";
            this.other_radioButton.Size = new System.Drawing.Size(70, 24);
            this.other_radioButton.TabIndex = 1;
            this.other_radioButton.TabStop = true;
            this.other_radioButton.Text = "Other";
            this.other_radioButton.UseVisualStyleBackColor = true;
            // 
            // admin_radioButton
            // 
            this.admin_radioButton.AutoSize = true;
            this.admin_radioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_radioButton.ForeColor = System.Drawing.Color.White;
            this.admin_radioButton.Location = new System.Drawing.Point(376, 16);
            this.admin_radioButton.Name = "admin_radioButton";
            this.admin_radioButton.Size = new System.Drawing.Size(77, 24);
            this.admin_radioButton.TabIndex = 0;
            this.admin_radioButton.TabStop = true;
            this.admin_radioButton.Text = "Admin";
            this.admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // old_password_textBox
            // 
            this.old_password_textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_password_textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.old_password_textBox.Location = new System.Drawing.Point(340, 103);
            this.old_password_textBox.MaxLength = 40;
            this.old_password_textBox.Name = "old_password_textBox";
            this.old_password_textBox.Size = new System.Drawing.Size(311, 30);
            this.old_password_textBox.TabIndex = 3;
            this.old_password_textBox.UseSystemPasswordChar = true;
            // 
            // new_old_password_label
            // 
            this.new_old_password_label.AutoSize = true;
            this.new_old_password_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_old_password_label.ForeColor = System.Drawing.Color.White;
            this.new_old_password_label.Location = new System.Drawing.Point(134, 103);
            this.new_old_password_label.Name = "new_old_password_label";
            this.new_old_password_label.Size = new System.Drawing.Size(180, 20);
            this.new_old_password_label.TabIndex = 18;
            this.new_old_password_label.Text = "Enter current password :";
            // 
            // verify_oldpassword_button
            // 
            this.verify_oldpassword_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verify_oldpassword_button.FlatAppearance.BorderSize = 2;
            this.verify_oldpassword_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify_oldpassword_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_oldpassword_button.ForeColor = System.Drawing.Color.White;
            this.verify_oldpassword_button.Location = new System.Drawing.Point(340, 139);
            this.verify_oldpassword_button.Name = "verify_oldpassword_button";
            this.verify_oldpassword_button.Size = new System.Drawing.Size(311, 46);
            this.verify_oldpassword_button.TabIndex = 4;
            this.verify_oldpassword_button.Text = "VERIFY";
            this.verify_oldpassword_button.UseVisualStyleBackColor = true;
            this.verify_oldpassword_button.Click += new System.EventHandler(this.verify_oldpassword_button_Click);
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
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 881);
            this.Controls.Add(this.new_password_panel_change);
            this.Controls.Add(this.old_password_panel_change);
            this.Name = "change_password";
            this.Text = "CHANGE PASSWORD";
            this.Controls.SetChildIndex(this.left_panel, 0);
            this.Controls.SetChildIndex(this.top_panel, 0);
            this.Controls.SetChildIndex(this.old_password_panel_change, 0);
            this.Controls.SetChildIndex(this.new_password_panel_change, 0);
            this.left_panel.ResumeLayout(false);
            this.left_top_panel.ResumeLayout(false);
            this.left_top_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.new_password_panel_change.ResumeLayout(false);
            this.new_password_panel_change.PerformLayout();
            this.old_password_panel_change.ResumeLayout(false);
            this.old_password_panel_change.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel new_password_panel_change;
        private TextBox new_password_textBox_change;
        private Label enter_new_password_change;
        private Button save_new_details_button_change;
        private Label disabled_new_password_label;
        private Panel old_password_panel_change;
        private TextBox old_password_textBox;
        private Label new_old_password_label;
        private Button verify_oldpassword_button;
        protected Button back_button;
        private RadioButton other_radioButton;
        private RadioButton admin_radioButton;
        private TextBox username_textBox;
        private Label enter_username_label;
        private TextBox new_username_textBox;
        private Label label1;
    }
}