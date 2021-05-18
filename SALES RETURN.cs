using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Transactions;
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

            lb.Items.Add(UserIDGV);

            lb.Items.Add(PaymentGV);

            lb.Items.Add(ProductIDGV);

            SQL_TASKS.load_data("st_getSalesReceiptwrtSalesID", sales_return_dataGridView, lb, ht);
        }

        private void SALES_RETURN_Load(object sender, EventArgs e)
        {
            base.edit_button.Visible = false;
            base.save_button.Visible = false;
            base.search_textBox.Visible = false;
            base.delete_button.Visible = false;
            base.add_button.Visible = false;
            base.cancel_button.Visible = false;
            base.view_button.Visible = false;
            base.add_button.Visible = false;
            base.search_groupBox.Visible = false;
        }

        Regex rg = new Regex("^[0-9]+$");
        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sale_ID_textBox.Text != "")
                {
                    if (rg.Match(sale_ID_textBox.Text).Success)
                    {
                        LoadSales();

                        dateTimePicker_sales_return.Value = Convert.ToDateTime(sales_return_dataGridView.Rows[0].Cells["DateGV"].Value);

                        user_textBox.Text = sales_return_dataGridView.Rows[0].Cells["UserIDGV"].Value.ToString();

                        paymentType_textBox.Text = sales_return_dataGridView.Rows[0].Cells["PaymentGV"].Value.ToString();

                        total_amount_label.Text = "Total Amount: " + sales_return_dataGridView.Rows[0].Cells["TotalAmountGV"].Value.ToString();

                        total_discount_label.Text = "Total Discount: " + sales_return_dataGridView.Rows[0].Cells["TotalDiscountGV"].Value.ToString();

                    }
                    else
                    {
                        sale_ID_textBox.Text = "";

                        sale_ID_textBox.Focus();

                        dateTimePicker_sales_return.Value = DateTime.Now;

                        user_textBox.Text = "";

                        paymentType_textBox.Text = "";

                        total_amount_label.Text = "Total Amount: 0";

                        total_discount_label.Text = "Total Discount: 0";
                    }
                }
                else
                {
                    MainClass.ShowMsg("Enter sale ID first.", "Error");

                    dateTimePicker_sales_return.Value = DateTime.Now;

                    user_textBox.Text = "";

                    paymentType_textBox.Text = "";

                    total_amount_label.Text = "Total Amount: 0";

                    total_discount_label.Text = "Total Discount: 0";
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }

        }

        public override void add_button_Click(object sender, EventArgs e)
        {

        }

        public override void save_button_Click(object sender, EventArgs e)
        {
            //Hashtable ht = new Hashtable();

            //if(amount_to_refund_textBox.Text != "" && sale_ID_textBox.Text != "")
            //{
            //    DialogResult dr = MessageBox.Show("Are you sure, you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            //    using(TransactionScope sc = new TransactionScope())
            //    {
            //        int x = 0;

            //        foreach(DictionaryEntry de in ht)
            //        {
            //            ht.Add("@refSaleID",);


            //            x += SQL_TASKS.insert_update_delete("st_insertRefund", ht);

            //            int currentQuantity = (int)(SQL_TASKS.getProductQuantity((int)(de.Key)));

            //            int finalQuantity = currentQuantity - Convert.ToInt16(de.Value);

            //            Hashtable htx = new Hashtable();

            //            htx.Add("@prodID",);

            //            htx.Add("@quan",);

            //            SQL_TASKS.insert_update_delete("st_insertSTOCK",ht);
            //        }

            //        if(x > 0)
            //        {
            //            MainClass.ShowMsg("Return and Refund Successfull","Success");
            //            x = 0;
            //            ht.Clear();
            //        }
            //        sc.Complete();
            //    }
            //}
        }

        public override void delete_button_Click(object sender, EventArgs e)
        {

        }

        public override void search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        public override void cancel_button_Click(object sender, EventArgs e)
        {

        }

        public override void view_button_Click(object sender, EventArgs e)
        {

        }

        public override void edit_button_Click(object sender, EventArgs e)
        {

        }

        float amount_refund = 0;

        Hashtable ht = new Hashtable();

        //private void barcode_textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    try
        //    {
        //        if (barcode_textBox.Text != "")
        //        {
        //            if (sales_return_dataGridView.Rows.Count > 0)
        //            {
        //                using (TransactionScope sc = new TransactionScope())
        //                {
        //                    foreach (DataGridViewRow row in sales_return_dataGridView.Rows)
        //                    {
        //                        if (barcode_textBox.Text == row.Cells["BarcodeGV"].Value.ToString())
        //                        {
        //                            DialogResult dr = MessageBox.Show("Are you sure you want to return " + row.Cells["ProductGV"].Value.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //                            if (dr == DialogResult.Yes)
        //                            {
        //                                //----------------------INSERTING RECORD TO REFUND TABLE------------------
        //                                Hashtable htx = new Hashtable();

        //                                htx.Add("@refSaleID", Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString()));

        //                                htx.Add("@refDate", DateTime.Now);

        //                                htx.Add("@refDoneBy", Convert.ToInt64(row.Cells["UserIDGV"].Value.ToString()));

        //                                htx.Add("@refProdID", Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString()));

        //                                htx.Add("@refQuantity", Convert.ToInt64(row.Cells["QuantityGV"].Value.ToString()));

        //                                htx.Add("@refAmount", Convert.ToSingle(row.Cells["ProductPriceGV"].Value.ToString()));

        //                                int x = 0;

        //                                x += SQL_TASKS.insert_update_delete("st_insertRefundReturn", htx);

        //                                if (x > 0)
        //                                {
        //                                    MainClass.ShowMsg("Return and Refund Successfull", "Success");
        //                                    x = 0;
        //                                    ht.Clear();
        //                                }
        //                                else
        //                                {
        //                                    throw new Exception("Something went wrong");
        //                                }

        //                                //----------------------UPDATING STOCK------------------

        //                                int currentQuantity = (int)SQL_TASKS.getProductQuantity(Convert.ToInt32((row.Cells["ProductIDGV"].Value.ToString())));

        //                                int finalQuantity = currentQuantity - Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());

        //                                Hashtable htinsetrStock = new Hashtable();

        //                                htinsetrStock.Add("@prodID", Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString()));

        //                                htinsetrStock.Add("@quan", finalQuantity);

        //                                SQL_TASKS.insert_update_delete("st_updateSTOCK", htinsetrStock);

        //                                Int64 productID = Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString());

        //                                float productPrice = Convert.ToSingle(row.Cells["ProductPriceGV"].Value.ToString());

        //                                int product_quantity = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());

        //                                amount_refund += productPrice;

        //                                amount_to_refund_textBox.Text = Math.Round(amount_refund, 0).ToString();

        //                                if (product_quantity == 0)
        //                                {
        //                                    if (ht.ContainsKey(row.Cells["ProductIDGV"].Value))
        //                                    {
        //                                        Int64 prodIDht = Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString());

        //                                        ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) - 1;
        //                                    }
        //                                    else
        //                                    {
        //                                        ht.Add(row.Cells["ProductIDGV"].Value, 1);
        //                                    }

        //                                    sales_return_dataGridView.Rows.Remove(row);
        //                                }
        //                                else
        //                                {
        //                                    row.Cells["QuantityGV"].Value = product_quantity;

        //                                    row.Cells["PerProductTotalGV"].Value = Convert.ToSingle(row.Cells["PerProductTotalGV"].Value.ToString());

        //                                    if (ht.ContainsKey(row.Cells["ProductIDGV"].Value))
        //                                    {
        //                                        Int64 prodIDht = Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString());

        //                                        ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) + 1;
        //                                    }
        //                                    else
        //                                    {
        //                                        ht.Add(row.Cells["ProductIDGV"].Value, 1);
        //                                    }
        //                                    sales_return_dataGridView.Rows.Remove(row);
        //                                }

        //                            }

        //                        }
        //                        break;
        //                    }
        //                    sc.Complete();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MainClass.ShowMsg(ex.Message, "Error");
        //    }
        //}

        private void return_button_Click(object sender, EventArgs e)
        {
            try
            {

                bool found = false;

                if (barcode_textBox.Text != "")
                {
                    if (sales_return_dataGridView.Rows.Count > 0)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            foreach (DataGridViewRow row in sales_return_dataGridView.Rows)
                            {
                                if (barcode_textBox.Text == row.Cells["BarcodeGV"].Value.ToString())
                                {
                                    DialogResult dr = MessageBox.Show("Are you sure you want to return " + row.Cells["ProductGV"].Value.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (dr == DialogResult.Yes)
                                    {
                                        //----------------------INSERTING RECORD TO REFUND TABLE------------------
                                        Hashtable htx = new Hashtable();

                                        htx.Add("@refSaleID", Convert.ToInt64(row.Cells["saleIDGV"].Value.ToString()));

                                        htx.Add("@refDate", DateTime.Now);

                                        htx.Add("@refDoneBy", Convert.ToInt64(row.Cells["UserIDGV"].Value.ToString()));

                                        htx.Add("@refProdID", Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString()));

                                        htx.Add("@refQuantity", Convert.ToInt64(row.Cells["QuantityGV"].Value.ToString()));

                                        htx.Add("@refAmount", Convert.ToSingle(row.Cells["ProductPriceGV"].Value.ToString()));

                                        int x = 0;

                                        x += SQL_TASKS.insert_update_delete("st_insertRefundReturn", htx);

                                        if (x > 0)
                                        {
                                            MainClass.ShowMsg("Return and Refund Successfull", "Success");
                                            x = 0;
                                            ht.Clear();
                                        }
                                        else
                                        {
                                            throw new Exception("Something went wrong");
                                        }


                                        //----------------------UPDATING STOCK------------------

                                        int currentQuantity = (int)SQL_TASKS.getProductQuantityfromSTOCK(Convert.ToInt64((row.Cells["ProductIDGV"].Value.ToString())));

                                        int finalQuantity = currentQuantity - Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());

                                        Hashtable htinsertStock = new Hashtable();

                                        htinsertStock.Add("@prodID", row.Cells["ProductIDGV"].Value.ToString());

                                        htinsertStock.Add("@quan", finalQuantity);

                                        SQL_TASKS.insert_update_delete("st_updateSTOCK", htinsertStock);

                                        Int64 productID = Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString());

                                        float productPrice = Convert.ToSingle(row.Cells["ProductPriceGV"].Value.ToString());

                                        int product_quantity = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());

                                        amount_refund += productPrice;

                                        amount_to_refund_textBox.Text = Math.Round(amount_refund, 0).ToString();

                                        if (product_quantity == 0)
                                        {
                                            if (ht.ContainsKey(row.Cells["ProductIDGV"].Value))
                                            {
                                                Int64 prodIDht = Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString());

                                                ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) - 1;
                                            }
                                            else
                                            {
                                                ht.Add(row.Cells["ProductIDGV"].Value, 1);
                                            }

                                            sales_return_dataGridView.Rows.Remove(row);
                                        }
                                        else
                                        {
                                            row.Cells["QuantityGV"].Value = product_quantity;

                                            row.Cells["PerProductTotalGV"].Value = Convert.ToSingle(row.Cells["PerProductTotalGV"].Value.ToString());

                                            if (ht.ContainsKey(row.Cells["ProductIDGV"].Value))
                                            {
                                                Int64 prodIDht = Convert.ToInt64(row.Cells["ProductIDGV"].Value.ToString());

                                                ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) + 1;
                                            }
                                            else
                                            {
                                                ht.Add(row.Cells["ProductIDGV"].Value, 1);
                                            }
                                            sales_return_dataGridView.Rows.Remove(row);
                                        }

                                    }
                                    found = true;
                                }
                                if(found)
                                {
                                    break;
                                }
                                
                            }
                            sc.Complete();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }
    }
}
