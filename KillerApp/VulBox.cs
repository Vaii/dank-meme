using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KillerApp
{
    class VulBox
    {
        public List<string> cbVul = new List<string>();

        public bool vulBox(VulBox _cbBoxVul)
        {
            Settings mySettings = new Settings();
            SqlConnection conn = new SqlConnection(mySettings.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT CategorieNaam FROM Categorie";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string catInfo = reader.GetString(0);
                    cbVul.Add(catInfo);
                }
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
                conn.Dispose();
            }
        }


    }
}
