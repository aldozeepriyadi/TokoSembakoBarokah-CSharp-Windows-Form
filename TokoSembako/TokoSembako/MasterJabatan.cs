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
    public partial class MasterJabatan : Form
    {
        String ID;
        public MasterJabatan()
        {
            InitializeComponent();
            string q = "SELECT TOP 1 id_jabatan FROM Jabatan ORDER BY id_jabatan DESC";
            ID = idotomatis("JBT", q);

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

        private void btnTambah_Click(object sender, EventArgs e)
        {

            if (txtjabatan.Text == "")
            {
                MessageBox.Show("Seluruh data harus diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string connectionstring =
               "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertJabatan", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_jabatan", ID);
            insert.Parameters.AddWithValue("nama_jabatan", txtjabatan.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat penyimpanan data : " + ex.Message);
            }
        }
        private void clear()
        {
            txtjabatan.Text = "";
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
