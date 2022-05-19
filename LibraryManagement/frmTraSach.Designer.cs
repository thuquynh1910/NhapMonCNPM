namespace LibraryManagement
{
    partial class frmTraSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboMaPhieu = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.boxMaDocGia = new System.Windows.Forms.Label();
            this.boxMaSach = new System.Windows.Forms.Label();
            this.boxNgayMuon = new System.Windows.Forms.Label();
            this.boxTreHan = new System.Windows.Forms.Label();
            this.boxTienPhat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(91, 24);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(108, 23);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Text = "TRẢ SÁCH";
            this.txtTitle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // comboMaPhieu
            // 
            this.comboMaPhieu.FormattingEnabled = true;
            this.comboMaPhieu.Location = new System.Drawing.Point(13, 97);
            this.comboMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.comboMaPhieu.Name = "comboMaPhieu";
            this.comboMaPhieu.Size = new System.Drawing.Size(310, 24);
            this.comboMaPhieu.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(13, 145);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(310, 44);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Kiểm tra";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã độc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Trễ hạn:";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(16, 411);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(310, 44);
            this.btnTraSach.TabIndex = 23;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // boxMaDocGia
            // 
            this.boxMaDocGia.AutoSize = true;
            this.boxMaDocGia.Location = new System.Drawing.Point(114, 214);
            this.boxMaDocGia.Name = "boxMaDocGia";
            this.boxMaDocGia.Size = new System.Drawing.Size(74, 16);
            this.boxMaDocGia.TabIndex = 24;
            this.boxMaDocGia.Text = "Mã độc giả:";
            this.boxMaDocGia.Click += new System.EventHandler(this.label6_Click);
            // 
            // boxMaSach
            // 
            this.boxMaSach.Location = new System.Drawing.Point(114, 250);
            this.boxMaSach.Name = "boxMaSach";
            this.boxMaSach.Size = new System.Drawing.Size(209, 16);
            this.boxMaSach.TabIndex = 25;
            this.boxMaSach.Text = "Mã sách:";
            // 
            // boxNgayMuon
            // 
            this.boxNgayMuon.Location = new System.Drawing.Point(114, 285);
            this.boxNgayMuon.Name = "boxNgayMuon";
            this.boxNgayMuon.Size = new System.Drawing.Size(209, 16);
            this.boxNgayMuon.TabIndex = 26;
            this.boxNgayMuon.Text = "Mã sách:";
            // 
            // boxTreHan
            // 
            this.boxTreHan.Location = new System.Drawing.Point(114, 316);
            this.boxTreHan.Name = "boxTreHan";
            this.boxTreHan.Size = new System.Drawing.Size(209, 16);
            this.boxTreHan.TabIndex = 27;
            this.boxTreHan.Text = "Mã sách:";
            // 
            // boxTienPhat
            // 
            this.boxTienPhat.Location = new System.Drawing.Point(114, 348);
            this.boxTienPhat.Name = "boxTienPhat";
            this.boxTienPhat.Size = new System.Drawing.Size(209, 16);
            this.boxTienPhat.TabIndex = 29;
            this.boxTienPhat.Text = "Tiền phạt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Số tiền phạt:";
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 467);
            this.Controls.Add(this.boxTienPhat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxTreHan);
            this.Controls.Add(this.boxNgayMuon);
            this.Controls.Add(this.boxMaSach);
            this.Controls.Add(this.boxMaDocGia);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMaPhieu);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraSach";
            this.Text = "frmTraSach";
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMaPhieu;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Label boxMaDocGia;
        private System.Windows.Forms.Label boxMaSach;
        private System.Windows.Forms.Label boxNgayMuon;
        private System.Windows.Forms.Label boxTreHan;
        private System.Windows.Forms.Label boxTienPhat;
        private System.Windows.Forms.Label label7;
    }
}