namespace GSM_Projesi
{
    partial class İşlemler
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
            MÜŞTERİ_iŞLEMLERİ = new Button();
            TARİFE_İŞLEMLERİ = new Button();
            FATURA_İŞLEMLERİ = new Button();
            TAHSİLAT_İŞLEMLERİ = new Button();
            SuspendLayout();
            // 
            // MÜŞTERİ_iŞLEMLERİ
            // 
            MÜŞTERİ_iŞLEMLERİ.BackColor = Color.Transparent;
            MÜŞTERİ_iŞLEMLERİ.BackgroundImageLayout = ImageLayout.Center;
            MÜŞTERİ_iŞLEMLERİ.FlatStyle = FlatStyle.Flat;
            MÜŞTERİ_iŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MÜŞTERİ_iŞLEMLERİ.Location = new Point(171, 109);
            MÜŞTERİ_iŞLEMLERİ.Name = "MÜŞTERİ_iŞLEMLERİ";
            MÜŞTERİ_iŞLEMLERİ.Size = new Size(184, 76);
            MÜŞTERİ_iŞLEMLERİ.TabIndex = 0;
            MÜŞTERİ_iŞLEMLERİ.Text = "Müşteri İşlemleri";
            MÜŞTERİ_iŞLEMLERİ.UseVisualStyleBackColor = false;
            MÜŞTERİ_iŞLEMLERİ.Click += MÜŞTERİ_iŞLEMLERİ_Click;
            // 
            // TARİFE_İŞLEMLERİ
            // 
            TARİFE_İŞLEMLERİ.BackColor = Color.Transparent;
            TARİFE_İŞLEMLERİ.BackgroundImageLayout = ImageLayout.Stretch;
            TARİFE_İŞLEMLERİ.FlatStyle = FlatStyle.Flat;
            TARİFE_İŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TARİFE_İŞLEMLERİ.Location = new Point(475, 109);
            TARİFE_İŞLEMLERİ.Name = "TARİFE_İŞLEMLERİ";
            TARİFE_İŞLEMLERİ.Size = new Size(184, 76);
            TARİFE_İŞLEMLERİ.TabIndex = 1;
            TARİFE_İŞLEMLERİ.Text = "Tarife İşlemleri";
            TARİFE_İŞLEMLERİ.UseVisualStyleBackColor = false;
            TARİFE_İŞLEMLERİ.Click += TARİFE_İŞLEMLERİ_Click;
            // 
            // FATURA_İŞLEMLERİ
            // 
            FATURA_İŞLEMLERİ.BackColor = Color.Transparent;
            FATURA_İŞLEMLERİ.FlatStyle = FlatStyle.Flat;
            FATURA_İŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURA_İŞLEMLERİ.Location = new Point(171, 253);
            FATURA_İŞLEMLERİ.Name = "FATURA_İŞLEMLERİ";
            FATURA_İŞLEMLERİ.Size = new Size(184, 73);
            FATURA_İŞLEMLERİ.TabIndex = 2;
            FATURA_İŞLEMLERİ.Text = "Fatura İşlemleri";
            FATURA_İŞLEMLERİ.UseVisualStyleBackColor = false;
            FATURA_İŞLEMLERİ.Click += FATURA_İŞLEMLERİ_Click;
            // 
            // TAHSİLAT_İŞLEMLERİ
            // 
            TAHSİLAT_İŞLEMLERİ.BackColor = Color.Transparent;
            TAHSİLAT_İŞLEMLERİ.FlatStyle = FlatStyle.Flat;
            TAHSİLAT_İŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TAHSİLAT_İŞLEMLERİ.Location = new Point(475, 253);
            TAHSİLAT_İŞLEMLERİ.Name = "TAHSİLAT_İŞLEMLERİ";
            TAHSİLAT_İŞLEMLERİ.Size = new Size(184, 73);
            TAHSİLAT_İŞLEMLERİ.TabIndex = 3;
            TAHSİLAT_İŞLEMLERİ.Text = "Tahsilat İşlemleri";
            TAHSİLAT_İŞLEMLERİ.UseVisualStyleBackColor = false;
            TAHSİLAT_İŞLEMLERİ.Click += TAHSİLAT_İŞLEMLERİ_Click;
            // 
            // İşlemler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 476);
            Controls.Add(TAHSİLAT_İŞLEMLERİ);
            Controls.Add(FATURA_İŞLEMLERİ);
            Controls.Add(TARİFE_İŞLEMLERİ);
            Controls.Add(MÜŞTERİ_iŞLEMLERİ);
            DoubleBuffered = true;
            Name = "İşlemler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İŞLEMLER";
            FormClosing += İşlemler_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button MÜŞTERİ_iŞLEMLERİ;
        private Button TARİFE_İŞLEMLERİ;
        private Button FATURA_İŞLEMLERİ;
        private Button TAHSİLAT_İŞLEMLERİ;
    }
}