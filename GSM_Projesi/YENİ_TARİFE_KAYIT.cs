using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSM_Projesi
{
    public partial class YENİ_TARİFE_KAYIT : Form
    {
        public YENİ_TARİFE_KAYIT()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();

        private void YENİ_TARİFE_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TARİFE_İŞLEMLERİ ac = new TARİFE_İŞLEMLERİ();
            ac.Show();
        }

        private void YENİ_TARİFE_KAYDET_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglantı.State == ConnectionState.Closed)
                    baglantı.Open();
                string kayıt = "INSERT INTO TARİFELER(TarifeAdı,TarifeÜcreti,Tarifeİçeriği) values(@TarifeAdı,@TarifeÜcreti,@Tarifeİçeriği)";
                SqlCommand komut = new SqlCommand(kayıt, baglantı);
                if (YENİ_TARİFE_AD.Text == "" && YENİ_TARİFE_ÜCRET.Text == "" && YENİ_TARİFE_İÇERİĞİ.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakmayınız");
                }

                komut.Parameters.AddWithValue("@TarifeAdı", YENİ_TARİFE_AD.Text);
                komut.Parameters.AddWithValue("@TarifeÜcreti", YENİ_TARİFE_ÜCRET.Text);
                komut.Parameters.AddWithValue("@Tarifeİçeriği", YENİ_TARİFE_İÇERİĞİ.Text);

                komut.ExecuteNonQuery();


                baglantı.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti");

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu" + hata.Message);
            }


        }
    }
}
