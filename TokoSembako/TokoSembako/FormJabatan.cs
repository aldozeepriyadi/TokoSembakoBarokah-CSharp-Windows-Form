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
    public partial class FormJabatan : Form
    {
        public FormJabatan()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MasterJabatan Mj = new MasterJabatan();
            Mj.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusJabatan hapus = new UbahHapusJabatan();
            hapus.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatJabatan lihat = new LihatJabatan();
            lihat.Show();
        }

        private void FormJabatan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
