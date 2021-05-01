using System;
using System.Data.SqlClient;
using System.Collections;

namespace inv
{
    public partial class login_interface : sample1
    {
        SqlConnection con = new SqlConnection(MainClass.connection());

        SqlCommand cmd = new SqlCommand();

        public login_interface()
        {
            InitializeComponent();
        }

        private void back_to_settings_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (username_textBox.Text != "" && password_textBox.Text != "")
                {
                    Hashtable ht = new Hashtable();

                    ht.Add("@email", username_textBox.Text);

                    ht.Add("@password", password_textBox.Text);

                    if (other_radioButton.Checked == true)
                    {
                        if (LoginCodeClass.getlogindetails("st_getAuthenticationDetails", ht, false))
                        {
                            LoginCodeClass.isAdmin = false; //not admin, common user

                            LoginCodeClass.IsLogged = true;

                            var sal = new SALES();

                            

                            MainClass.ShowWindow(sal, MDI.ActiveForm);

                        }
                    }
                    else if (admin_radioButton.Checked == true)
                    {
                        if (LoginCodeClass.getlogindetails("st_getAuthenticationDetailsFromAUTH", ht, true))
                        {
                            LoginCodeClass.isAdmin = true; //Admin,not common user

                            LoginCodeClass.IsLogged = true;

                            var cat = new CATEGORIES();

                            MainClass.ShowWindow(cat, MDI.ActiveForm);
                        }
                    }
                    else
                    {
                        MainClass.ShowMsg("Please select if you are admin or any other person.", "Error");

                        LoginCodeClass.IsLogged = false;
                    }
                }
                else
                { MainClass.ShowMsg("Please fill all fields.", "Error"); LoginCodeClass.IsLogged = false; }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                LoginCodeClass.IsLogged = false;
            }
           
        }

        private void forgot_password_button_Click(object sender, EventArgs e)
        {
            forgot_password fp = new forgot_password();

            MainClass.ShowWindow(fp, MDI.ActiveForm);
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            change_password fp = new change_password();

            MainClass.ShowWindow(fp, MDI.ActiveForm);
        }

        private void login_interface_Load(object sender, EventArgs e)
        {
            LoginCodeClass.IsLogged = false;
        }
    }
}

