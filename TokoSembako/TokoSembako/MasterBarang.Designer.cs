namespace TokoSembako
{
    partial class MasterBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterBarang));
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cmbSatuan = new System.Windows.Forms.ComboBox();
            this.cmbMerk = new System.Windows.Forms.ComboBox();
            this.tokoSembakoDataSet24 = new TokoSembako.TokoSembakoDataSet24();
            this.merkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.merkTableAdapter = new TokoSembako.TokoSembakoDataSet24TableAdapters.MerkTableAdapter();
            this.tokoSembakoDataSet25 = new TokoSembako.TokoSembakoDataSet25();
            this.satuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satuanTableAdapter = new TokoSembako.TokoSembakoDataSet25TableAdapters.SatuanTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txthargajual = new System.Windows.Forms.TextBox();
            this.txthargagrosir = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(396, 538);
            this.btnBersihkan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(86, 26);
            this.btnBersihkan.TabIndex = 68;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.AutoSize = true;
            this.btnTambah.Location = new System.Drawing.Point(275, 538);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(70, 27);
            this.btnTambah.TabIndex = 67;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(275, 350);
            this.txtnama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnama.Multiline = true;
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(168, 24);
            this.txtnama.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Merk";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 576);
            this.panel1.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Satuan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(59, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(258, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 55);
            this.label2.TabIndex = 35;
            this.label2.Text = "Master Barang";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Location = new System.Drawing.Point(0, -12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 60);
            this.panel2.TabIndex = 59;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 204);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(275, 385);
            this.txtstok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(168, 22);
            this.txtstok.TabIndex = 70;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(691, 538);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 92;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // cmbSatuan
            // 
            this.cmbSatuan.DataSource = this.satuanBindingSource;
            this.cmbSatuan.DisplayMember = "satuan";
            this.cmbSatuan.FormattingEnabled = true;
            this.cmbSatuan.Location = new System.Drawing.Point(275, 313);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.Size = new System.Drawing.Size(168, 24);
            this.cmbSatuan.TabIndex = 93;
            this.cmbSatuan.ValueMember = "id_satuan";
            // 
            // cmbMerk
            // 
            this.cmbMerk.DataSource = this.merkBindingSource;
            this.cmbMerk.DisplayMember = "merk";
            this.cmbMerk.FormattingEnabled = true;
            this.cmbMerk.Location = new System.Drawing.Point(275, 278);
            this.cmbMerk.Name = "cmbMerk";
            this.cmbMerk.Size = new System.Drawing.Size(168, 24);
            this.cmbMerk.TabIndex = 94;
            this.cmbMerk.ValueMember = "id_merk";
            // 
            // tokoSembakoDataSet24
            // 
            this.tokoSembakoDataSet24.DataSetName = "TokoSembakoDataSet24";
            this.tokoSembakoDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // merkBindingSource
            // 
            this.merkBindingSource.DataMember = "Merk";
            this.merkBindingSource.DataSource = this.tokoSembakoDataSet24;
            // 
            // merkTableAdapter
            // 
            this.merkTableAdapter.ClearBeforeFill = true;
            // 
            // tokoSembakoDataSet25
            // 
            this.tokoSembakoDataSet25.DataSetName = "TokoSembakoDataSet25";
            this.tokoSembakoDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satuanBindingSource
            // 
            this.satuanBindingSource.DataMember = "Satuan";
            this.satuanBindingSource.DataSource = this.tokoSembakoDataSet25;
            // 
            // satuanTableAdapter
            // 
            this.satuanTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Harga Grosir";
            // 
            // txthargajual
            // 
            this.txthargajual.Location = new System.Drawing.Point(275, 424);
            this.txthargajual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthargajual.Name = "txthargajual";
            this.txthargajual.Size = new System.Drawing.Size(168, 22);
            this.txthargajual.TabIndex = 63;
            // 
            // txthargagrosir
            // 
            this.txthargagrosir.Location = new System.Drawing.Point(275, 463);
            this.txthargagrosir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthargagrosir.Name = "txthargagrosir";
            this.txthargagrosir.Size = new System.Drawing.Size(168, 22);
            this.txthargagrosir.TabIndex = 95;
            // 
            // MasterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(745, 589);
            this.Controls.Add(this.txthargagrosir);
            this.Controls.Add(this.cmbMerk);
            this.Controls.Add(this.cmbSatuan);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txthargajual);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MasterBarang";
            this.Text = "MasterBarang";
            this.Load += new System.EventHandler(this.MasterBarang_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MasterBarang_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox cmbSatuan;
        private System.Windows.Forms.ComboBox cmbMerk;
        private TokoSembakoDataSet24 tokoSembakoDataSet24;
        private System.Windows.Forms.BindingSource merkBindingSource;
        private TokoSembakoDataSet24TableAdapters.MerkTableAdapter merkTableAdapter;
        private TokoSembakoDataSet25 tokoSembakoDataSet25;
        private System.Windows.Forms.BindingSource satuanBindingSource;
        private TokoSembakoDataSet25TableAdapters.SatuanTableAdapter satuanTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txthargajual;
        private System.Windows.Forms.TextBox txthargagrosir;
    }
}