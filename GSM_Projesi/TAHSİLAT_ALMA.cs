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
    public partial class TAHSİLAT_ALMA : Form
    {
        public TAHSİLAT_ALMA()
        {
            InitializeComponent();
        }

        private void TAHSİLAT_ALMA_GERİ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAHSİLAT_iŞLEMLERİ ac = new TAHSİLAT_iŞLEMLERİ();
            ac.Show();
        }
    }
}
