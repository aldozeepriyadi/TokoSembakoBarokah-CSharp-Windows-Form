using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSembako
{
    public partial class TransaksiSupplier : Form
    {
        public TransaksiSupplier()
        {
            InitializeComponent();
            txtIDtrans.Text= autoId();
            txtDetail.Text = autoId2();
            txtNamaBrg.Enabled = false;
            txtJumlah.Enabled = false;
            txtNamaSupplier.Enabled = false;
            txtAlamatSupplier.Enabled = false;
            txtTotalPembayaran.Text = "0";
        }
        private string autoId()
        {
            try
            {
                int numberId = 0;               //4 digit terakhir dibelakang 2 huruf
                string stringId = null; //nilai id otomatis
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("sp_autoId", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("tableParameter", "TransaksiSupplier");
                cmd.Parameters.AddWithValue("idParameter", "trs_idSP");

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                if (dr["idReturn"].ToString() == "")
                {
                    numberId = 1;
                }
                else
                {
                    numberId = Int32.Parse(dr["idReturn"].ToString());
                }

                if (numberId < 10)
                {
                    stringId = "TSP000" + numberId;
                }
                else if (numberId < 100)
                {
                    stringId = "TSP00" + numberId;
                }
                else if (numberId < 1000)
                {
                    stringId = "TSP0" + numberId;
                }
                else
                {
                    stringId = "TSP" + numberId;
                }

                dr.Close();
                connection.Close();

                return stringId;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private string autoId2()
        {
            try
            {
                int numberId = 0;               //4 digit terakhir dibelakang 2 huruf
                string stringId = null; //nilai id otomatis
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("sp_autoId", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("tableParameter", "DetailTransSupplier");
                cmd.Parameters.AddWithValue("idParameter", "id_detail");

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                if (dr["idReturn"].ToString() == "")
                {
                    numberId = 1;
                }
                else
                {
                    numberId = Int32.Parse(dr["idReturn"].ToString());
                }

                if (numberId < 10)
                {
                    stringId = "DTL000" + numberId;
                }
                else if (numberId < 100)
                {
                    stringId = "DTL00" + numberId;
                }
                else if (numberId < 1000)
                {
                    stringId = "DTL0" + numberId;
                }
                else
                {
                    stringId = "DTL" + numberId;
                }

                dr.Close();
                connection.Close();

                return stringId;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnTmbhKrjg_Click(object sender, EventArgs e)
        {

           
        }

        public void inputTransaksiSupplier()
        {
            try
            {

                string connectionString1 = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
                SqlConnection connection2 = new SqlConnection(connectionString1);
                SqlCommand com2 = new SqlCommand();
                com2.Connection = connection2;

                com2.CommandText = "sp_InputTransaksiSupplier";
                com2.CommandType = CommandType.StoredProcedure;

                com2.Parameters.AddWithValue("@trs_idSP", txtIDtrans.Text);
                com2.Parameters.AddWithValue("@id_pengguna", txtIDPengguna.Text);
                com2.Parameters.AddWithValue("@id_supplier", txtIDSupplier.Text);
                com2.Parameters.AddWithValue("@total", txtTotal.Text);
                com2.Parameters.AddWithValue("@tgl_transaksi", Convert.ToDateTime(dtpTrans.Text));


                connection2.Open();
                int result2 = Convert.ToInt32(com2.ExecuteNonQuery());
                connection2.Close();

                if (result2 != 0)
                {
                    MessageBox.Show("Transaksi" + txtIDtrans.Text + " Berhasil");
                    //ClearAll();

                }
                else
                {
                    MessageBox.Show("Transaksi Gagal!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void TambahStokBrg()
        {
            try
            {

                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";
                SqlConnection con = new SqlConnection(connectionString);


                con.Open();
                SqlCommand update = new SqlCommand("sp_TambahStokTrans", con);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("id_barang", txtIdBarang.Text);
                update.Parameters.AddWithValue("stok", txtStokBrg.Text);
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
        public void inputDetailTransaksiSupplier()
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = con;

                com.CommandText = "sp_InputDetailTransaksiSupplier";

                com.Parameters.Clear();
                com.Parameters.Add("@id_detail", txtDetail.Text);
                com.Parameters.Add("@trs_idSP", txtIDtrans.Text);
                com.Parameters.Add("@id_barang", txtIdBarang.Text);
                com.Parameters.Add("@nama_barang", txtNamaBrg.Text);
                com.Parameters.Add("@jumlah", int.Parse(txtStokBrg.Text));

                con.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                con.Close();
                if (result != 0)
                {
                    MessageBox.Show("Berhasil Melakukan Transaksi");
                    // Clear();
                }
                else
                {
                    MessageBox.Show("Gagal Melakukan Transaksi");
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }



        }

        private void btnCari1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako"; 

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier WHERE id_supplier ='" + txtIDSupplier.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtNamaSupplier.Text = dt.Rows[0]["nama"].ToString();
                txtAlamatSupplier.Text = dt.Rows[0]["alamat"].ToString();


                
                txtNamaSupplier.Enabled = true;
                txtAlamatSupplier.Enabled = true;

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan dalam data:" + ex);

            }
        }
        public void clear()
        {
            txtIdBarang.Text = "";
            txtDetail.Text = "";
            txtIDtrans.Text = "";
            txtIDPengguna.Text = "";
            txtIDSupplier.Text = "";
            txtNamaBrg.Text = "";
            txtNamaSupplier.Text = "";
            txtStokBrg.Text = "";
            txtAlamatSupplier.Text = "";
            txtTotal.Text = "";
            txtJumlah.Text = "";
        }

        private void btnCari2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = LAPTOP-FGN79AHI\\BASISDATA ; initial catalog = TokoSembako";

                SqlConnection com = new SqlConnection(connectionString);
                com.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE id_barang ='" + txtIdBarang.Text + "'", com);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtNamaBrg.Text = dt.Rows[0]["nama"].ToString();
                txtStokBrg.Text = dt.Rows[0]["stok"].ToString();
                txtJumlah.Text = dt.Rows[0]["harga_jual"].ToString();



                txtNamaBrg.Enabled = true;
                txtStokBrg.Enabled = true;
                txtJumlah.Enabled = true;

                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan dalam data:" + ex);

            }
        }

        private void btnTmbhKrjg_Click_1(object sender, EventArgs e)
        {
            int row = 0;

            int stok = int.Parse(txtStokBrg.Text);
            int jumlah = int.Parse(txtJumlah.Text);
            int total = (Convert.ToInt16(stok) * Convert.ToInt32(jumlah));
            dtTransaksiSupp.Rows.Add();
            row = dtTransaksiSupp.Rows.Count - 2;
            dtTransaksiSupp["id_barang", row].Value = txtIdBarang.Text;
            dtTransaksiSupp["nama_barang", row].Value = txtNamaBrg.Text;
            dtTransaksiSupp["stok", row].Value = txtStokBrg.Text;
            dtTransaksiSupp["jumlah", row].Value = total.ToString();

            dtTransaksiSupp.Refresh();

            int sum = 0;
            for (int i = 0; i < dtTransaksiSupp.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dtTransaksiSupp.Rows[i].Cells[3].Value);
            }

            int rupiah = int.Parse(sum.ToString());
            txtTotal.Text = rupiah.ToString();


            int pembayaran1 = int.Parse(txtTotalPembayaran.Text);

            int pembayaran2 = int.Parse(txtTotal.Text);


            int sisa = (Convert.ToInt32(pembayaran1) - Convert.ToInt32(pembayaran2));

            txtKembalian.Text = sisa.ToString();
            
        }


        private void btnSimpanTransaksi_Click(object sender, EventArgs e)
        {
            inputTransaksiSupplier();
            inputDetailTransaksiSupplier();
            TambahStokBrg();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransaksiSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
