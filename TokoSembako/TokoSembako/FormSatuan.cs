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
    public partial class FormSatuan : Form
    {
        public FormSatuan()
        {
            InitializeComponent();
        }

        

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            MasterSatuan ms = new MasterSatuan();
            ms.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusSatuan ubahHapus = new UbahHapusSatuan();
            ubahHapus.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatSatuan ls = new LihatSatuan();
            ls.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSatuan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
