using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inv
{
    public partial class SALES_REPORT : Form
    {
        public SALES_REPORT()
        {
            InitializeComponent();
        }

        private void SALES_REPORT_Load(object sender, EventArgs e)
        {
            if(Sales_Invoice_Details.SaleID == 0)
            {
                SQL_TASKS.ShowReport(crystalReportViewer1, "st_getSalesReceipt", "@userID", LoginCodeClass.USERID);
            }
            else
            {
                SQL_TASKS.ShowReport(crystalReportViewer1, "st_getSalesReceiptwrtSalesID", "@saleID", Sales_Invoice_Details.SaleID);

                Sales_Invoice_Details.SaleID = 0;
            }
            
        }
    }
}
