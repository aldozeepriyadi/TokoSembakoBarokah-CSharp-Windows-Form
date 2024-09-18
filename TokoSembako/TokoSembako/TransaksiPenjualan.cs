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
    public partial class TransaksiPenjualan : Form
    {
        String ID;
        public TransaksiPenjualan()
        {
            InitializeComponent();
            
            DateTime now;
            now = DateTime.Now;
            tgl.Text = now.ToShortDateString();
            string q = "SELECT TOP 1 trs_idpj FROM penjualan ORDER BY trs_idpj DESC";
            ID = idotomatis("PJ", q);
            txtidpenjualan.Text = ID;
            txtbayar.Text = "0";

        }
        public string idotomatis(string firstID, string query)
        {
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";
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

        private void TransaksiPenjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSembakoDataSet31.Promo' table. You can move, or remove it, as needed.
            this.promoTableAdapter.Fill(this.tokoSembakoDataSet31.Promo);
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cbPromo.Enabled = false;
            txtPoinmember.Enabled = false;
            txtIdmember.Enabled = false;
            txtNamamember.Enabled = false;
        }

        private void rbMember_CheckedChanged(object sender, EventArgs e)
        {
           
            txtPoinmember.Enabled = true;
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtidbarang.Text = "";
            txtjumlahbarang.Text = "";
            txtharga.Text = "";
            txttotalharga.Text = "";
        }

        private void btnLihatBarang_Click(object sender, EventArgs e)
        {
            LihatBarang lb = new LihatBarang();
            lb.Show();
        }

        private void btnCaribarang_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE id_barang ='" + txtidbarang.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtbarang.Text = dt.Rows[0]["nama"].ToString();


                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!" + ex);
                clear();
            }
        }

        private void rbsatuan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE id_barang ='" + txtidbarang.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtharga.Text = dt.Rows[0]["harga_jual"].ToString();


                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!" + ex);
                clear();
            }
        }

        private void rbgrosir_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE id_barang ='" + txtidbarang.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtharga.Text = dt.Rows[0]["harga_grosir"].ToString();


                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!" + ex);
                clear();
            }
        }

        private void txtDaftarMember_Click(object sender, EventArgs e)
        {
            MasterMember mm = new MasterMember();
            mm.Show();
        }

        private void btnTambahkeranjang_Click(object sender, EventArgs e)
        {
            if (txtidpenjualan.Text == "" || txtidbarang.Text == "" || txtbarang.Text == "" || txtjumlahbarang.Text == "" )
            {
                MessageBox.Show
                   ("Isi Data Dahulu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int harga = Convert.ToInt32(txtharga.Text);
            int jumlah = Convert.ToInt32(txtjumlahbarang.Text);
           

            int total = harga * jumlah;

            int row = 0;
            keranjang.Rows.Add();
            row = keranjang.Rows.Count - 2;

            keranjang["id_barang", row].Value = txtidbarang.Text;
            keranjang["nama", row].Value = txtbarang.Text;
            keranjang["jumlah", row].Value = txtjumlahbarang.Text;
            keranjang["total_harga", row].Value = total.ToString();
            keranjang.Refresh();

            int sum = 0;
            for (int i = 0; i < keranjang.Rows.Count; i++)
            {
                sum += Convert.ToInt32(keranjang.Rows[i].Cells[3].Value);
            }

            int rupiah = int.Parse(sum.ToString());
            txttotalharga.Text = rupiah.ToString();

            int potongan = int.Parse(cbPromo.Text);

            int pembayaran1 = int.Parse(txtbayar.Text);
            int pembayaran2 = int.Parse(txttotalharga.Text);

            int promo = Convert.ToInt32(int.Parse(cbPromo.Text)) - Convert.ToInt32(pembayaran2);

            int kembali = Convert.ToInt32(int.Parse(txtbayar.Text)) - Convert.ToInt32(pembayaran2);

            txtkembali.Text = kembali.ToString();
            /*
            int totalharga = Convert.ToInt32(txttotalharga.Text);
            int bayar = Convert.ToInt32(txtbayar.Text);
            int transaksi = rupiah - bayar;
            txtkembali.Text = transaksi.ToString();*/

            /*int totalharga = Convert.ToInt32(txttotalharga.Text);*/
         


        }

        private void tgl_Click(object sender, EventArgs e)
        {

        }

        private void btnViewmember_Click(object sender, EventArgs e)
        {
            LihatMember Lm = new LihatMember();
            Lm.Show();
        }

        public void inputpenjualan()
        {
            string jenispelanggan = "";
            if (rbMember.Checked)
            {
                jenispelanggan = "Member";
            }
            else if (rbNonmember.Checked)
            {
                jenispelanggan = "Non Member";
            }

            try
            {
                string connectionString1 = "integrated security=true; data source= LAPTOP-FGN79AHI\\BASISDATA; initial catalog= TokoSembako";
                SqlConnection connection2 = new SqlConnection(connectionString1);
                SqlCommand com2 = new SqlCommand();
                com2.Connection = connection2;

                com2.CommandText = "sp_InputPenjualan";
                com2.CommandType = CommandType.StoredProcedure;

                com2.Parameters.AddWithValue("@trs_idpj", ID);
                com2.Parameters.AddWithValue("@id_member", txtIdmember);
                com2.Parameters.AddWithValue("@id_pengguna",txtidpenjualan);
                com2.Parameters.AddWithValue("@tgl_transaksi", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"));
                com2.Parameters.AddWithValue("@promo", cbPromo.Text);
                com2.Parameters.AddWithValue("@poin", txtPoinmember.Text);

                connection2.Open();
                int result2 = Convert.ToInt32(com2.ExecuteNonQuery());
                connection2.Close();

                if (result2 != 0)
                {
                    MessageBox.Show("Transaksi dengan ID " + ID + " Berhasil");

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

        public void inputDetailPenjualan()
        {

            for (int i = 0; i < keranjang.Rows.Count - 1; i++)
            {
                try
                {
                    string connectionString = "integrated security=true; data source=LAPTOP-FGN79AHI\\BASISDATA; initial catalog=TokoSembako";

                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                    com.CommandText = "sp_InputDetailpenjualann";

                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@trs_idPj", ID);
                    com.Parameters.AddWithValue("@id_Barang", keranjang[0, i].Value.ToString());
                    com.Parameters.AddWithValue("@nama", keranjang[1, i].Value.ToString());
                    com.Parameters.AddWithValue("@jumlah", int.Parse(keranjang[2, i].Value.ToString()));
                    com.Parameters.AddWithValue("@total_harga", Convert.ToInt32(keranjang[3, i].Value));
                    connection.Open();
                    com.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e);
                }
            }
        }

        

        private void btnCariMember_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Member WHERE id_member ='" + txtIdmember.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtNamamember.Text = dt.Rows[0]["nama"].ToString();
               
                txtIdmember.Enabled = true;
                txtNamamember.Enabled = true;
               
                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");
                clear();
            }
        
    }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            inputpenjualan();
            inputDetailPenjualan();
        }
    }
}
