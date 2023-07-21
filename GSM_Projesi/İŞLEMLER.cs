using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSM_Projesi
{
    public partial class İşlemler : Form
    {
        public İşlemler()
        {
            InitializeComponent();
        }

        private void MÜŞTERİ_iŞLEMLERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            MÜŞTERİ_İŞLEMLERİ ac = new MÜŞTERİ_İŞLEMLERİ();
            ac.Show();
        }

        private void TARİFE_İŞLEMLERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TARİFE_İŞLEMLERİ ac = new TARİFE_İŞLEMLERİ();
            ac.Show();
        }

        private void FATURA_İŞLEMLERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FATURA_İŞLEMLERİ ac = new FATURA_İŞLEMLERİ();
            ac.Show();
        }

        private void TAHSİLAT_İŞLEMLERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAHSİLAT_iŞLEMLERİ ac = new TAHSİLAT_iŞLEMLERİ();
            ac.Show();
        }
    }
}

