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
            baglantı.Close();
            baglantı.Open();

            string tarifeID = "0";
            string musteriID = "0";

            string kmt = "select TarifeID from TARİFELER where TarifeAdı=''" + Tarife_Müşteri.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(kmt, baglantı);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                tarifeID = dr[0].ToString();
            }
            
            kmt = "select MusteriID from MÜŞTERİLER where TC=" + textBox3.Text;
            sqlCommand = new SqlCommand(kmt, baglantı);
            dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                musteriID = dr[0].ToString();
            }
            
            baglantı.Close();

            try
            {
                if (baglantı.State == ConnectionState.Closed)
                    baglantı.Open();
                string kayıt = "INSERT INTO MÜŞTERİ_TARİFELERİ(Ad,Soyad,TarifeBaşlangıç,TarifeBitiş,TarifeID, TC, GSMno, MüşteriID) values(@Ad,@Soyad,@TarifeBaslangic,@TarifeBitis,@TarifeID, @TC, @GSMno, @MusteriID)";
                SqlCommand cmd = new SqlCommand(kayıt, baglantı);


                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox5.Text == "" && textBox6.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakmayınız");
                }

                cmd.Parameters.AddWithValue("@Ad", textBox1.Text);
                cmd.Parameters.AddWithValue("@Soyad", textBox2.Text);
                cmd.Parameters.AddWithValue("@TarifeBaslangic", DateTime.Now.Date.ToString());
                cmd.Parameters.AddWithValue("@TarifeBitis", DateTime.Now.AddYears(1).ToString());
                cmd.Parameters.AddWithValue("@TarifeID", tarifeID);

                cmd.Parameters.AddWithValue("@TC", textBox3.Text);
                cmd.Parameters.AddWithValue("@GSMno", textBox5.Text);
                cmd.Parameters.AddWithValue("@MusteriID", musteriID);


                cmd.ExecuteNonQuery();

                baglantı.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu" + hata.Message);
            }




            //SqlCommand komut = new SqlCommand("SELECT MÜŞTERİLER.MuşteriID, MÜŞTERİLER.Ad, MÜŞTERİLER.Soyad, MÜŞTERİLER.TC, MÜŞTERİLER.GSMno TARİFELER.TarifeAdı FROM MÜŞTERİ_TARİFELER INNER JOIN MÜŞTERİLER ON TARİFELER.TarifeID = MÜŞTERİLER.MusteriID WHERE MÜŞTERİLER.MusteriID);
            SqlCommand komut = new SqlCommand("INSERT INTO SELECT MÜŞTERİ_TABLOSU.MüşteriID, FROM MÜŞTERİLER JOİN islem on MÜŞTERİLER.MüşteriID= islem.MüşteriID JOİN TARİFELER ON TARİFELER.TarifeID = islem.TarifeID");
            baglantı.Open();
            Tarife_Müşteri_SelectedIndexChanged(sender, e);
            komut.ExecuteNonQuery();
            baglantı.Close();

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
