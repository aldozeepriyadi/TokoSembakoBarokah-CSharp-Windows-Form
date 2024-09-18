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
    public partial class UbahHapusPromo : Form
    {
        public UbahHapusPromo()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Promo WHERE id_promo ='" + txtidpromo.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtpromo.Text = dt.Rows[0]["nama_promo"].ToString();
                txtDisc.Text = dt.Rows[0]["discount"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["tanggal_mulai"].ToString();
                dateTimePicker2.Text = dt.Rows[0]["tanggal_berakhir"].ToString();



                txtidpromo.Enabled = true;
                txtpromo.Enabled = true;
                txtDisc.Enabled = true;
               

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtidpromo.Text == "" || txtpromo.Text == "" || txtDisc.Text == "");
            {
                MessageBox.Show("Data Wajib diisi Semua!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Validasi aman semua
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdatePromo", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_promo", txtidpromo.Text);
            update.Parameters.AddWithValue("nama_promo", txtpromo.Text);
            update.Parameters.AddWithValue("discount", Convert.ToInt32(txtDisc.Text));
            update.Parameters.AddWithValue("tanggal_mulai", Convert.ToDateTime(dateTimePicker1.Text));
            update.Parameters.AddWithValue("tanggal_berakhir",Convert.ToDateTime(dateTimePicker2.Text));

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Berhasil diubah", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal!" + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string myCommand = "DELETE FROM Promo WHERE id_promo	 = '" + txtidpromo.Text + "'";
            DeleteDB(myCommand);
            clear();
        }
        private void clear()
        {
            txtidpromo.Text = "";
            txtpromo.Text = "";
            txtDisc.Text = "";
        }
        private void DeleteDB(string cmd)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Gagal menghapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
