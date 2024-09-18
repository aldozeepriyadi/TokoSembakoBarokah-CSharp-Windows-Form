namespace TokoSembako
{
    partial class UbahHapusPengguna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahHapusPengguna));
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.jabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokoSembakoDataSet10 = new TokoSembako.TokoSembakoDataSet10();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtnotelp = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.txtidpengguna = new System.Windows.Forms.TextBox();
            this.jabatanTableAdapter = new TokoSembako.TokoSembakoDataSet10TableAdapters.JabatanTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(269, 675);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(225, 22);
            this.txtpassword.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 620);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 565);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Username";
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.DataSource = this.jabatanBindingSource;
            this.cmbJabatan.DisplayMember = "nama_jabatan";
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(269, 334);
            this.cmbJabatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(232, 24);
            this.cmbJabatan.TabIndex = 82;
            this.cmbJabatan.ValueMember = "id_jabatan";
            // 
            // jabatanBindingSource
            // 
            this.jabatanBindingSource.DataMember = "Jabatan";
            this.jabatanBindingSource.DataSource = this.tokoSembakoDataSet10;
            // 
            // tokoSembakoDataSet10
            // 
            this.tokoSembakoDataSet10.DataSetName = "TokoSembakoDataSet10";
            this.tokoSembakoDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.BackColor = System.Drawing.Color.White;
            this.rbPerempuan.Location = new System.Drawing.Point(381, 558);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(102, 21);
            this.rbPerempuan.TabIndex = 79;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = false;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.BackColor = System.Drawing.Color.White;
            this.rbLaki.Location = new System.Drawing.Point(269, 558);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(86, 21);
            this.rbLaki.TabIndex = 78;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-Laki";
            this.rbLaki.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Jabatan";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBox4.Location = new System.Drawing.Point(10, 667);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 40);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 802);
            this.panel1.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "ID Pengguna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "No Telp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-4, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 50);
            this.label1.TabIndex = 36;
            this.label1.Text = "Toko Barokah ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(50, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(258, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 55);
            this.label2.TabIndex = 35;
            this.label2.Text = "Master Pengguna";
            // 
            // btnKeluar
            // 
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKeluar.Location = new System.Drawing.Point(1668, 45);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(64, 64);
            this.btnKeluar.TabIndex = 36;
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1668, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(269, 620);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(225, 22);
            this.txtusername.TabIndex = 83;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(269, 482);
            this.txtalamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(225, 42);
            this.txtalamat.TabIndex = 76;
            // 
            // txtnotelp
            // 
            this.txtnotelp.Location = new System.Drawing.Point(269, 437);
            this.txtnotelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnotelp.Name = "txtnotelp";
            this.txtnotelp.Size = new System.Drawing.Size(225, 22);
            this.txtnotelp.TabIndex = 77;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(269, 386);
            this.txtnama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(225, 22);
            this.txtnama.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Location = new System.Drawing.Point(1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 60);
            this.panel2.TabIndex = 73;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(396, 731);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(86, 26);
            this.btnHapus.TabIndex = 89;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(542, 278);
            this.btnCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(68, 26);
            this.btnCari.TabIndex = 88;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(274, 731);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(86, 26);
            this.btnUbah.TabIndex = 87;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.AutoSize = true;
            this.btnBersihkan.Location = new System.Drawing.Point(524, 733);
            this.btnBersihkan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(86, 27);
            this.btnBersihkan.TabIndex = 86;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // txtidpengguna
            // 
            this.txtidpengguna.Location = new System.Drawing.Point(269, 280);
            this.txtidpengguna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidpengguna.Name = "txtidpengguna";
            this.txtidpengguna.Size = new System.Drawing.Size(225, 22);
            this.txtidpengguna.TabIndex = 90;
            // 
            // jabatanTableAdapter
            // 
            this.jabatanTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 772);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UbahHapusPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(790, 840);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtidpengguna);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cmbJabatan);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtnotelp);
            this.Controls.Add(this.txtnama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UbahHapusPengguna";
            this.Text = "UbahHapusPengguna";
            this.Load += new System.EventHandler(this.UbahHapusPengguna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtnotelp;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.TextBox txtidpengguna;
        private TokoSembakoDataSet10 tokoSembakoDataSet10;
        private System.Windows.Forms.BindingSource jabatanBindingSource;
        private TokoSembakoDataSet10TableAdapters.JabatanTableAdapter jabatanTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}