namespace inv
{
    partial class sample1
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
            this.left_panel = new System.Windows.Forms.Panel();
            this.left_top_panel = new System.Windows.Forms.Panel();
            this.welcome_label = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.user_label = new System.Windows.Forms.Label();
            this.left_panel.SuspendLayout();
            this.left_top_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.left_panel.Controls.Add(this.left_top_panel);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_panel.ForeColor = System.Drawing.Color.White;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(404, 757);
            this.left_panel.TabIndex = 0;
            // 
            // left_top_panel
            // 
            this.left_top_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.left_top_panel.Controls.Add(this.welcome_label);
            this.left_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.left_top_panel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_top_panel.ForeColor = System.Drawing.Color.White;
            this.left_top_panel.Location = new System.Drawing.Point(0, 0);
            this.left_top_panel.Name = "left_top_panel";
            this.left_top_panel.Size = new System.Drawing.Size(404, 102);
            this.left_top_panel.TabIndex = 0;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(266, 32);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(132, 32);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "WELCOME";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.user_label);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_panel.ForeColor = System.Drawing.Color.ForestGreen;
            this.top_panel.Location = new System.Drawing.Point(404, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(967, 102);
            this.top_panel.TabIndex = 1;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.BackColor = System.Drawing.Color.White;
            this.user_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.user_label.Location = new System.Drawing.Point(6, 32);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(74, 32);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "USER";
            // 
            // sample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 757);
            this.ControlBox = false;
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.left_panel);
            this.Name = "sample1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "sample1";
            this.Load += new System.EventHandler(this.sample1_Load);
            this.left_panel.ResumeLayout(false);
            this.left_top_panel.ResumeLayout(false);
            this.left_top_panel.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel left_panel;
        public System.Windows.Forms.Panel left_top_panel;
        public System.Windows.Forms.Panel top_panel;
        public System.Windows.Forms.Label welcome_label;
        public System.Windows.Forms.Label user_label;
    }
}