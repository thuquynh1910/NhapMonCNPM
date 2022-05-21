namespace LibraryManagement
{
    partial class frmChoMuonSach
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
            this.comboMaDocGia = new System.Windows.Forms.ComboBox();
            this.comboSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoSach = new System.Windows.Forms.Label();
            this.txtSoNgay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboMaDocGia
            // 
            this.comboMaDocGia.FormattingEnabled = true;
            this.comboMaDocGia.Location = new System.Drawing.Point(15, 207);
            this.comboMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.comboMaDocGia.Name = "comboMaDocGia";
            this.comboMaDocGia.Size = new System.Drawing.Size(310, 24);
            this.comboMaDocGia.TabIndex = 0;
            // 
            // comboSach
            // 
            this.comboSach.FormattingEnabled = true;
            this.comboSach.Location = new System.Drawing.Point(15, 282);
            this.comboSach.Margin = new System.Windows.Forms.Padding(4);
            this.comboSach.Name = "comboSach";
            this.comboSach.Size = new System.Drawing.Size(310, 24);
            this.comboSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã độc giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sách:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 340);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(310, 44);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Hiển thị phiếu";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "CHO MƯỢN SÁCH";
            this.label3.Visible = false;
            // 
            // txtSoSach
            // 
            this.txtSoSach.AutoSize = true;
            this.txtSoSach.Location = new System.Drawing.Point(15, 60);
            this.txtSoSach.Name = "txtSoSach";
            this.txtSoSach.Size = new System.Drawing.Size(175, 16);
            this.txtSoSach.TabIndex = 19;
            this.txtSoSach.Text = "Số sách được mượn tối đa là ";
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.AutoSize = true;
            this.txtSoNgay.Location = new System.Drawing.Point(15, 80);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(80, 16);
            this.txtSoNgay.TabIndex = 20;
            this.txtSoNgay.Text = "Trong  ngày ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 48);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bạn chỉ có thể chọn những sách chưa cho mượn và những độc giả mượn ít hơn số sách" +
    " quy định, và cọn hạn thẻ";
            // 
            // frmChoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.txtSoSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSach);
            this.Controls.Add(this.comboMaDocGia);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChoMuonSach";
            this.Text = "Cho mượn sách";
            this.Load += new System.EventHandler(this.frmChoMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMaDocGia;
        private System.Windows.Forms.ComboBox comboSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSoSach;
        private System.Windows.Forms.Label txtSoNgay;
        private System.Windows.Forms.Label label4;
    }
}