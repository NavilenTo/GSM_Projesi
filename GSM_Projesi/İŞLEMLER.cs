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

        private void İşlemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //private void İşlemler_Resize(object sender, EventArgs e)
        //{
        //    MÜŞTERİ_iŞLEMLERİ.Location = new Point(this.Width - (this.Width - MÜŞTERİ_iŞLEMLERİ.Location.X), this.Height - (this.Height - MÜŞTERİ_iŞLEMLERİ.Location.Y));
        //    TAHSİLAT_İŞLEMLERİ.Location = new Point(this.Width - (TAHSİLAT_İŞLEMLERİ.Width + TAHSİLAT_İŞLEMLERİ.Location.X), this.Height - (TAHSİLAT_İŞLEMLERİ.Height + TAHSİLAT_İŞLEMLERİ.Location.Y));
        //    TARİFE_İŞLEMLERİ.Location = new Point(this.Width - (TARİFE_İŞLEMLERİ.Width + TARİFE_İŞLEMLERİ.Location.X), this.Height - (TARİFE_İŞLEMLERİ.Height + TARİFE_İŞLEMLERİ.Location.Y));
        //    FATURA_İŞLEMLERİ.Location = new Point(this.Width - (FATURA_İŞLEMLERİ.Width + FATURA_İŞLEMLERİ.Location.X), this.Height - (FATURA_İŞLEMLERİ.Height + FATURA_İŞLEMLERİ.Location.Y));
        //}
    }
}

