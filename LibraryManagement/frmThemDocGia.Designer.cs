
namespace LibraryManagement
{
    partial class frmThemDocGia
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
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.Label();
            this.boxHoVaTen = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtLoaiDocGia = new System.Windows.Forms.Label();
            this.txtNgayLapThe = new System.Windows.Forms.Label();
            this.comboLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.dateNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.boxDiaChi = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(13, 9);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(158, 29);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Thêm độc giả";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.AutoSize = true;
            this.txtHoVaTen.Location = new System.Drawing.Point(14, 63);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(88, 19);
            this.txtHoVaTen.TabIndex = 2;
            this.txtHoVaTen.Text = "Họ và Tên:";
            // 
            // boxHoVaTen
            // 
            this.boxHoVaTen.Location = new System.Drawing.Point(18, 100);
            this.boxHoVaTen.Name = "boxHoVaTen";
            this.boxHoVaTen.Size = new System.Drawing.Size(276, 27);
            this.boxHoVaTen.TabIndex = 3;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(18, 197);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(608, 27);
            this.boxEmail.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(17, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(107, 19);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Địa chỉ Email:";
            // 
            // txtLoaiDocGia
            // 
            this.txtLoaiDocGia.AutoSize = true;
            this.txtLoaiDocGia.Location = new System.Drawing.Point(346, 63);
            this.txtLoaiDocGia.Name = "txtLoaiDocGia";
            this.txtLoaiDocGia.Size = new System.Drawing.Size(100, 19);
            this.txtLoaiDocGia.TabIndex = 6;
            this.txtLoaiDocGia.Text = "Loại độc giả:";
            // 
            // txtNgayLapThe
            // 
            this.txtNgayLapThe.AutoSize = true;
            this.txtNgayLapThe.Location = new System.Drawing.Point(346, 252);
            this.txtNgayLapThe.Name = "txtNgayLapThe";
            this.txtNgayLapThe.Size = new System.Drawing.Size(104, 19);
            this.txtNgayLapThe.TabIndex = 8;
            this.txtNgayLapThe.Text = "Ngày lập thẻ:";
            // 
            // comboLoaiDocGia
            // 
            this.comboLoaiDocGia.FormattingEnabled = true;
            this.comboLoaiDocGia.Location = new System.Drawing.Point(350, 100);
            this.comboLoaiDocGia.Name = "comboLoaiDocGia";
            this.comboLoaiDocGia.Size = new System.Drawing.Size(276, 27);
            this.comboLoaiDocGia.TabIndex = 10;
            // 
            // dateNgayLapThe
            // 
            this.dateNgayLapThe.Enabled = false;
            this.dateNgayLapThe.Location = new System.Drawing.Point(350, 289);
            this.dateNgayLapThe.Name = "dateNgayLapThe";
            this.dateNgayLapThe.Size = new System.Drawing.Size(276, 27);
            this.dateNgayLapThe.TabIndex = 11;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Location = new System.Drawing.Point(21, 289);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(276, 27);
            this.dateNgaySinh.TabIndex = 13;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Location = new System.Drawing.Point(17, 252);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(85, 19);
            this.txtNgaySinh.TabIndex = 12;
            this.txtNgaySinh.Text = "Ngày sinh:";
            // 
            // boxDiaChi
            // 
            this.boxDiaChi.Location = new System.Drawing.Point(18, 379);
            this.boxDiaChi.Multiline = true;
            this.boxDiaChi.Name = "boxDiaChi";
            this.boxDiaChi.Size = new System.Drawing.Size(608, 116);
            this.boxDiaChi.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(17, 344);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(63, 19);
            this.txtDiaChi.TabIndex = 14;
            this.txtDiaChi.Text = "Địa chỉ:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(18, 547);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(608, 44);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "Hiển thị thẻ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmThemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 622);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.boxDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.dateNgayLapThe);
            this.Controls.Add(this.comboLoaiDocGia);
            this.Controls.Add(this.txtNgayLapThe);
            this.Controls.Add(this.txtLoaiDocGia);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.boxHoVaTen);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemDocGia";
            this.Text = "frmThemDocGia";
            this.Load += new System.EventHandler(this.frmThemDocGia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtHoVaTen;
        private System.Windows.Forms.TextBox boxHoVaTen;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtLoaiDocGia;
        private System.Windows.Forms.Label txtNgayLapThe;
        private System.Windows.Forms.ComboBox comboLoaiDocGia;
        private System.Windows.Forms.DateTimePicker dateNgayLapThe;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.TextBox boxDiaChi;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Button btnShow;
    }
}