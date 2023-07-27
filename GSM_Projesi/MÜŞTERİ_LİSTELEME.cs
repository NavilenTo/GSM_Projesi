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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GSM_Projesi
{
    public partial class MÜŞTERİ_LİSTELEME : Form
    {
        public MÜŞTERİ_LİSTELEME()
        {
            DataTable yenile()
            {
                baglantı.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From MÜŞTERİLER", baglantı);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                baglantı.Close();
                return tablo;
            }
            InitializeComponent();
            GetList();
            dataGridView1.DataSource = yenile();
            this.dataGridView1.Columns["MusteriID"].Visible = false;
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();


        private void MÜŞTERİ_LİSTELE_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();

            MÜŞTERİ_İŞLEMLERİ ac = new MÜŞTERİ_İŞLEMLERİ();
            ac.Show();
        }

        //private void MÜŞTERİ_GÖRÜNTÜLE_Click(object sender, EventArgs e)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("Select * From MÜŞTERİLER", baglantı);
        //    DataSet yeniset = new DataSet();
        //    baglantı.Open();
        //    da.Fill(yeniset, "MÜŞTERİLER");
        //    dataGridView1.DataSource = yeniset.Tables[0];
        //    baglantı.Close();

        //}
        DataTable yenile()
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From MÜŞTERİLER", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglantı.Close();
            return tablo;


        }
        private void MÜŞTERİ_SİL_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM MÜŞTERİLER WHERE MusteriID='" + dataGridView1.SelectedRows[i].Cells["MusteriID"].Value.ToString() + "'", baglantı);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                }
                MessageBox.Show("Kayıt Silindi");
                dataGridView1.DataSource = yenile();
            }
            catch (Exception)
            {

                MessageBox.Show("Silinme İşlemi Yapılamadı");
            }
        }
        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("SELECT * FROM MÜŞTERİLER", baglantı);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;
        }
        private void MÜŞTERİ_GÜNCELLE_Click(object sender, EventArgs e)
        {
            try
            {
                commandBuilder = new SqlCommandBuilder(adtr);
                adtr.Update(tbl);
                GetList();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Güncellemede Hata Oluştu");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tbl.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}

