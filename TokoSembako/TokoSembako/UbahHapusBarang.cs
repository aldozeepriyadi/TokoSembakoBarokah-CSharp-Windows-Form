using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSembako
{
    public partial class UbahHapusBarang : Form
    {
        public UbahHapusBarang()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
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

                txtmerk.Text = dt.Rows[0]["id_merk"].ToString();
                txtSatuan.Text = dt.Rows[0]["id_satuan"].ToString();
                txtnama.Text = dt.Rows[0]["nama"].ToString();
                txtstok.Text = dt.Rows[0]["stok"].ToString();
                txthargajual.Text = dt.Rows[0]["harga_jual"].ToString();
                txthargagrosir.Text = dt.Rows[0]["harga_grosir"].ToString();

                txtidbarang.Enabled = true;
                txtmerk.Enabled = true;
                txtSatuan.Enabled = true;
                txtnama.Enabled = true;
                txtstok.Enabled = true;
                txthargajual.Enabled = true;

                

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!"+ex);
                clear();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtidbarang.Text == "" || txtmerk.Text == "" || txtSatuan.Text == "" || txtnama.Text == "" || txtstok.Text == "" || txthargajual.Text == "" || txthargagrosir.Text == "") ;
            {
                MessageBox.Show("Data Wajib diisi Semua!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            

            string connectionString = "data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateBarang", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_barang", txtidbarang.Text);
            update.Parameters.AddWithValue("id_merk", txtmerk.Text);
            update.Parameters.AddWithValue("id_satuan", txtSatuan.Text);
            update.Parameters.AddWithValue("nama", txtnama.Text);
            update.Parameters.AddWithValue("stok", txtstok.Text);
            update.Parameters.AddWithValue("harga_jual", txthargajual.Text);
            update.Parameters.AddWithValue("harga_grosir", txthargagrosir.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Telah Mengupdate data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak dapat update: " + ex.Message);
            }
        }
        private void DeleteDB(string cmd)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear()
        {
            txtidbarang.Text = "";
            txtmerk.Text = "";
            txtSatuan.Text = "";
            txtnama.Text = "";
            txtstok.Text = "";
            txthargajual.Text = "";
            txthargagrosir.Text = "";
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            string myCommand = "DELETE FROM Barang WHERE id_barang	 = '" + txtidbarang.Text + "'";
            DeleteDB(myCommand);
            clear();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
