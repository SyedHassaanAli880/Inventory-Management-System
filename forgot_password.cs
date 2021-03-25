using System;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace inv
{
    public partial class forgot_password : sample1
    {
        int x;

        SqlConnection sq = new SqlConnection(MainClass.connection());

        public void disable_clear()
        {
            email_address_textBox.Text = "";

            verification_code_textBox.Text = "";

            new_password_textBox.Text = "";

            new_username_textBox.Text = "";

            new_details_panel.Enabled = false;
        }

        public forgot_password()
        {
            InitializeComponent();
        }

        private void forgot_password_Load(object sender, EventArgs e)
        {
            new_details_panel.Enabled = false;
        }

        private void send_code_button_Click(object sender, EventArgs e)
        {
            if (email_address_textBox.Text == "" || current_username_textBox_forgot_password.Text == "")
            {
                MainClass.ShowMsg("Please enter email address.", "error");
            }
            else
            {
                try
                {
                    Random r = new Random();

                    x = r.Next(1, 1000000); //Generating 6-digit verification code

                    SmtpClient cl = new SmtpClient("smtp.gmail.com");

                    cl.Port = 587;

                    cl.Credentials = new System.Net.NetworkCredential("gymmanagement491@gmail.com", "syedkamranali90.");

                    cl.EnableSsl = true;

                    MailMessage mail = new MailMessage("gymmanagement491@gmail.com", email_address_textBox.Text, "VERIFICATION CODE", "Your confirmation code is " + x.ToString() + ".");

                    cl.Send(mail);

                    MessageBox.Show("A code is sent to " +"' "+  email_address_textBox.Text + " ' " + ".Enter code to verify it.");
                }
                catch (Exception ex)
                {
                    MainClass.ShowMsg(ex.Message, "Error");
                }
            }
        }

        private void verify_code_button_Click(object sender, EventArgs e)
        {
            if (x.ToString() == verification_code_textBox.Text)
            {
                disabled_new_details_label.Text = "ENABLED";

                new_details_panel.Enabled = true;
            }
            else
            {
                MainClass.ShowMsg("Incorrect code.", "Error");
            }
        }

        private void save_new_details_button_Click(object sender, EventArgs e)
        {
            if (new_username_textBox.Text == "" || new_password_textBox.Text == "")
            {
                MainClass.ShowMsg("Please enter all details.", "error");
            }
            else
            {

                try
                {
                    sq.Open();

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = sq;

                    cmd.CommandText = "st_deleteusers";

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", LoginCodeClass.USERID);

                    cmd.ExecuteNonQuery();

                    cmd.Dispose();

                    SqlCommand newcom = new SqlCommand();

                    string query = "insert into users values(@username,@password)";

                    newcom.Parameters.AddWithValue("@username", new_username_textBox.Text);

                    newcom.Parameters.AddWithValue("@password", new_password_textBox.Text);

                    newcom.CommandText = query;

                    newcom.ExecuteNonQuery();

                    MainClass.ShowMsg("Username and password changed successfully.", "success");

                    sq.Close();

                    disable_clear();

                    newcom.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "success", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

                    sq.Close();

                    disable_clear();
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            login_interface li = new login_interface();

            forgot_password fp = new forgot_password();

            MainClass.ShowWindow(li, fp, MDI.ActiveForm);
        }
    }
}
