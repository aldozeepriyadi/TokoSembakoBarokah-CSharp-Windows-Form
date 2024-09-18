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
    
    public partial class UpdateHapusMember : Form
    {
        string jeniskelamin = "";
        String ID;
        public UpdateHapusMember()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Member WHERE id_member ='" + txtidmember.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtnama.Text = dt.Rows[0]["nama"].ToString();
                txtalamat.Text = dt.Rows[0]["alamat"].ToString();                            
                jeniskelamin = dt.Rows[0]["Jeniskelamin"].ToString();
                txtnotelp.Text = dt.Rows[0]["noTelp"].ToString();
                txtpoin.Text = dt.Rows[0]["poin"].ToString();
                if (dt.Rows[0]["Jeniskelamin"].ToString().Equals("Laki-Laki"))
                {
                    rbLaki.Checked = true;
                }
                else
                {
                    rbPerempuan.Checked = true;
                }


                txtidmember.Enabled = true;
                txtnama.Enabled = true;
                txtalamat.Enabled = true;
                rbLaki.Enabled = true;
                rbPerempuan.Enabled = true;
                txtnotelp.Enabled = true;
                txtpoin.Enabled = true;
               
                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Data Tidak ditemukan!");
                clear();
            }
        }
        private void clear()
        {
            txtnama.Text = "";
            txtalamat.Text = "";
            txtnotelp.Text = "";
            rbLaki.Enabled = true;
            rbPerempuan.Enabled = true;
            txtpoin.Text = "";
        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked)
            {
                jeniskelamin = "Laki-Laki";
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked)
            {
                jeniskelamin = "Perempuan";
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtidmember.Text == "" || txtnama.Text == ""|| txtnotelp.Text == "" || txtalamat.Text == "" || txtpoin.Text == "") ;
            {
                MessageBox.Show("Data Wajib diisi Semua!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Validasi aman semua
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateMember", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_member", txtidmember.Text);
            update.Parameters.AddWithValue("nama", txtnama.Text);
            update.Parameters.AddWithValue("alamat", txtalamat.Text);
            update.Parameters.AddWithValue("Jeniskelamin", jeniskelamin);
            update.Parameters.AddWithValue("noTelp", txtnotelp.Text);
            update.Parameters.AddWithValue("poin", txtpoin.Text);
            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Berhasil diubah", "Infromation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal!" + ex.Message);
            }
          
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string myCommand = "DELETE FROM Member WHERE id_member	 = '" + txtidmember.Text + "'";
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }

        
        private void pictureBox4_Click_2(object sender, EventArgs e)
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
