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
    public partial class UbahHapusJabatan : Form
    {
        public UbahHapusJabatan()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtjabatan.Text = "";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Jabatan WHERE id_jabatan ='" + txtidjabatan.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtjabatan.Text = dt.Rows[0]["nama_jabatan"].ToString();

                txtidjabatan.Enabled = true;
                txtjabatan.Enabled = true;

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");
                clear();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = connection;
            com.CommandText = "sp_UpdateJabatan";
            // Mengatur type command yang akan digunakan
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@id_jabatan", txtidjabatan.Text);
            com.Parameters.AddWithValue("@nama_jabatan", txtjabatan.Text);
            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Telah Mengupdate data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak dapat update: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string myCommand = "DELETE FROM Jabatan WHERE id_jabatan	 = '" + txtidjabatan.Text + "'";
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
                MessageBox.Show("Data Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
