namespace inv
{
    partial class Sales_Details
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
            this.back_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.left_panel.SuspendLayout();
            this.left_top_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.load_button);
            this.left_panel.Size = new System.Drawing.Size(404, 745);
            this.left_panel.Controls.SetChildIndex(this.left_top_panel, 0);
            this.left_panel.Controls.SetChildIndex(this.load_button, 0);
            // 
            // left_top_panel
            // 
            this.left_top_panel.Controls.Add(this.back_button);
            this.left_top_panel.Controls.SetChildIndex(this.welcome_label, 0);
            this.left_top_panel.Controls.SetChildIndex(this.back_button, 0);
            // 
            // top_panel
            // 
            this.top_panel.Size = new System.Drawing.Size(949, 102);
            // 
            // back_button
            // 
            this.back_button.BackgroundImage = global::inv.Properties.Resources.back;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(0, 0);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(101, 99);
            this.back_button.TabIndex = 8;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // load_button
            // 
            this.load_button.FlatAppearance.BorderSize = 2;
            this.load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_button.ForeColor = System.Drawing.Color.White;
            this.load_button.Location = new System.Drawing.Point(9, 283);
            this.load_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(389, 52);
            this.load_button.TabIndex = 8;
            this.load_button.Text = "&LOAD";
            this.load_button.UseVisualStyleBackColor = true;
            // 
            // Sales_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 745);
            this.Name = "Sales_Details";
            this.Text = "Sales Details";
            this.left_panel.ResumeLayout(false);
            this.left_top_panel.ResumeLayout(false);
            this.left_top_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button load_button;
    }
}