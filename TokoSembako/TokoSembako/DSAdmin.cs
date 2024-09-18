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
    public partial class DSAdmin : Form
    {
        public DSAdmin(string v)
        {
            InitializeComponent();
        }

      

        private void btnMember_Click(object sender, EventArgs e)
        {
            FormMember fmr = new FormMember();
            fmr.Show();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            FormBarang mb = new FormBarang();
            mb.Show();
        }

        private void btnSatuan_Click(object sender, EventArgs e)
        {
            FormSatuan fs = new FormSatuan();
            fs.Show();
        }

        private void btnMerk_Click(object sender, EventArgs e)
        {
            FormMerk fmk = new FormMerk();
            fmk.Show();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            FormPromo mpm = new FormPromo();
            mpm.Show();
        }

        private void btnHadiah_Click(object sender, EventArgs e)
        {
            FormHadiah fh = new FormHadiah();
            fh.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier ms = new FormSupplier();
            ms.Show();
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            FormPengguna fp = new FormPengguna();
            fp.Show();
        }

        private void btnJabatan_Click(object sender, EventArgs e)
        {
            FormJabatan fj = new FormJabatan();
            fj.Show();
        }

        private void btnPenggunaJabatan_Click(object sender, EventArgs e)
        {
            MasterPenggunaJabatan mpj = new MasterPenggunaJabatan();
            mpj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DSAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.ShowDialog();
            this.Close();
        }
        public void formlogin()
        {
            FormLogin FL = new FormLogin();
            FL.Show();
        }
    }
}
