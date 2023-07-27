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
    public partial class FATURALAR : Form
    {
        public FATURALAR()
        {
            DataTable yenile()
            {
                baglantı.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select m.Ad, m.Soyad, m.TC,t.TarifeAdı,f.Ücret,f.Dönem, f.Ödeme_Durumu,f.FaturaID From FATURALAR as f Left join MÜŞTERİLER as m ON f.MüşteriID = m.MusteriID Left join TARİFELER AS t ON f.TarifeID =t.TarifeID ", baglantı);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                baglantı.Close();
                return tablo;
            }
            InitializeComponent();
            GetList();
            dataGridView1.DataSource = yenile();
            this.dataGridView1.Columns["FaturaID"].Visible = false;
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();

        private void FATURALAR_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FATURA_İŞLEMLERİ ac = new FATURA_İŞLEMLERİ();
            ac.Show();
        }
        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("SELECT * FROM FATURALAR", baglantı);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;
        }
        DataTable yenile2()
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FATURALAR", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglantı.Close();
            return tablo;


        }

        private void Faturlar_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM FATURALAR WHERE FaturaID='" + dataGridView1.SelectedRows[i].Cells["FaturaID"].Value.ToString() + "'", baglantı);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                }
                MessageBox.Show("Kayıt Silindi");
                dataGridView1.DataSource = yenile();

                DataTable yenile()
                {
                    baglantı.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select m.Ad, m.Soyad, m.TC,t.TarifeAdı,f.Ücret,f.Dönem, f.Ödeme_Durumu,f.FaturaID From FATURALAR as f Left join MÜŞTERİLER as m ON f.MüşteriID = m.MusteriID Left join TARİFELER AS t ON f.TarifeID =t.TarifeID ", baglantı);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    baglantı.Close();
                    return tablo;
                }
                dataGridView1.DataSource = yenile2();
                this.dataGridView1.Columns["FaturaID"].Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Silinme İşlemi Yapılamadı");
            }
        }

    }
}


