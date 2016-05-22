using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KillerApp
{
    class users
    {
        public string username;
        public string wachtwoord;
        public string email;
        public string loginUser;
        public string loginPass;
        public int userID;
        public string userNaam;
        public string loginWW;


        public bool userReg(users _Reg)
        {
            Settings mySetting = new Settings();
            SqlConnection conn = new SqlConnection(mySetting.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Users (UserNaam,UserPass,UserMail)" + "Values(@UserNaam,@UserPass,@UserMail)";
            cmd.Parameters.AddWithValue("@UserNaam", _Reg.username);
            cmd.Parameters.AddWithValue("@UserPass", _Reg.wachtwoord);
            cmd.Parameters.AddWithValue("@UserMail", _Reg.email);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
                cmd = null;
            }
        }

        public bool userLogin(users _login)
        {
            Settings mySettings = new Settings();
            SqlConnection conn = new SqlConnection(mySettings.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT UserID, UserNaam, UserPass FROM Users WHERE UserNaam = @Naam AND UserPass = @Pass";
            cmd.Parameters.AddWithValue("@Naam", _login.loginUser);
            cmd.Parameters.AddWithValue("@Pass", _login.loginPass);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userID = reader.GetInt32(0);
                    userNaam = reader.GetString(1);
                    loginWW = reader.GetString(2);
                }
                if(userID == 0)
                {
                    MessageBox.Show("Inloggen mislukt");
                    conn.Close();
                    return false;
                }
                else
                {
                    conn.Close();
                    return true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
                cmd = null;
            }
        }

    }
}
