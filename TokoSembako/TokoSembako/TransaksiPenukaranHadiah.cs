using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TokoSembako
{
    public partial class TransaksiPenukaranHadiah : Form
    {
        String ID;
        String ID2;
        public TransaksiPenukaranHadiah()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            DateTime now;
            now = DateTime.Now;
            tgl.Text = now.ToShortDateString();
            string q = "SELECT TOP 1 trs_idPH FROM PenukaranHadiah ORDER BY trs_idPH DESC";
            ID = idotomatis1("PNH", q);         
            txtidpenukaran.Text = ID;
            
        }   

        public string idotomatis1(string firstID, string query)
        {
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlCommand MyCommand;
            SqlConnection MyConnection;
            string result = "";
            int num = 0;


            try
            {
                MyConnection = new SqlConnection(connectionString);
                MyConnection.Open();
                MyCommand = new SqlCommand(query, MyConnection);

                SqlDataReader reader = MyCommand.ExecuteReader();

                if (reader.Read())
                {
                    string lastID = reader[0].ToString();
                    num = Convert.ToInt32(lastID.Remove(0, firstID.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstID + num.ToString().PadLeft(2, '0');
            return result;

           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransaksiPenukaranHadiah_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Member WHERE id_member ='" + txtidmember.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtnama.Text = dt.Rows[0]["nama"].ToString();
                txtpoin.Text = dt.Rows[0]["poin"].ToString();

                txtidmember.Enabled = true;
                txtnama.Enabled = true;
                txtpoin.Enabled = true;

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");
            }
        }

        private void clear()
        {
            txtidhadiah.Text = "";
            txthadiah.Text = "";
            txtpoinhadiah.Text = "";
            txtjumlah.Text = "";
        }

        private void btncari2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HadiahMember WHERE id_hadiah ='" + txtidhadiah.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txthadiah.Text = dt.Rows[0]["hadiah"].ToString();
                txtpoinhadiah.Text = dt.Rows[0]["poin"].ToString();


                txtidhadiah.Enabled = true;
                txthadiah.Enabled = true;
                txtpoinhadiah.Enabled = true;

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");

            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtidmember.Text == "" || txtnama.Text == "" || txtpoin.Text == "" || txtidhadiah.Text == "" || txthadiah.Text == "" || txtpoinhadiah.Text == "" || txtjumlah.Text == "")
            {
                MessageBox.Show
                   ("Isi Data Dahulu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int poinhadiah = Convert.ToInt32(txtpoinhadiah.Text);
            int jumlah = Convert.ToInt32(txtjumlah.Text);

            int total = poinhadiah * jumlah;

            int row = 0;
            keranjang.Rows.Add();
            row = keranjang.Rows.Count - 2;
            keranjang["id_hadiah", row].Value = txtidhadiah.Text;
            keranjang["hadiah", row].Value = txthadiah.Text;
            keranjang["jumlah", row].Value = txtjumlah.Text;
            keranjang["TotalPoin", row].Value = total.ToString();

            keranjang.Refresh();

            int sum = 0;
            for (int i = 0; i < keranjang.Rows.Count; i++)
            {
                sum += Convert.ToInt32(keranjang.Rows[i].Cells[3].Value);
            }

            int rupiah = int.Parse(sum.ToString());
            txttotalpoin.Text = rupiah.ToString();

            int sisa = (Convert.ToInt32(txtpoin.Text) - Convert.ToInt32(txttotalpoin.Text));

            txtsisapoin.Text = sisa.ToString();
            clear();
        }

        private void btnSimpanTransaksi_Click(object sender, EventArgs e)
        {
            inputPenukaran();
            inputDetailpenukaranhadiah();
         
        }

        public void inputPenukaran()
        {

            try
            {
                string connectionString1 = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
                SqlConnection connection2 = new SqlConnection(connectionString1);
                SqlCommand com2 = new SqlCommand();
                com2.Connection = connection2;

                com2.CommandText = "sp_InputPenukaranHadiah";
                com2.CommandType = CommandType.StoredProcedure;

                com2.Parameters.AddWithValue("@trs_idPH", txtidpenukaran.Text);
                com2.Parameters.AddWithValue("@trs_tanggal", Convert.ToDateTime(tgl.Text));
                com2.Parameters.AddWithValue("@id_pengguna", txtidpengguna.Text);
                com2.Parameters.AddWithValue("@id_member", txtidmember.Text);
                com2.Parameters.AddWithValue("@trs_poin", Convert.ToInt32(txtpoin.Text));

                connection2.Open();
                int result2 = Convert.ToInt32(com2.ExecuteNonQuery());
                connection2.Close();

                if (result2 != 0)
                {
                    MessageBox.Show("Transaksi" + txtidpenukaran.Text + " Berhasil");
                    //ClearAll();
                    inputDetailpenukaranhadiah();
                }
                else
                {
                    MessageBox.Show("Transaksi Gagal!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public void inputDetailpenukaranhadiah()
        {
            int jumlah;
            int poin;
            for (int i = 0; i < keranjang.Rows.Count; i++)
            {
                try
                {
                    string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
                    SqlConnection com1 = new SqlConnection(connectionString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = com1;

                    com.CommandText = "sp_InputDetailPenukaranHadiah";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Clear();

                    com.Parameters.Add("@trs_idPH", txtidpenukaran.Text);
                    com.Parameters.AddWithValue("@id_hadiah", (keranjang[1, i].Value));
                    com.Parameters.AddWithValue("@jumlah", Convert.ToInt32(keranjang[2, i].Value.ToString()));
                    com.Parameters.AddWithValue("@poin", Convert.ToInt32(keranjang[3, i].Value.ToString()));
                    
                    com1.Open();
                    com1.Close();
                    try
                    {
                        com1.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Data telah Terinput", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("gagal Input : " + ex.Message);
                    }
                }

                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e);
                }

            }
        }

        private void txthadiah_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndaftarhadiah_Click(object sender, EventArgs e)
        {
            LihatHadiah lh = new LihatHadiah();
            lh.Show();
        }
    }
}
