namespace KillerApp
{
    partial class KillerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Upload = new System.Windows.Forms.Panel();
            this.btnImgUpload = new System.Windows.Forms.Button();
            this.pbSelectedIMG = new System.Windows.Forms.PictureBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.StartScherm = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.lblLoginNaam = new System.Windows.Forms.Label();
            this.tbLoginPass = new System.Windows.Forms.TextBox();
            this.tbLoginUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnKies = new System.Windows.Forms.Button();
            this.Randomizer = new System.Windows.Forms.Panel();
            this.GifKiezen = new System.Windows.Forms.Panel();
            this.pbExtract = new System.Windows.Forms.PictureBox();
            this.gbRating = new System.Windows.Forms.GroupBox();
            this.lblCijfer = new System.Windows.Forms.Label();
            this.lblRateInfo = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.clbRating = new System.Windows.Forms.CheckedListBox();
            this.cbCategorieKies = new System.Windows.Forms.ComboBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.tbImgInfo = new System.Windows.Forms.TextBox();
            this.navMenu = new System.Windows.Forms.Panel();
            this.lblNaamLogged = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogScherm = new System.Windows.Forms.Button();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.btnHoofdMenu = new System.Windows.Forms.Button();
            this.panelReg = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbRegPassCheck = new System.Windows.Forms.TextBox();
            this.tbRegPass = new System.Windows.Forms.TextBox();
            this.tbRegUser = new System.Windows.Forms.TextBox();
            this.btnImgurUpload = new System.Windows.Forms.Button();
            this.Upload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedIMG)).BeginInit();
            this.StartScherm.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.GifKiezen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtract)).BeginInit();
            this.gbRating.SuspendLayout();
            this.navMenu.SuspendLayout();
            this.panelReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Controls.Add(this.btnImgUpload);
            this.Upload.Controls.Add(this.pbSelectedIMG);
            this.Upload.Controls.Add(this.lblNaam);
            this.Upload.Controls.Add(this.lblCategorie);
            this.Upload.Controls.Add(this.tbNaam);
            this.Upload.Controls.Add(this.btnBrowse);
            this.Upload.Controls.Add(this.cbCategorie);
            this.Upload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upload.Location = new System.Drawing.Point(0, 0);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(494, 387);
            this.Upload.TabIndex = 0;
            this.Upload.Visible = false;
            // 
            // btnImgUpload
            // 
            this.btnImgUpload.Location = new System.Drawing.Point(29, 246);
            this.btnImgUpload.Name = "btnImgUpload";
            this.btnImgUpload.Size = new System.Drawing.Size(227, 23);
            this.btnImgUpload.TabIndex = 7;
            this.btnImgUpload.Text = "Upload";
            this.btnImgUpload.UseVisualStyleBackColor = true;
            this.btnImgUpload.Click += new System.EventHandler(this.btnImgUpload_Click);
            // 
            // pbSelectedIMG
            // 
            this.pbSelectedIMG.Location = new System.Drawing.Point(29, 81);
            this.pbSelectedIMG.Name = "pbSelectedIMG";
            this.pbSelectedIMG.Size = new System.Drawing.Size(227, 159);
            this.pbSelectedIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedIMG.TabIndex = 6;
            this.pbSelectedIMG.TabStop = false;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(26, 39);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 5;
            this.lblNaam.Text = "Naam";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(132, 39);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Categorie";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(29, 55);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(262, 55);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(135, 55);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbCategorie.TabIndex = 0;
            this.cbCategorie.Text = "Kies Categorie";
            // 
            // StartScherm
            // 
            this.StartScherm.Controls.Add(this.panelLogin);
            this.StartScherm.Controls.Add(this.btnUpload);
            this.StartScherm.Controls.Add(this.btnKies);
            this.StartScherm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartScherm.Location = new System.Drawing.Point(0, 29);
            this.StartScherm.Name = "StartScherm";
            this.StartScherm.Size = new System.Drawing.Size(494, 358);
            this.StartScherm.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblLoginPass);
            this.panelLogin.Controls.Add(this.lblLoginNaam);
            this.panelLogin.Controls.Add(this.tbLoginPass);
            this.panelLogin.Controls.Add(this.tbLoginUserName);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(494, 358);
            this.panelLogin.TabIndex = 2;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Location = new System.Drawing.Point(128, 140);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(71, 13);
            this.lblLoginPass.TabIndex = 4;
            this.lblLoginPass.Text = "Wachtwoord:";
            // 
            // lblLoginNaam
            // 
            this.lblLoginNaam.AutoSize = true;
            this.lblLoginNaam.Location = new System.Drawing.Point(141, 114);
            this.lblLoginNaam.Name = "lblLoginNaam";
            this.lblLoginNaam.Size = new System.Drawing.Size(58, 13);
            this.lblLoginNaam.TabIndex = 3;
            this.lblLoginNaam.Text = "Username:";
            // 
            // tbLoginPass
            // 
            this.tbLoginPass.Location = new System.Drawing.Point(205, 137);
            this.tbLoginPass.Name = "tbLoginPass";
            this.tbLoginPass.Size = new System.Drawing.Size(100, 20);
            this.tbLoginPass.TabIndex = 2;
            // 
            // tbLoginUserName
            // 
            this.tbLoginUserName.Location = new System.Drawing.Point(205, 111);
            this.tbLoginUserName.Name = "tbLoginUserName";
            this.tbLoginUserName.Size = new System.Drawing.Size(100, 20);
            this.tbLoginUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(205, 163);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Inloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(265, 141);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(99, 49);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Uploaden";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnKies
            // 
            this.btnKies.Location = new System.Drawing.Point(160, 141);
            this.btnKies.Name = "btnKies";
            this.btnKies.Size = new System.Drawing.Size(99, 49);
            this.btnKies.TabIndex = 0;
            this.btnKies.Text = "Gif Zoeken";
            this.btnKies.UseVisualStyleBackColor = true;
            this.btnKies.Click += new System.EventHandler(this.btnKies_Click);
            // 
            // Randomizer
            // 
            this.Randomizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Randomizer.Location = new System.Drawing.Point(0, 0);
            this.Randomizer.Name = "Randomizer";
            this.Randomizer.Size = new System.Drawing.Size(494, 387);
            this.Randomizer.TabIndex = 1;
            this.Randomizer.Visible = false;
            // 
            // GifKiezen
            // 
            this.GifKiezen.Controls.Add(this.pbExtract);
            this.GifKiezen.Controls.Add(this.gbRating);
            this.GifKiezen.Controls.Add(this.cbCategorieKies);
            this.GifKiezen.Controls.Add(this.btnExtract);
            this.GifKiezen.Controls.Add(this.tbImgInfo);
            this.GifKiezen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GifKiezen.Location = new System.Drawing.Point(0, 29);
            this.GifKiezen.Name = "GifKiezen";
            this.GifKiezen.Size = new System.Drawing.Size(494, 358);
            this.GifKiezen.TabIndex = 2;
            this.GifKiezen.Visible = false;
            // 
            // pbExtract
            // 
            this.pbExtract.Location = new System.Drawing.Point(57, 89);
            this.pbExtract.Name = "pbExtract";
            this.pbExtract.Size = new System.Drawing.Size(383, 158);
            this.pbExtract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExtract.TabIndex = 0;
            this.pbExtract.TabStop = false;
            // 
            // gbRating
            // 
            this.gbRating.Controls.Add(this.btnImgurUpload);
            this.gbRating.Controls.Add(this.lblCijfer);
            this.gbRating.Controls.Add(this.lblRateInfo);
            this.gbRating.Controls.Add(this.lblRate);
            this.gbRating.Controls.Add(this.clbRating);
            this.gbRating.Location = new System.Drawing.Point(57, 279);
            this.gbRating.Name = "gbRating";
            this.gbRating.Size = new System.Drawing.Size(383, 67);
            this.gbRating.TabIndex = 10;
            this.gbRating.TabStop = false;
            this.gbRating.Visible = false;
            // 
            // lblCijfer
            // 
            this.lblCijfer.AutoSize = true;
            this.lblCijfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijfer.Location = new System.Drawing.Point(179, 32);
            this.lblCijfer.Name = "lblCijfer";
            this.lblCijfer.Size = new System.Drawing.Size(23, 25);
            this.lblCijfer.TabIndex = 7;
            this.lblCijfer.Text = "5";
            this.lblCijfer.Visible = false;
            // 
            // lblRateInfo
            // 
            this.lblRateInfo.AutoSize = true;
            this.lblRateInfo.Location = new System.Drawing.Point(101, 16);
            this.lblRateInfo.Name = "lblRateInfo";
            this.lblRateInfo.Size = new System.Drawing.Size(180, 13);
            this.lblRateInfo.TabIndex = 6;
            this.lblRateInfo.Text = "Het gemiddelde cijfer van deze gif is:";
            this.lblRateInfo.Visible = false;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(101, 16);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(178, 13);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Wat voor cijfer geef je aan deze gif?";
            // 
            // clbRating
            // 
            this.clbRating.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clbRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbRating.CausesValidation = false;
            this.clbRating.CheckOnClick = true;
            this.clbRating.ColumnWidth = 40;
            this.clbRating.FormattingEnabled = true;
            this.clbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.clbRating.Location = new System.Drawing.Point(87, 32);
            this.clbRating.MultiColumn = true;
            this.clbRating.Name = "clbRating";
            this.clbRating.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbRating.Size = new System.Drawing.Size(287, 15);
            this.clbRating.TabIndex = 5;
            this.clbRating.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbRating_ItemCheck);
            this.clbRating.Click += new System.EventHandler(this.clbRating_Click);
            // 
            // cbCategorieKies
            // 
            this.cbCategorieKies.FormattingEnabled = true;
            this.cbCategorieKies.Location = new System.Drawing.Point(120, 58);
            this.cbCategorieKies.Name = "cbCategorieKies";
            this.cbCategorieKies.Size = new System.Drawing.Size(121, 21);
            this.cbCategorieKies.TabIndex = 3;
            this.cbCategorieKies.Text = "Kies Categorie";
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(247, 58);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(127, 23);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.Text = "Random Gif";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // tbImgInfo
            // 
            this.tbImgInfo.Location = new System.Drawing.Point(57, 253);
            this.tbImgInfo.Name = "tbImgInfo";
            this.tbImgInfo.ReadOnly = true;
            this.tbImgInfo.Size = new System.Drawing.Size(383, 20);
            this.tbImgInfo.TabIndex = 1;
            // 
            // navMenu
            // 
            this.navMenu.Controls.Add(this.lblNaamLogged);
            this.navMenu.Controls.Add(this.lblUserID);
            this.navMenu.Controls.Add(this.lblUser);
            this.navMenu.Controls.Add(this.btnLogScherm);
            this.navMenu.Controls.Add(this.btnRegistreren);
            this.navMenu.Controls.Add(this.btnHoofdMenu);
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(494, 29);
            this.navMenu.TabIndex = 2;
            // 
            // lblNaamLogged
            // 
            this.lblNaamLogged.AutoSize = true;
            this.lblNaamLogged.Location = new System.Drawing.Point(353, 9);
            this.lblNaamLogged.Name = "lblNaamLogged";
            this.lblNaamLogged.Size = new System.Drawing.Size(0, 13);
            this.lblNaamLogged.TabIndex = 11;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(336, 9);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 13);
            this.lblUserID.TabIndex = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(174, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(156, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "U bent momenteel niet ingelogd";
            // 
            // btnLogScherm
            // 
            this.btnLogScherm.Location = new System.Drawing.Point(93, 3);
            this.btnLogScherm.Name = "btnLogScherm";
            this.btnLogScherm.Size = new System.Drawing.Size(75, 23);
            this.btnLogScherm.TabIndex = 9;
            this.btnLogScherm.Text = "Inloggen";
            this.btnLogScherm.UseVisualStyleBackColor = true;
            this.btnLogScherm.Visible = false;
            this.btnLogScherm.Click += new System.EventHandler(this.btnLogScherm_Click);
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(12, 3);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreren.TabIndex = 5;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // btnHoofdMenu
            // 
            this.btnHoofdMenu.Location = new System.Drawing.Point(416, 3);
            this.btnHoofdMenu.Name = "btnHoofdMenu";
            this.btnHoofdMenu.Size = new System.Drawing.Size(75, 23);
            this.btnHoofdMenu.TabIndex = 0;
            this.btnHoofdMenu.Text = "Hoofdmenu";
            this.btnHoofdMenu.UseVisualStyleBackColor = true;
            this.btnHoofdMenu.Visible = false;
            this.btnHoofdMenu.Click += new System.EventHandler(this.btnHoofdMenu_Click);
            // 
            // panelReg
            // 
            this.panelReg.Controls.Add(this.Email);
            this.panelReg.Controls.Add(this.label3);
            this.panelReg.Controls.Add(this.label2);
            this.panelReg.Controls.Add(this.label1);
            this.panelReg.Controls.Add(this.btnRegistreer);
            this.panelReg.Controls.Add(this.tbEmail);
            this.panelReg.Controls.Add(this.tbRegPassCheck);
            this.panelReg.Controls.Add(this.tbRegPass);
            this.panelReg.Controls.Add(this.tbRegUser);
            this.panelReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReg.Location = new System.Drawing.Point(0, 0);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(494, 387);
            this.panelReg.TabIndex = 3;
            this.panelReg.Visible = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(144, 173);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(68, 13);
            this.Email.TabIndex = 8;
            this.Email.Text = "E-mail Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Herhaal Wachtwoord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wachtwoord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(221, 194);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(100, 23);
            this.btnRegistreer.TabIndex = 4;
            this.btnRegistreer.Text = "Registreren";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(221, 170);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbRegPassCheck
            // 
            this.tbRegPassCheck.Location = new System.Drawing.Point(221, 144);
            this.tbRegPassCheck.Name = "tbRegPassCheck";
            this.tbRegPassCheck.Size = new System.Drawing.Size(100, 20);
            this.tbRegPassCheck.TabIndex = 2;
            // 
            // tbRegPass
            // 
            this.tbRegPass.Location = new System.Drawing.Point(221, 118);
            this.tbRegPass.Name = "tbRegPass";
            this.tbRegPass.Size = new System.Drawing.Size(100, 20);
            this.tbRegPass.TabIndex = 1;
            // 
            // tbRegUser
            // 
            this.tbRegUser.Location = new System.Drawing.Point(221, 92);
            this.tbRegUser.Name = "tbRegUser";
            this.tbRegUser.Size = new System.Drawing.Size(100, 20);
            this.tbRegUser.TabIndex = 0;
            // 
            // btnImgurUpload
            // 
            this.btnImgurUpload.Location = new System.Drawing.Point(6, 12);
            this.btnImgurUpload.Name = "btnImgurUpload";
            this.btnImgurUpload.Size = new System.Drawing.Size(66, 45);
            this.btnImgurUpload.TabIndex = 4;
            this.btnImgurUpload.Text = "Upload to imgur";
            this.btnImgurUpload.UseVisualStyleBackColor = true;
            this.btnImgurUpload.Click += new System.EventHandler(this.btnImgurUpload_Click);
            // 
            // KillerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 387);
            this.Controls.Add(this.GifKiezen);
            this.Controls.Add(this.StartScherm);
            this.Controls.Add(this.navMenu);
            this.Controls.Add(this.panelReg);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Randomizer);
            this.Name = "KillerApp";
            this.Text = "Reaction Gif Randomizer";
            this.Load += new System.EventHandler(this.KillerApp_Load);
            this.Upload.ResumeLayout(false);
            this.Upload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedIMG)).EndInit();
            this.StartScherm.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.GifKiezen.ResumeLayout(false);
            this.GifKiezen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtract)).EndInit();
            this.gbRating.ResumeLayout(false);
            this.gbRating.PerformLayout();
            this.navMenu.ResumeLayout(false);
            this.navMenu.PerformLayout();
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Upload;
        private System.Windows.Forms.Panel StartScherm;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnKies;
        private System.Windows.Forms.Panel Randomizer;
        private System.Windows.Forms.Panel GifKiezen;
        private System.Windows.Forms.Panel navMenu;
        private System.Windows.Forms.Button btnHoofdMenu;
        private System.Windows.Forms.PictureBox pbSelectedIMG;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Button btnImgUpload;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox tbImgInfo;
        private System.Windows.Forms.PictureBox pbExtract;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbRegPassCheck;
        private System.Windows.Forms.TextBox tbRegPass;
        private System.Windows.Forms.TextBox tbRegUser;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Label lblLoginNaam;
        private System.Windows.Forms.TextBox tbLoginPass;
        private System.Windows.Forms.TextBox tbLoginUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.Button btnLogScherm;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNaamLogged;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ComboBox cbCategorieKies;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.GroupBox gbRating;
        private System.Windows.Forms.CheckedListBox clbRating;
        private System.Windows.Forms.Label lblCijfer;
        private System.Windows.Forms.Label lblRateInfo;
        private System.Windows.Forms.Button btnImgurUpload;
    }
}

