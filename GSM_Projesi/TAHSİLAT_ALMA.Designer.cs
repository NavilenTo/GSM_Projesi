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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Tahsilat_Alma_Button
            // 
            Tahsilat_Alma_Button.BackColor = Color.White;
            Tahsilat_Alma_Button.FlatStyle = FlatStyle.Flat;
            Tahsilat_Alma_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Tahsilat_Alma_Button.Location = new Point(349, 397);
            Tahsilat_Alma_Button.Name = "Tahsilat_Alma_Button";
            Tahsilat_Alma_Button.Size = new Size(127, 32);
            Tahsilat_Alma_Button.TabIndex = 0;
            Tahsilat_Alma_Button.Text = "Tahsilat Al";
            Tahsilat_Alma_Button.UseVisualStyleBackColor = false;
            Tahsilat_Alma_Button.Click += Tahsilat_Alma_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 319);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
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
            TAHSİLAT_ALMA_GERİ.BackColor = Color.White;
            TAHSİLAT_ALMA_GERİ.BackgroundImage = Properties.Resources.back;
            TAHSİLAT_ALMA_GERİ.BackgroundImageLayout = ImageLayout.Zoom;
            TAHSİLAT_ALMA_GERİ.FlatStyle = FlatStyle.Flat;
            TAHSİLAT_ALMA_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TAHSİLAT_ALMA_GERİ.ForeColor = SystemColors.ControlText;
            TAHSİLAT_ALMA_GERİ.Location = new Point(12, 14);
            TAHSİLAT_ALMA_GERİ.Name = "TAHSİLAT_ALMA_GERİ";
            TAHSİLAT_ALMA_GERİ.Size = new Size(68, 29);
            TAHSİLAT_ALMA_GERİ.TabIndex = 14;
            TAHSİLAT_ALMA_GERİ.UseVisualStyleBackColor = false;
            TAHSİLAT_ALMA_GERİ.Click += TAHSİLAT_ALMA_GERİ_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(1045, 110);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 15;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(1045, 125);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 16;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(1045, 140);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 17;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(1045, 155);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 18;
            label5.Text = "label5";
            // 
            // TAHSİLAT_ALMA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MüsteriIslemleri_background__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = TAHSİLAT_ALMA_GERİ;
            ClientSize = new Size(1338, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TAHSİLAT_ALMA_GERİ);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Tahsilat_Alma_Button);
            Name = "TAHSİLAT_ALMA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TAHSİLAT_ALMA";
            Load += TAHSİLAT_ALMA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Tahsilat_Alma_Button;
        private DataGridView dataGridView1;
        private Label label1;
        private Button TAHSİLAT_ALMA_GERİ;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}