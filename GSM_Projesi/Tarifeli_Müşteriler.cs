using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GSM_Projesi
{
    public partial class Tarifeli_Müşteriler : Form
    {
        public Tarifeli_Müşteriler()
        {
            InitializeComponent();
            //GetList();
            //GetList2();
            dataGridView1.DataSource = yenile();
            this.dataGridView1.Columns["TarifeID"].Visible = false;
            this.dataGridView1.Columns["MüşteriID"].Visible = false;
            this.dataGridView1.Columns["TarifeID1"].Visible = false;
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();
        SqlCommand komut = new SqlCommand();
        DataSet ds = new DataSet();

        private void YENİ_TARİFE_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();

            MÜŞTERİ_İŞLEMLERİ ac = new MÜŞTERİ_İŞLEMLERİ();
            ac.Show();
        }

        //DataTable GetList()
        //{
        //    tbl.Clear();
        //    adtr = new SqlDataAdapter("SELECT * FROM MüşteriTarifeleri", baglantı);
        //    adtr.Fill(tbl);
        //    dataGridView1.DataSource = tbl;
        //    return tbl;
        //}

        //DataTable GetList2()
        //{
        //    tbl.Clear();
        //    adtr = new SqlDataAdapter("SELECT * FROM MüşteriTarifeleri", baglantı);
        //    adtr.Fill(tbl);
        //    dataGridView1.DataSource = tbl;
        //    return tbl;
        //}

        DataTable yenile()
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From MüşteriTarifeleri Left JOIN TARİFELER on TARİFELER.TarifeID = MüşteriTarifeleri.TarifeID", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglantı.Close();
            return tablo;
        }

        private void Tarifeli_Müşteri_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM MüşteriTarifeleri WHERE Ad='" + dataGridView1.SelectedRows[i].Cells["Ad"].Value.ToString() + "'", baglantı);
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
    }
}
