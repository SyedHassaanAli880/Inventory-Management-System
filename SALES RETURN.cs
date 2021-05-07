using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace inv
{
    public partial class SALES_RETURN : sample2
    {
        public SALES_RETURN()
        {
            InitializeComponent();
        }

        void LoadSales()
        {
            var ht = new Hashtable();

            ht.Add("@saleID", Convert.ToInt64(sale_ID_textBox.Text));

            var lb = new ListBox();

            lb.Items.Add(saleIDGV);

            lb.Items.Add(BarcodeGV);

            lb.Items.Add(ProductGV);

            lb.Items.Add(QuantityGV);

            lb.Items.Add(TotalDiscountGV);

            lb.Items.Add(TotalAmountGV);

            lb.Items.Add(AmountGivenGV);

            lb.Items.Add(AmountReturnedGV);

            lb.Items.Add(DateGV);

            lb.Items.Add(ProductPriceGV);

            lb.Items.Add(PerProductDiscountGV);

            lb.Items.Add(PerProductTotalGV);

            lb.Items.Add(UserGV);

            lb.Items.Add(PaymentGV);

            SQL_TASKS.load_data("st_getSalesReceiptwrtSalesID", sales_return_dataGridView, lb, ht);
        }

        private void SALES_RETURN_Load(object sender, EventArgs e)
        {
            
        }

        Regex rg = new Regex("^[0-9]+$");
        private void load_button_Click(object sender, EventArgs e)
        {
            if(sale_ID_textBox.Text != "")
            {
                if (rg.Match(sale_ID_textBox.Text).Success)
                {
                    LoadSales();

                    dateTimePicker_sales_return.Value = Convert.ToDateTime(sales_return_dataGridView.Rows[0].Cells["DateGV"].Value);

                    user_textBox.Text = sales_return_dataGridView.Rows[0].Cells["UserGV"].Value.ToString();

                    paymentType_textBox.Text = sales_return_dataGridView.Rows[0].Cells["PaymentGV"].Value.ToString();
                
                    amoun
                }
                else
                {
                    sale_ID_textBox.Text = ""; 
                    
                    sale_ID_textBox.Focus();

                    dateTimePicker_sales_return.Value = DateTime.Now;

                    user_textBox.Text = "";

                    paymentType_textBox.Text = "";
                }
            }
            else
            {
                MainClass.ShowMsg("Enter sale ID first.", "Error");

                dateTimePicker_sales_return.Value = DateTime.Now;

                user_textBox.Text = "";

                paymentType_textBox.Text = "";
            }

        }
    }
}
