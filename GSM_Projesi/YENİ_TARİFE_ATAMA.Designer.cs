namespace GSM_Projesi
{
    partial class YENİ_TARİFE_ATAMA
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
            textBox1 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            Tarife_Müşteri = new ComboBox();
            YeniTarifeAtama = new Button();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            YENİ_TARİFE_GERİ = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(91, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(730, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(584, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 1;
            label1.Text = "Yeni Tarife Atama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(932, 261);
            label5.Name = "label5";
            label5.Size = new Size(69, 30);
            label5.TabIndex = 43;
            label5.Text = "Tarife";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1012, 268);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(170, 23);
            textBox6.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(929, 218);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 41;
            label4.Text = "Tel No";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1012, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 23);
            textBox5.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(948, 170);
            label3.Name = "label3";
            label3.Size = new Size(38, 30);
            label3.TabIndex = 39;
            label3.Text = "TC";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1012, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(932, 121);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 37;
            label2.Text = "Soyad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1012, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(948, 70);
            label6.Name = "label6";
            label6.Size = new Size(39, 30);
            label6.TabIndex = 35;
            label6.Text = "Ad";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1012, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 34;
            // 
            // Tarife_Müşteri
            // 
            Tarife_Müşteri.FormattingEnabled = true;
            Tarife_Müşteri.Location = new Point(1188, 268);
            Tarife_Müşteri.Name = "Tarife_Müşteri";
            Tarife_Müşteri.Size = new Size(121, 23);
            Tarife_Müşteri.TabIndex = 33;
            Tarife_Müşteri.SelectedIndexChanged += Tarife_Müşteri_SelectedIndexChanged;
            // 
            // YeniTarifeAtama
            // 
            YeniTarifeAtama.BackColor = Color.Snow;
            YeniTarifeAtama.FlatStyle = FlatStyle.Flat;
            YeniTarifeAtama.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            YeniTarifeAtama.Location = new Point(641, 380);
            YeniTarifeAtama.Name = "YeniTarifeAtama";
            YeniTarifeAtama.Size = new Size(189, 34);
            YeniTarifeAtama.TabIndex = 44;
            YeniTarifeAtama.Text = "Yeni Tarifeye geçiş";
            YeniTarifeAtama.UseVisualStyleBackColor = false;
            YeniTarifeAtama.Click += YeniTarifeAtama_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(1432, 399);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(45, 23);
            textBox11.TabIndex = 46;
            textBox11.Visible = false;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1432, 428);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(59, 23);
            textBox10.TabIndex = 45;
            textBox10.Visible = false;
            // 
            // YENİ_TARİFE_GERİ
            // 
            YENİ_TARİFE_GERİ.BackgroundImage = Properties.Resources.back;
            YENİ_TARİFE_GERİ.BackgroundImageLayout = ImageLayout.Zoom;
            YENİ_TARİFE_GERİ.FlatStyle = FlatStyle.Flat;
            YENİ_TARİFE_GERİ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            YENİ_TARİFE_GERİ.ForeColor = SystemColors.ControlText;
            YENİ_TARİFE_GERİ.Location = new Point(12, 12);
            YENİ_TARİFE_GERİ.Name = "YENİ_TARİFE_GERİ";
            YENİ_TARİFE_GERİ.Size = new Size(67, 29);
            YENİ_TARİFE_GERİ.TabIndex = 47;
            YENİ_TARİFE_GERİ.UseVisualStyleBackColor = true;
            YENİ_TARİFE_GERİ.Click += YENİ_TARİFE_GERİ_Click;
            // 
            // YENİ_TARİFE_ATAMA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MüsteriIslemleri_background__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = YENİ_TARİFE_GERİ;
            ClientSize = new Size(1415, 450);
            Controls.Add(YENİ_TARİFE_GERİ);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(YeniTarifeAtama);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(Tarife_Müşteri);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "YENİ_TARİFE_ATAMA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += YENİ_TARİFE_ATAMA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox6;
        private Label label4;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox4;
        private ComboBox Tarife_Müşteri;
        private Button YeniTarifeAtama;
        private TextBox textBox11;
        private TextBox textBox10;
        private Button YENİ_TARİFE_GERİ;
    }
}