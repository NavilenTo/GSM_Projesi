using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;

namespace GSM_Projesi
{
    public partial class Giriþ_Ekraný : Form
    {
        public Giriþ_Ekraný()
        {
            InitializeComponent();
        }

        public SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=Tbl_GSM;Integrated Security=True");


        private void GÝRÝÞ_YAP_Click(object sender, EventArgs e)
        {
            string Kullanici;

            string sifre;

            Kullanici = KULLANICI_ADI_TEXT.Text;

            sifre = ÞÝFRE_TEXT.Text;

            if (Kullanici == "abc" && sifre == "123")
            {

                this.Hide();
                Ýþlemler frm = new Ýþlemler();
                frm.Show();

            }
            else
            {
                GÝRÝÞ_HATA_MESAJI.Show();
            }
        }


        private void Giriþ_Ekraný_Load(object sender, EventArgs e)
        {
            GÝRÝÞ_HATA_MESAJI.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ýþlemler frm = new Ýþlemler();
            frm.Show();
        }

        private void ÞÝFRE_TEXT_TextChanged(object sender, EventArgs e)
        {
            ÞÝFRE_TEXT.PasswordChar = '*';
        }
    }
}