using System;
using System.Collections;
using System.Windows.Forms;

namespace inv
{
    public partial class STOCK : sample1
    {
        public STOCK()
        {
            InitializeComponent();
        }
        public void LoadStocks()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(productidGV);

            lb.Items.Add(productnameGV);

            lb.Items.Add(productbarcodeGV);

            lb.Items.Add(PerUnitPriceGV);

            lb.Items.Add(productbuyingpriceGV);

            lb.Items.Add(BuyingDateGV);

            lb.Items.Add(expirydateGV);

            lb.Items.Add(productcategoryGV);

            lb.Items.Add(availablestockGV);

            lb.Items.Add(statusGV);

            SQL_TASKS.load_data("st_getSTOCK", stocks_dataGridView, lb);
        }
        private void STOCK_Load(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();

            lb.Items.Add(productidGV);

            lb.Items.Add(productnameGV);

            lb.Items.Add(productbarcodeGV);

            lb.Items.Add(PerUnitPriceGV);

            lb.Items.Add(productbuyingpriceGV);

            lb.Items.Add(BuyingDateGV);

            lb.Items.Add(expirydateGV);

            lb.Items.Add(productcategoryGV);

            lb.Items.Add(availablestockGV);

            lb.Items.Add(statusGV);

            SQL_TASKS.load_data("st_getSTOCK", stocks_dataGridView, lb);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (search_stock_textBox.Text != "")
            {
                ListBox lb = new ListBox();

                lb.Items.Add(productnameGV);

                Hashtable ht = new Hashtable();

                ht.Add("@data", search_stock_textBox.Text);

                SQL_TASKS.load_data("st_searchSTOCKS", stocks_dataGridView, lb, ht);
            }
            else
            {
                LoadStocks();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            LoadStocks();
        }

        private void stocks_dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.stocks_dataGridView.Rows[e.RowIndex].Cells["snoGV"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
