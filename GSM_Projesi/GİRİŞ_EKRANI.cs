using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;

namespace GSM_Projesi
{
    public partial class Giri�_Ekran� : Form
    {
        public Giri�_Ekran�()
        {
            InitializeComponent();
        }

        public SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=Tbl_GSM;Integrated Security=True");


        private void G�R��_YAP_Click(object sender, EventArgs e)
        {
            string Kullanici;

            string sifre;

            Kullanici = KULLANICI_ADI_TEXT.Text;

            sifre = ��FRE_TEXT.Text;

            if (Kullanici == "abc" && sifre == "123")
            {

                this.Hide();
                ��lemler frm = new ��lemler();
                frm.Show();

            }
            else
            {
                G�R��_HATA_MESAJI.Show();
            }
        }


        private void Giri�_Ekran�_Load(object sender, EventArgs e)
        {
            G�R��_HATA_MESAJI.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ��lemler frm = new ��lemler();
            frm.Show();
        }

        private void ��FRE_TEXT_TextChanged(object sender, EventArgs e)
        {
            ��FRE_TEXT.PasswordChar = '*';
        }
    }
}