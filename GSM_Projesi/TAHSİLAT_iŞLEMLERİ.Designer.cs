﻿namespace GSM_Projesi
{
    partial class TAHSİLAT_iŞLEMLERİ
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
            Tahsilatlar = new Button();
            Tahsilat_Alma = new Button();
            TAHSİLAT_İŞLEMLERİ_GERİ = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 0;
            label1.Text = "Tahsilat İşlemleri";
            // 
            // Tahsilatlar
            // 
            Tahsilatlar.BackColor = Color.White;
            Tahsilatlar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tahsilatlar.Location = new Point(329, 242);
            Tahsilatlar.Name = "Tahsilatlar";
            Tahsilatlar.Size = new Size(125, 33);
            Tahsilatlar.TabIndex = 1;
            Tahsilatlar.Text = "Tahsilatlar";
            Tahsilatlar.UseVisualStyleBackColor = false;
            Tahsilatlar.Click += Tahsilatlar_Click;
            // 
            // Tahsilat_Alma
            // 
            Tahsilat_Alma.BackColor = Color.White;
            Tahsilat_Alma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tahsilat_Alma.Location = new Point(329, 155);
            Tahsilat_Alma.Name = "Tahsilat_Alma";
            Tahsilat_Alma.Size = new Size(125, 33);
            Tahsilat_Alma.TabIndex = 2;
            Tahsilat_Alma.Text = "Tahsilat Alma";
            Tahsilat_Alma.UseVisualStyleBackColor = false;
            Tahsilat_Alma.Click += Tahsilat_Alma_Click;
            // 
            // TAHSİLAT_İŞLEMLERİ_GERİ
            // 
            TAHSİLAT_İŞLEMLERİ_GERİ.BackColor = Color.White;
            TAHSİLAT_İŞLEMLERİ_GERİ.BackgroundImage = Properties.Resources.back;
            TAHSİLAT_İŞLEMLERİ_GERİ.BackgroundImageLayout = ImageLayout.Zoom;
            TAHSİLAT_İŞLEMLERİ_GERİ.FlatStyle = FlatStyle.Flat;
            TAHSİLAT_İŞLEMLERİ_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TAHSİLAT_İŞLEMLERİ_GERİ.ForeColor = SystemColors.ControlText;
            TAHSİLAT_İŞLEMLERİ_GERİ.Location = new Point(12, 12);
            TAHSİLAT_İŞLEMLERİ_GERİ.Name = "TAHSİLAT_İŞLEMLERİ_GERİ";
            TAHSİLAT_İŞLEMLERİ_GERİ.Size = new Size(61, 29);
            TAHSİLAT_İŞLEMLERİ_GERİ.TabIndex = 14;
            TAHSİLAT_İŞLEMLERİ_GERİ.UseVisualStyleBackColor = false;
            TAHSİLAT_İŞLEMLERİ_GERİ.Click += TAHSİLAT_İŞLEMLERİ_GERİ_Click;
            // 
            // TAHSİLAT_iŞLEMLERİ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MüsteriIslemleri_background__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = TAHSİLAT_İŞLEMLERİ_GERİ;
            ClientSize = new Size(800, 450);
            Controls.Add(TAHSİLAT_İŞLEMLERİ_GERİ);
            Controls.Add(Tahsilat_Alma);
            Controls.Add(Tahsilatlar);
            Controls.Add(label1);
            Name = "TAHSİLAT_iŞLEMLERİ";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TAHSİLAT_iŞLEMLERİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Tahsilatlar;
        private Button Tahsilat_Alma;
        private Button TAHSİLAT_İŞLEMLERİ_GERİ;
    }
}