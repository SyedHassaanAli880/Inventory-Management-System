using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace inv
{
    public partial class CATEGORIES : sample2
    {
        int edit = 0, categoryID; // 0 for add record and 1 for update record

        Int16 stat;

        SqlConnection sql_con = new SqlConnection(MainClass.connection());

        SqlCommand cmd = new SqlCommand();

        public CATEGORIES()
        {
            InitializeComponent();
        }

        public void LoadCategory()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(categoryidGV);

            lb.Items.Add(categorynameGV);

            lb.Items.Add(categorystatusGV);

            SQL_TASKS.load_data("st_getcategoriesdata",categories_dataGridView,lb);
        }

        public void reset_enable()
        {
            category_name_textBox.Enabled = true;

            category_name_textBox.Text = "";

            is_active_category_comboBox.Enabled = true;

            is_active_category_comboBox.SelectedIndex = -1;
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
            category_name_textBox.Enabled = true;

            is_active_category_comboBox.Enabled = true;
        }

        public void reset_disable()
        {
            category_name_textBox.Enabled = false;

            category_name_textBox.Text = "";

            is_active_category_comboBox.Enabled = false;

            is_active_category_comboBox.SelectedIndex = -1;
        }

        public void disable()
        {
            category_name_textBox.Enabled = false;

            is_active_category_comboBox.Enabled = false;
        }

        private void CATEGORIES_Load(object sender, EventArgs e)
        {
            
            reset_disable();

            LoadCategory();

            enable_crude_buttons();

        }

        public override void add_button_Click(object sender, EventArgs e)
        {
            reset_enable();

            edit = 0;

            view_button.Enabled = false;

            delete_button.Enabled = false;
        }

        public override void save_button_Click(object sender, EventArgs e)
        {
            if (category_name_textBox.Text == "" || is_active_category_comboBox.SelectedIndex == -1)
            { 
                MainClass.ShowMsg("Please enter all required information.", "error");

                reset_disable();

                enable_crude_buttons();
            }
            else
            {
                if (Convert.ToString(is_active_category_comboBox.SelectedItem) == "Yes")
                {
                    stat = 1; //active
                }
                else if (Convert.ToString(is_active_category_comboBox.SelectedItem) == "No")
                {
                    stat = 0; //in-active
                }

                if (edit == 0) //0 to add record
                {
                    try
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@name", category_name_textBox.Text);

                        ht.Add("@isActive", stat);

                        if (SQL_TASKS.insert_update_delete("st_insertcategories", ht) > 0)
                        {
                            MainClass.ShowMsg(category_name_textBox.Text + " added successfully to the system.", "Success");

                            reset_disable();

                            enable_crude_buttons();

                            LoadCategory();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            reset_disable();

                            enable_crude_buttons();
                        }

                        LoadCategory();

                        enable_crude_buttons();

                        reset_disable();
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMsg(ex.Message, "error");

                        reset_disable();

                        enable_crude_buttons();
                    }
                }
                else if (edit == 1) // to update record
                {
                    if (Convert.ToString(is_active_category_comboBox.SelectedItem) == "Yes")
                    {
                        stat = 1; //active
                    }
                    else if (Convert.ToString(is_active_category_comboBox.SelectedItem) == "No")
                    {
                        stat = 0; //in-active
                    }
                    
                    try
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@id", categoryID);

                        ht.Add("@name", category_name_textBox.Text);

                        ht.Add("@isActive", stat);

                        if (SQL_TASKS.insert_update_delete("st_updatecategories", ht) > 0)
                        {
                            MainClass.ShowMsg(category_name_textBox.Text + " updated successfully to the system.", "Success");

                            reset_disable();

                            enable_crude_buttons();

                            LoadCategory();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            reset_disable();

                            enable_crude_buttons();
                        }

                        LoadCategory();

                        edit = 0;
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMsg(ex.Message, "error");

                        reset_disable();

                        enable_crude_buttons();
                    }
                }

            }
        }

        public override void delete_button_Click(object sender, EventArgs e)
        {
            if (category_name_textBox.Text == ""|| is_active_category_comboBox.SelectedIndex == -1)
            {
                MainClass.ShowMsg("Please enter a record to delete.", "error");

                reset_disable();

                enable_crude_buttons();
            }
            else if (category_name_textBox.Enabled == true || is_active_category_comboBox.Enabled == true)
            {
                MainClass.ShowMsg("Please select record from the table.", "error");

                reset_disable();

                enable_crude_buttons();
            }
            else if ((category_name_textBox.Enabled == false && is_active_category_comboBox.Enabled == false) && (category_name_textBox.Text != "" && is_active_category_comboBox.SelectedIndex != -1))
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to delete current record.", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ans == DialogResult.Yes)
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@id", categoryID);

                        if (SQL_TASKS.insert_update_delete("st_deletecategories", ht) > 0)
                        {
                            MainClass.ShowMsg(category_name_textBox.Text + " deleted successfully.", "Success");

                            reset_disable();

                            enable_crude_buttons();

                            LoadCategory();

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

                lb.Items.Add(categoryidGV);

                lb.Items.Add(categorynameGV);

                lb.Items.Add(categorystatusGV);

                Hashtable ht = new Hashtable();

                ht.Add("@data", search_textBox.Text);

                SQL_TASKS.load_data("st_searchCATEGORIES", categories_dataGridView, lb, ht);
            }
            else
            {
                LoadCategory();
            }
        }

        public override void cancel_button_Click(object sender, EventArgs e)
        {
            reset_disable();

            enable_crude_buttons();
        }

        public override void view_button_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void categories_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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

                DataGridViewRow row = categories_dataGridView.Rows[e.RowIndex];

                categoryID = Convert.ToInt32(row.Cells["categoryidGV"].Value.ToString());

                category_name_textBox.Text = row.Cells["categorynameGV"].Value.ToString();

                is_active_category_comboBox.SelectedValue = row.Cells["categorystatusGV"].Value.ToString();

                disable();

                delete_button.Enabled = true;

                edit_button.Enabled = true;

                save_button.Enabled = false;

                cancel_button.Enabled = true;

                view_button.Enabled = true;

                is_active_category_comboBox.Enabled = true;
            }
        }

        private void categories_dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.categories_dataGridView.Rows[e.RowIndex].Cells["snoGV"].Value = (e.RowIndex + 1).ToString();
        }

        public override void edit_button_Click(object sender, EventArgs e)
        {
            if (category_name_textBox.Text == "" || is_active_category_comboBox.SelectedIndex == -1)
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
