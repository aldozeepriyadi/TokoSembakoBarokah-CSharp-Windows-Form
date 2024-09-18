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
    public partial class DSPemilik : Form
    {
        public DSPemilik(string v)
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

        private void DSPemilik_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LaporanPenukaranHadiah lph = new LaporanPenukaranHadiah();
            lph.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LaporanTransaksiSupplier lts = new LaporanTransaksiSupplier();
            lts.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LaporanTransaksiPenjualan LTP = new LaporanTransaksiPenjualan();
            LTP.Show();
        }
    }
}
