using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace inv
{
    public partial class PRODUCT_PRICING : sample2
    {
        public PRODUCT_PRICING()
        {
            InitializeComponent();
        }

        void LoadProducts()
        {
            Hashtable ht = new Hashtable();

            ht.Add("@categID", Convert.ToInt32(category_comboBox_product_pricing.SelectedValue));

            ListBox lb = new ListBox();

            lb.Items.Add(productIDGV);

            lb.Items.Add(productnameGV);

            lb.Items.Add(buyingpriceGV);

            lb.Items.Add(PerUnitPriceGV);

            lb.Items.Add(QuantityGV);

            lb.Items.Add(BarcodeGV);

            SQL_TASKS.load_data("getPRODUCTSwrtCATEGORIES", product_pricing_dataGridView, lb,ht);
        }

        public void enable_crude_buttons()
        {
            add_button.Enabled = true;

            delete_button.Enabled = true;

            cancel_button.Enabled = true;

            view_button.Enabled = true;

            save_button.Enabled = true;
        }

        public override void add_button_Click(object sender, EventArgs e)
        {
            category_comboBox_product_pricing.Enabled = true;
        }

        public override void save_button_Click(object sender, EventArgs e)
        {
            bool success = false; 
            
            int che = 0;
            
            try
            {
                if (category_comboBox_product_pricing.SelectedIndex != -1 && product_pricing_dataGridView.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in product_pricing_dataGridView.Rows)
                    {
                        if ((bool)row.Cells["selectGV"].FormattedValue == true)
                        {
                            ++che;

                            float disc, pm, sp;

                            disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());

                            pm = row.Cells["profitmarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitmarginGV"].Value.ToString());

                            Hashtable ht = new Hashtable();

                            ht.Add("@prodID", row.Cells["productIDGV"].Value.ToString());

                            ht.Add("@bp", Convert.ToSingle(row.Cells["buyingpriceGV"].Value.ToString()));

                            if (disc == 0 && pm == 0)
                            {
                                sp = Convert.ToSingle(row.Cells["buyingpriceGV"].Value.ToString());
                            }
                            else { sp = Convert.ToSingle(row.Cells["finalpriceGV"].Value.ToString()); }

                            ht.Add("@sp", sp);

                            ht.Add("@buyingdate", DateTime.Today);

                            ht.Add("@profitper", pm);

                            ht.Add("@discount", disc);

                            ht.Add("@productbarcode", row.Cells["BarcodeGV"].Value.ToString());

                            if (SQL_TASKS.insert_update_delete("st_updatePRODUCTPRICE", ht) > 0)
                            {
                                success = true;
                            }
                            else { success = false; }
                        }
                    }
                        if (success && che > 0)
                        { 
                            MainClass.ShowMsg("Updated successfully...", "Success"); enable_crude_buttons(); che = 0;
                        }
                        else
                        { 
                            throw new Exception("Unbale to update.Verify if the product is checked."); che = 0; 
                        }
                    
                }
                else { throw new Exception("Select a product first!"); che = 0; }
            }
            catch(Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                enable_crude_buttons();

                che = 0;
            }
        }

        public override void delete_button_Click(object sender, EventArgs e)
        {

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

        }

        public override void view_button_Click(object sender, EventArgs e)
        {

        }

        public override void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void PRODUCT_PRICING_Load(object sender, EventArgs e)
        {
            SQL_TASKS.LoadList("st_getcategorieslist", category_comboBox_product_pricing, "ID", "Category");

            enable_crude_buttons();

            product_pricing_dataGridView.AutoGenerateColumns = false;

            foreach (DataGridViewRow row in product_pricing_dataGridView.Rows)
            {
                product_pricing_dataGridView.Rows.Remove(row);
            }

        }

        private void category_comboBox_product_pricing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category_comboBox_product_pricing.SelectedIndex != -1)
            {
                LoadProducts();
            }
        }
        
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        private void product_pricing_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DataGridViewRow row = product_pricing_dataGridView.Rows[e.RowIndex];

                    if (row.Cells["profitmarginGV"].Value != null && rg.Match(row.Cells["profitmarginGV"].Value.ToString()).Success)
                    {
                        float perunitPrice = (Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()));

                        float profitmargin = (Convert.ToSingle(row.Cells["profitmarginGV"].Value.ToString()) / 100);

                        float amountTOincrease = profitmargin * perunitPrice;

                        float finalsellingprice = perunitPrice + amountTOincrease;

                        float discount;

                        if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                        {
                            discount = finalsellingprice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                        }
                        else
                        {
                            discount = 0;
                        }

                        row.Cells["finalpriceGV"].Value = finalsellingprice-discount;
                    }
                    else
                    {
                        row.Cells["finalpriceGV"].Value = null;
                        row.Cells["profitmarginGV"].Value = null;
                        row.Cells["discountGV"].Value = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void product_pricing_dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.product_pricing_dataGridView.Rows[e.RowIndex].Cells["snoGV"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
