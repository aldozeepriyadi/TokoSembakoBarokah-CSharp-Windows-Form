namespace TokoSembako
{
    partial class FormMerk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMerk));
            this.btnView = new System.Windows.Forms.Button();
            this.btnUbahHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(1224, 933);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(165, 41);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Lihat Merk";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUbahHapus
            // 
            this.btnUbahHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahHapus.Location = new System.Drawing.Point(941, 933);
            this.btnUbahHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUbahHapus.Name = "btnUbahHapus";
            this.btnUbahHapus.Size = new System.Drawing.Size(209, 41);
            this.btnUbahHapus.TabIndex = 5;
            this.btnUbahHapus.Text = "Ubah Hapus";
            this.btnUbahHapus.UseVisualStyleBackColor = true;
            this.btnUbahHapus.Click += new System.EventHandler(this.btnUbahHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(661, 933);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(192, 41);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah Merk";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 775);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(965, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Merk";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1958, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 51);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-34, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2136, 100);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormMerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1942, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUbahHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMerk";
            this.Text = "FormMerk";
            this.Load += new System.EventHandler(this.FormMerk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUbahHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}