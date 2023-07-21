namespace GSM_Projesi
{
    partial class TARİFE_İŞLEMLERİ
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
            YENİ_TARİFE = new Button();
            label1 = new Label();
            TARİFE_İŞLEMLERİ_GERİ = new Button();
            TARİFELER_BUTONU = new Button();
            SuspendLayout();
            // 
            // YENİ_TARİFE
            // 
            YENİ_TARİFE.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            YENİ_TARİFE.Location = new Point(338, 101);
            YENİ_TARİFE.Name = "YENİ_TARİFE";
            YENİ_TARİFE.Size = new Size(114, 29);
            YENİ_TARİFE.TabIndex = 0;
            YENİ_TARİFE.Text = "Yeni tarife";
            YENİ_TARİFE.UseVisualStyleBackColor = true;
            YENİ_TARİFE.Click += YENİ_TARİFE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 1;
            label1.Text = "Tarife İşlemleri";
            // 
            // TARİFE_İŞLEMLERİ_GERİ
            // 
            TARİFE_İŞLEMLERİ_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TARİFE_İŞLEMLERİ_GERİ.ForeColor = SystemColors.ControlText;
            TARİFE_İŞLEMLERİ_GERİ.Location = new Point(12, 409);
            TARİFE_İŞLEMLERİ_GERİ.Name = "TARİFE_İŞLEMLERİ_GERİ";
            TARİFE_İŞLEMLERİ_GERİ.Size = new Size(128, 29);
            TARİFE_İŞLEMLERİ_GERİ.TabIndex = 10;
            TARİFE_İŞLEMLERİ_GERİ.Text = "Geri";
            TARİFE_İŞLEMLERİ_GERİ.UseVisualStyleBackColor = true;
            TARİFE_İŞLEMLERİ_GERİ.Click += TARİFE_İŞLEMLERİ_GERİ_Click;
            // 
            // TARİFELER_BUTONU
            // 
            TARİFELER_BUTONU.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TARİFELER_BUTONU.Location = new Point(338, 189);
            TARİFELER_BUTONU.Name = "TARİFELER_BUTONU";
            TARİFELER_BUTONU.Size = new Size(114, 29);
            TARİFELER_BUTONU.TabIndex = 11;
            TARİFELER_BUTONU.Text = "Tarifeler";
            TARİFELER_BUTONU.UseVisualStyleBackColor = true;
            TARİFELER_BUTONU.Click += TARİFELER_BUTONU_Click;
            // 
            // TARİFE_İŞLEMLERİ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = TARİFE_İŞLEMLERİ_GERİ;
            ClientSize = new Size(800, 450);
            Controls.Add(TARİFELER_BUTONU);
            Controls.Add(TARİFE_İŞLEMLERİ_GERİ);
            Controls.Add(label1);
            Controls.Add(YENİ_TARİFE);
            Name = "TARİFE_İŞLEMLERİ";
            Text = "TARİFE_İŞLEMLERİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button YENİ_TARİFE;
        private Label label1;
        private Button TARİFE_İŞLEMLERİ_GERİ;
        private Button TARİFELER_BUTONU;
    }
}