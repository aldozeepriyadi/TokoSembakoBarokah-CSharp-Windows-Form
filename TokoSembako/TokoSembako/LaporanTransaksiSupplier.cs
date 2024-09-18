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
    public partial class LaporanTransaksiSupplier : Form
    {
        public LaporanTransaksiSupplier()
        {
            InitializeComponent();
        }

        private void LaporanTransaksiSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'LaporanTransSupplier.TransaksiSupp' table. You can move, or remove it, as needed.
            // this.TransaksiSuppTableAdapter.Fill(this.LaporanTransSupplier.TransaksiSupp,dateTimePicker1);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TransaksiSuppTableAdapter.Fill(this.LaporanTransSupplier.TransaksiSupp, dateTimePicker1.Text, dateTimePicker2.Text);
            this.reportViewer1.RefreshReport();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
