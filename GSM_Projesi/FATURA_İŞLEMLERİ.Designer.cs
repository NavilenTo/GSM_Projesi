namespace GSM_Projesi
{
    partial class FATURA_İŞLEMLERİ
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
            label1 = new Label();
            FATURA_OLUŞTUR = new Button();
            FATURALAR = new Button();
            FATURA_İŞLEMLERİ_GERİ = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 0;
            label1.Text = "Fatura İşlemleri";
            // 
            // FATURA_OLUŞTUR
            // 
            FATURA_OLUŞTUR.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURA_OLUŞTUR.Location = new Point(330, 100);
            FATURA_OLUŞTUR.Name = "FATURA_OLUŞTUR";
            FATURA_OLUŞTUR.Size = new Size(125, 33);
            FATURA_OLUŞTUR.TabIndex = 1;
            FATURA_OLUŞTUR.Text = "Fatura Oluştur";
            FATURA_OLUŞTUR.UseVisualStyleBackColor = true;
            FATURA_OLUŞTUR.Click += FATURA_OLUŞTUR_Click;
            // 
            // FATURALAR
            // 
            FATURALAR.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURALAR.Location = new Point(330, 182);
            FATURALAR.Name = "FATURALAR";
            FATURALAR.Size = new Size(125, 33);
            FATURALAR.TabIndex = 2;
            FATURALAR.Text = "Faturalar";
            FATURALAR.UseVisualStyleBackColor = true;
            FATURALAR.Click += FATURALAR_Click;
            // 
            // FATURA_İŞLEMLERİ_GERİ
            // 
            FATURA_İŞLEMLERİ_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURA_İŞLEMLERİ_GERİ.ForeColor = SystemColors.ControlText;
            FATURA_İŞLEMLERİ_GERİ.Location = new Point(12, 409);
            FATURA_İŞLEMLERİ_GERİ.Name = "FATURA_İŞLEMLERİ_GERİ";
            FATURA_İŞLEMLERİ_GERİ.Size = new Size(128, 29);
            FATURA_İŞLEMLERİ_GERİ.TabIndex = 12;
            FATURA_İŞLEMLERİ_GERİ.Text = "Geri";
            FATURA_İŞLEMLERİ_GERİ.UseVisualStyleBackColor = true;
            FATURA_İŞLEMLERİ_GERİ.Click += FATURA_İŞLEMLERİ_GERİ_Click;
            // 
            // FATURA_İŞLEMLERİ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = FATURA_İŞLEMLERİ_GERİ;
            ClientSize = new Size(800, 450);
            Controls.Add(FATURA_İŞLEMLERİ_GERİ);
            Controls.Add(FATURALAR);
            Controls.Add(FATURA_OLUŞTUR);
            Controls.Add(label1);
            Name = "FATURA_İŞLEMLERİ";
            Text = "FATURA_İŞLEMLERİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button FATURA_OLUŞTUR;
        private Button FATURALAR;
        private Button FATURA_İŞLEMLERİ_GERİ;
    }
}