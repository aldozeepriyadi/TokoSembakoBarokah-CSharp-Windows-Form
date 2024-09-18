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
    public partial class UbahHapusSatuan : Form
    {
        public UbahHapusSatuan()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Satuan WHERE id_satuan ='" + txtidsatuan.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtsatuan.Text = dt.Rows[0]["satuan"].ToString();
               



                txtsatuan.Enabled = true;
                


                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtidsatuan.Text == "" || txtsatuan.Text == "") ;
            {
                MessageBox.Show("Data Wajib diisi Semua!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Validasi aman semua
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateSatuan", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_satuan", txtidsatuan.Text);
            update.Parameters.AddWithValue("satuan", txtsatuan.Text);
            
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
            string myCommand = "DELETE FROM Satuan WHERE id_satuan	 = '" + txtidsatuan.Text + "'";
            DeleteDB(myCommand);
            clear();
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
        private void clear()
        {
            txtidsatuan.Text = "";
            txtsatuan.Text = "";
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
