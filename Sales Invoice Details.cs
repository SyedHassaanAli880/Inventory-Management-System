using System;
using System.Collections;
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
    public partial class Sales_Invoice_Details : sample_in
    {
        public Sales_Invoice_Details()
        {
            InitializeComponent();
        }

        void LoadSalesDetails()
        {
            var ht = new Hashtable();

            ht.Add("@date", dateTimePicker_sales.Value);

            var lb = new ListBox();

            lb.Items.Add(saleIDGV);

            lb.Items.Add(TotalAmountGV);

            lb.Items.Add(AmountGivenGV);

            lb.Items.Add(AmountReturnedGV);

            lb.Items.Add(UserGV);

            lb.Items.Add(TotalDiscountGV);

            lb.Items.Add(UserIDGV);

            SQL_TASKS.load_data("st_GetDailySales", sales_details_dataGridView, lb,ht);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadSalesDetails();
        }

        public static int SaleID;

        private void sales_details_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != 1 && e.ColumnIndex != 1)
            {
                var row = sales_details_dataGridView.Rows[e.RowIndex];

                SaleID = Convert.ToInt32(row.Cells["UserIDGV"].Value.ToString());

                var sr = new SALES_REPORT();

                sr.Show();
            }
        }
    }
}
