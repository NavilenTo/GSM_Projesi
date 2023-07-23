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
            MÜŞTERİ_iŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MÜŞTERİ_iŞLEMLERİ.Location = new Point(186, 134);
            MÜŞTERİ_iŞLEMLERİ.Name = "MÜŞTERİ_iŞLEMLERİ";
            MÜŞTERİ_iŞLEMLERİ.Size = new Size(156, 72);
            MÜŞTERİ_iŞLEMLERİ.TabIndex = 0;
            MÜŞTERİ_iŞLEMLERİ.Text = "Müşteri İşlemleri";
            MÜŞTERİ_iŞLEMLERİ.UseVisualStyleBackColor = true;
            MÜŞTERİ_iŞLEMLERİ.Click += MÜŞTERİ_iŞLEMLERİ_Click;
            // 
            // TARİFE_İŞLEMLERİ
            // 
            TARİFE_İŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TARİFE_İŞLEMLERİ.Location = new Point(496, 134);
            TARİFE_İŞLEMLERİ.Name = "TARİFE_İŞLEMLERİ";
            TARİFE_İŞLEMLERİ.Size = new Size(156, 72);
            TARİFE_İŞLEMLERİ.TabIndex = 1;
            TARİFE_İŞLEMLERİ.Text = "Tarife İşlemleri";
            TARİFE_İŞLEMLERİ.UseVisualStyleBackColor = true;
            TARİFE_İŞLEMLERİ.Click += TARİFE_İŞLEMLERİ_Click;
            // 
            // FATURA_İŞLEMLERİ
            // 
            FATURA_İŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURA_İŞLEMLERİ.Location = new Point(186, 314);
            FATURA_İŞLEMLERİ.Name = "FATURA_İŞLEMLERİ";
            FATURA_İŞLEMLERİ.Size = new Size(156, 69);
            FATURA_İŞLEMLERİ.TabIndex = 2;
            FATURA_İŞLEMLERİ.Text = "Fatura İşlemleri";
            FATURA_İŞLEMLERİ.UseVisualStyleBackColor = true;
            FATURA_İŞLEMLERİ.Click += FATURA_İŞLEMLERİ_Click;
            // 
            // TAHSİLAT_İŞLEMLERİ
            // 
            TAHSİLAT_İŞLEMLERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TAHSİLAT_İŞLEMLERİ.Location = new Point(496, 314);
            TAHSİLAT_İŞLEMLERİ.Name = "TAHSİLAT_İŞLEMLERİ";
            TAHSİLAT_İŞLEMLERİ.Size = new Size(156, 69);
            TAHSİLAT_İŞLEMLERİ.TabIndex = 3;
            TAHSİLAT_İŞLEMLERİ.Text = "Tahsilat İşlemleri";
            TAHSİLAT_İŞLEMLERİ.UseVisualStyleBackColor = true;
            TAHSİLAT_İŞLEMLERİ.Click += TAHSİLAT_İŞLEMLERİ_Click;
            // 
            // İşlemler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 531);
            Controls.Add(TAHSİLAT_İŞLEMLERİ);
            Controls.Add(FATURA_İŞLEMLERİ);
            Controls.Add(TARİFE_İŞLEMLERİ);
            Controls.Add(MÜŞTERİ_iŞLEMLERİ);
            Name = "İşlemler";
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