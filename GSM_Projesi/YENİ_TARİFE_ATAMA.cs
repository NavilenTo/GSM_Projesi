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
    public partial class YENİ_TARİFE_ATAMA : Form
    {
        public YENİ_TARİFE_ATAMA()
        {
            InitializeComponent();
            GetList();
            //GetList2();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlDataAdapter adtr2;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();
        DataTable tbl2 = new DataTable();
        SqlCommand komut = new SqlCommand();
        DataSet ds = new DataSet();

        DataView filtrele()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "Convert(TC, 'System.String') like '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
            return dv;

        }

        DataTable GetList()
        {

            tbl.Clear();
            adtr = new SqlDataAdapter("SELECT * From MüşteriTarifeleri", baglantı);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;

        }
        //DataTable GetList2()
        //{

        //    tbl2.Clear();
        //    adtr2 = new SqlDataAdapter("SELECT * From MüşteriTarifeleri", baglantı);
        //    adtr2.Fill(tbl);
        //    dataGridView1.DataSource = tbl2;
        //    return tbl2;

        //}


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtrele();
        }

        private void YeniTarifeAtama_Click(object sender, EventArgs e)
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
            SqlCommand komut3 = new SqlCommand("SELECT * FROM müşteriler where ad='" + textBox4.Text + "'", baglantı);
            SqlDataReader read2 = komut3.ExecuteReader();
            while (read2.Read())
            {
                textBox11.Text = read2["MusteriID"].ToString();

            }
            baglantı.Close();
            baglantı.Open();

            SqlCommand komut = new SqlCommand("update müşteritarifeleri set Ad=@Ad,Soyad=@Soyad,TarifeBaşlangıç=@TarifeBaşlangıç,TarifeBitiş=@TarifeBitiş,TarifeID=@TarifeID,TC=@TC,GSMno=@GSMno WHERE MüşteriID=@MüşteriID", baglantı);
            komut.Connection = baglantı;
            komut.Parameters.AddWithValue("@Ad", textBox4.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@TarifeBaşlangıç", DateTime.Now);
            komut.Parameters.AddWithValue("@TarifeBitiş", DateTime.Now.AddYears(1));
            komut.Parameters.AddWithValue("TarifeID", Convert.ToInt32(textBox10.Text));
            komut.Parameters.AddWithValue("@TC", textBox3.Text);
            komut.Parameters.AddWithValue("@GSMno", textBox5.Text);
            komut.Parameters.AddWithValue("@MüşteriID", Convert.ToInt32(textBox11.Text));
            komut.ExecuteNonQuery();
            baglantı.Close();

            MessageBox.Show("Müşteri Güncelleme İşlemi Gerçekleşti");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();






        }

        private void YENİ_TARİFE_ATAMA_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Tarifeler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Tarife_Müşteri.Items.Add(dr["TarifeAdı"]);
            }
            baglanti.Close();
        }

        private void Tarife_Müşteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = Tarife_Müşteri.SelectedItem.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox4.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["GSMno"].Value.ToString();
        }
    }
}
