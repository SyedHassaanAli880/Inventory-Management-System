using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace inv
{
    class MainClass
    {
        public static int temp = 1;

        public static void disbale_reset(Panel leftpanel)
        {
            foreach (Control c in leftpanel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;

                    t.Enabled = false; t.Text = "";
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    cb.Enabled = false; cb.SelectedIndex = -1;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;

                    rb.Enabled = false; rb.Checked = false;
                }

                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;

                    ch.Enabled = false; ch.Checked = false;
                }
            }
        }

        public static void disbale(Panel leftpanel)
        {
            foreach (Control c in leftpanel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;

                    t.Enabled = false; 
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    cb.Enabled = false; 
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;

                    rb.Enabled = false; 
                }

                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;

                    ch.Enabled = false; 
                }
            }
        }

        public static void enable(Panel leftpanel)
        {
            foreach (Control c in leftpanel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;

                    t.Enabled = true;
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    cb.Enabled = true;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;

                    rb.Enabled = true;
                }

                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;

                    ch.Enabled = true;
                }
            }
        }

        public static void enable_rsest(Panel leftpanel)
        {
            foreach (Control c in leftpanel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;

                    t.Enabled = true; t.Text = "";
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    cb.Enabled = true; cb.SelectedIndex = -1;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;

                    rb.Enabled = true; rb.Checked = false;
                }

                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;

                    ch.Enabled = true; ch.Checked = false;
                }
            }
        }
        public static void ShowWindow(Form openwin, Form closewin, Form MDIwin)
        {
            closewin.Close();

            openwin.MdiParent = MDIwin;

            openwin.WindowState = FormWindowState.Maximized;

            openwin.Show();
        }

        public static void ShowWindow(Form openwin, Form MDIwin)
        {
            try
            {
                openwin.MdiParent = MDIwin;

                openwin.WindowState = FormWindowState.Maximized;

                openwin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void ShowMsg(string msg, string type)
        {
            if (type == "Success")
            {
                MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static string s;

        public static string connection()
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            s = File.ReadAllText(path + "\\ims_connect");

            return s;

        }


    }
}
