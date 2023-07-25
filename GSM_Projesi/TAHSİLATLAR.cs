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

namespace GSM_Projesi
{
    public partial class TAHSİLATLAR : Form
    {
        public TAHSİLATLAR()
        {
            InitializeComponent();
            GetList();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-1PBBFPF;Initial Catalog=Tbl_GSM;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();

        private void TAHSİLAT_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAHSİLAT_iŞLEMLERİ ac = new TAHSİLAT_iŞLEMLERİ();
            ac.Show();
        }
        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("SELECT * FROM TAHSİLAT", baglantı);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;
        }
    }
}
