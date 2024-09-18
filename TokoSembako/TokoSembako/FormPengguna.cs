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
    public partial class FormPengguna : Form
    {
        public FormPengguna()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MasterPengguna mp = new MasterPengguna();
            mp.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusPengguna hapus = new UbahHapusPengguna();
            hapus.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatPengguna lihat = new LihatPengguna();
            lihat.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPengguna_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
