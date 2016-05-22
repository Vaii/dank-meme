using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KillerApp
{
    class imgUpload
    {
        public string categorie;
        public string Naam;
        public Image photo { get; set; }
        public Image picture;
        private int catID;
        private string catNaam;
        public string CatNaam
        {
            get { return catNaam; }
            set { catNaam = value; }
        }

        private int userID;
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string userNaam;
        private int randomCat;
        private int ratingID;
        private int imgID;
        public int RatingID
        {
            get { return RatingID; }
        }
        private int ratingWaarde = 0;

        public List<Image> rGif = new List<Image>();
        public List<string> gifUser = new List<string>();
        public List<int> picRating = new List<int>();

        // convert image to byte array
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public bool AddImage(imgUpload _Image)
        {
            Settings mySettings = new Settings();
            SqlConnection conn = new SqlConnection(mySettings.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT CategorieID FROM Categorie WHERE CategorieNaam = @Naam";
            cmd.Parameters.AddWithValue("@Naam", _Image.catNaam);


            try
            {
                conn.Open();
                catID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO Rating (RatingTotal) OUTPUT INSERTED.ImgRatingID VALUES (@ratingWaarde)";
                cmd.Parameters.AddWithValue("@ratingWaarde", _Image.ratingWaarde);
                ratingID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.CommandText = "INSERT INTO Foto (Naam, img,CategorieID, UserID, ImgRatingID) VALUES(@Naam,@img,@CatID,@UserID,@RatingID)";
                cmd.Parameters.AddWithValue("@Naam", _Image.Naam);
                cmd.Parameters.AddWithValue("@img", imageToByteArray(_Image.photo));
                cmd.Parameters.AddWithValue("CatID", _Image.catID);
                cmd.Parameters.AddWithValue("@UserID", _Image.userID);
                cmd.Parameters.AddWithValue("@RatingID", _Image.ratingID);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                cmd = null;
                conn.Dispose();
            }
            
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        byte[] ObjectToByteArray(object image)
        {
            if (image == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, image);
                return ms.ToArray();
            }
        }

        public bool extractImage(imgUpload _Extract)
        {
            Settings mySettings = new Settings();
            SqlConnection conn = new SqlConnection(mySettings.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT CategorieID FROM Categorie WHERE CategorieNaam = @Naam";
            cmd.Parameters.AddWithValue("@Naam", _Extract.categorie);


            try
            {
                conn.Open();
                randomCat = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT img,UserNaam, Rating.ImgRatingID FROM Foto INNER JOIN Users ON Foto.UserID = Users.UserID INNER JOIN Rating ON Rating.ImgRatingID = Foto.ImgRatingID WHERE CategorieID = @CatID ";
                cmd.Parameters.AddWithValue("@CatID", _Extract.randomCat);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long size = reader.GetBytes(0, 0, null, 0, 0);
                    byte[] image = new byte[size];
                    reader.GetBytes(0, 0, image, 0, (int)size);
                    picture = (Bitmap)((new ImageConverter()).ConvertFrom(image));
                    rGif.Add(picture);
                    userNaam = reader.GetString(1);
                    gifUser.Add(userNaam);
                    ratingID = reader.GetInt32(2);
                    picRating.Add(ratingID);
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
                if (conn.State == ConnectionState.Open) conn.Close();
                cmd = null;
            }
        }
    }
}
