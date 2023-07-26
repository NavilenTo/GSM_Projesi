namespace GSM_Projesi
{
    partial class FATURALAR
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
            Faturlar_Sil = new Button();
            FATURALAR_GERİ = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(600, 292);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(366, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 1;
            label1.Text = "Faturalar";
            // 
            // Faturlar_Sil
            // 
            Faturlar_Sil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Faturlar_Sil.Location = new Point(632, 135);
            Faturlar_Sil.Name = "Faturlar_Sil";
            Faturlar_Sil.Size = new Size(110, 29);
            Faturlar_Sil.TabIndex = 2;
            Faturlar_Sil.Text = "Sil";
            Faturlar_Sil.UseVisualStyleBackColor = true;
            Faturlar_Sil.Click += Faturlar_Sil_Click;
            // 
            // FATURALAR_GERİ
            // 
            FATURALAR_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FATURALAR_GERİ.ForeColor = SystemColors.ControlText;
            FATURALAR_GERİ.Location = new Point(12, 409);
            FATURALAR_GERİ.Name = "FATURALAR_GERİ";
            FATURALAR_GERİ.Size = new Size(128, 29);
            FATURALAR_GERİ.TabIndex = 13;
            FATURALAR_GERİ.Text = "Geri";
            FATURALAR_GERİ.UseVisualStyleBackColor = true;
            FATURALAR_GERİ.Click += FATURALAR_GERİ_Click;
            // 
            // FATURALAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = FATURALAR_GERİ;
            ClientSize = new Size(800, 450);
            Controls.Add(FATURALAR_GERİ);
            Controls.Add(Faturlar_Sil);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FATURALAR";
            Text = "FATURALAR";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button Faturlar_Sil;
        private Button FATURALAR_GERİ;
    }
}