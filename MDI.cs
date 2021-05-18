using System;
using System.Windows.Forms;
using System.IO;

namespace inv
{
    public partial class MDI : Form
    {
        int t;

        public MDI()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            t = MainClass.temp;

            if (t == 0)//connect file exist
            {

                DialogResult dr = new DialogResult();

                dr = MessageBox.Show("Are you sure you want to logout?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    login_interface li = new login_interface();

                    MainClass.ShowWindow(li, MDI.ActiveForm);

                    LoginCodeClass.IsLogged = false;
                }
                else
                {
                    LoginCodeClass.IsLogged = true;
                }


            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load_1(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                if (File.Exists(path + "\\ims_connect"))
                {
                    login_interface log = new login_interface();

                    MainClass.ShowWindow(log, this);

                    MainClass.temp = 0;
                }
                else
                {
                    string s = "";

                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    //s = "Data Source=DESKTOP-QEVD9D5 ;Initial Catalog=imsDB;User ID=shUSER;Password=syedhassanali12.;";

                    s = "Data Source=DESKTOP-QEVD9D5;Initial Catalog=imsDB;User ID=sa;Password=123";

                    File.WriteAllText(path + "\\ims_connect", s);

                    login_interface log = new login_interface();

                    MainClass.ShowWindow(log, this);

                    MainClass.temp = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    if (LoginCodeClass.isAdmin == true)
                    {
                        users us = new users();

                        MainClass.ShowWindow(us, MDI.ActiveForm);
                    }
                    else
                    {
                        MainClass.ShowMsg("You do not have permission to view users.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    if (LoginCodeClass.isAdmin == true)
                    {
                        var cat = new CATEGORIES();

                        MainClass.ShowWindow(cat, MDI.ActiveForm);
                    }
                    else
                    {
                        MainClass.ShowMsg("You do not have permission to view categories.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                      if (LoginCodeClass.IsLogged == false)
                      {
                            throw new Exception("Login first.");
                      }
                        else
                        {
                            if (LoginCodeClass.isAdmin == true)
                            {
                                var prod = new Products();

                                MainClass.ShowWindow(prod, MDI.ActiveForm);
                            }
                            else
                            {
                                MainClass.ShowMsg("You do not have permission to view Products.", "Error");
                            }
                        }
                   
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void productPricingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    if (LoginCodeClass.isAdmin == true)
                    {
                        var ppd = new PRODUCT_PRICING();

                        MainClass.ShowWindow(ppd, MDI.ActiveForm);
                    }
                    else
                    {
                        MainClass.ShowMsg("You do not have permission to view Product pricing.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "error");
            }
        }

        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    if (LoginCodeClass.isAdmin == true)
                    {
                        var purch = new PURCHASE_INVOICE();

                        MainClass.ShowWindow(purch, MDI.ActiveForm);
                    }
                    else
                    {
                        MainClass.ShowMsg("You do not have permission to view Purchase Invoice window.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    SALES sl = new SALES();

                    MainClass.ShowWindow(sl, MDI.ActiveForm);
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    SALES_RETURN sr = new SALES_RETURN();

                    MainClass.ShowWindow(sr, MDI.ActiveForm);
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    if (LoginCodeClass.isAdmin == true)
                    {
                        var st = new STOCK();

                        MainClass.ShowWindow(st, MDI.ActiveForm);
                    }
                    else
                    {
                        MainClass.ShowMsg("You do not have permission to view Purchase Invoice window.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginCodeClass.IsLogged == false)
                {
                    throw new Exception("Login first.");
                }
                else
                {
                    if (LoginCodeClass.isAdmin == true)
                    {
                        var supp = new SUPPLIERS();

                        MainClass.ShowWindow(supp, MDI.ActiveForm);
                    }
                    else
                    {
                        MainClass.ShowMsg("You do not have permission to view Suppliers.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }
    }
}
