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
    public partial class MÜŞTERİ_İŞLEMLERİ : Form
    {
        public MÜŞTERİ_İŞLEMLERİ()
        {
            InitializeComponent();
        }

        private void MÜŞTERİ_İŞLEMLERİ_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            İşlemler ac = new İşlemler();
            ac.Show();
        }

        private void MÜŞTERİ_KAYIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            YENİ_MÜŞTERİ_KAYIT ac = new YENİ_MÜŞTERİ_KAYIT();
            ac.Show();
        }

        private void TARİFE_ATAMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            TARİFE_ATAMA ac = new TARİFE_ATAMA();
            ac.Show();
        }

        private void MÜŞTERİ_LİSTESİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            MÜŞTERİ_LİSTELEME ac = new MÜŞTERİ_LİSTELEME();
            ac.Show();
        }

        private void Tarifeli_Müşteriler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarifeli_Müşteriler ac = new Tarifeli_Müşteriler();
            ac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YENİ_TARİFE_ATAMA ac = new YENİ_TARİFE_ATAMA();
            ac.Show();
        }
    }
}
