namespace GSM_Projesi
{
    partial class TAHSİLATLAR
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
            TAHSİLAT_GERİ = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TAHSİLAT_GERİ
            // 
            TAHSİLAT_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TAHSİLAT_GERİ.Location = new Point(12, 409);
            TAHSİLAT_GERİ.Name = "TAHSİLAT_GERİ";
            TAHSİLAT_GERİ.Size = new Size(128, 29);
            TAHSİLAT_GERİ.TabIndex = 7;
            TAHSİLAT_GERİ.Text = "Geri";
            TAHSİLAT_GERİ.UseVisualStyleBackColor = true;
            TAHSİLAT_GERİ.Click += TAHSİLAT_GERİ_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 310);
            dataGridView1.TabIndex = 8;
            // 
            // TAHSİLATLAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = TAHSİLAT_GERİ;
            ClientSize = new Size(823, 454);
            Controls.Add(dataGridView1);
            Controls.Add(TAHSİLAT_GERİ);
            Name = "TAHSİLATLAR";
            Text = "TAHSİLATLAR";
            Load += TAHSİLATLAR_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button TAHSİLAT_GERİ;
        private DataGridView dataGridView1;
    }
}