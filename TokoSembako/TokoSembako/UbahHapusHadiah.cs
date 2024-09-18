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
    public partial class UbahHapusHadiah : Form
    {
        public UbahHapusHadiah()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HadiahMember WHERE id_hadiah ='" + txtidhadiah.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtHadiah.Text = dt.Rows[0]["hadiah"].ToString();
                txtStok.Text = dt.Rows[0]["stok_hadiah"].ToString();             
                txtPoin.Text = dt.Rows[0]["poin"].ToString();
                

                txtidhadiah.Enabled = true;
                txtHadiah.Enabled = true;
                txtStok.Enabled = true;
                txtPoin.Enabled = true;

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");
                clear();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void clear()
        {
            txtidhadiah.Text = "";
            txtHadiah.Text = "";
            txtStok.Text = "";
            txtPoin.Text = "";
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateHadiahMember", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_hadiah", txtidhadiah.Text);
            update.Parameters.AddWithValue("hadiah", txtHadiah.Text);
            update.Parameters.AddWithValue("stok_hadiah", txtStok.Text);
            update.Parameters.AddWithValue("poin", txtPoin.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Telah Mengupdate data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak dapat update: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string myCommand = "DELETE FROM HadiahMember WHERE id_hadiah	 = '" + txtidhadiah.Text + "'";
            DeleteDB(myCommand);
            clear();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
