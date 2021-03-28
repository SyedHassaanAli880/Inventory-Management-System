using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace inv
{
    public partial class users :sample2 
    {
        int edit = 0,USERID; // 0 for add record and 1 for update record

        Int16 stat;

        string temp_name,temp_username,temp_password,temp_mail,temp_phone,temp_status;

        SqlConnection sql_con = new SqlConnection(MainClass.connection());

        SqlCommand cmd = new SqlCommand();

        public users()
        {
            InitializeComponent();
        }

        private void users_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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

                    DataGridViewRow row = users_dataGridView.Rows[e.RowIndex];

                    USERID = Convert.ToInt32(row.Cells["useridGV"].Value.ToString());

                    name_textBox.Text = row.Cells["nameGV"].Value.ToString();

                    email_textBox.Text = row.Cells["emailGV"].Value.ToString();

                    password_textBox.Text = row.Cells["passwordGV"].Value.ToString();

                    phone_number_textBox.Text = row.Cells["phonenumberGV"].Value.ToString();

                    status_comboBox.SelectedItem = row.Cells["statusGV"].Value.ToString();

                    role_textBox.Text = row.Cells["roleGV"].Value.ToString();

                    MainClass.disbale(left_panel_sample2);

                    delete_button.Enabled = true;

                    edit_button.Enabled = true;

                    save_button.Enabled = false;

                    cancel_button.Enabled = true;

                    view_button.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        public void loadUsers()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(useridGV);

            lb.Items.Add(nameGV);

            lb.Items.Add(emailGV);

            lb.Items.Add(passwordGV);

            lb.Items.Add(phonenumberGV);

            

            lb.Items.Add(statusGV);

            lb.Items.Add(roleGV);

            SQL_TASKS.load_data("st_getusersdata", users_dataGridView,lb);
        }

        public void enable_crude_buttons()
        {
            add_button.Enabled = true;

            delete_button.Enabled = true;

            cancel_button.Enabled = true;

            view_button.Enabled = true;

            save_button.Enabled = true;
        }
        private void users_Load(object sender, EventArgs e)
        {
            loadUsers();

            MainClass.disbale_reset(left_panel_sample2);

            enable_crude_buttons();

        }

        public override void add_button_Click(object sender, EventArgs e)
        {
            MainClass.enable_rsest(left_panel_sample2);

            edit = 0;

            view_button.Enabled = false;

            delete_button.Enabled = false;
        }

        private void users_dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.users_dataGridView.Rows[e.RowIndex].Cells["snoGV"].Value = (e.RowIndex + 1).ToString();
        }

        private void search_textBox_TextChanged_1(object sender, EventArgs e)
        {
            if (search_textBox.Text != "")
            {
                ListBox lb = new ListBox();

                lb.Items.Add(useridGV);

                lb.Items.Add(emailGV);

                lb.Items.Add(passwordGV);

                lb.Items.Add(phonenumberGV);

                lb.Items.Add(statusGV);

                lb.Items.Add(roleGV);

                Hashtable ht = new Hashtable();

                ht.Add("@data", search_textBox.Text);

                SQL_TASKS.load_data("st_getusersdatalike", users_dataGridView, lb, ht);
            }
            else
            {
                loadUsers();
            }
  
        }

        public override void edit_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "" || phone_number_textBox.Text == "" || email_textBox.Text == "" || password_textBox.Text == "" || username_textBox.Text == "")
            {
                MainClass.ShowMsg("Please enter a record to edit.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else
            {
                edit = 1;

                temp_name = name_textBox.Text;

                temp_phone = phone_number_textBox.Text;

                temp_username = username_textBox.Text;

                temp_password = password_textBox.Text;

                temp_mail = email_textBox.Text;

                temp_status = status_comboBox.Text;

                save_button.Enabled = true;

                add_button.Enabled = false;

                MainClass.enable(left_panel_sample2);

            }
        }

        public override void save_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "" || username_textBox.Text == "" || password_textBox.Text == "" || email_textBox.Text == "" || phone_number_label.Text == "" || status_comboBox.SelectedIndex == -1)
            {
                MainClass.ShowMsg("Please enter all required information.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else
            {

                if (Convert.ToString(status_comboBox.SelectedItem) == "Active") 
                {
                    stat = 1; //active
                }
                else if (Convert.ToString(status_comboBox.SelectedItem) == "In-active") 
                {
                    stat = 0; //in-active
                }
                
                if (edit == 0) //0 to add record
                {
                    try
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@name", username_textBox.Text);

                        ht.Add("@email", email_textBox.Text);

                        ht.Add("@password", password_textBox.Text);

                        ht.Add("@phone", phone_number_textBox.Text);

                        ht.Add("@status", stat);

                        ht.Add("@role", role_textBox.Text);

                        if (SQL_TASKS.insert_update_delete("st_insertusers", ht) > 0)
                        {
                            MainClass.ShowMsg(username_textBox.Text + " added successfully to the system.", "Success");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();

                            loadUsers();
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
                else if(edit == 1) // to update record
                {
                    if (Convert.ToString(status_comboBox.SelectedItem) == "Active")
                    {
                        stat = 1; //active
                    }
                    else if (Convert.ToString(status_comboBox.SelectedItem) == "In-active") 
                    {
                        stat = 0; //in-active
                    }
                   
                    try
                    {
                        if (name_textBox.Text == temp_name && phone_number_textBox.Text == temp_phone && username_textBox.Text == temp_username && password_textBox.Text == temp_password && email_textBox.Text == temp_mail && status_comboBox.Text == temp_status )
                        {
                            MainClass.ShowMsg("This record is already saved.","error");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();
                        }

                        Hashtable ht = new Hashtable();

                        ht.Add("@name", username_textBox.Text);

                        ht.Add("@email", email_textBox.Text);

                        ht.Add("@password", password_textBox.Text);

                        ht.Add("@phone", phone_number_textBox.Text);

                        ht.Add("@status", stat);

                        ht.Add("@role", role_textBox.Text);

                        ht.Add("@id", USERID);

                        if (SQL_TASKS.insert_update_delete("st_updateusers", ht) > 0)
                        {
                            MainClass.ShowMsg(username_textBox.Text + " updated successfully.", "Success");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();

                            loadUsers();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();
                        }
                        edit = 0;

                        loadUsers();    
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
            if (name_textBox.Text == "" || phone_number_textBox.Text == "" || username_textBox.Text == "" || password_textBox.Text == "" || email_textBox.Text == "")
            {
                MainClass.ShowMsg("Please enter a record to delete.", "error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else if (name_textBox.Enabled == true || phone_number_textBox.Enabled == true || username_textBox.Enabled == true || password_textBox.Enabled == true || email_textBox.Enabled == true)
            {
                MainClass.ShowMsg("Please select record from the table.","error");

                MainClass.disbale_reset(left_panel_sample2);

                enable_crude_buttons();
            }
            else if ((name_textBox.Enabled == false && phone_number_textBox.Enabled == false && username_textBox.Enabled == false && password_textBox.Enabled == false && email_textBox.Enabled == false) && (name_textBox.Text != "" && phone_number_textBox.Text != "" && username_textBox.Text != "" && password_textBox.Text != "" && email_textBox.Text != ""))
            {
                try
                {
                    DialogResult ans = MessageBox.Show("Are you sure you want to delete current record.", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ans == DialogResult.Yes)
                    {
                        Hashtable ht = new Hashtable();

                        ht.Add("@id", USERID);

                        if (SQL_TASKS.insert_update_delete("st_deleteusers", ht) > 0)
                        {
                            MainClass.ShowMsg(username_textBox.Text + " deleted successfully.", "Success");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();

                            loadUsers();
                        }
                        else
                        {
                            MainClass.ShowMsg("Unable to save record.", "Error");

                            MainClass.disbale_reset(left_panel_sample2);

                            enable_crude_buttons();
                        }

                        MainClass.disbale_reset(left_panel_sample2);

                        enable_crude_buttons();

                        loadUsers();

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

        public override void cancel_button_Click(object sender, EventArgs e)
        {
            MainClass.disbale_reset(left_panel_sample2);

            enable_crude_buttons();

            loadUsers();
        }

        public override void view_button_Click(object sender, EventArgs e)
        {
            loadUsers();
        }
    }
}
