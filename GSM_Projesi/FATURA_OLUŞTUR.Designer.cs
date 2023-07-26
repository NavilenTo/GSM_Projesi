namespace GSM_Projesi
{
    partial class FATURA_OLUŞTUR
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
            FATURAA_OLUŞTUR = new Button();
            label1 = new Label();
            Aylar = new ComboBox();
            dataGridView1 = new DataGridView();
            FATURA_OLUŞTUR_GERİ = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FATURAA_OLUŞTUR
            // 
            FATURAA_OLUŞTUR.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURAA_OLUŞTUR.Location = new Point(396, 444);
            FATURAA_OLUŞTUR.Name = "FATURAA_OLUŞTUR";
            FATURAA_OLUŞTUR.Size = new Size(123, 34);
            FATURAA_OLUŞTUR.TabIndex = 0;
            FATURAA_OLUŞTUR.Text = "Fatura Oluştur";
            FATURAA_OLUŞTUR.UseVisualStyleBackColor = true;
            FATURAA_OLUŞTUR.Click += FATURAA_OLUŞTUR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(374, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 1;
            label1.Text = "Fatura Oluştur";
            // 
            // Aylar
            // 
            Aylar.FormattingEnabled = true;
            Aylar.Items.AddRange(new object[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" });
            Aylar.Location = new Point(721, 77);
            Aylar.Name = "Aylar";
            Aylar.Size = new Size(121, 23);
            Aylar.TabIndex = 2;
            Aylar.SelectedIndexChanged += Aylar_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(693, 343);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // FATURA_OLUŞTUR_GERİ
            // 
            FATURA_OLUŞTUR_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURA_OLUŞTUR_GERİ.ForeColor = SystemColors.ControlText;
            FATURA_OLUŞTUR_GERİ.Location = new Point(12, 449);
            FATURA_OLUŞTUR_GERİ.Name = "FATURA_OLUŞTUR_GERİ";
            FATURA_OLUŞTUR_GERİ.Size = new Size(128, 29);
            FATURA_OLUŞTUR_GERİ.TabIndex = 12;
            FATURA_OLUŞTUR_GERİ.Text = "Geri";
            FATURA_OLUŞTUR_GERİ.UseVisualStyleBackColor = true;
            FATURA_OLUŞTUR_GERİ.Click += FATURA_OLUŞTUR_GERİ_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1158, 89);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1158, 104);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1158, 123);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // FATURA_OLUŞTUR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = FATURA_OLUŞTUR_GERİ;
            ClientSize = new Size(1309, 490);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FATURA_OLUŞTUR_GERİ);
            Controls.Add(dataGridView1);
            Controls.Add(Aylar);
            Controls.Add(label1);
            Controls.Add(FATURAA_OLUŞTUR);
            Name = "FATURA_OLUŞTUR";
            Text = "FATURA_OLUŞTUR";
            Load += FATURA_OLUŞTUR_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FATURAA_OLUŞTUR;
        private Label label1;
        private ComboBox Aylar;
        private DataGridView dataGridView1;
        private Button FATURA_OLUŞTUR_GERİ;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}