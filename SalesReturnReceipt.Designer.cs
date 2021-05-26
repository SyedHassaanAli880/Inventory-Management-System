
namespace inv
{
    partial class SalesReturnReceipt
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
            this.SalesReturncrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // SalesReturncrystalReportViewer
            // 
            this.SalesReturncrystalReportViewer.ActiveViewIndex = -1;
            this.SalesReturncrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesReturncrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesReturncrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReturncrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SalesReturncrystalReportViewer.Name = "SalesReturncrystalReportViewer";
            this.SalesReturncrystalReportViewer.ShowCloseButton = false;
            this.SalesReturncrystalReportViewer.ShowCopyButton = false;
            this.SalesReturncrystalReportViewer.ShowGroupTreeButton = false;
            this.SalesReturncrystalReportViewer.ShowLogo = false;
            this.SalesReturncrystalReportViewer.ShowParameterPanelButton = false;
            this.SalesReturncrystalReportViewer.ShowRefreshButton = false;
            this.SalesReturncrystalReportViewer.ShowTextSearchButton = false;
            this.SalesReturncrystalReportViewer.Size = new System.Drawing.Size(1424, 721);
            this.SalesReturncrystalReportViewer.TabIndex = 1;
            this.SalesReturncrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // SalesReturnReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 721);
            this.Controls.Add(this.SalesReturncrystalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SalesReturnReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReturnReceipt";
            this.Load += new System.EventHandler(this.SalesReturnReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer SalesReturncrystalReportViewer;
    }
}