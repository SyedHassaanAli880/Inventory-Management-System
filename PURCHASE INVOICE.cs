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
    public partial class PURCHASE_INVOICE : sample2
    {
        bool edit = false; int count = 0;

        float gross_total; string productNAME, productBARCODE;

        Int64 purchaseinvoiceID_FROM_SQL_TASKS;
            
        int productID;

        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public PURCHASE_INVOICE()
        {
            InitializeComponent();
        }

        public void enable_crude_buttons()
        {
            add_button.Enabled = true;

            delete_button.Enabled = true;

            cancel_button.Enabled = true;

            view_button.Enabled = true;

            save_button.Enabled = true;
        }

        private string[] loadProductswrtBarcode(string proc, Hashtable ht)
        {
            var sql_con = new SqlConnection(MainClass.connection());

            string[] productswrt = new string[3];

            try
            {
                var command = new SqlCommand(proc, sql_con);

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
                        productswrt[0] = dr[0].ToString();

                        productswrt[1] = dr[1].ToString();

                        productswrt[2] = dr[2].ToString();
                    }
                }
                else
                {
                    MainClass.ShowMsg("No products available....","Error");

                    MainClass.disbale_reset(left_panel_sample2);

                    sql_con.Close();
                }
                
                sql_con.Close();
            }
            catch(Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                MainClass.disbale_reset(left_panel_sample2);

                sql_con.Close();
            }

            return productswrt;
        }

        private string[] GetProductDeatils(string proc, Hashtable ht)
        {
            var sql_con = new SqlConnection(MainClass.connection());

            string[] productswrt = new string[3];

            try
            {
                var command = new SqlCommand(proc, sql_con);

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
                        productswrt[0] = dr[0].ToString();

                        productswrt[1] = dr[1].ToString();

                        productswrt[2] = dr[2].ToString();
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
        public override void add_button_Click(object sender, EventArgs e)
        {
            MainClass.enable_rsest(left_panel_sample2);

            edit = false;

            view_button.Enabled = false;

            delete_button.Enabled = false;
        }

        private void purchaseinvoice_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    add_button.Enabled = false;

                    if (edit == true) //updating member
                    {
                        save_button.Enabled = true;
                    }
                    else if (edit == false) //adding member
                    {
                        save_button.Enabled = false;

                    }

                    if (e.ColumnIndex == 8)
                    {
                        DataGridViewRow row = purchase_dataGridView.Rows[e.RowIndex];

                        gross_total -= Convert.ToSingle(row.Cells["totalGV"].Value.ToString());

                        gross_total_price_label.Text = gross_total.ToString();

                        purchase_dataGridView.Rows.Remove(row);

                        save_button.Enabled = true;

                        view_button.Enabled = false;
                    }
                    else
                    {
                        DataGridViewRow row = purchase_dataGridView.Rows[e.RowIndex];

                        supplier_comboBox.Text = row.Cells["suppliernameGV"].Value.ToString();

                        product_name_textBox_purchase_invoice.Text = row.Cells["productnameGV"].Value.ToString();

                        product_barcode_textBox_purchase_invoice.Text = row.Cells["productbarcodeGV"].Value.ToString();

                        per_unit_price_textBox.Text = row.Cells["perunitpriceGV"].Value.ToString();

                        product_quantity_textBox.Text = row.Cells["productquantityGV"].Value.ToString();

                        MainClass.disbale(left_panel_sample2);

                        delete_button.Enabled = true;
                    }

                }

            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                MainClass.disbale_reset(left_panel_sample2); enable_crude_buttons();
            }
        }

        bool success,correctIT = false;

        public override void save_button_Click(object sender, EventArgs e)
        {
            if(purchase_dataGridView.Rows.Count == 0 || purchase_dataGridView.Rows.Count < 0)
            {
                MainClass.ShowMsg("Please enter all required information.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();

            }
            else
            {
                MainClass.disbale_reset(left_panel_sample2); enable_crude_buttons();
                   
                    try
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            int compare,compareTO;

                            here:

                            for(int i = 0; i < purchase_dataGridView.Rows.Count; ++i)
                            {
                                compare = Convert.ToInt32(purchase_dataGridView.Rows[i].Cells["productIDGV"].Value);

                                for(int j = i+1; j < purchase_dataGridView.Rows.Count; ++j)
                                {
                                    compareTO = Convert.ToInt32(purchase_dataGridView.Rows[j].Cells["productIDGV"].Value);

                                    if (compare == compareTO)
                                    {
                                        if (correctIT == false)
                                        {
                                            DialogResult dr = MessageBox.Show("You added a duplicate product which is not allowed.\n\nDo you want to remove that duplicate product and add its quantity?", "Duplicate product(s) encountered!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                                            if (DialogResult.Yes == dr)
                                            {
                                                correctIT = true;

                                                goto here;
                                            }
                                            else
                                            {
                                                correctIT = false;

                                                throw new Exception("Duplicate products are not allowed!");

                                            }
                                        }
                                        else
                                        {
                                            Int32 originalproductTOTAL, originalproductVALUE, dupliactedproductVALUE, dupliactedproductTOTAL;

                                            originalproductVALUE = Convert.ToInt32(purchase_dataGridView.Rows[i].Cells["productquantityGV"].Value);

                                            dupliactedproductVALUE = Convert.ToInt32(purchase_dataGridView.Rows[j].Cells["productquantityGV"].Value);

                                            originalproductTOTAL = Convert.ToInt32(purchase_dataGridView.Rows[i].Cells["totalGV"].Value);

                                            dupliactedproductTOTAL = Convert.ToInt32(purchase_dataGridView.Rows[j].Cells["totalGV"].Value);

                                            originalproductVALUE += dupliactedproductVALUE;

                                            originalproductTOTAL += dupliactedproductTOTAL;

                                            purchase_dataGridView.Rows[i].Cells["productquantityGV"].Value = originalproductVALUE;

                                            purchase_dataGridView.Rows[i].Cells["totalGV"].Value = originalproductTOTAL;

                                            int beforeREMOVE = purchase_dataGridView.Rows.Count; int afterREMOVE;

                                            purchase_dataGridView.Rows.Remove(purchase_dataGridView.Rows[j]);

                                            afterREMOVE = purchase_dataGridView.Rows.Count;

                                            if(afterREMOVE < beforeREMOVE)
                                            {
                                                MainClass.ShowMsg("Operation successfull.", "Success");
                                            }
                                            else
                                            {
                                                throw new Exception("An error occured during removing duplicated products!");
                                            }
                                        }
                                    }


                                }
                            }

                            SQL_TASKS ss = new SQL_TASKS();

                            foreach (DataGridViewRow row in purchase_dataGridView.Rows)
                            {
                                //inserting purchase invoice

                                purchaseinvoiceID_FROM_SQL_TASKS = ss.insertPurchaseinvoice(DateTime.Today, LoginCodeClass.USERID,Convert.ToInt32(row.Cells["supplierIDGV"].Value));

                                //inserting purchase invoice details

                                count += ss.insertPurchaseinvoicedetails(purchaseinvoiceID_FROM_SQL_TASKS, Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["productquantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));

                                SqlConnection sql_con = new SqlConnection(MainClass.connection());

                                SqlCommand cmd = new SqlCommand();

                                cmd.Connection = sql_con;    

                                cmd.CommandType = CommandType.Text;
                                
                                cmd.CommandText = "select pp_prodID from ProductPrice where pp_ProductBarcode='"+ row.Cells["productbarcodeGV"].Value.ToString() + "' ";

                                sql_con.Open();
                                object check = cmd.ExecuteScalar();

                                sql_con.Close();

                            if (check == null) //product not present
                            {
                                Hashtable ht1 = new Hashtable();

                                ht1.Add("@prodID", row.Cells["productIDGV"].Value.ToString());

                                ht1.Add("@bp", Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));

                                ht1.Add("@sp", DBNull.Value);

                                ht1.Add("@buyingdate", DateTime.Today);

                                ht1.Add("@profitper", DBNull.Value);

                                ht1.Add("@discount", DBNull.Value);

                                ht1.Add("@productbarcode", row.Cells["productbarcodeGV"].Value.ToString());

                                // inserting product price:

                                if (SQL_TASKS.insert_update_delete("st_insertPRODUCTPRICE", ht1) > 0) { success = true; } else { success = false; }
                            }
                            else //product present
                            {
                                cmd.CommandText = "select pp_BuyingDate from ProductPrice where pp_BuyingDate='" + DateTime.Today + "' ";

                                sql_con.Open();

                                DateTime productdate = Convert.ToDateTime(cmd.ExecuteScalar());

                                sql_con.Close();

                                if (productdate == DateTime.Today)
                                {
                                    Hashtable ht2 = new Hashtable();

                                    ht2.Add("@prodID", row.Cells["productIDGV"].Value.ToString());

                                    cmd.CommandText = "select pp_buyingPrice from ProductPrice where pp_BuyingDate='" + DateTime.Today + "' ";

                                    sql_con.Open();

                                    Int64 ExistingBuyingPrice = Convert.ToInt64(cmd.ExecuteScalar());

                                    sql_con.Close();

                                    Int64 finalp = Convert.ToInt64(row.Cells["totalGV"].Value) + ExistingBuyingPrice;

                                    ht2.Add("@bp", finalp); 
                                    
                                    ht2.Add("@sp", DBNull.Value);

                                    ht2.Add("@buyingdate", DateTime.Today);

                                    ht2.Add("@profitper", DBNull.Value);

                                    ht2.Add("@discount", DBNull.Value);

                                    ht2.Add("@productbarcode", row.Cells["productbarcodeGV"].Value.ToString());

                                    // updating product price:

                                    if (SQL_TASKS.insert_update_delete("st_updatePRODUCTPRICEwrtDATE", ht2) > 0) { success = true; } else { success = false; }
                                }
                                else
                                {
                                    Hashtable ht3 = new Hashtable();

                                    ht3.Add("@prodID", row.Cells["productIDGV"].Value.ToString());

                                    ht3.Add("@bp", Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));

                                    ht3.Add("@sp", DBNull.Value);

                                    ht3.Add("@buyingdate", DateTime.Today);

                                    ht3.Add("@productbarcode", row.Cells["productbarcodeGV"].Value.ToString());

                                    //inserting product price:

                                    if (SQL_TASKS.insert_update_delete("st_insertPRODUCTPRICE", ht3) > 0) { success = true; } else { success = false; }
                                }
                            }

                                int q; object stockcount;

                                bool DoesExist = SQL_TASKS.IfProductExist(Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()));
                          

                            if (DoesExist) //if product does exist
                            {
                                //update stock

                                stockcount = SQL_TASKS.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));

                                q = Convert.ToInt32(stockcount);

                                q += Convert.ToInt32(row.Cells["productquantityGV"].Value.ToString());

                                Hashtable hta = new Hashtable();

                                hta.Add("@prodID", Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));

                                hta.Add("@quan", q);

                                //updating stock:

                                if (SQL_TASKS.insert_update_delete("st_updateSTOCK", hta) > 0) { success = true;}
                            }
                            else //if product does not exist
                            {
                                //insert

                                Hashtable htb = new Hashtable();

                                htb.Add("@prodID", Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));

                                htb.Add("@quan", Convert.ToInt32(row.Cells["productquantityGV"].Value.ToString()));

                                // inserting stock:

                                if (SQL_TASKS.insert_update_delete("st_insertSTOCK", htb) > 0) { success = true; } else { success = false;}
                            }
                            
                        
                            }

                            if (count > 0 && success == true)
                            {
                                MainClass.ShowMsg("Purchase Invoice created successfully.", "Success");

                                MainClass.disbale_reset(left_panel_sample2);

                                enable_crude_buttons();

                                purchase_dataGridView.Rows.Clear(); gross_total_price_label.Text = "";
                            }
                            else
                            {
                                MainClass.ShowMsg("Unable to create Purchase Invoice", "Error");

                                MainClass.disbale_reset(left_panel_sample2);

                                enable_crude_buttons();

                                purchase_dataGridView.Rows.Clear(); gross_total_price_label.Text = "";
                            }

                            sc.Complete();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMsg(ex.Message, "Error");

                        MainClass.disbale_reset(left_panel_sample2);

                        enable_crude_buttons();

                    }
                
                         
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {this.Close();}

        public override void search_textBox_TextChanged(object sender, EventArgs e)
        {
            if (search_textBox.Text != "")
            {
                foreach (DataGridViewRow row in purchase_dataGridView.Rows)
                {
                    if (row.Cells["productnameGV"].Value.ToString() != search_textBox.Text)
                    {
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in purchase_dataGridView.Rows)
                {row.Visible = true;}
            }
        }

        public override void cancel_button_Click(object sender, EventArgs e)
        {
            MainClass.disbale_reset(left_panel_sample2);

            enable_crude_buttons();
        }

        private void PURCHASE_INVOICE_Load(object sender, EventArgs e)
        {
            enable_crude_buttons(); MainClass.disbale_reset(left_panel_sample2);

            SQL_TASKS.LoadList("st_loadlistSUPPLIERS", supplier_comboBox,"ID", "Supplier Company");

            total_amount_label.Text = "0.00";

            gross_total_price_label.Text = "0.00";
        }

        private void product_quantity_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (product_quantity_textBox.Text != "")
                {
                    if (rg.Match(product_quantity_textBox.Text).Success)
                    {
                        float quan = 0, price = 0, total = 0;

                        if (product_quantity_textBox.Text == "" || per_unit_price_textBox.Text == "")
                        {
                            throw new Exception("No fields can be empty.Please enter details in an order");
                        }
                        else
                        {
                            quan = Convert.ToSingle(product_quantity_textBox.Text);

                            price = Convert.ToSingle(per_unit_price_textBox.Text);

                            total = quan * price;

                            total_amount_label.Text = total.ToString("############.##");
                        }
                    }
                    else
                    {
                        product_quantity_textBox.SelectAll();
                    }
                }
                else
                {
                    total_amount_label.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                product_barcode_textBox_purchase_invoice.Text = "";

                product_name_textBox_purchase_invoice.Text = "";

                per_unit_price_textBox.Text = ""; product_quantity_textBox.Text = "";
            }
        }

        private void add_to_cart_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.isAdmin != true)
                {
                    if (supplier_comboBox.SelectedIndex == -1 || product_barcode_textBox_purchase_invoice.Text == "" || product_quantity_textBox.Text == "")
                    {
                        MainClass.ShowMsg("Please enter a record to delete.", "error");

                        MainClass.disbale_reset(left_panel_sample2);

                        enable_crude_buttons();
                    }
                    else
                    {
                        

                        if (edit == false)
                        {
                            purchase_dataGridView.Rows.Add(productID, product_name_textBox_purchase_invoice.Text, product_quantity_textBox.Text, per_unit_price_textBox.Text, total_amount_label.Text, supplier_comboBox.SelectedValue, supplier_comboBox.Text.ToString(), product_barcode_textBox_purchase_invoice.Text);

                            gross_total += Convert.ToSingle(total_amount_label.Text);

                            gross_total_price_label.Text = gross_total.ToString();

                            product_barcode_textBox_purchase_invoice.Text = "";

                            product_name_textBox_purchase_invoice.Text = "";

                            product_quantity_textBox.Text = "";

                            per_unit_price_textBox.Text = "";

                            product_barcode_textBox_purchase_invoice.Focus();

                            int exist = -2;
                        }
                        else
                        {
                            purchase_dataGridView.CurrentRow.Cells["suppliernameGV"].Value = supplier_comboBox.Text;

                            purchase_dataGridView.CurrentRow.Cells["productnameGV"].Value = product_name_textBox_purchase_invoice.Text;

                            purchase_dataGridView.CurrentRow.Cells["productbarcodeGV"].Value = product_barcode_textBox_purchase_invoice.Text;

                            int productQUANTITY = Convert.ToInt32(product_quantity_textBox.Text);

                            int productPERUNITPRICE = Convert.ToInt32(per_unit_price_textBox.Text);

                            purchase_dataGridView.CurrentRow.Cells["perunitpriceGV"].Value = per_unit_price_textBox.Text;

                            purchase_dataGridView.CurrentRow.Cells["productquantityGV"].Value = product_quantity_textBox.Text;

                            int productTOTALPRICE = productQUANTITY * productPERUNITPRICE;

                            purchase_dataGridView.CurrentRow.Cells["totalGV"].Value = productTOTALPRICE;

                            gross_total = 0; MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();

                            foreach (DataGridViewRow row in purchase_dataGridView.Rows)
                            {
                                gross_total += Convert.ToSingle(row.Cells["totalGV"].Value);

                                gross_total_price_label.Text = gross_total.ToString();
                            }
                        }
                    }
                }
                else { throw new Exception("Admin cannot create purchase invoice.To create purchase invoice login with a user account."); }
            }
            catch (Exception ex)
            { MainClass.ShowMsg(ex.Message, "Error"); }

            
        }

        private void product_barcode_textBox_purchase_invoice_Validating(object sender, CancelEventArgs e)
        {
            Hashtable ht = new Hashtable();

            ht.Add("@barcode", product_barcode_textBox_purchase_invoice.Text);

            string[] productswrt = new string[3];

            if (product_barcode_textBox_purchase_invoice.Text != "")
            {
                productswrt = loadProductswrtBarcode("st_getPRODUCTbyBarcode", ht);

                productID = Convert.ToInt32(productswrt[0]);

                productNAME = productswrt[1];

                product_name_textBox_purchase_invoice.Text = productNAME;

                productBARCODE = productswrt[2];

                product_name_textBox_purchase_invoice.Enabled = false;

                if (productBARCODE != null)
                {
                    per_unit_price_textBox.Focus();
                }
            }
            else
            {
                productID = 0;

                product_name_textBox_purchase_invoice.Text = "";

                per_unit_price_textBox.Text = "";

                Array.Clear(productswrt, 0, productswrt.Length);
            }
        }

        private void per_unit_price_textBox_TextChanged(object sender, EventArgs e)
        {
            if (per_unit_price_textBox.Text != "")
            {
                if (!rg.Match(per_unit_price_textBox.Text).Success)
                {
                    per_unit_price_textBox.Text = ""; per_unit_price_textBox.Focus();
                }
            }
    
        }

        public override void view_button_Click(object sender, EventArgs e)
        {
            Purchase_Invoice_Details pid = new Purchase_Invoice_Details();

            MainClass.ShowWindow(pid, MDI.ActiveForm);
        }

        public override void edit_button_Click(object sender, EventArgs e)
        {
            if (supplier_comboBox.SelectedIndex == -1 || product_barcode_textBox_purchase_invoice.Text == "" || product_quantity_textBox.Text == "")
            {
                MainClass.ShowMsg("Please enter/select a record to edit.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else
            {
                supplier_comboBox.Enabled = false; product_barcode_textBox_purchase_invoice.Enabled = false;

                product_name_textBox_purchase_invoice.Enabled = false;

                delete_button.Enabled = true;

                save_button.Enabled = true;

                add_button.Enabled = false; edit = true;

                per_unit_price_textBox.Enabled = true; product_quantity_textBox.Enabled = true;

            }
        }

        public override void delete_button_Click(object sender, EventArgs e)
        {
            if(supplier_comboBox.SelectedIndex == -1 || product_barcode_textBox_purchase_invoice.Text == "" || product_quantity_textBox.Text == "")
            {
                MainClass.ShowMsg("Please enter/select a record to delete.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to delete current record.", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ans == DialogResult.Yes)
                    {
                        purchase_dataGridView.Rows.Remove(purchase_dataGridView.CurrentRow);

                        MainClass.disbale_reset(left_panel_sample2);

                        gross_total = 0;

                        foreach (DataGridViewRow row in purchase_dataGridView.Rows)
                        {
                            gross_total += Convert.ToSingle(row.Cells["totalGV"].Value);

                            gross_total_price_label.Text = gross_total.ToString();
                        }

                        MainClass.disbale_reset(left_panel_sample2);

                        enable_crude_buttons();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                    MainClass.disbale_reset(left_panel_sample2);

                    enable_crude_buttons();
                }

            }
        }
    }
}
