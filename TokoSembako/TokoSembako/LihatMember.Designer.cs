namespace TokoSembako
{
    partial class LihatMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatMember));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tokoSembakoDataSet29 = new TokoSembako.TokoSembakoDataSet29();
            this.viewMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewMemberTableAdapter = new TokoSembako.TokoSembakoDataSet29TableAdapters.viewMemberTableAdapter();
            this.idmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Location = new System.Drawing.Point(-4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 68);
            this.panel2.TabIndex = 60;
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
            this.label2.Location = new System.Drawing.Point(264, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 55);
            this.label2.TabIndex = 35;
            this.label2.Text = "Master Member";
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
            this.idmemberDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn,
            this.poinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewMemberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(784, 243);
            this.dataGridView1.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(784, 341);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tokoSembakoDataSet29
            // 
            this.tokoSembakoDataSet29.DataSetName = "TokoSembakoDataSet29";
            this.tokoSembakoDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewMemberBindingSource
            // 
            this.viewMemberBindingSource.DataMember = "viewMember";
            this.viewMemberBindingSource.DataSource = this.tokoSembakoDataSet29;
            // 
            // viewMemberTableAdapter
            // 
            this.viewMemberTableAdapter.ClearBeforeFill = true;
            // 
            // idmemberDataGridViewTextBoxColumn
            // 
            this.idmemberDataGridViewTextBoxColumn.DataPropertyName = "id_member";
            this.idmemberDataGridViewTextBoxColumn.HeaderText = "id_member";
            this.idmemberDataGridViewTextBoxColumn.Name = "idmemberDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "Jeniskelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "Jeniskelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "noTelp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "noTelp";
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            // 
            // poinDataGridViewTextBoxColumn
            // 
            this.poinDataGridViewTextBoxColumn.DataPropertyName = "poin";
            this.poinDataGridViewTextBoxColumn.HeaderText = "poin";
            this.poinDataGridViewTextBoxColumn.Name = "poinDataGridViewTextBoxColumn";
            // 
            // LihatMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(867, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LihatMember";
            this.Text = "LihatMember";
            this.Load += new System.EventHandler(this.LihatMember_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMemberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TokoSembakoDataSet29 tokoSembakoDataSet29;
        private System.Windows.Forms.BindingSource viewMemberBindingSource;
        private TokoSembakoDataSet29TableAdapters.viewMemberTableAdapter viewMemberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poinDataGridViewTextBoxColumn;
    }
}