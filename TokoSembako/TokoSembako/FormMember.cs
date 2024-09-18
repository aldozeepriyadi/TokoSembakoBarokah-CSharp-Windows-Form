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
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterMember Mb = new MasterMember();
            Mb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateHapusMember update = new UpdateHapusMember();
            update.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LihatMember lihat = new LihatMember();
            lihat.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
