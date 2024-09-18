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
    public partial class FormPromo : Form
    {
        public FormPromo()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MasterPromo mp = new MasterPromo();
            mp.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatPromo lihat = new LihatPromo();
            lihat.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusPromo hapus = new UbahHapusPromo();
            hapus.Show();
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            MasterPromo mp = new MasterPromo();
            mp.Show();
        }

        private void btnUbahHapus_Click_1(object sender, EventArgs e)
        {
            UbahHapusPromo ubahHapus = new UbahHapusPromo();
            ubahHapus.Show();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            LihatPromo lp = new LihatPromo();
            lp.Show();
        }

        private void FormPromo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
