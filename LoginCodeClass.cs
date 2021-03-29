using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace inv
{

    public class LoginCodeClass
    {
        private static int userID;

        private static string userROLE;

        public static bool isAdmin;

        public static string usernameOFadmin, passwordOFadmin;

        private static string USERname;

        public static bool IsLogged = false;

        public static int USERID //setter and getter for user ID
        {
            get
            { return userID; }

            private set
            { userID = value; }
        }

        public static string USERROLE //setter and getter for user's role
        {
            get
            { return userROLE; }

            private set
            { userROLE = value; }
        }

        public static string NAME //setter and getter for name
        {
            get
            { return USERname; }

            set
            {
                USERname = value;
            }
        }

        public static bool getlogindetails(string proc, Hashtable ht, bool admin)
        {
            bool check = false;

            try
            {
                var sql_con = new SqlConnection(MainClass.connection());

                var cmd = new SqlCommand(proc, sql_con);

                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                sql_con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    check = true;

                    while (dr.Read()) //reading data
                    {
                        if (admin == true) //fetch admin username & password
                        {
                            usernameOFadmin = dr["email"].ToString();

                            passwordOFadmin = dr["password"].ToString();
                        }
                        else 
                        {
                            USERID = Convert.ToInt32(dr[0].ToString());

                            NAME = dr[1].ToString(); 
                            
                            USERROLE = dr[2].ToString();
                        }
                    }
                }
                else
                {
                    check = false;

                    MainClass.ShowMsg("Invalid username or password", "Error");
                }

                
            }
            catch (Exception ex)
            {
                MainClass.ShowMsg(ex.Message, "Error");

                check = false;
            }

            return check;
        }

    }

}
