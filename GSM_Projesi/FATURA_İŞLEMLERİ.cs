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
    public partial class FATURA_İŞLEMLERİ : Form
    {
        public FATURA_İŞLEMLERİ()
        {
            InitializeComponent();
        }

        private void FATURA_İŞLEMLERİ_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            İşlemler ac = new İşlemler();
            ac.Show();
        }

        private void FATURA_OLUŞTUR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FATURA_OLUŞTUR ac = new FATURA_OLUŞTUR();
            ac.Show();
        }

        private void FATURALAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FATURALAR ac = new FATURALAR();
            ac.Show();
        }
    }
}
