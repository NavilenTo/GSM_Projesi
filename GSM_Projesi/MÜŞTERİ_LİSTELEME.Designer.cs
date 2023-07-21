namespace GSM_Projesi
{
    partial class MÜŞTERİ_LİSTELEME
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
            MÜŞTERİ_LİSTELE_GERİ = new Button();
            MÜŞTERİ_SİL = new Button();
            MÜŞTERİ_GÜNCELLE = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MÜŞTERİ_LİSTELE_GERİ
            // 
            MÜŞTERİ_LİSTELE_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MÜŞTERİ_LİSTELE_GERİ.ForeColor = SystemColors.ControlText;
            MÜŞTERİ_LİSTELE_GERİ.Location = new Point(12, 409);
            MÜŞTERİ_LİSTELE_GERİ.Name = "MÜŞTERİ_LİSTELE_GERİ";
            MÜŞTERİ_LİSTELE_GERİ.Size = new Size(128, 29);
            MÜŞTERİ_LİSTELE_GERİ.TabIndex = 11;
            MÜŞTERİ_LİSTELE_GERİ.Text = "Geri";
            MÜŞTERİ_LİSTELE_GERİ.UseVisualStyleBackColor = true;
            MÜŞTERİ_LİSTELE_GERİ.Click += MÜŞTERİ_LİSTELE_GERİ_Click;
            // 
            // MÜŞTERİ_SİL
            // 
            MÜŞTERİ_SİL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MÜŞTERİ_SİL.Location = new Point(675, 91);
            MÜŞTERİ_SİL.Name = "MÜŞTERİ_SİL";
            MÜŞTERİ_SİL.Size = new Size(113, 32);
            MÜŞTERİ_SİL.TabIndex = 12;
            MÜŞTERİ_SİL.Text = "Sil";
            MÜŞTERİ_SİL.UseVisualStyleBackColor = true;
            MÜŞTERİ_SİL.Click += MÜŞTERİ_SİL_Click;
            // 
            // MÜŞTERİ_GÜNCELLE
            // 
            MÜŞTERİ_GÜNCELLE.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MÜŞTERİ_GÜNCELLE.Location = new Point(675, 149);
            MÜŞTERİ_GÜNCELLE.Name = "MÜŞTERİ_GÜNCELLE";
            MÜŞTERİ_GÜNCELLE.Size = new Size(113, 32);
            MÜŞTERİ_GÜNCELLE.TabIndex = 13;
            MÜŞTERİ_GÜNCELLE.Text = "Güncelle";
            MÜŞTERİ_GÜNCELLE.UseVisualStyleBackColor = true;
            MÜŞTERİ_GÜNCELLE.Click += MÜŞTERİ_GÜNCELLE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 15;
            label1.Text = "Müşteri Listele";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(633, 299);
            dataGridView1.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MÜŞTERİ_LİSTELEME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = MÜŞTERİ_LİSTELE_GERİ;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(MÜŞTERİ_GÜNCELLE);
            Controls.Add(MÜŞTERİ_SİL);
            Controls.Add(MÜŞTERİ_LİSTELE_GERİ);
            Name = "MÜŞTERİ_LİSTELEME";
            Text = "MÜŞTERİ_LİSTELEME";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button MÜŞTERİ_LİSTELE_GERİ;
        private Button MÜŞTERİ_SİL;
        private Button MÜŞTERİ_GÜNCELLE;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}