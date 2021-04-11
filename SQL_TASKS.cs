using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace inv
{
    public class SQL_TASKS
    {
        public static string s;

        private Int64 purchaseinvoiceIDSQLTASKS;

        public int PIDcount;

        private object stockcount = 0;

        private static int ProductStockQuantity = 0;

        public static void ShowReport(CrystalReportViewer crv,string proc, string param, object val1)
        {
            try
            {
                ReportDocument rd;

                SqlConnection sql_con = new SqlConnection(MainClass.connection());

                SqlCommand cmd = new SqlCommand(proc, sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(param, val1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dat = new DataTable();

                adapter.Fill(dat);

                rd = new ReportDocument();

                rd.Load(Application.StartupPath + "\\Reports\\CrystalReport1.rpt");

                rd.SetDataSource(dat);

                crv.ReportSource = rd; crv.RefreshReport();
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        public static int getStockwrtProduct(int ProductID)
        {
            SqlConnection sql_con = new SqlConnection(MainClass.connection());
            try
            {
                SqlCommand cmd = new SqlCommand("getProductStockwrtProdID", sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prodID", ProductID);

                sql_con.Open();

                ProductStockQuantity = Convert.ToInt32((cmd.ExecuteScalar()));

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                sql_con.Close();
            }

            return ProductStockQuantity;

        }

        public static object ISproductEXISTPRICE;

        public static object getProductPrice(int productID)
        {
            SqlConnection sql_con = new SqlConnection(MainClass.connection());
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPRODUCTPRICE", sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prodID", productID);

                sql_con.Open();

                ISproductEXISTPRICE = Convert.ToSingle((cmd.ExecuteScalar()));

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                sql_con.Close();
            }

            return ISproductEXISTPRICE;
        }

        public static object getProductQuantity(int productID)
        {
            object stockcount = null;

            var sql_con = new SqlConnection(MainClass.connection());
            try
            {
                var cmd = new SqlCommand("st_getPRODUCTQUANTITY", sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prodID", productID);

                sql_con.Open();

                stockcount = Convert.ToInt32(cmd.ExecuteScalar());

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                sql_con.Close();
            }

            return stockcount;
        }

        public static object getProductQuantityfromSTOCK(int productID)
        {
            object stockcount = null;

            var sql_con = new SqlConnection(MainClass.connection());
            try
            {
                var cmd = new SqlCommand("st_getPRODUCTQUANTITYfromSTOCK", sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prodID", productID);

                sql_con.Open();

                stockcount = Convert.ToInt32(cmd.ExecuteScalar());

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                sql_con.Close();
            }

            return stockcount;
        }

        public static bool IfProductExist(Int64 ProductID)
        {
            int x = 0;

            SqlConnection sql_con = new SqlConnection(MainClass.connection());
            try
            {
                SqlCommand cmd = new SqlCommand("st_ProductExist", sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prodID", ProductID);

                sql_con.Open();

                x = Convert.ToInt32(cmd.ExecuteScalar());

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                sql_con.Close();
            }

            if (x == 0) return false;
            else return true;  
        }

        public Int64 InsertPurchaseinvoice(DateTime date, int doneBy, int suppID)
        {
            SqlConnection sql_con = new SqlConnection(MainClass.connection());
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    var cmd = new SqlCommand("st_insertPURCHASEINVOICE", sql_con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@date", date);

                    cmd.Parameters.AddWithValue("@doneby", doneBy);

                    cmd.Parameters.AddWithValue("@suppID", suppID);

                    sql_con.Open();

                    cmd.ExecuteNonQuery();

                    sql_con.Close();

                    SqlCommand cmd1 = new SqlCommand("st_getLASTPURCHASEINVOICEID", sql_con);

                    cmd1.CommandType = CommandType.StoredProcedure;

                    sql_con.Open();

                    purchaseinvoiceIDSQLTASKS = Convert.ToInt64(cmd1.ExecuteScalar());

                    sql_con.Close();

                    sc.Complete();
                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message,"Error");

                sql_con.Close();
            }

            return purchaseinvoiceIDSQLTASKS;
        }

        public int insertPurchaseinvoicedetails(Int64 purchID, int prodID, int quan, float price)
        {
            SqlConnection sql_con = new SqlConnection(MainClass.connection());
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPURCHASEINVOICEDETAILS", sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@purchaseID", purchID);

                cmd.Parameters.AddWithValue("@prodID", prodID);

                cmd.Parameters.AddWithValue("@quant", quan);

                cmd.Parameters.AddWithValue("@total", price);

                sql_con.Open();

                PIDcount = cmd.ExecuteNonQuery();

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                sql_con.Close();
            }

            return PIDcount;
        }

        public static double[] SaleInvoiceAmounts(string proc, Hashtable ht)
        {
            double[] arr = new double[3];

            try
            {
                SqlConnection sql_con = new SqlConnection(MainClass.connection());

                SqlCommand cmd = new SqlCommand(proc, sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                sql_con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        arr[0] = Convert.ToDouble(dr["Total Amount"].ToString());

                        arr[1] = Convert.ToDouble(dr["Amount Paid"].ToString());

                        arr[2] = Convert.ToDouble(dr["Remaining Amount"].ToString());
                    }
                }

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }

            return arr;
        }

        public static double[] LoadLastBalance(string proc, Hashtable ht)
        {
            SqlConnection sql_con = new SqlConnection(MainClass.connection());

            double[] amounts = new double[2];

            try
            {
                SqlCommand cmd = new SqlCommand(proc, sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                sql_con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        amounts[0] = Convert.ToDouble(dr[0].ToString());

                        amounts[1] = Convert.ToDouble(dr[1].ToString());
                    }
                }

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                sql_con.Close();
            }

            return amounts;


        }

        public static void load_data(string proc, DataGridView dv, ListBox lb, Hashtable ht)
        {
            try
            {
                SqlConnection sql_con = new SqlConnection(MainClass.connection());

                SqlCommand command = new SqlCommand(proc, sql_con);

                command.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    command.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dat = new DataTable();

                adapter.Fill(dat);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;

                    dv.Columns[colName1].DataPropertyName = dat.Columns[i].ToString();
                }

                dv.DataSource = dat;
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        //load any kind of data
        public static void load_data(string proc, DataGridView dv, ListBox lb)
        {
            try
            {
                SqlConnection sql_con = new SqlConnection(MainClass.connection());

                SqlCommand command = new SqlCommand(proc, sql_con);

                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dat = new DataTable();

                adapter.Fill(dat);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;

                    dv.Columns[colName1].DataPropertyName = dat.Columns[i].ToString();
                }

                dv.DataSource = dat;
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        public static object getLASTID(string proc)
        {
            object o = null;

            SqlConnection con = new SqlConnection(MainClass.connection());

            try
            {
                SqlCommand cmd = new SqlCommand(proc, con);

                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                o = cmd.ExecuteScalar();

                con.Close();
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                con.Close();
            }

            return o;
        }

        public static void LoadListModifiedHashTable(string proc, ComboBox cb, string valueMember, string displayMember, Hashtable ht)
        {
            try
            {
                cb.DataSource = null;

                cb.Items.Clear();

                SqlConnection sql = new SqlConnection(MainClass.connection());

                SqlCommand cmd = new SqlCommand(proc, sql);

                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable(); 
                
                da.Fill(dt);

                DataRow dr = dt.NewRow();

                dr.ItemArray = new object[] { 0, "Select..." };

                dt.Rows.InsertAt(dr, 0);

                cb.DisplayMember = displayMember;

                cb.ValueMember = valueMember;

                cb.DataSource = dt;

                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        public static void LoadList(string proc, ComboBox cb, string valueMember, string displayMember, string param, object val)
        {
            try
            {
                cb.DataSource = null;

                SqlConnection sql = new SqlConnection(MainClass.connection());

                SqlCommand cmd = new SqlCommand(proc, sql);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(param, val);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable(); 
                
                da.Fill(dt);

                cb.DisplayMember = displayMember; 
                
                cb.ValueMember = valueMember;

                cb.DataSource = dt; 
                
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        public static void LoadList(string proc, ComboBox cb, string valueMember, string displayMember)
        {
            try
            {
                var sql = new SqlConnection(MainClass.connection());

                var cmd = new SqlCommand(proc, sql);

                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);

                var dt = new DataTable(); 
                
                da.Fill(dt);

                cb.DisplayMember = displayMember; 
                
                cb.ValueMember = valueMember;

                cb.DataSource = dt; 
                
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }
        }

        public static int insert_update_delete(string proc, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlConnection sql_con = new SqlConnection(MainClass.connection());

                SqlCommand cmd = new SqlCommand(proc, sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                sql_con.Open();

                //returns an integer which indicates how many rows have been affected
                res = cmd.ExecuteNonQuery();

                sql_con.Close();

            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");
            }

            return res;
        }

        
    }
}
