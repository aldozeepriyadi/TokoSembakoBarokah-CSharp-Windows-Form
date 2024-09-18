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
    public partial class FormMerk : Form
    {
        public FormMerk()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MasterMerk mm = new MasterMerk();
            mm.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusMerk hapus = new UbahHapusMerk();
            hapus.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatMerk lihat = new LihatMerk();
            lihat.Show();
        }

        private void FormMerk_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
