namespace inv
{
    partial class sample_in
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.left_panel = new System.Windows.Forms.Panel();
            this.top_left_panel = new System.Windows.Forms.Panel();
            this.welcome_label = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.user_label = new System.Windows.Forms.Label();
            this.center_panel = new System.Windows.Forms.Panel();
            this.left_panel.SuspendLayout();
            this.top_left_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.left_panel.Controls.Add(this.top_left_panel);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_panel.ForeColor = System.Drawing.Color.White;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(404, 757);
            this.left_panel.TabIndex = 0;
            // 
            // top_left_panel
            // 
            this.top_left_panel.Controls.Add(this.welcome_label);
            this.top_left_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_left_panel.Location = new System.Drawing.Point(0, 0);
            this.top_left_panel.Name = "top_left_panel";
            this.top_left_panel.Size = new System.Drawing.Size(404, 92);
            this.top_left_panel.TabIndex = 0;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(266, 30);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(132, 32);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Text = "WELCOME";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.user_label);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(404, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(967, 92);
            this.top_panel.TabIndex = 1;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.user_label.Location = new System.Drawing.Point(6, 30);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(74, 32);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "USER";
            // 
            // center_panel
            // 
            this.center_panel.BackColor = System.Drawing.Color.White;
            this.center_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_panel.Location = new System.Drawing.Point(404, 92);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(967, 665);
            this.center_panel.TabIndex = 2;
            // 
            // sample_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 757);
            this.Controls.Add(this.center_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.left_panel);
            this.Name = "sample_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sample_in";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sample_in_Load);
            this.left_panel.ResumeLayout(false);
            this.top_left_panel.ResumeLayout(false);
            this.top_left_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel left_panel;
        public System.Windows.Forms.Panel top_panel;
        public System.Windows.Forms.Panel top_left_panel;
        public System.Windows.Forms.Panel center_panel;
        public System.Windows.Forms.Label welcome_label;
        public System.Windows.Forms.Label user_label;
    }
}