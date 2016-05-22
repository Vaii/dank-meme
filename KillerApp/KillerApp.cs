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
using System.Collections.Specialized;
using System.Net;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace KillerApp
{
    public partial class KillerApp : Form
    {
        int ratingID;
        public KillerApp()
        {
            InitializeComponent();
            VulBox cbCategorieVullen = new VulBox();
            if (cbCategorieVullen.vulBox(cbCategorieVullen))
            {
                int x = 0;
                foreach (string element in cbCategorieVullen.cbVul)
                {
                    cbCategorie.Items.Add(cbCategorieVullen.cbVul.ElementAt(x));
                    cbCategorieKies.Items.Add(cbCategorieVullen.cbVul.ElementAt(x));
                    x++;
                }
            }
        }

        private void KillerApp_Load(object sender, EventArgs e)
        {

        }

        private void btnHoofdMenu_Click(object sender, EventArgs e)
        {
            StartScherm.Visible = true;
            Upload.Visible = false;
            Randomizer.Visible = false;
            GifKiezen.Visible = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            StartScherm.Visible = false;
            Upload.Visible = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbSelectedIMG.Image = new Bitmap(open.FileName);
            }
        }

        private void btnImgUpload_Click(object sender, EventArgs e)
        {
            imgUpload uploadImg = new imgUpload();

            uploadImg.Naam = tbNaam.Text.Trim();
            uploadImg.photo = pbSelectedIMG.Image;
            uploadImg.CatNaam = cbCategorie.Text;
            uploadImg.UserID = Convert.ToInt32(lblUserID.Text);

            if (uploadImg.AddImage(uploadImg))
                MessageBox.Show("Gif Added Succesfully");
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                UncheckAllItems();
                imgUpload extractImg = new imgUpload();
                extractImg.categorie = cbCategorieKies.Text;
                gbRating.Visible = true;
                lblCijfer.Visible = false;
                lblRateInfo.Visible = false;
                lblRate.Visible = true;
                clbRating.Visible = true;


                if (cbCategorieKies.Text == "Kies Categorie")
                {
                    MessageBox.Show("Selecteer aub een categorie");
                }
                else
                {
                    if (extractImg.extractImage(extractImg))
                    {
                        Random rnd = new Random();
                        int randGif = rnd.Next(0, extractImg.rGif.Count);
                        pbExtract.Image = extractImg.rGif.ElementAt(randGif);
                        tbImgInfo.Text = "This picture was uploaded by " + extractImg.gifUser.ElementAt(randGif);
                        gbRating.Visible = true;
                        ratingID = extractImg.picRating.ElementAt(randGif);
                    }
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Deze categorie heeft nog geen gifs, u kunt er zelf in toevoegen door er een te uploaden.");
                pbExtract.Image = null;
                gbRating.Visible = false;
                tbImgInfo.Clear();
            }
        }
        private void UncheckAllItems()
        {
            while (clbRating.CheckedIndices.Count > 0)
                clbRating.SetItemChecked(clbRating.CheckedIndices[0], false);
        }

        private void btnKies_Click(object sender, EventArgs e)
        {
            GifKiezen.Visible = true;
            StartScherm.Visible = false;
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            users registreren = new users();

            registreren.username = tbRegUser.Text;
            registreren.wachtwoord = tbRegPass.Text;
            registreren.email = tbEmail.Text;

            if (tbRegPass.Text == tbRegPassCheck.Text)
            {
                if (registreren.userReg(registreren))
                {
                    MessageBox.Show("U hebt u succesvol geregistreerd");
                    btnLogScherm.Visible = true;
                }
            }
            else if (string.IsNullOrWhiteSpace(tbRegPass.Text) || string.IsNullOrWhiteSpace(tbRegPassCheck.Text) || string.IsNullOrWhiteSpace(tbRegUser.Text))
            {
                MessageBox.Show("Het wachtwoord moet 2x ingevuld worden");
            }
            else
            {
                MessageBox.Show("De ingevulde wachtwoorden matchen niet");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            users login = new users();

            login.loginUser = tbLoginUserName.Text;
            login.loginPass = tbLoginPass.Text;

            if (string.IsNullOrWhiteSpace(tbLoginPass.Text) || string.IsNullOrWhiteSpace(tbLoginUserName.Text))
            {
                MessageBox.Show("Vul aub alle velden in");
            }
            else
            {
                if (login.userLogin(login))
                {
                    if (login.userNaam == tbLoginUserName.Text && login.loginWW == tbLoginPass.Text)
                    {
                        MessageBox.Show("Inloggen succesvol");
                        btnRegistreren.Visible = false;
                        btnHoofdMenu.Visible = true;
                        panelLogin.Visible = false;
                        lblUser.Text = "U bent bent ingelogd als:";
                        lblUserID.Text = Convert.ToString(login.userID);
                        lblNaamLogged.Text = login.userNaam;
                    }
                    else
                    {
                        MessageBox.Show("Inloggen Mislukt");
                    }

                }
            }


        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelReg.Visible = true;
            StartScherm.Visible = false;
            btnLogScherm.Visible = true;

        }

        private void btnLogScherm_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelReg.Visible = false;
            StartScherm.Visible = true;
            btnLogScherm.Visible = false;
        }

        private void clbRating_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbRating.CheckedItems.Count >= 1 && e.CurrentValue != CheckState.Checked)
            {
                e.NewValue = e.CurrentValue;
                MessageBox.Show("Je kan maar 1 cijfer selecteren");

            }
        }

        private void clbRating_Click(object sender, EventArgs e)
        {
            int gegevenCijfer = Convert.ToInt32(clbRating.SelectedItem.ToString());
            clbRating.Visible = false;
            lblRate.Visible = false;
            RatingSysteem rate = new RatingSysteem();
            rate.RatingID = ratingID;
            rate.UserRating = gegevenCijfer;


            switch (gegevenCijfer)
            {
                case 1:
                    if (rate.ratingBerekenen(rate))
                    {
                        lblRateInfo.Visible = true;
                        lblCijfer.Visible = true;
                        lblCijfer.Text = Convert.ToString(rate.NeuwGemRating);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan");
                        break;
                    }
                case 2:
                    if (rate.ratingBerekenen(rate))
                    {
                        lblRateInfo.Visible = true;
                        lblCijfer.Visible = true;
                        lblCijfer.Text = Convert.ToString(rate.NeuwGemRating);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan");
                        break;
                    }
                case 3:
                    if (rate.ratingBerekenen(rate))
                    {
                        lblRateInfo.Visible = true;
                        lblCijfer.Visible = true;
                        lblCijfer.Text = Convert.ToString(rate.NeuwGemRating);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan");
                        break;
                    }
                case 4:
                    if (rate.ratingBerekenen(rate))
                    {
                        lblRateInfo.Visible = true;
                        lblCijfer.Visible = true;
                        lblCijfer.Text = Convert.ToString(rate.NeuwGemRating);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan");
                        break;
                    }
                case 5:
                    if (rate.ratingBerekenen(rate))
                    {
                        lblRateInfo.Visible = true;
                        lblCijfer.Visible = true;
                        lblCijfer.Text = Convert.ToString(rate.NeuwGemRating);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan");
                        break;
                    }
            }
        }

        private void btnImgurUpload_Click(object sender, EventArgs e)
        {
            using (var w = new WebClient())
            {
                var values = new NameValueCollection
                {
                {"image", Convert.ToBase64String(imageToByteArray(pbExtract.Image))}
                };

                w.Headers.Add("Authorization", "Client-ID 3e3d910f763f5fc");
                byte[] response = w.UploadValues("https://api.imgur.com/3/upload.xml", values);
                string responseString = Convert.ToString(XDocument.Load(new MemoryStream(response)));
                string strStart = "<link>";
                string strEnd = "</link>";
                string imgUrl = getBetween(responseString, strStart, strEnd);
                Clipboard.SetText(imgUrl);
            }
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }


        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
 }

