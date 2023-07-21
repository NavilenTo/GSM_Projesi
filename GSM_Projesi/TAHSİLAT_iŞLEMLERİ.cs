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
    public partial class TAHSİLAT_iŞLEMLERİ : Form
    {
        public TAHSİLAT_iŞLEMLERİ()
        {
            InitializeComponent();
        }

        private void TAHSİLAT_İŞLEMLERİ_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            İşlemler ac = new İşlemler();
            ac.Show();
        }

        private void Tahsilat_Alma_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAHSİLAT_ALMA ac = new TAHSİLAT_ALMA();
            ac.Show();
        }

        private void Tahsilatlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAHSİLATLAR ac = new TAHSİLATLAR();
            ac.Show();
        }
    }
}
