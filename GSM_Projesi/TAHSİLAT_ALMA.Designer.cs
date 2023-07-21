namespace GSM_Projesi
{
    partial class TAHSİLAT_ALMA
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
            Tahsilat_Alma_Button = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            TAHSİLAT_ALMA_GERİ = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Tahsilat_Alma_Button
            // 
            Tahsilat_Alma_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tahsilat_Alma_Button.Location = new Point(349, 397);
            Tahsilat_Alma_Button.Name = "Tahsilat_Alma_Button";
            Tahsilat_Alma_Button.Size = new Size(127, 32);
            Tahsilat_Alma_Button.TabIndex = 0;
            Tahsilat_Alma_Button.Text = "Tahsilat Al";
            Tahsilat_Alma_Button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 319);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 2;
            label1.Text = "Tahsilat Alma";
            // 
            // TAHSİLAT_ALMA_GERİ
            // 
            TAHSİLAT_ALMA_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TAHSİLAT_ALMA_GERİ.ForeColor = SystemColors.ControlText;
            TAHSİLAT_ALMA_GERİ.Location = new Point(12, 409);
            TAHSİLAT_ALMA_GERİ.Name = "TAHSİLAT_ALMA_GERİ";
            TAHSİLAT_ALMA_GERİ.Size = new Size(128, 29);
            TAHSİLAT_ALMA_GERİ.TabIndex = 14;
            TAHSİLAT_ALMA_GERİ.Text = "Geri";
            TAHSİLAT_ALMA_GERİ.UseVisualStyleBackColor = true;
            TAHSİLAT_ALMA_GERİ.Click += TAHSİLAT_ALMA_GERİ_Click;
            // 
            // TAHSİLAT_ALMA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = TAHSİLAT_ALMA_GERİ;
            ClientSize = new Size(800, 450);
            Controls.Add(TAHSİLAT_ALMA_GERİ);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Tahsilat_Alma_Button);
            Name = "TAHSİLAT_ALMA";
            Text = "TAHSİLAT_ALMA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Tahsilat_Alma_Button;
        private DataGridView dataGridView1;
        private Label label1;
        private Button TAHSİLAT_ALMA_GERİ;
    }
}