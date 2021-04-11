using System;
using System.Collections;
using System.Transactions;
using System.Windows.Forms;

namespace inv
{
    public partial class Purchase_Invoice_Details : sample2
    {
        public Purchase_Invoice_Details()
        {
            InitializeComponent();
        }

        private void LoadPurchaseInvoiceDetails()
        {
            Hashtable ht = new Hashtable();

            ht.Add("@purchaseinvoiceID", Convert.ToInt64(purchaseinvoice_comboBox.SelectedValue));

            ListBox lb = new ListBox();

            lb.Items.Add(purchaseinvoiceIDGV);

            lb.Items.Add(productIDGV);

            lb.Items.Add(productnameGV);

            lb.Items.Add(productquantityGV);

            lb.Items.Add(perunitpriceGV);

            lb.Items.Add(totalGV);

            SQL_TASKS.load_data("st_getPURCHASEINVOICEDETAILS", purchaseinvoice_dataGridView, lb,ht);

        }

        private void Purchase_Invoice_Details_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();

            ht.Add("@month", dateTimePicker_invoicedetails.Value.Month);

            ht.Add("@year", dateTimePicker_invoicedetails.Value.Year);

            SQL_TASKS.LoadListModifiedHashTable("st_getPURCHASEINVOICELIST", purchaseinvoice_comboBox, "ID", "Company", ht);

            purchaseinvoice_dataGridView.AutoGenerateColumns = false;

            //LoadPurchaseInvoiceDetails(); 
            
            //purchaseinvoice_comboBox.SelectedIndex = -1;

            base.add_button.Visible = false; 
            
            base.view_button.Visible = false;

            base.edit_button.Visible = false; 
            
            base.delete_button.Visible = false;

            base.search_groupBox.Visible = false;

            base.save_button.Visible = false; 
            
            base.cancel_button.Visible = false;
        }

        private void dateTimePicker_invoicedetails_ValueChanged(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();

            ht.Add("@month", dateTimePicker_invoicedetails.Value.Month);

            ht.Add("@year", dateTimePicker_invoicedetails.Value.Year);

            SQL_TASKS.LoadListModifiedHashTable("st_getPURCHASEINVOICELIST", purchaseinvoice_comboBox, "ID", "Company", ht);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            PURCHASE_INVOICE pinv = new PURCHASE_INVOICE();

            MainClass.ShowWindow(pinv,MDI.ActiveForm);
        }

        private void purchaseinvoice_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purchaseinvoice_comboBox.SelectedIndex != -1 && purchaseinvoice_comboBox.SelectedIndex != 0)
            {
                LoadPurchaseInvoiceDetails();

                float gt = 0;

                foreach (DataGridViewRow row in purchaseinvoice_dataGridView.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalGV"].Value);
                }
                
                gross_total_price_label.Text = gt.ToString();
            }
        }

        private void purchaseinvoice_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (LoginCodeClass.isAdmin != true)
                {
                    if (e.RowIndex != -1 && e.ColumnIndex != -1)
                    {
                        if (e.ColumnIndex == 6)
                        {
                            DataGridViewRow row = purchaseinvoice_dataGridView.Rows[e.RowIndex];

                            DialogResult dr = MessageBox.Show("Are you sure you want to delete?\n\nIt will affect your stock.", "PRODUCT DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dr == DialogResult.Yes)
                            {
                                using (TransactionScope sc = new TransactionScope())
                                {
                                    Hashtable ht = new Hashtable();

                                    ht.Add("@purchID", Convert.ToInt64(purchaseinvoice_comboBox.SelectedValue.ToString()));

                                    ht.Add("@userID", LoginCodeClass.USERID);

                                    ht.Add("@proID", Convert.ToInt32(row.Cells["productIDGV"].Value));

                                    ht.Add("@quan", Convert.ToInt32(row.Cells["productquantityGV"].Value));

                                    ht.Add("@date", DateTime.Today);

                                    SQL_TASKS.insert_update_delete("st_insertDeletedItemPI", ht);

                                    int q; object ob;

                                    ob = SQL_TASKS.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));

                                    bool update = true;

                                    if (ob != null || Convert.ToInt32(ob) != 0)
                                    { update = true; }
                                    else { update = false; }

                                    if (update)
                                    {
                                        //update

                                        q = Convert.ToInt32(ob);

                                        q -= Convert.ToInt32(row.Cells["productquantityGV"].Value.ToString());

                                        Hashtable ht1 = new Hashtable();

                                        ht1.Add("@prodID", Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));

                                        ht1.Add("@quan", q);

                                        SQL_TASKS.insert_update_delete("st_updateSTOCK", ht1);

                                        Hashtable ht3 = new Hashtable();

                                        ht3.Add("@purchaseinvoicedetailsID", Convert.ToInt64(row.Cells["purchaseinvoiceIDGV"].Value.ToString()));

                                        if (SQL_TASKS.insert_update_delete("st_deletePRODUCTSfromPURCHASEINVOICEDETAILS", ht3) > 0)
                                        {
                                            MainClass.ShowMsg("Deleted successfully.", "Success");

                                            gross_total_price_label.Text = "0.00";

                                            LoadPurchaseInvoiceDetails(); purchaseinvoice_comboBox.SelectedIndex = -1;
                                        }
                                        else
                                        {
                                            MainClass.ShowMsg("Unable to delete.", "Error");

                                            gross_total_price_label.Text = "0.00";

                                            purchaseinvoice_comboBox.SelectedIndex = -1;
                                        }

                                        sc.Complete();

                                    }
                                }
                            }
                        }
                    }
                }
                else { throw new Exception("Admin cannot delete purchase invoice details.To delete purchase invoice details login with an user account."); }
            }
            catch(Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();

            ht.Add("@month", dateTimePicker_invoicedetails.Value.Month);

            ht.Add("@year", dateTimePicker_invoicedetails.Value.Year);

            SQL_TASKS.LoadListModifiedHashTable("st_getPURCHASEINVOICELIST", purchaseinvoice_comboBox, "ID", "Company", ht);

            purchaseinvoice_dataGridView.AutoGenerateColumns = false;

            LoadPurchaseInvoiceDetails(); gross_total_price_label.Text = "0.00";

        }
    }
}
