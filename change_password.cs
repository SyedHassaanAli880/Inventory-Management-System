using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inv
{
    public partial class change_password : sample1
    {
        SqlConnection sq = new SqlConnection(MainClass.connection());

        bool IsAdmin; string username;

        public change_password()
        {
            InitializeComponent();
        }

        public void clear_disable()
        {
            old_password_textBox.Text = "";

            new_password_textBox_change.Text = "";

            new_password_panel_change.Enabled = false;
        }

        private void verify_oldpassword_button_Click(object sender, EventArgs e)
        {
            if (old_password_textBox.Text == "" || username_textBox.Text == "")
            {
                MainClass.ShowMsg("Please enter your current password and current username.", "Error");
            }
            else if (admin_radioButton.Checked == false && other_radioButton.Checked == false)
            {
                MainClass.ShowMsg("Please select if you are admin or any other person.", "Error");
            }
            else if (admin_radioButton.Checked == true) //admin
            {
                try
                {
                    IsAdmin = true;

                    string x;

                    sq.Open();

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = sq;

                    SqlDataReader dr;

                    cmd.CommandText = "select password,username from AUTH";

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        x = (dr["password"].ToString());

                        username = (dr["username"].ToString());

                        if (x == old_password_textBox.Text && username == username_textBox.Text)
                        {
                            new_password_panel_change.Enabled = true;

                            disabled_new_password_label.Text = "ENABLED";

                            sq.Close();
                        }
                        else
                        {
                            MainClass.ShowMsg("Wrong password.", "Error");

                            sq.Close();

                            clear_disable();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sq.Close();

                    clear_disable();
                }
            }
            else //user
            {
                IsAdmin = false;

                try
                {

                    //IsAdmin = true;

                    string x;

                    sq.Open();

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = sq;

                    SqlDataReader dr;

                    cmd.CommandText = "select usr_password,usr_username from users where usr_username = '" + username_textBox.Text + "' ";

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        x = (dr["usr_password"].ToString());

                        username = (dr["usr_username"].ToString());

                        if (x == old_password_textBox.Text && username == username_textBox.Text)
                        {
                            new_password_panel_change.Enabled = true;

                            disabled_new_password_label.Text = "ENABLED";

                            sq.Close();
                        }
                        else
                        {
                            MainClass.ShowMsg("Wrong password.", "Error");

                            sq.Close();

                            clear_disable();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    clear_disable();
                }
            }
        }

        private void change_password_Load(object sender, EventArgs e)
        {
            new_password_panel_change.Enabled = false;
        }


        private void back_button_Click(object sender, EventArgs e)
        {
            login_interface li = new login_interface();

            change_password cp = new change_password();

            MainClass.ShowWindow(li, cp, MDI.ActiveForm);
        }

        private void save_new_details_button_change_Click(object sender, EventArgs e)
        {
            if (new_password_textBox_change.Text == "" || new_username_textBox.Text == "")
            {
                MainClass.ShowMsg("Please enter new username and new password.", "Error");
            }
            else
            {

                try
                {
                    if (IsAdmin == false)
                    {
                        sq.Open();

                        //fetching data of user first

                        string query = "SELECT * FROM users where usr_username = '"+username+"' ";

                        SqlCommand cmd = new SqlCommand(query,sq);

                        SqlDataReader dr = cmd.ExecuteReader(); //data in dr fetched

                      

                        if (dr.Read())
                        {
                            //storing data in textboxes

                            //name_textBox_change_password.Text = dr["usr_name"].ToString();

                            //username_textBox_change_password.Text = dr["usr_username"].ToString();

                            //phone_number_textBox_change_password.Text = dr["usr_phone"].ToString();

                            //password_textBox_change_password.Text = dr["usr_password"].ToString();

                            //email_textBox_change_password.Text = dr["usr_email"].ToString();

                            //status_comboBox_change_password.SelectedText = dr["usr_status"].ToString();

                            //role_textBox_change_password.Text = dr["usr_role"].ToString();
                        }

                        dr.Close();

                        //now deleting data of user

                        SqlCommand sql = new SqlCommand("delete from users where usr_username = '" + username + "' ", sq);

                        sql.ExecuteNonQuery();

                        //data deleted

                        //sql.Parameters.AddWithValue("@name", name_textBox_change_password.Text);

                        //sql.Parameters.AddWithValue("@username", new_username_textBox.Text);

                        //sql.Parameters.AddWithValue("@password", new_password_textBox_change.Text);

                        //sql.Parameters.AddWithValue("@phone", phone_number_textBox_change_password.Text);

                        //sql.Parameters.AddWithValue("@email", email_textBox_change_password.Text);

                        //sql.Parameters.AddWithValue("@status", status_comboBox_change_password.SelectedText);

                        //sql.Parameters.AddWithValue("@role", role_textBox_change_password.Text);

                        //inserting data of user with new username & password

                        string cmdquery = "insert into users values(@name,@username,@password,@phone,@email,@status,@role)";

                        sql.CommandText = cmdquery;

                        sql.ExecuteNonQuery();

                        MainClass.ShowMsg("Password changed successfully.", "Success");

                        sq.Close();

                        clear_disable();
                    }
                    else // admin
                    {
                        sq.Open();

                        SqlCommand sql = new SqlCommand("delete from AUTH", sq);

                        sql.ExecuteNonQuery();

                        sql.Parameters.AddWithValue("@username", new_username_textBox.Text);

                        sql.Parameters.AddWithValue("@password", new_password_textBox_change.Text);

                        string query = "insert into AUTH values(@username,@password)";

                        sql.CommandText = query;

                        sql.ExecuteNonQuery();

                        MainClass.ShowMsg("Password changed successfully.", "Success");

                        sq.Close();

                        clear_disable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "success", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sq.Close();

                    clear_disable();
                }
            }
        }
    }
}
