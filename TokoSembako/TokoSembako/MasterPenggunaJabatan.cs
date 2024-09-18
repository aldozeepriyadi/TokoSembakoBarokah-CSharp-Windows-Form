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
    public partial class MasterPenggunaJabatan : Form
    {
        String ID;
        string jeniskelamin = "";
        public MasterPenggunaJabatan()
        {
            InitializeComponent();
            string q = "SELECT TOP 1 id_penggunajabatan FROM PenggunaJabatan ORDER BY id_penggunajabatan DESC";
            ID = idotomatis("PGJ", q);
        }
        public string idotomatis(string firstID, string query)
        {
            string connectionString = "integrated security = true; data source = LAPTOP-1HF0VN7J; initial catalog = TokoSembako";
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
    }
}
