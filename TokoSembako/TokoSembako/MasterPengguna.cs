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
    public partial class MasterPengguna : Form
    {
        String ID;
        string jeniskelamin = "";
        public MasterPengguna()
        {
            InitializeComponent();
            string q = "SELECT TOP 1 id_pengguna FROM Pengguna ORDER BY id_pengguna DESC";
            ID = idotomatis("PGN", q);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public string idotomatis(string firstID, string query)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MasterPengguna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSembakoDataSet8.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.tokoSembakoDataSet8.Jabatan);
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

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertPengguna", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (cmbJabatan.Text == ""||txtnama.Text == "" || txtalamat.Text == "" || txtnotelp.Text == "" || rbLaki.Text == "" || rbPerempuan.Text == ""|| txtusername.Text == ""||txtpassword.Text == "")
            {
                MessageBox.Show
                   ("Isi Data Dahulu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                insert.Parameters.AddWithValue("id_pengguna", ID);
                insert.Parameters.AddWithValue("id_jabatan", cmbJabatan.SelectedValue);
                insert.Parameters.AddWithValue("nama", txtnama.Text);
                insert.Parameters.AddWithValue("alamat", txtalamat.Text);
                insert.Parameters.AddWithValue("Jeniskelamin", jeniskelamin);
                insert.Parameters.AddWithValue("noTelp", txtnotelp.Text);
                insert.Parameters.AddWithValue("username", txtusername.Text);
                insert.Parameters.AddWithValue("pass", txtpassword.Text);

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data telah Terinput", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("gagal menambahkan data : " + ex.Message);
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
