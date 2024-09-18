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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MasterSupplier ms = new MasterSupplier();
            ms.Show();
        }

        private void btnUbahHapus_Click(object sender, EventArgs e)
        {
            UbahHapusSupplier ubahHapus = new UbahHapusSupplier();
            ubahHapus.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LihatSupplier ls = new LihatSupplier();
            ls.Show();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
