namespace GSM_Projesi
{
    partial class Giriş_Ekranı
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş_Ekranı));
            Kullanıcı_Adi = new Label();
            Şifre = new Label();
            KULLANICI_ADI_TEXT = new TextBox();
            ŞİFRE_TEXT = new TextBox();
            GİRİŞ_YAP = new Button();
            GİRİŞ_HATA_MESAJI = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Kullanıcı_Adi
            // 
            Kullanıcı_Adi.AutoSize = true;
            Kullanıcı_Adi.BackColor = Color.Transparent;
            Kullanıcı_Adi.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Kullanıcı_Adi.Location = new Point(151, 44);
            Kullanıcı_Adi.Name = "Kullanıcı_Adi";
            Kullanıcı_Adi.Size = new Size(142, 32);
            Kullanıcı_Adi.TabIndex = 0;
            Kullanıcı_Adi.Text = "Kullanıcı Adı";
            // 
            // Şifre
            // 
            Şifre.AutoSize = true;
            Şifre.BackColor = Color.Transparent;
            Şifre.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Şifre.Location = new Point(188, 169);
            Şifre.Name = "Şifre";
            Şifre.Size = new Size(60, 32);
            Şifre.TabIndex = 1;
            Şifre.Text = "Şifre";
            // 
            // KULLANICI_ADI_TEXT
            // 
            KULLANICI_ADI_TEXT.Location = new Point(127, 98);
            KULLANICI_ADI_TEXT.Name = "KULLANICI_ADI_TEXT";
            KULLANICI_ADI_TEXT.Size = new Size(192, 23);
            KULLANICI_ADI_TEXT.TabIndex = 2;
            // 
            // ŞİFRE_TEXT
            // 
            ŞİFRE_TEXT.Location = new Point(127, 216);
            ŞİFRE_TEXT.Name = "ŞİFRE_TEXT";
            ŞİFRE_TEXT.Size = new Size(192, 23);
            ŞİFRE_TEXT.TabIndex = 3;
            ŞİFRE_TEXT.TextChanged += ŞİFRE_TEXT_TextChanged;
            // 
            // GİRİŞ_YAP
            // 
            GİRİŞ_YAP.BackColor = Color.CadetBlue;
            GİRİŞ_YAP.FlatStyle = FlatStyle.Flat;
            GİRİŞ_YAP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GİRİŞ_YAP.Location = new Point(166, 276);
            GİRİŞ_YAP.Name = "GİRİŞ_YAP";
            GİRİŞ_YAP.Size = new Size(116, 34);
            GİRİŞ_YAP.TabIndex = 4;
            GİRİŞ_YAP.Text = "Giriş Yap";
            GİRİŞ_YAP.UseVisualStyleBackColor = false;
            GİRİŞ_YAP.Click += GİRİŞ_YAP_Click;
            // 
            // GİRİŞ_HATA_MESAJI
            // 
            GİRİŞ_HATA_MESAJI.AutoSize = true;
            GİRİŞ_HATA_MESAJI.BackColor = Color.Transparent;
            GİRİŞ_HATA_MESAJI.Font = new Font("Leelawadee", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            GİRİŞ_HATA_MESAJI.ForeColor = Color.Red;
            GİRİŞ_HATA_MESAJI.Location = new Point(42, 347);
            GİRİŞ_HATA_MESAJI.Name = "GİRİŞ_HATA_MESAJI";
            GİRİŞ_HATA_MESAJI.Size = new Size(376, 25);
            GİRİŞ_HATA_MESAJI.TabIndex = 5;
            GİRİŞ_HATA_MESAJI.Text = "YANLIŞ KULLANICI ADI YADA ŞİFRE";
            // 
            // button1
            // 
            button1.Location = new Point(742, 376);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
            panel1.Controls.Add(Kullanıcı_Adi);
            panel1.Controls.Add(Şifre);
            panel1.Controls.Add(GİRİŞ_HATA_MESAJI);
            panel1.Controls.Add(KULLANICI_ADI_TEXT);
            panel1.Controls.Add(GİRİŞ_YAP);
            panel1.Controls.Add(ŞİFRE_TEXT);
            panel1.Location = new Point(207, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 416);
            panel1.TabIndex = 7;
            // 
            // Giriş_Ekranı
            // 
            AcceptButton = GİRİŞ_YAP;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_background;
            ClientSize = new Size(829, 534);
            Controls.Add(panel1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Giriş_Ekranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += Giriş_Ekranı_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Kullanıcı_Adi;
        private Label Şifre;
        private TextBox KULLANICI_ADI_TEXT;
        private TextBox ŞİFRE_TEXT;
        private Button GİRİŞ_YAP;
        private Label GİRİŞ_HATA_MESAJI;
        private Button button1;
        private Panel panel1;
    }
}