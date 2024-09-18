namespace TokoSembako
{
    partial class LihatHadiah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatHadiah));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tokoSembakoDataSet33 = new TokoSembako.TokoSembakoDataSet33();
            this.viewHadiahMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewHadiahMemberTableAdapter = new TokoSembako.TokoSembakoDataSet33TableAdapters.viewHadiahMemberTableAdapter();
            this.idhadiahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadiahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokhadiahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHadiahMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Location = new System.Drawing.Point(-4, -14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 68);
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
            this.label2.Location = new System.Drawing.Point(196, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 55);
            this.label2.TabIndex = 35;
            this.label2.Text = "Master Hadiah";
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
            this.idhadiahDataGridViewTextBoxColumn,
            this.hadiahDataGridViewTextBoxColumn,
            this.stokhadiahDataGridViewTextBoxColumn,
            this.poinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewHadiahMemberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(644, 243);
            this.dataGridView1.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(643, 321);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tokoSembakoDataSet33
            // 
            this.tokoSembakoDataSet33.DataSetName = "TokoSembakoDataSet33";
            this.tokoSembakoDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewHadiahMemberBindingSource
            // 
            this.viewHadiahMemberBindingSource.DataMember = "viewHadiahMember";
            this.viewHadiahMemberBindingSource.DataSource = this.tokoSembakoDataSet33;
            // 
            // viewHadiahMemberTableAdapter
            // 
            this.viewHadiahMemberTableAdapter.ClearBeforeFill = true;
            // 
            // idhadiahDataGridViewTextBoxColumn
            // 
            this.idhadiahDataGridViewTextBoxColumn.DataPropertyName = "id_hadiah";
            this.idhadiahDataGridViewTextBoxColumn.HeaderText = "id_hadiah";
            this.idhadiahDataGridViewTextBoxColumn.Name = "idhadiahDataGridViewTextBoxColumn";
            // 
            // hadiahDataGridViewTextBoxColumn
            // 
            this.hadiahDataGridViewTextBoxColumn.DataPropertyName = "hadiah";
            this.hadiahDataGridViewTextBoxColumn.HeaderText = "hadiah";
            this.hadiahDataGridViewTextBoxColumn.Name = "hadiahDataGridViewTextBoxColumn";
            // 
            // stokhadiahDataGridViewTextBoxColumn
            // 
            this.stokhadiahDataGridViewTextBoxColumn.DataPropertyName = "stok_hadiah";
            this.stokhadiahDataGridViewTextBoxColumn.HeaderText = "stok_hadiah";
            this.stokhadiahDataGridViewTextBoxColumn.Name = "stokhadiahDataGridViewTextBoxColumn";
            // 
            // poinDataGridViewTextBoxColumn
            // 
            this.poinDataGridViewTextBoxColumn.DataPropertyName = "poin";
            this.poinDataGridViewTextBoxColumn.HeaderText = "poin";
            this.poinDataGridViewTextBoxColumn.Name = "poinDataGridViewTextBoxColumn";
            // 
            // LihatHadiah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(711, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LihatHadiah";
            this.Text = "LihatHadiah";
            this.Load += new System.EventHandler(this.LihatHadiah_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSembakoDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHadiahMemberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TokoSembakoDataSet33 tokoSembakoDataSet33;
        private System.Windows.Forms.BindingSource viewHadiahMemberBindingSource;
        private TokoSembakoDataSet33TableAdapters.viewHadiahMemberTableAdapter viewHadiahMemberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhadiahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadiahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokhadiahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poinDataGridViewTextBoxColumn;
    }
}