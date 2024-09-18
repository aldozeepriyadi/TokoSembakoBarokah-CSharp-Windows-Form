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
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
        }



        private void btnTambah_Click(object sender, EventArgs e)
        {
            MasterBarang Mb = new MasterBarang();
            Mb.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusBarang hapus = new UbahHapusBarang();
            hapus.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatBarang lihat = new LihatBarang();
            lihat.Show();
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            MasterBarang mb = new MasterBarang();
            mb.Show();
        }

        private void btnUbahHapus_Click_1(object sender, EventArgs e)
        {
            UbahHapusBarang ubahHapus = new UbahHapusBarang();
            ubahHapus.Show();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            LihatBarang lb = new LihatBarang();
            lb.Show();
    
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
