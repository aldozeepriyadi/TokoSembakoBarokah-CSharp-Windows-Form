﻿using System;
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
    public partial class LaporanTransaksiPenjualan : Form
    {
        public LaporanTransaksiPenjualan()
        {
            InitializeComponent();
        }

        private void LaporanTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnLihatLaporan_Click(object sender, EventArgs e)
        {

        }
    }
}
