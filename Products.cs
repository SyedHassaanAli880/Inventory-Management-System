using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace inv
{
    public partial class Products : sample2
    {
        int edit = 0, productID; // 0 to add record and 1 to update record

        SqlConnection sql_con = new SqlConnection(MainClass.connection());

        SqlCommand cmd = new SqlCommand();
        public Products()
        {
            InitializeComponent();
        }

        void LoadProducts()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(productidGV);

            lb.Items.Add(productnameGV);

            lb.Items.Add(productbarcodeGV);

            lb.Items.Add(expirydateGV);

            lb.Items.Add(categoryIDGV);

            lb.Items.Add(productcategoryGV);

            SQL_TASKS.load_data("st_getPRODUCTS", products_dataGridView, lb);
        }
        private void products_dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    add_button.Enabled = false;

                    if (edit == 1) //updating member
                    {
                        save_button.Enabled = true;
                    }
                    else if (edit == 0) //adding member
                    {
                        save_button.Enabled = false;

                    }

                    DataGridViewRow row = products_dataGridView.Rows[e.RowIndex];

                    productID = Convert.ToInt32(row.Cells["productidGV"].Value.ToString());

                    product_name_textBox.Text = row.Cells["ProductnameGV"].Value.ToString();

                    barcode_textBox.Text = row.Cells["ProductbarcodeGV"].Value.ToString();

                    if (row.Cells["ExpirydateGV"].FormattedValue.ToString() == "")
                    {
                        dateTimePicker_expiry_products.Value = DateTime.Now;
                    }
                    else
                    {
                        dateTimePicker_expiry_products.Value = Convert.ToDateTime(row.Cells["ExpirydateGV"].Value.ToString());
                    }

                    categories_comboBox.SelectedValue = row.Cells["categoryIDGV"].Value.ToString();

                    disable();

                    delete_button.Enabled = true;

                    edit_button.Enabled = true;

                    save_button.Enabled = false;

                    cancel_button.Enabled = true;

                    view_button.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }


        public void reset_enable()
        {
            product_name_textBox.Text = "";

            barcode_textBox.Text = "";

            dateTimePicker_expiry_products.Text = "";

            categories_comboBox.SelectedIndex = -1;

            product_name_textBox.Enabled = true;

            barcode_textBox.Enabled = true;

            dateTimePicker_expiry_products.Enabled = true;

            categories_comboBox.Enabled = true;
        }

        public void enable_crude_buttons()
        {
            add_button.Enabled = true;

            delete_button.Enabled = true;

            cancel_button.Enabled = true;

            view_button.Enabled = true;

            save_button.Enabled = true;
        }

        public void enable()
        {
            product_name_textBox.Enabled = true;

            barcode_textBox.Enabled = true;

            dateTimePicker_expiry_products.Enabled = true;

            categories_comboBox.Enabled = true;
        }

        public void reset_disable()
        {
            product_name_textBox.Text = "";

            barcode_textBox.Text = "";

            dateTimePicker_expiry_products.Text = "";

            categories_comboBox.SelectedIndex = -1;

            product_name_textBox.Enabled = false;

            barcode_textBox.Enabled = false;

            dateTimePicker_expiry_products.Enabled = false;

            categories_comboBox.Enabled = false;
        }

        public void disable()
        {
            product_name_textBox.Enabled = false;

            barcode_textBox.Enabled = false;

            dateTimePicker_expiry_products.Enabled = false;

            categories_comboBox.Enabled = false;
        }

        public override void add_button_Click(object sender, EventArgs e)
        {
            SQL_TASKS.LoadList("st_getcategorieslist", categories_comboBox, "ID", "Category");

            reset_enable();

            edit = 0;

            view_button.Enabled = false;

            delete_button.Enabled = false;
        }

        
        private void Products_Load(object sender, EventArgs e)
        {
            reset_disable();

            LoadProducts();

            SQL_TASKS.LoadList("st_getcategorieslist", categories_comboBox, "ID","Category");

            enable_crude_buttons();
        }

        public override void save_button_Click(object sender, EventArgs e)
        {
            if (product_name_textBox.Text == "" || barcode_textBox.Text == "" || dateTimePicker_expiry_products.Value < DateTime.Today || categories_comboBox.SelectedIndex == -1 )
            {
                MainClass.ShowMsg("Please enter all required information.", "Error");

                reset_disable();

                enable_crude_buttons();
            }
            else
            {

                if (edit == 0) //0 to add record
                {
                    try
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@productname", product_name_textBox.Text);

                        ht.Add("@productbarcode", barcode_textBox.Text);

                        ht.Add("@productexpirydate", dateTimePicker_expiry_products.Value);

                        ht.Add("@productcategoryID", Convert.ToInt32(categories_comboBox.SelectedValue.ToString()));

                        if (SQL_TASKS.insert_update_delete("st_insertPRODUCTS", ht) > 0)
                        {
                            MainClass.ShowMsg(product_name_textBox.Text + " added successfully to the system.", "Success");

                            reset_disable();

                            enable_crude_buttons();

                            LoadProducts();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            reset_disable();

                            enable_crude_buttons();
                        }

                        LoadProducts();

                        enable_crude_buttons();

                        reset_disable();
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMsg(ex.Message, "Error");

                        reset_disable();

                        enable_crude_buttons();
                    }
                }
                else if (edit == 1) // to update record
                {
                    try
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@productid", productID);

                        ht.Add("@productname", product_name_textBox.Text);

                        ht.Add("@productbarcode", barcode_textBox.Text);

                        ht.Add("@productexpirydate", dateTimePicker_expiry_products.Value);

                        ht.Add("@productcategoryID", Convert.ToInt32(categories_comboBox.SelectedValue.ToString()));

                        if (SQL_TASKS.insert_update_delete("st_updatePRODUCTS", ht) > 0)
                        {
                            MainClass.ShowMsg(product_name_textBox.Text + " updated successfully to the system.", "Success");

                            reset_disable();

                            enable_crude_buttons();

                            LoadProducts();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            reset_disable();

                            enable_crude_buttons();
                        }

                        edit = 0;
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMsg(ex.Message, "Error");

                        reset_disable();

                        enable_crude_buttons();
                    }
                }

            }
        }

        public override void delete_button_Click(object sender, EventArgs e)
        {
            if (product_name_textBox.Text == "" || barcode_textBox.Text == "" || dateTimePicker_expiry_products.Text == "" || categories_comboBox.SelectedIndex == -1)
            {
                MainClass.ShowMsg("Please enter a record to delete.", "error");

                reset_disable();

                enable_crude_buttons();
            }
            else if (product_name_textBox.Enabled == true || barcode_textBox.Enabled == true || dateTimePicker_expiry_products.Enabled == true || categories_comboBox.Enabled == true)
            {
                MainClass.ShowMsg("Please select record from the table.", "error");

                reset_disable();

                enable_crude_buttons();
            }
            else if ((product_name_textBox.Enabled == false || barcode_textBox.Enabled == false || dateTimePicker_expiry_products.Enabled == false || categories_comboBox.Enabled == false) && (product_name_textBox.Text != "" || barcode_textBox.Text != "" || dateTimePicker_expiry_products.Text != "" || categories_comboBox.Text != ""))
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to delete current record.", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ans == DialogResult.Yes)
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@id", productID);

                        if (SQL_TASKS.insert_update_delete("st_deletePRODUCTS", ht) > 0)
                        {
                            MainClass.ShowMsg(product_name_textBox.Text + " deleted successfully.", "Success");

                            reset_disable();

                            enable_crude_buttons();

                            LoadProducts();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            reset_disable();

                            enable_crude_buttons();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    reset_disable();

                    sql_con.Close();

                    enable_crude_buttons();
                }

            }
        }

        public override void search_textBox_TextChanged(object sender, EventArgs e)
        {
            if (search_textBox.Text != "")
            {
                ListBox lb = new ListBox();

                lb.Items.Add(productidGV);

                lb.Items.Add(productnameGV);

                lb.Items.Add(productbarcodeGV);

                lb.Items.Add(expirydateGV);

                lb.Items.Add(categoryIDGV);

                lb.Items.Add(productcategoryGV);

                Hashtable ht = new Hashtable();

                ht.Add("@data", search_textBox.Text);

                SQL_TASKS.load_data("st_searchPRODUCTS",products_dataGridView,lb,ht);
            }
            else
            {
                LoadProducts();  
            }
        }

        public override void cancel_button_Click(object sender, EventArgs e)
        {
            reset_disable();

            enable_crude_buttons();
        }

        public override void view_button_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void products_dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.products_dataGridView.Rows[e.RowIndex].Cells["sno"].Value = (e.RowIndex + 1).ToString();
        }

        public override void edit_button_Click(object sender, EventArgs e)
        {
            if (product_name_textBox.Text == "" || barcode_textBox.Text == ""|| dateTimePicker_expiry_products.Text == "" || categories_comboBox.SelectedIndex == -1)
            {
                MainClass.ShowMsg("Please enter a record to edit.", "error");

                reset_disable();

                enable_crude_buttons();
            }
            else
            {
                edit = 1;

                save_button.Enabled = true;

                add_button.Enabled = false;

                enable();

            }
        }
    }
}
