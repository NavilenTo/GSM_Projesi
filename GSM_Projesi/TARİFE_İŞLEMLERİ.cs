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
    public partial class TARİFE_İŞLEMLERİ : Form
    {
        public TARİFE_İŞLEMLERİ()
        {
            InitializeComponent();
        }

        private void TARİFE_İŞLEMLERİ_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            İşlemler ac = new İşlemler();
            ac.Show();
        }

        private void YENİ_TARİFE_Click(object sender, EventArgs e)
        {
            this.Hide();
            YENİ_TARİFE_KAYIT ac = new YENİ_TARİFE_KAYIT();
            ac.Show();
        }

        private void TARİFELER_BUTONU_Click(object sender, EventArgs e)
        {
            this.Hide();
            TARİFELER ac = new TARİFELER();
            ac.Show();
        }
    }
}
