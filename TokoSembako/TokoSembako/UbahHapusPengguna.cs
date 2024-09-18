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
    public partial class UbahHapusPengguna : Form
    {
        string jeniskelamin = "";
        public UbahHapusPengguna()
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
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pengguna WHERE id_pengguna ='" + txtidpengguna.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cmbJabatan.SelectedValue = dt.Rows[0]["id_jabatan"].ToString();
                txtnama.Text = dt.Rows[0]["nama"].ToString();
                txtnotelp.Text = dt.Rows[0]["noTelp"].ToString();
                txtalamat.Text = dt.Rows[0]["alamat"].ToString();
                jeniskelamin = dt.Rows[0]["Jeniskelamin"].ToString();
                if (dt.Rows[0]["Jeniskelamin"].ToString().Equals("Laki-Laki"))
                {
                    rbLaki.Checked = true;
                }
                else
                {
                    rbPerempuan.Checked = true;
                }
                txtusername.Text = dt.Rows[0]["username"].ToString();
                txtpassword.Text = dt.Rows[0]["pass"].ToString();

                txtidpengguna.Enabled = true;
                cmbJabatan.Enabled = true;
                txtnama.Enabled = true;
                txtalamat.Enabled = true;
                rbLaki.Enabled = true;
                rbPerempuan.Enabled = true;
                txtnotelp.Enabled = true;
                txtusername.Enabled = true;
                txtpassword.Enabled = true;

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
            if (txtidpengguna.Text == "" || txtnama.Text == "" || txtnotelp.Text == "" || txtalamat.Text == "" || txtusername.Text == "" || txtpassword.Text == "") ;
            {
                MessageBox.Show("Data Wajib diisi Semua!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            string connectionString = "data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdatePengguna", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_pengguna", txtidpengguna.Text);
            update.Parameters.AddWithValue("id_jabatan", cmbJabatan.SelectedValue);
            update.Parameters.AddWithValue("nama", txtnama.Text);
            update.Parameters.AddWithValue("noTelp", txtnotelp.Text);
            update.Parameters.AddWithValue("alamat", txtalamat.Text);
            update.Parameters.AddWithValue("Jeniskelamin", jeniskelamin);
            update.Parameters.AddWithValue("username", txtusername.Text);
            update.Parameters.AddWithValue("pass", txtpassword.Text);

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
            string myCommand = "DELETE FROM Pengguna WHERE id_pengguna	 = '" + txtidpengguna.Text + "'";
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

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            cmbJabatan.Text = "";
            txtnama.Text = "";
            txtalamat.Text = "";
            txtnotelp.Text = "";
            rbLaki.Enabled = true;
            rbPerempuan.Enabled = true;
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void UbahHapusPengguna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSembakoDataSet10.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.tokoSembakoDataSet10.Jabatan);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
