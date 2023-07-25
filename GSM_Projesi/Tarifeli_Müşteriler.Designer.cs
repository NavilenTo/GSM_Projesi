namespace GSM_Projesi
{
    partial class Tarifeli_Müşteriler
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Tarifeli_Müşteri_Sil = new Button();
            YENİ_TARİFE_GERİ = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(619, 309);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(414, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 1;
            label1.Text = " TARİFELİ MÜŞTERİLER";
            // 
            // Tarifeli_Müşteri_Sil
            // 
            Tarifeli_Müşteri_Sil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tarifeli_Müşteri_Sil.Location = new Point(749, 114);
            Tarifeli_Müşteri_Sil.Name = "Tarifeli_Müşteri_Sil";
            Tarifeli_Müşteri_Sil.Size = new Size(128, 29);
            Tarifeli_Müşteri_Sil.TabIndex = 2;
            Tarifeli_Müşteri_Sil.Text = "Sil";
            Tarifeli_Müşteri_Sil.UseVisualStyleBackColor = true;
            Tarifeli_Müşteri_Sil.Click += Tarifeli_Müşteri_Sil_Click;
            // 
            // YENİ_TARİFE_GERİ
            // 
            YENİ_TARİFE_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            YENİ_TARİFE_GERİ.ForeColor = SystemColors.ControlText;
            YENİ_TARİFE_GERİ.Location = new Point(12, 409);
            YENİ_TARİFE_GERİ.Name = "YENİ_TARİFE_GERİ";
            YENİ_TARİFE_GERİ.Size = new Size(128, 29);
            YENİ_TARİFE_GERİ.TabIndex = 28;
            YENİ_TARİFE_GERİ.Text = "Geri";
            YENİ_TARİFE_GERİ.UseVisualStyleBackColor = true;
            YENİ_TARİFE_GERİ.Click += YENİ_TARİFE_GERİ_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 30;
            label2.Text = "TarifeliMüşteriler";
            // 
            // Tarifeli_Müşteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = YENİ_TARİFE_GERİ;
            ClientSize = new Size(972, 471);
            Controls.Add(label2);
            Controls.Add(YENİ_TARİFE_GERİ);
            Controls.Add(Tarifeli_Müşteri_Sil);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Tarifeli_Müşteriler";
            Text = "Tarifeli_Müşteriler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button Tarifeli_Müşteri_Sil;
        private Button YENİ_TARİFE_GERİ;
        private Label label2;
    }
}