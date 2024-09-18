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
    public partial class LaporanPenukaranHadiah : Form
    {
        public LaporanPenukaranHadiah()
        {
            InitializeComponent();
        }

        private void LaporanPenukaranHadiah_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TokoSembakoDataSet35.PenukaranHadiah' table. You can move, or remove it, as needed.
            this.PenukaranHadiahTableAdapter.Fill(this.TokoSembakoDataSet35.PenukaranHadiah);
            // TODO: This line of code loads data into the 'tokoSembakoDataSet34.PenukaranHadiah' table. You can move, or remove it, as needed.
            // this.penukaranHadiahTableAdapter.Fill(this.tokoSembakoDataSet34.PenukaranHadiah);
            // TODO: This line of code loads data into the 'TokoSembako_PRG2DataSet7.PenukaranHadiah' table. You can move, or remove it, as needed.
            // this.PenukaranHadiahTableAdapter.Fill(this.TokoSembako_PRG2DataSet7.PenukaranHadiah);
            // TODO: This line of code loads data into the 'TokoSembako_PRG2DataSet6.DetailPenukaranHadiah' table. You can move, or remove it, as needed.

            this.WindowState = FormWindowState.Maximized;
            this.reportViewer1.RefreshReport();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PenukaranHadiahTableAdapter.FillBy(this.TokoSembakoDataSet35.PenukaranHadiah, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void penukaranHadiahBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }
    }
}
