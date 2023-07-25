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
    public partial class TARİFE_ATAMA : Form
    {
        public TARİFE_ATAMA()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlDataAdapter adtr2;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();
        DataTable tbl2 = new DataTable();
        SqlCommand komut = new SqlCommand();
        DataSet ds = new DataSet();



        private void TARİFE_ATAMA_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            MÜŞTERİ_İŞLEMLERİ ac = new MÜŞTERİ_İŞLEMLERİ();
            ac.Show();
        }

        private void TARİFE_ATAMA_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TARİFELER", baglantı);
            Guncelle();
            

            baglantı.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {

                Tarife_Müşteri.Items.Add(dr["TarifeAdı"]);

            }

            Tarife_Müşteri.Sorted = true;

            baglantı.Close();

            GetList();

        }

        private void TARİFE_ATA_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM tarifeler where tarifeadı='" + textBox6.Text + "'", baglantı);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                textBox10.Text = read["TarifeID"].ToString();

            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM müşteriler where ad='" + textBox1.Text + "'", baglantı);
            SqlDataReader read2 = komut3.ExecuteReader();
            while (read2.Read())
            {
                textBox11.Text = read2["MusteriID"].ToString();

            }
            baglantı.Close();
            baglantı.Open();

            SqlCommand komut = new SqlCommand("insert into müşteritarifeleri(Ad,Soyad,TarifeBaşlangıç,TarifeBitiş,TarifeID,TC,GSMno,MüşteriID)values (@Ad,@Soyad,@TarifeBaşlangıç,@TarifeBitiş,@TarifeID,@TC,@GSMno,@MüşteriID)", baglantı);
            komut.Connection = baglantı;
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@TarifeBaşlangıç", DateTime.Now);
            komut.Parameters.AddWithValue("@TarifeBitiş", DateTime.Now.AddYears(1));
            komut.Parameters.AddWithValue("TarifeID", Convert.ToInt32(textBox10.Text));
            komut.Parameters.AddWithValue("@TC", textBox3.Text);
            komut.Parameters.AddWithValue("@GSMno", textBox5.Text);
            komut.Parameters.AddWithValue("@MüşteriID", Convert.ToInt32(textBox11.Text));
            komut.ExecuteNonQuery();
            baglantı.Close();

            MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();






        }
        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("SELECT * FROM MÜŞTERİLER", baglantı);
            adtr.Fill(tbl);
            TARİFE_ATAMA_MÜŞTERİ.DataSource = tbl;
            return tbl;
        }





        private void Tarife_Müşteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seçilentarife = Tarife_Müşteri.ToString();
            textBox6.Text = (string)Tarife_Müşteri.SelectedItem;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tbl.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + textBox4.Text + "%'";
            TARİFE_ATAMA_MÜŞTERİ.DataSource = dv;
            //verileri tabloya aldık
        }

        private void Guncelle()
        {
            adtr = new SqlDataAdapter("Select * from MÜŞTERİLER", baglantı);
            ds = new DataSet();
            baglantı.Open();
            adtr.Fill(ds, "MÜŞTERİLER");
            baglantı.Close();
            TARİFE_ATAMA_MÜŞTERİ.DataSource = ds.Tables["MÜŞTERİLER"];
        }

        int seçilensatır;




        private void TARİFE_ATAMA_MÜŞTERİ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            textBox1.Text = TARİFE_ATAMA_MÜŞTERİ.CurrentRow.Cells["Ad"].Value.ToString();
            textBox2.Text = TARİFE_ATAMA_MÜŞTERİ.CurrentRow.Cells["Soyad"].Value.ToString();
            textBox3.Text = TARİFE_ATAMA_MÜŞTERİ.CurrentRow.Cells["TC"].Value.ToString();
            textBox5.Text = TARİFE_ATAMA_MÜŞTERİ.CurrentRow.Cells["GSMno"].Value.ToString();

        }


        //void Listele2()
        //{
        //adtr2 = new SqlDataAdapter("SELECT * FROM MÜŞTERİ_TARİFELERİ", baglantı);
        //ds = new DataSet();
        //baglantı.Open();
        //adtr2.Fill(ds, "MÜŞTERİ_TARİFELERİ");
        //TARİFE_ATAMA_GRİDVİEW.DataSource = ds.Tables["MÜŞTERİ_TARİFELERİ"];
        //baglantı.Close();

        //tbl2.Clear(); 
        //adtr2 = new SqlDataAdapter("SELECT * From MÜŞTERİ_TARİFELERİ", baglantı);
        //adtr2.Fill(tbl);
        //TARİFE_ATAMA_GRİDVİEW.DataSource = tbl2;
        //return tbl2;

        //}


    }
}
