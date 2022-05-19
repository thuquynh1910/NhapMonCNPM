namespace LibraryManagement
{
    partial class frmQuanLyDocGia
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
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChoMuonSach = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(971, 13);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(152, 28);
            this.btnThemDocGia.TabIndex = 0;
            this.btnThemDocGia.Text = "Thêm Độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1111, 751);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnChoMuonSach
            // 
            this.btnChoMuonSach.Location = new System.Drawing.Point(813, 12);
            this.btnChoMuonSach.Name = "btnChoMuonSach";
            this.btnChoMuonSach.Size = new System.Drawing.Size(152, 28);
            this.btnChoMuonSach.TabIndex = 2;
            this.btnChoMuonSach.Text = "Cho mượn sách";
            this.btnChoMuonSach.UseVisualStyleBackColor = true;
            this.btnChoMuonSach.Click += new System.EventHandler(this.btnChoMuonSach_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(701, 12);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(106, 28);
            this.btnTaiLai.TabIndex = 3;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 810);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnChoMuonSach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThemDocGia);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyDocGia";
            this.Text = "frmQuanLyDocGia";
            this.Load += new System.EventHandler(this.frmQuanLyDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChoMuonSach;
        private System.Windows.Forms.Button btnTaiLai;
    }
}