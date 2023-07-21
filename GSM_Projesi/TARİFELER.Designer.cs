namespace GSM_Projesi
{
    partial class TARİFELER
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
            Tarife_Sil = new Button();
            label1 = new Label();
            Tarife_Güncelle = new Button();
            Tarifeler_DataGridView = new DataGridView();
            TARİFELER_GERİ = new Button();
            TARİFE_ARAMA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Tarifeler_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Tarife_Sil
            // 
            Tarife_Sil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tarife_Sil.Location = new Point(618, 169);
            Tarife_Sil.Name = "Tarife_Sil";
            Tarife_Sil.Size = new Size(104, 31);
            Tarife_Sil.TabIndex = 0;
            Tarife_Sil.Text = "Sil";
            Tarife_Sil.UseVisualStyleBackColor = true;
            Tarife_Sil.Click += Tarife_Sil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 1;
            label1.Text = "Tarifeler";
            // 
            // Tarife_Güncelle
            // 
            Tarife_Güncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tarife_Güncelle.Location = new Point(618, 215);
            Tarife_Güncelle.Name = "Tarife_Güncelle";
            Tarife_Güncelle.Size = new Size(104, 31);
            Tarife_Güncelle.TabIndex = 2;
            Tarife_Güncelle.Text = "Güncelle";
            Tarife_Güncelle.UseVisualStyleBackColor = true;
            Tarife_Güncelle.Click += Tarife_Güncelle_Click;
            // 
            // Tarifeler_DataGridView
            // 
            Tarifeler_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tarifeler_DataGridView.Location = new Point(39, 92);
            Tarifeler_DataGridView.Name = "Tarifeler_DataGridView";
            Tarifeler_DataGridView.RowTemplate.Height = 25;
            Tarifeler_DataGridView.Size = new Size(562, 269);
            Tarifeler_DataGridView.TabIndex = 4;
            Tarifeler_DataGridView.CellContentClick += Tarifeler_DataGridView_CellContentClick;
            // 
            // TARİFELER_GERİ
            // 
            TARİFELER_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TARİFELER_GERİ.ForeColor = SystemColors.ControlText;
            TARİFELER_GERİ.Location = new Point(12, 409);
            TARİFELER_GERİ.Name = "TARİFELER_GERİ";
            TARİFELER_GERİ.Size = new Size(128, 29);
            TARİFELER_GERİ.TabIndex = 11;
            TARİFELER_GERİ.Text = "Geri";
            TARİFELER_GERİ.UseVisualStyleBackColor = true;
            TARİFELER_GERİ.Click += TARİFELER_GERİ_Click;
            // 
            // TARİFE_ARAMA
            // 
            TARİFE_ARAMA.Location = new Point(39, 63);
            TARİFE_ARAMA.Name = "TARİFE_ARAMA";
            TARİFE_ARAMA.Size = new Size(151, 23);
            TARİFE_ARAMA.TabIndex = 12;
            TARİFE_ARAMA.TextChanged += TARİFE_ARAMA_TextChanged;
            // 
            // TARİFELER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = TARİFELER_GERİ;
            ClientSize = new Size(800, 450);
            Controls.Add(TARİFE_ARAMA);
            Controls.Add(TARİFELER_GERİ);
            Controls.Add(Tarifeler_DataGridView);
            Controls.Add(Tarife_Güncelle);
            Controls.Add(label1);
            Controls.Add(Tarife_Sil);
            Name = "TARİFELER";
            Text = "TARİFELER";
            ((System.ComponentModel.ISupportInitialize)Tarifeler_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Tarife_Sil;
        private Label label1;
        private Button Tarife_Güncelle;
        private DataGridView Tarifeler_DataGridView;
        private Button TARİFELER_GERİ;
        private TextBox TARİFE_ARAMA;
    }
}