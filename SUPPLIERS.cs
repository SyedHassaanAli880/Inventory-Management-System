using System;
using System.Collections;
using System.Windows.Forms;

namespace inv
{
    public partial class SUPPLIERS : sample2
    {
        bool edit = false;
        
        int supplierID; 

        Int16 stat;

        public SUPPLIERS()
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

        private void suppliers_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
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

                    DataGridViewRow row = suppliers_dataGridView.Rows[e.RowIndex];

                    supplierID = Convert.ToInt32(row.Cells["supplierIDGV"].Value.ToString());

                    supplier_name_textBox.Text = row.Cells["suppliernameGV"].Value.ToString();

                    contact_person_textBox.Text = row.Cells["contactpersonnameGV"].Value.ToString();

                    phone1_textBox.Text = row.Cells["phone1GV"].Value.ToString();

                    phone2_textBox.Text = row.Cells["phone2GV"].Value.ToString();

                    address_textBox_suppliers.Text = row.Cells["addressGV"].Value.ToString();

                    supplier_status_comboBox.SelectedItem = row.Cells["statusGV"].Value.ToString();

                    NTN_textBox.Text = row.Cells["ntnGV"].Value.ToString();

                    
                }

            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        public void loadSuppliers()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(supplierIDGV);

            lb.Items.Add(suppliernameGV);

            lb.Items.Add(contactpersonnameGV);

            lb.Items.Add(phone1GV);

            lb.Items.Add(phone2GV);

            lb.Items.Add(addressGV);

            lb.Items.Add(ntnGV);

            lb.Items.Add(statusGV);

            SQL_TASKS.load_data("st_getSUPPLIERS", suppliers_dataGridView, lb);
        }

        public override void add_button_Click(object sender, EventArgs e)
        {
            MainClass.enable_rsest(left_panel_sample2);

            edit = false;

            view_button.Enabled = false;

            delete_button.Enabled = false;
        }

        public override void save_button_Click(object sender, EventArgs e)
        {
            if (supplier_name_textBox.Text == "" || contact_person_textBox.Text == "" || phone1_textBox.Text == "" || address_textBox_suppliers.Text == "" || NTN_textBox.Text == "" || supplier_status_comboBox.SelectedIndex == -1)
            {
                MainClass.ShowMsg("Please enter all required information.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else
            {

                if (Convert.ToString(supplier_status_comboBox.SelectedItem) == "Active")
                {
                    stat = 1; //active
                }
                else if (Convert.ToString(supplier_status_comboBox.SelectedItem) == "In-active")
                {
                    stat = 0; //in-active
                }

                if (edit == false) //0 to add record
                {
                    try
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@suppliername", supplier_name_textBox.Text);

                        ht.Add("@contactpersonname", contact_person_textBox.Text);

                        ht.Add("@phone1", phone1_textBox.Text);

                        ht.Add("@phone2", phone2_textBox.Text);

                        ht.Add("@address", address_textBox_suppliers.Text);

                        ht.Add("@ntn", NTN_textBox.Text);

                        ht.Add("@status", stat);

                        if (SQL_TASKS.insert_update_delete("st_insertSUPPLIERS", ht) > 0)
                        {
                            MainClass.ShowMsg(supplier_name_textBox.Text + " added successfully to the system.", "Success");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();

                            loadSuppliers();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();
                        }
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMsg(ex.Message, "Error");

                        MainClass.disbale_reset(left_panel_sample2);

                        enable_crude_buttons();
                    }
                }
                else if (edit == true) // to update record
                {
                    if (Convert.ToString(supplier_status_comboBox.SelectedItem) == "Active")
                    {
                        stat = 1; //active
                    }
                    else if (Convert.ToString(supplier_status_comboBox.SelectedItem) == "In-active")
                    {
                        stat = 0; //in-active
                    }

                    try
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@suppliername", supplier_name_textBox.Text);

                        ht.Add("@contactpersonname", contact_person_textBox.Text);

                        ht.Add("@phone1", phone1_textBox.Text);

                        ht.Add("@phone2", phone2_textBox.Text);

                        ht.Add("@address", address_textBox_suppliers.Text);

                        ht.Add("@ntn", NTN_textBox.Text);

                        ht.Add("@status", stat);

                        ht.Add("@supp_id", supplierID);

                        if (SQL_TASKS.insert_update_delete("st_updateSUPPLIERS", ht) > 0)
                        {
                            MainClass.ShowMsg(supplier_name_textBox.Text + " updated successfully.", "Success");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();

                            loadSuppliers();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();
                        }
                        edit = false;

                        loadSuppliers();
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMsg(ex.Message, "error");

                        MainClass.disbale_reset(left_panel_sample2);

                        enable_crude_buttons();
                    }
                }

            }
        }

        public override void delete_button_Click(object sender, EventArgs e)
        {
            if (supplier_name_textBox.Text == "" || contact_person_textBox.Text == "" || phone1_textBox.Text == "" || address_textBox_suppliers.Text == "" || NTN_textBox.Text == "" || supplier_status_comboBox.SelectedIndex == -1)
            {
                MainClass.ShowMsg("Please enter a record to delete.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else if (supplier_name_textBox.Enabled == true || contact_person_textBox.Enabled == true || phone1_textBox.Enabled == true || address_textBox_suppliers.Enabled == true || NTN_textBox.Enabled == true || supplier_status_comboBox.Enabled == true)
            {
                MainClass.ShowMsg("Please select record from the table.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else if ((supplier_name_textBox.Enabled == false || contact_person_textBox.Enabled == false || phone1_textBox.Enabled == false || address_textBox_suppliers.Enabled == false || NTN_textBox.Enabled == false || supplier_status_comboBox.Enabled == false) && (supplier_name_textBox.Text != "" || contact_person_textBox.Text != "" || phone1_textBox.Text != "" || address_textBox_suppliers.Text != "" || NTN_textBox.Text != "" || supplier_status_comboBox.SelectedIndex != -1))
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to delete current record.", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ans == DialogResult.Yes)
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@supp_id", supplierID);

                        if (SQL_TASKS.insert_update_delete("st_deleteSUPPLIERS", ht) > 0)
                        {
                            MainClass.ShowMsg(supplier_name_textBox.Text + " deleted successfully.", "Success");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();

                            loadSuppliers();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();
                        }

                        MainClass.disbale_reset(left_panel_sample2);

                        enable_crude_buttons();

                        loadSuppliers();

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

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public override void search_textBox_TextChanged(object sender, EventArgs e)
        {
            if (search_textBox.Text != "")
            {
                ListBox lb = new ListBox();

                lb.Items.Add(supplierIDGV);

                lb.Items.Add(suppliernameGV);

                lb.Items.Add(contactpersonnameGV);

                lb.Items.Add(phone1GV);

                lb.Items.Add(phone2GV);

                lb.Items.Add(addressGV);

                lb.Items.Add(ntnGV);

                lb.Items.Add(statusGV);

                Hashtable ht = new Hashtable();

                ht.Add("@data", search_textBox.Text);

                SQL_TASKS.load_data("st_searchSUPPLIERS", suppliers_dataGridView, lb, ht);
            }
            else
            {
                loadSuppliers();
            }
        }

        public override void cancel_button_Click(object sender, EventArgs e)
        {
            MainClass.disbale_reset(left_panel_sample2);

            enable_crude_buttons();

            loadSuppliers();
        }

        public override void view_button_Click(object sender, EventArgs e)
        {
            loadSuppliers();
        }

        public override void edit_button_Click(object sender, EventArgs e)
        {
            if (supplier_name_textBox.Text == "" || contact_person_textBox.Text == "" || phone1_textBox.Text == "" || address_textBox_suppliers.Text == "" || NTN_textBox.Text == "" || supplier_status_comboBox.SelectedIndex == -1)
            {
                MainClass.ShowMsg("Please enter a record to edit.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else
            {
                edit = true;

                save_button.Enabled = true;

                add_button.Enabled = false;

                MainClass.enable(left_panel_sample2);

            }
        }

        private void SUPPLIERS_Load(object sender, EventArgs e)
        {
            loadSuppliers(); 
            
            enable_crude_buttons(); 
            
            MainClass.disbale_reset(left_panel_sample2);
        }

        private void suppliers_dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.suppliers_dataGridView.Rows[e.RowIndex].Cells["snoGV"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
