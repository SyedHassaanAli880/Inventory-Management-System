using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Transactions;

namespace inv
{
    public partial class SALES : sample2
    {
        public SALES()
        {
            InitializeComponent();
        }

        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        private string[] loadProductswrtBarcode(string proc, Hashtable ht)
        {
            SqlConnection sql_con = new SqlConnection(MainClass.connection());

            string[] productswrt = new string[6];

            try
            {
                SqlCommand command = new SqlCommand(proc, sql_con);

                command.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    command.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                sql_con.Open();

                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productswrt[0] = dr[0].ToString();//prod ID 

                        productswrt[1] = dr[1].ToString();//product

                        productswrt[2] = dr[2].ToString();//Barcode

                        productswrt[3] = dr[3].ToString();//Selling Price

                        productswrt[4] = dr[4].ToString();//Discount

                        productswrt[5] = dr[5].ToString();//Final Selling Price

                    }
                }
                else
                {
                    MainClass.ShowMsg("No products available....", "Error");

                    MainClass.disbale_reset(left_panel_sample2);

                    sql_con.Close();
                }

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                MainClass.disbale_reset(left_panel_sample2);

                sql_con.Close();
            }

            return productswrt;
        }

        float gross;
        private void SALES_Load(object sender, EventArgs e)
        {
            base.edit_button.Enabled = false; base.edit_button.Text = "Cannot EDIT";

            base.delete_button.Enabled = false; base.delete_button.Text = "Cannot delete from here.";

            base.save_button.Enabled = false; base.save_button.Text = "Cannot SAVE";

        }

        public override void add_button_Click(object sender, EventArgs e)
        {
            product_barcode_textBox.Enabled = true;
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public override void search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        public override void cancel_button_Click(object sender, EventArgs e)
        {
            MainClass.disbale_reset(left_panel_sample2);
        }

        public override void view_button_Click(object sender, EventArgs e)
        {
            Sales_Invoice_Details sd = new Sales_Invoice_Details(); 
            
            MainClass.ShowWindow(sd, MDI.ActiveForm);
        }
        private void product_barcode_textBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                bool productcheck = false;

                Hashtable ht = new Hashtable();

                ht.Add("@barcode", product_barcode_textBox.Text);

                string[] productswrt = new string[6];

                    if (product_barcode_textBox.Text != "")
                    {
                        int qCount = 0, sCount = 0, nCount = 0; 
                    
                        productswrt = loadProductswrtBarcode("st_getPRODUCTbyBarcode", ht);

                        //st_getPRODUCTbyBarcodeFORSALES

                        product_barcode_textBox.Text = "";

                        gross_textBox.Text = "";

                        discount_textBox.Text = "";

                        amount_given_textBox.Text = "";

                        change_to_give_textBox.Text = "";

                        payment_Type_comboBox.SelectedIndex = -1;

                        foreach (DataGridViewRow row in sales_dataGridView.Rows)
                        {
                            if (row.Cells["productIDGV"].Value.ToString() == productswrt[0])
                            {
                                qCount = qCount + Convert.ToInt32(row.Cells["productquantityGV"].Value.ToString());
                            }

                        }

                        sCount = SQL_TASKS.getStockwrtProduct(Convert.ToInt32(productswrt[0]));

                        nCount = sCount - qCount;

                        if (nCount <= 0)
                        {
                            throw new Exception("Product Quanity is finished in stock.");
                        }
                        else
                        {
                        if (sales_dataGridView.Rows.Count == 0)
                        {                                               //product ID     //product name //quantity              //sp                        //sp                   //discount    //discount             //fsp                           //fsp
                            sales_dataGridView.Rows.Add(Convert.ToInt32(productswrt[0]), productswrt[1], 1, Convert.ToSingle(productswrt[3]), Convert.ToSingle(productswrt[3]), productswrt[4], productswrt[4], Convert.ToSingle(productswrt[5]), Convert.ToSingle(productswrt[5]));
                        }
                        else
                        {
                                foreach (DataGridViewRow row in sales_dataGridView.Rows)
                                {
                                    if (row.Cells["productIDGV"].Value.ToString() == productswrt[0])
                                    {
                                        productcheck = true; break;
                                    }
                                    else { productcheck = false; }
                                }

                                if (productcheck)
                                {
                                    foreach (DataGridViewRow row in sales_dataGridView.Rows)
                                    {
                                        if (row.Cells["productIDGV"].Value.ToString() == productswrt[0])
                                        {
                                            float disc = 0;

                                            row.Cells["productquantityGV"].Value = Convert.ToInt32(row.Cells["productquantityGV"].Value) + 1;

                                            if (row.Cells["discountGV"].Value.ToString() != null)
                                            {
                                                disc = Convert.ToSingle(row.Cells["discountGVDUP"].Value.ToString()) * Convert.ToSingle(row.Cells["productquantityGV"].Value.ToString());

                                                row.Cells["discountGV"].Value = disc;
                                            }

                                            float sp = Convert.ToSingle(row.Cells["SellingPriceGVDUP"].Value) * Convert.ToInt64(row.Cells["productquantityGV"].Value);

                                            float tot = (sp - Convert.ToSingle(row.Cells["discountGV"].Value.ToString()));

                                            row.Cells["FinalSellingPriceGV"].Value = tot; row.Cells["SellingPriceGV"].Value = sp;

                                        }
                                    }
                                }                                     //product ID                  //product name      //quantity              //sp                                    //sp                   //discount       //discount             //fsp                           //fsp
                                else { sales_dataGridView.Rows.Add(Convert.ToInt32(productswrt[0]), productswrt[1], 1, Convert.ToSingle(productswrt[3]), Convert.ToSingle(productswrt[3]), productswrt[4], productswrt[4], Convert.ToSingle(productswrt[5]), Convert.ToSingle(productswrt[5])); }


                            }

                            foreach (DataGridViewRow row2 in sales_dataGridView.Rows)
                            {
                                gross += Convert.ToSingle(row2.Cells["FinalSellingPriceGV"].Value.ToString());
                            }

                            gross_total_price_label.Text = Math.Round(gross,0).ToString(); gross = 0;

                            product_barcode_textBox.Focus(); product_barcode_textBox.Text = "";

                        }

                    }


            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }

        }

        private void sales_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                float gt = 0;

                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (e.ColumnIndex == 9)
                    {
                        product_barcode_textBox.Text = "";
                        
                        gross_textBox.Text = "";

                        discount_textBox.Text = "";

                        amount_given_textBox.Text = "";

                        change_to_give_textBox.Text = "";

                        payment_Type_comboBox.SelectedIndex = -1;

                        DataGridViewRow row = sales_dataGridView.Rows[e.RowIndex];

                        int q = Convert.ToInt32(row.Cells["productquantityGV"].Value.ToString());

                        if (q == 1)
                        {
                            gt = Convert.ToSingle(gross_total_price_label.Text);

                            gt = gt - Convert.ToSingle(row.Cells["FinalSellingPriceGV"].Value.ToString());

                            gross_total_price_label.Text = (Convert.ToSingle(gt)).ToString();

                            sales_dataGridView.Rows.Remove(row);
                        }
                        else if (q > 1)
                        {
                            float fsp = Convert.ToSingle(row.Cells["FinalSellingPriceGV"].Value);

                            float fspdup = Convert.ToSingle(row.Cells["FinalSellingPriceGVDUP"].Value);

                            float fspTemp = fsp - fspdup;

                            float sp = Convert.ToSingle(row.Cells["SellingPriceGV"].Value);

                            float spdup = Convert.ToSingle(row.Cells["SellingPriceGVDUP"].Value);

                            float spTemp = sp - spdup;

                            float disc = Convert.ToSingle(row.Cells["discountGV"].Value);

                            float discdup = Convert.ToSingle(row.Cells["discountGVDUP"].Value);

                            float discTemp = disc - discdup;

                            row.Cells["FinalSellingPriceGV"].Value = Convert.ToSingle(fspTemp);

                            row.Cells["SellingPriceGV"].Value = Convert.ToSingle(spTemp);

                            row.Cells["discountGV"].Value = Convert.ToSingle(discTemp);

                            q--; row.Cells["productquantityGV"].Value = q;

                            foreach (DataGridViewRow row2 in sales_dataGridView.Rows)
                            {
                                gt += Convert.ToSingle(row2.Cells["FinalSellingPriceGV"].Value.ToString());
                            }

                            gross_total_price_label.Text = (Convert.ToSingle(gt)).ToString();


                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception ex) { MainClass.ShowMsg(ex.Message, "Error"); }
        }

        private void check_out_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sales_dataGridView.Rows.Count > 0)
                {
                    float disc = 0, gross = 0;

                    foreach (DataGridViewRow row in sales_dataGridView.Rows)
                    {
                        disc += Convert.ToSingle(row.Cells["discountGV"].Value);

                        gross += Convert.ToSingle(row.Cells["FinalSellingPriceGV"].Value);
                    }

                    gross_textBox.Text = Math.Round(gross,0).ToString();

                    discount_textBox.Text = disc.ToString();

                    payment_Type_comboBox.Enabled = true; amount_given_textBox.Enabled = true;
                }
                else { gross_textBox.Text = ""; discount_textBox.Text = ""; }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void amount_given_textBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (amount_given_textBox.Text != "" && gross_textBox.Text != "")
                {
                    if (!(Convert.ToSingle(gross_textBox.Text) <= Convert.ToSingle(amount_given_textBox.Text)))
                    {
                        amount_given_textBox.Text = ""; amount_given_textBox.Focus();

                        change_to_give_textBox.Text = "";
                    }
                    else 
                    {
                        float amountGIVEN = Convert.ToSingle(amount_given_textBox.Text);

                        float amountTOreturn = amountGIVEN - Convert.ToSingle(gross_textBox.Text);

                        change_to_give_textBox.Text = Math.Round(amountTOreturn,0).ToString();
                    }
                }

                
            }
            catch (Exception ex) { MainClass.ShowMsg(ex.Message, "Error"); }
        }

        private void amount_given_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (amount_given_textBox.Text != "")
                {
                    if (!rg.Match(amount_given_textBox.Text).Success)
                    {
                        amount_given_textBox.Text = ""; amount_given_textBox.Focus();
                    }
                }
                else { change_to_give_textBox.Text = ""; }
            }
            catch (Exception ex) { MainClass.ShowMsg(ex.Message, "Error"); }
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (gross_textBox.Text != "" && discount_textBox.Text != "" && payment_Type_comboBox.SelectedIndex != -1 && change_to_give_textBox.Text != "" && amount_given_textBox.Text != "")
                {
                    Hashtable ht = new Hashtable();

                    ht.Add("@done", LoginCodeClass.USERID);

                    ht.Add("@date", DateTime.Now);

                    ht.Add("@totalamt", Convert.ToSingle(gross_textBox.Text));

                    ht.Add("@totaldisc", Convert.ToSingle(discount_textBox.Text));

                    ht.Add("@givenamt", Convert.ToSingle(amount_given_textBox.Text));

                    ht.Add("@return", Convert.ToSingle(change_to_give_textBox.Text));

                    if (payment_Type_comboBox.SelectedIndex == 0)
                    {
                        ht.Add("@payType", 0); //0 means cash
                    }
                    else if (payment_Type_comboBox.SelectedIndex == 1)
                    {
                        ht.Add("@payType", 1);//1 means debit
                    }
                    else { ht.Add("@payType", 2); } //2 means credit

                    DialogResult dr = MessageBox.Show("\n\tTotal Amount: " + gross_textBox.Text + "\n\tTotal Discount: " + discount_textBox.Text + "\n\tAmount Given: " + amount_given_textBox.Text + "\n\tAmount to return: " + change_to_give_textBox.Text + "\n\tPayment Type: " + payment_Type_comboBox.SelectedItem.ToString() + " \n\nAre you sure you want to submit current sales?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == dr)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            if (SQL_TASKS.insert_update_delete("st_insertSALES", ht) > 0)
                            {
                                foreach (DataGridViewRow row in sales_dataGridView.Rows)
                                {
                                    int CurrentProductQuan = SQL_TASKS.getStockwrtProduct(Convert.ToInt32(row.Cells["ProductIDGV"].Value));

                                    Hashtable ht1 = new Hashtable();

                                    int x = CurrentProductQuan - Convert.ToInt32(row.Cells["ProductquantityGV"].Value);

                                    ht1.Add("@prodID", Convert.ToInt32(row.Cells["ProductIDGV"].Value));

                                    ht1.Add("@quan", x);

                                    SQL_TASKS.insert_update_delete("st_updateSTOCK", ht1);

                                    Hashtable ht2 = new Hashtable();

                                    ht2.Add("@saleID",SQL_TASKS.getLASTID("st_getSalesID"));

                                    ht2.Add("@prodID",Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()));

                                    ht2.Add("@quantity", Convert.ToInt32(row.Cells["productquantityGV"].Value.ToString()));

                                    SQL_TASKS.insert_update_delete("st_insertSalesDetails", ht2);
                                }

                                MainClass.ShowMsg("Record saved successfully.", "Success");

                                MainClass.disbale_reset(left_panel_sample2); 
                                
                                sales_dataGridView.Rows.Clear();

                                SALES_REPORT sr = new SALES_REPORT();

                                sr.Show();

                                gross_total_price_label.Text = "0.00";
                            }
                            else
                            {
                                throw new Exception("Unable to save record.");
                            }
                            sc.Complete();
                        }
                        
                    }
                }
                else
                {
                    throw new Exception("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }

        }
    }

}
