using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSembako
{
    public partial class DSPegawai : Form
    {
        public DSPegawai(string v, string v1)
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.ShowDialog();
            this.Close();
        }

        private void DSPegawai_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnpenukaranhadiah_Click(object sender, EventArgs e)
        {
            TransaksiPenukaranHadiah tph = new TransaksiPenukaranHadiah();
            tph.Show();
        }

        private void btnpenjualan_Click(object sender, EventArgs e)
        {
            TransaksiPenjualan tp = new TransaksiPenjualan();
            tp.Show();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            TransaksiSupplier Ts = new TransaksiSupplier();
            Ts.Show();
        }
    }
}
