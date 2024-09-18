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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isAuthentic(string Uname, string Pass)
        {
            bool valid;
            string connectionString = "integrated security=true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection myConnection = new SqlConnection(connectionString);
            {
                SqlCommand cmd = new SqlCommand("sp_Login", myConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("username", Uname);
                cmd.Parameters.AddWithValue("pass", Pass);
                myConnection.Open();
                int status = Convert.ToInt32(cmd.ExecuteScalar());
                if (status == 1)
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }
                myConnection.Close();
                return valid;
            }
        }
        private string[] getData(string Uname, string Pass)
        {
            string connectionString = "integrated security=true;data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection myConnection = new SqlConnection(connectionString);
            {
                SqlCommand cmd = new SqlCommand("sp_getPengguna", myConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("username", Uname);
                cmd.Parameters.AddWithValue("pass", Pass);
                myConnection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                string[] pengguna = new string[8];
                while (read.Read())
                {
                    pengguna[0] = read["id_pengguna"].ToString();
                    pengguna[1] = read["id_jabatan"].ToString();
                    pengguna[2] = read["nama"].ToString();
                    pengguna[3] = read["noTelp"].ToString();
                    pengguna[4] = read["alamat"].ToString();
                    pengguna[5] = read["JenisKelamin"].ToString();
                    pengguna[6] = read["username"].ToString();
                    pengguna[7] = read["pass"].ToString();

                }
                myConnection.Close();
                return pengguna;
            }
        }

        private string getJabatan(string idjabatan)
        {
            string connectionString = "integrated security=true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection myConnection = new SqlConnection(connectionString);
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Jabatan WHERE id_jabatan='" + idjabatan + "'", myConnection);
                myConnection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                string jabatan = "";
                while (read.Read())
                {
                    jabatan = read["id_jabatan"].ToString();
                }
                myConnection.Close();
                return jabatan;
            }
        }

        private void cbLihatpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLihatpass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] pengguna = new string[9];
            if (isAuthentic(txtUsername.Text, txtPassword.Text))
            {
                pengguna = getData(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Nama : " + pengguna[2] + "\nLogin Berhasil");
                string jabatan = getJabatan(pengguna[1]);
                if (jabatan.Equals("JBT03"))
                {
                    DSPemilik db = new DSPemilik(pengguna[1]);
                    this.Hide();
                    db.ShowDialog();
                    this.Close();
                }
                else if (jabatan.Equals("JBT02"))
                {
                    DSPegawai db = new DSPegawai(pengguna[0], pengguna[1]);
                    this.Hide();
                    db.ShowDialog();
                    this.Close();
                }
                else if (jabatan.Equals("JBT01"))
                {
                    DSAdmin db = new DSAdmin(pengguna[1]);
                    this.Hide();
                    db.ShowDialog();
                    this.Close();
                }

            }
            else if (txtPassword.Text.Equals("") || txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Harap isi Username & Password dengan benar!!");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Username & Password Anda Salah, Harap Cek kembali.");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}

