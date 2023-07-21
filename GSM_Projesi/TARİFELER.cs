using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GSM_Projesi
{
    public partial class TARİFELER : Form
    {
        public TARİFELER()
        {
            InitializeComponent();
            GetList();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();

        private void TARİFELER_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TARİFE_İŞLEMLERİ ac = new TARİFE_İŞLEMLERİ();
            ac.Show();
        }
        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("SELECT * FROM TARİFELER", baglantı);
            adtr.Fill(tbl);
            Tarifeler_DataGridView.DataSource = tbl;
            return tbl;
        }



        private void Tarife_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Tarifeler_DataGridView.SelectedRows.Count; i++)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM TARİFELER WHERE TarifeID='" + Tarifeler_DataGridView.SelectedRows[i].Cells["TarifeID"].Value.ToString() + "'", baglantı);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                }
                MessageBox.Show("Kayıt Silindi");
                Tarifeler_DataGridView.DataSource = yenile();
            }
            catch (Exception)
            {

                MessageBox.Show("Silinme İşlemi Yapılamadı");
            }
            DataTable yenile()
            {
                baglantı.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TARİFELER", baglantı);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                baglantı.Close();
                return tablo;

            }
        }

        private void Tarife_Güncelle_Click(object sender, EventArgs e)
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

        private void Tarifeler_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Tarifeler_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TARİFE_ARAMA_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tbl.DefaultView;
            dv.RowFilter = "Convert(TarifeAdı, 'System.String') like '" + TARİFE_ARAMA.Text + "%'";
            Tarifeler_DataGridView.DataSource = dv;
        }
    }
}
