using System;
using System.Windows.Forms;

namespace inv
{
    public partial class sample2 : Form
    {
        public sample2()
        {
            InitializeComponent();
        }

        public virtual void add_button_Click(object sender, EventArgs e)
        {

        }

        public virtual void save_button_Click(object sender, EventArgs e)
        {

        }

        public virtual void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public virtual void search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void cancel_button_Click(object sender, EventArgs e)
        {

        }

        public virtual void view_button_Click(object sender, EventArgs e)
        {

        }

        public virtual void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void sample2_Load(object sender, EventArgs e)
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
