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
    public partial class FATURA_OLUŞTUR : Form
    {
        public FATURA_OLUŞTUR()
        {
            InitializeComponent();
        }

        private void FATURA_OLUŞTUR_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FATURA_İŞLEMLERİ ac = new FATURA_İŞLEMLERİ();
            ac.Show();
        }
    }
}
