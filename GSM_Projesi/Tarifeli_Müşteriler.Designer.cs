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
            button2 = new Button();
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
            Tarifeli_Müşteri_Sil.Location = new Point(746, 164);
            Tarifeli_Müşteri_Sil.Name = "Tarifeli_Müşteri_Sil";
            Tarifeli_Müşteri_Sil.Size = new Size(94, 28);
            Tarifeli_Müşteri_Sil.TabIndex = 2;
            Tarifeli_Müşteri_Sil.Text = "Sil";
            Tarifeli_Müşteri_Sil.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(746, 215);
            button2.Name = "button2";
            button2.Size = new Size(94, 28);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Tarifeli_Müşteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 450);
            Controls.Add(button2);
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
        private Button button2;
    }
}