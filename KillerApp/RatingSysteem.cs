using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KillerApp
{
    class RatingSysteem
    {
        private int ratingID;
        public int RatingID
        {
            get { return ratingID; }
            set { ratingID = value; }
        }
        private int userRating;
        public int UserRating
        {
            get { return userRating; }
            set { userRating = value; }
        }
        private float totaalAantalRating;
        private float aantalRating;
        private float nieuwGemRating;
        public float NeuwGemRating
        {
            get { return nieuwGemRating; }
        }
        public bool ratingBerekenen(RatingSysteem _Reken)
        {
            Settings mySettings = new Settings();
            SqlConnection conn = new SqlConnection(mySettings.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT RatingTotal, RatingAmount FROM Rating WHERE ImgRatingID = @ratingID";
            cmd.Parameters.AddWithValue("@ratingID", _Reken.ratingID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    totaalAantalRating = reader.GetInt32(0);
                    aantalRating = reader.GetInt32(1);
                }
                totaalAantalRating += userRating;
                aantalRating += 1;
                nieuwGemRating = totaalAantalRating / aantalRating;
                reader.Close();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE Rating SET Ratingtotal = @totaalRate, RatingAmount = @aantalRate, RatingAvg = @gemRating WHERE ImgRatingID = @ratingID";
                cmd.Parameters.AddWithValue("@totaalRate", _Reken.totaalAantalRating);
                cmd.Parameters.AddWithValue("@aantalRate", _Reken.aantalRating);
                cmd.Parameters.AddWithValue("@gemRating", _Reken.nieuwGemRating);
                cmd.Parameters.AddWithValue("@ratingID", _Reken.ratingID);
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
                conn.Dispose();
                cmd = null;
            }
        }
    }
}
