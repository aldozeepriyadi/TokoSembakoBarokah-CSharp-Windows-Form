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
    public partial class MasterHadiah : Form
    {
        String ID;

        public MasterHadiah()
        {
            InitializeComponent();
            string q = "SELECT TOP 1 id_hadiah FROM HadiahMember ORDER BY id_hadiah DESC";
            ID = idotomatis("HDM", q);
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertHadiahMember", connection);
            insert.CommandType = CommandType.StoredProcedure;


            if (txtHadiah.Text == "" || txtStok.Text == "" || txtPoin.Text == "")
            {
                MessageBox.Show("Isi data dahulu!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                insert.Parameters.AddWithValue("id_hadiah", ID);
                insert.Parameters.AddWithValue("hadiah", txtHadiah.Text);
                insert.Parameters.AddWithValue("stok_hadiah", txtStok.Text);
                insert.Parameters.AddWithValue("poin", txtPoin.Text);
     
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data telah Terinput", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("gagal Input : " + ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void clear()
        {
            txtHadiah.Text = "";
            txtStok.Text = "";
            txtPoin.Text = "";         
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            clear();
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
