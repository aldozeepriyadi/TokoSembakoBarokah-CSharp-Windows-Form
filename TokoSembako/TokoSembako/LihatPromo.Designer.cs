namespace TokoSembako
{
    partial class LihatPromo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatPromo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tokoSembakoDataSet30 = new TokoSembako.TokoSembakoDataSet30();
            this.viewPromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPromoTableAdapter = new TokoSembako.TokoSembakoDataSet30TableAdapters.viewPromoTableAdapter();
            this.idpromoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapromoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalmulaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalberakhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPromoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 68);
            this.panel2.TabIndex = 66;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(226, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 55);
            this.label2.TabIndex = 35;
            this.label2.Text = "Master Promo";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpromoDataGridViewTextBoxColumn,
            this.namapromoDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.tanggalmulaiDataGridViewTextBoxColumn,
            this.tanggalberakhirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewPromoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(660, 278);
            this.dataGridView1.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 392);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tokoSembakoDataSet30
            // 
            this.tokoSembakoDataSet30.DataSetName = "TokoSembakoDataSet30";
            this.tokoSembakoDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPromoBindingSource
            // 
            this.viewPromoBindingSource.DataMember = "viewPromo";
            this.viewPromoBindingSource.DataSource = this.tokoSembakoDataSet30;
            // 
            // viewPromoTableAdapter
            // 
            this.viewPromoTableAdapter.ClearBeforeFill = true;
            // 
            // idpromoDataGridViewTextBoxColumn
            // 
            this.idpromoDataGridViewTextBoxColumn.DataPropertyName = "id_promo";
            this.idpromoDataGridViewTextBoxColumn.HeaderText = "id_promo";
            this.idpromoDataGridViewTextBoxColumn.Name = "idpromoDataGridViewTextBoxColumn";
            // 
            // namapromoDataGridViewTextBoxColumn
            // 
            this.namapromoDataGridViewTextBoxColumn.DataPropertyName = "nama_promo";
            this.namapromoDataGridViewTextBoxColumn.HeaderText = "nama_promo";
            this.namapromoDataGridViewTextBoxColumn.Name = "namapromoDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // tanggalmulaiDataGridViewTextBoxColumn
            // 
            this.tanggalmulaiDataGridViewTextBoxColumn.DataPropertyName = "tanggal_mulai";
            this.tanggalmulaiDataGridViewTextBoxColumn.HeaderText = "tanggal_mulai";
            this.tanggalmulaiDataGridViewTextBoxColumn.Name = "tanggalmulaiDataGridViewTextBoxColumn";
            // 
            // tanggalberakhirDataGridViewTextBoxColumn
            // 
            this.tanggalberakhirDataGridViewTextBoxColumn.DataPropertyName = "tanggal_berakhir";
            this.tanggalberakhirDataGridViewTextBoxColumn.HeaderText = "tanggal_berakhir";
            this.tanggalberakhirDataGridViewTextBoxColumn.Name = "tanggalberakhirDataGridViewTextBoxColumn";
            // 
            // LihatPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(759, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LihatPromo";
            this.Text = "LihatPromo";
            this.Load += new System.EventHandler(this.LihatPromo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPromoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TokoSembakoDataSet30 tokoSembakoDataSet30;
        private System.Windows.Forms.BindingSource viewPromoBindingSource;
        private TokoSembakoDataSet30TableAdapters.viewPromoTableAdapter viewPromoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpromoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapromoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalmulaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalberakhirDataGridViewTextBoxColumn;
    }
}