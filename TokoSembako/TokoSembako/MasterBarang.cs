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
    public partial class MasterBarang : Form
    {
        String ID;
        string jeniskelamin = "";
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MasterBarang()
        {
            InitializeComponent();
            string q = "SELECT TOP 1 id_barang FROM Barang ORDER BY id_barang DESC";
            ID = idotomatis("BRG", q);

        }
        public string idotomatis(string firstID, string query)
        {
            string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA; initial catalog = TokoSembako";
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MasterBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSembakoDataSet25.Satuan' table. You can move, or remove it, as needed.
            this.satuanTableAdapter.Fill(this.tokoSembakoDataSet25.Satuan);
            // TODO: This line of code loads data into the 'tokoSembakoDataSet24.Merk' table. You can move, or remove it, as needed.
            this.merkTableAdapter.Fill(this.tokoSembakoDataSet24.Merk);

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MasterBarang_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertBarang", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (cmbMerk.Text == "" || cmbSatuan.Text == "" || txtnama.Text == "" || txtstok.Text == "" || txthargajual.Text == "")
            {
                MessageBox.Show
                   ("Isi Data Dahulu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                insert.Parameters.AddWithValue("id_barang", ID);
                insert.Parameters.AddWithValue("id_merk", cmbMerk.SelectedValue);
                insert.Parameters.AddWithValue("id_satuan", cmbSatuan.SelectedValue);
                insert.Parameters.AddWithValue("nama", txtnama.Text);
                insert.Parameters.AddWithValue("stok", int.Parse(txtstok.Text));
                insert.Parameters.AddWithValue("harga_jual", txthargajual.Text);
                insert.Parameters.AddWithValue("harga_grosir", txthargagrosir.Text);

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

        /* private void MasterBarang_Load(object sender, EventArgs e)
         {

         }*/

    }
}
