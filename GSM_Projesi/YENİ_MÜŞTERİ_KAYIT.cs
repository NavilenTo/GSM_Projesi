 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GSM_Projesi
{
    public partial class YENİ_MÜŞTERİ_KAYIT : Form
    {
        public YENİ_MÜŞTERİ_KAYIT()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();


        private void YENİ_MÜŞTERİ_KAYIT_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            MÜŞTERİ_İŞLEMLERİ ac = new MÜŞTERİ_İŞLEMLERİ();
            ac.Show();
        }

        private void YENİ_MÜŞTERİ_KAYIT_KAYDET_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglantı.State == ConnectionState.Closed)
                    baglantı.Open();
                string kayıt = "INSERT INTO MÜŞTERİLER(Ad,Soyad,TC,GSMno,EMail) values(@Ad,@Soyad,@TC,@GSMno,@EMail)";
                SqlCommand komut = new SqlCommand(kayıt, baglantı);
                if (YENİ_KAYIT_AD.Text == "" && YENİ_KAYIT_SOYAD.Text == "" && YENİ_KAYIT_TC.Text == "" && YENİ_KAYIT_TELNO.Text == "" && YENİ_KAYIT_E_MAİL.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakmayınız");
                }

                komut.Parameters.AddWithValue("@Ad", YENİ_KAYIT_AD.Text);
                komut.Parameters.AddWithValue("@Soyad", YENİ_KAYIT_SOYAD.Text);
                komut.Parameters.AddWithValue("@TC", YENİ_KAYIT_TC.Text);
                komut.Parameters.AddWithValue("@GSMno", YENİ_KAYIT_TELNO.Text);
                komut.Parameters.AddWithValue("@EMail", YENİ_KAYIT_E_MAİL.Text);

                komut.ExecuteNonQuery();
               

                baglantı.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti");
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu" + hata.Message);
            }

        }

        private void YENİ_KAYIT_TC_TextChanged(object sender, EventArgs e)
        {
            YENİ_KAYIT_TC.MaxLength = 11;
        }

        private void YENİ_KAYIT_TELNO_TextChanged(object sender, EventArgs e)
        {
            YENİ_KAYIT_TELNO.MaxLength = 10;
        }

        private void YENİ_KAYIT_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void YENİ_KAYIT_TELNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

