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
    public partial class TAHSİLAT_ALMA : Form
    {
        public TAHSİLAT_ALMA()
        {
            InitializeComponent();
            GetList();
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
            adtr = new SqlDataAdapter("SELECT * From faturalar", baglantı);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;

        }

        private void TAHSİLAT_ALMA_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAHSİLAT_iŞLEMLERİ ac = new TAHSİLAT_iŞLEMLERİ();
            ac.Show();
        }

        private void TAHSİLAT_ALMA_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            label2.Text = dataGridView1.CurrentRow.Cells["FaturaID"].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells["TarifeID"].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells["Ücret"].Value.ToString();
            label5.Text = dataGridView1.CurrentRow.Cells["Dönem"].Value.ToString();

        }

        private void Tahsilat_Alma_Button_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komut = new SqlCommand("insert into tahsilat(FaturaID,TarifeID,TarifeÜcreti,Dönem,TahsilTarihi)values (@FaturaID,@TarifeID,@TarifeÜcreti,@Dönem,@TahsilTarihi)", baglantı);
            komut.Connection = baglantı;
            komut.Parameters.AddWithValue("@FaturaID", Convert.ToInt32(label2.Text));
            komut.Parameters.AddWithValue("@TarifeID", Convert.ToInt32(label3.Text));
            komut.Parameters.AddWithValue("@TarifeÜcreti", label4.Text);
            komut.Parameters.AddWithValue("@Dönem", label5.Text);
            komut.Parameters.AddWithValue("@TahsilTarihi", DateTime.Now);

            komut.ExecuteNonQuery();
            baglantı.Close();

            MessageBox.Show("Ödeme İşlemi Gerçekleşti");
        }
    }
}
