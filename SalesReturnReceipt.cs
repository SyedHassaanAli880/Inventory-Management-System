using System;
using System.Windows.Forms;

namespace inv
{
    public partial class SalesReturnReceipt : Form
    {
        public SalesReturnReceipt()
        {
            InitializeComponent();
        }

        private void SalesReturnReceipt_Load(object sender, EventArgs e)
        {
            SQL_TASKS.ShowReportSaleReturn(SalesReturncrystalReportViewer, "st_getRefundInvoice","@saleID","1");
        }
    }
}
