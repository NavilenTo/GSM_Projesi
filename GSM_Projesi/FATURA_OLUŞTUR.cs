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
    public partial class FATURA_OLUŞTUR : Form
    {
        public FATURA_OLUŞTUR()
        {
            DataTable yenile()
            {
                baglantı.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From MüşteriTarifeleri Left JOIN TARİFELER on TARİFELER.TarifeID = MüşteriTarifeleri.TarifeID", baglantı);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                baglantı.Close();
                return tablo;
            }
            InitializeComponent();
            GetList();
            dataGridView1.DataSource = yenile();
            this.dataGridView1.Columns["TarifeID"].Visible = false;
            this.dataGridView1.Columns["MüşteriID"].Visible = false;
            this.dataGridView1.Columns["TarifeID1"].Visible = false;
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlDataAdapter adtr2;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();
        DataTable tbl2 = new DataTable();
        SqlCommand komut = new SqlCommand();
        DataSet ds = new DataSet();

        DataTable GetList()
        {

            tbl.Clear();
            adtr = new SqlDataAdapter("SELECT * From MüşteriTarifeleri", baglantı);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;

        }
        private void FATURA_OLUŞTUR_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FATURA_İŞLEMLERİ ac = new FATURA_İŞLEMLERİ();
            ac.Show();
        }

        private void Aylar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells["MüşteriID"].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells["TarifeID"].Value.ToString();
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM tarifeler where TarifeId='" + label3.Text + "'", baglantı);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                label4.Text = read["TarifeÜcreti"].ToString();

            }
            baglantı.Close();

            label2.Show();
            label3.Show();
            label4.Show();
        }

        private void FATURA_OLUŞTUR_Load(object sender, EventArgs e)
        {

            label2.Hide();
            label3.Hide();
            label4.Hide();


            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM MüşteriTarifeleri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            //SqlDataReader dr;
            //baglanti.Open();
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    Tarife_Müşteri.Items.Add(dr["TarifeAdı"]);
            //}
            //baglanti.Close();
        }

        private void FATURAA_OLUŞTUR_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komut = new SqlCommand("insert into faturalar(MüşteriID,TarifeID,Ücret,Dönem)values (@MüşteriID,@TarifeID,@Ücret,@Dönem)", baglantı);
            komut.Connection = baglantı;
            komut.Parameters.AddWithValue("@MüşteriID", label2.Text);
            komut.Parameters.AddWithValue("@TarifeID", label3.Text);
            komut.Parameters.AddWithValue("@Ücret", Convert.ToDouble(label4.Text));
            komut.Parameters.AddWithValue("@Dönem", Aylar.Text);

            komut.ExecuteNonQuery();
            baglantı.Close();

            MessageBox.Show("Fatura Oluşturma İşlemi Gerçekleşti");
        }
    }
}
