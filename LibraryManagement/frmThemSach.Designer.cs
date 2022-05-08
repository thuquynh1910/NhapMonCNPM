namespace LibraryManagement
{
    partial class frmThemSach
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
            this.comboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtLoaiDocGia = new System.Windows.Forms.Label();
            this.boxTenSach = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.Label();
            this.boxTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxTriGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxNamXuatBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.boxNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(13, 9);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(129, 29);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Thêm sách";
            // 
            // comboTheLoai
            // 
            this.comboTheLoai.FormattingEnabled = true;
            this.comboTheLoai.Location = new System.Drawing.Point(351, 196);
            this.comboTheLoai.Name = "comboTheLoai";
            this.comboTheLoai.Size = new System.Drawing.Size(276, 27);
            this.comboTheLoai.TabIndex = 14;
            // 
            // txtLoaiDocGia
            // 
            this.txtLoaiDocGia.AutoSize = true;
            this.txtLoaiDocGia.Location = new System.Drawing.Point(347, 159);
            this.txtLoaiDocGia.Name = "txtLoaiDocGia";
            this.txtLoaiDocGia.Size = new System.Drawing.Size(72, 19);
            this.txtLoaiDocGia.TabIndex = 13;
            this.txtLoaiDocGia.Text = "Thể loại:";
            // 
            // boxTenSach
            // 
            this.boxTenSach.Location = new System.Drawing.Point(18, 99);
            this.boxTenSach.Name = "boxTenSach";
            this.boxTenSach.Size = new System.Drawing.Size(276, 27);
            this.boxTenSach.TabIndex = 12;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.AutoSize = true;
            this.txtHoVaTen.Location = new System.Drawing.Point(14, 62);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(83, 19);
            this.txtHoVaTen.TabIndex = 11;
            this.txtHoVaTen.Text = "Tên sách :";
            // 
            // boxTacGia
            // 
            this.boxTacGia.Location = new System.Drawing.Point(18, 196);
            this.boxTacGia.Name = "boxTacGia";
            this.boxTacGia.Size = new System.Drawing.Size(276, 27);
            this.boxTacGia.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tác giả :";
            // 
            // boxTriGia
            // 
            this.boxTriGia.Location = new System.Drawing.Point(351, 293);
            this.boxTriGia.Name = "boxTriGia";
            this.boxTriGia.Size = new System.Drawing.Size(276, 27);
            this.boxTriGia.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Trị giá :";
            // 
            // boxNamXuatBan
            // 
            this.boxNamXuatBan.Location = new System.Drawing.Point(18, 296);
            this.boxNamXuatBan.Name = "boxNamXuatBan";
            this.boxNamXuatBan.Size = new System.Drawing.Size(276, 27);
            this.boxNamXuatBan.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Năm xuất bản :";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(18, 375);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(608, 44);
            this.btnShow.TabIndex = 21;
            this.btnShow.Text = "Hiển thị sách";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // boxNhaXuatBan
            // 
            this.boxNhaXuatBan.Location = new System.Drawing.Point(351, 99);
            this.boxNhaXuatBan.Name = "boxNhaXuatBan";
            this.boxNhaXuatBan.Size = new System.Drawing.Size(276, 27);
            this.boxNhaXuatBan.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nhà xuất bản  :";
            // 
            // frmThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 447);
            this.Controls.Add(this.boxNhaXuatBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.boxNamXuatBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxTriGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTheLoai);
            this.Controls.Add(this.txtLoaiDocGia);
            this.Controls.Add(this.boxTenSach);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThemSach";
            this.Text = "Thêm sách";
            this.Load += new System.EventHandler(this.frmThemSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.ComboBox comboTheLoai;
        private System.Windows.Forms.Label txtLoaiDocGia;
        private System.Windows.Forms.TextBox boxTenSach;
        private System.Windows.Forms.Label txtHoVaTen;
        private System.Windows.Forms.TextBox boxTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxTriGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNamXuatBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox boxNhaXuatBan;
        private System.Windows.Forms.Label label4;
    }
}