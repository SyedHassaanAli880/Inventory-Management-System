using System;
using System.Windows.Forms;

namespace inv
{
    public partial class sample1 : Form
    {
        public sample1()
        {
            InitializeComponent();
        }

        private void sample1_Load(object sender, EventArgs e)
        {
            if (LoginCodeClass.isAdmin)
            {
                if (LoginCodeClass.usernameOFadmin == "" || LoginCodeClass.usernameOFadmin == null)
                {
                    user_label.Text = "USER";
                }
                else
                {
                    user_label.Text = "Admin: " + LoginCodeClass.usernameOFadmin;
                }
            }
            else
            {
                if (LoginCodeClass.NAME == "" || LoginCodeClass.NAME == null)
                {
                    user_label.Text = "USER";
                }
                else
                {
                    user_label.Text = LoginCodeClass.NAME;
                }
            }
        }
    }
}
