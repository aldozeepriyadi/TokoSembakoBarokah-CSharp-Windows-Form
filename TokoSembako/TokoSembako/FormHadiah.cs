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
    public partial class FormHadiah : Form
    {
        public FormHadiah()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MasterHadiah Mh = new MasterHadiah();
            Mh.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusHadiah hapus = new UbahHapusHadiah();
            hapus.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatHadiah lihat = new LihatHadiah();
            lihat.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHadiah_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
