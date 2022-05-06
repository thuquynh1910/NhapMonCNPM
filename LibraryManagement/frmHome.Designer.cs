
namespace LibraryManagement
{
    partial class frmHome
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
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sideBar.Controls.Add(this.btnHelp);
            this.sideBar.Controls.Add(this.btnLogOut);
            this.sideBar.Controls.Add(this.btnThongKe);
            this.sideBar.Controls.Add(this.txtEmail);
            this.sideBar.Controls.Add(this.txtName);
            this.sideBar.Controls.Add(this.pictureBox1);
            this.sideBar.Controls.Add(this.txtTitle);
            this.sideBar.Controls.Add(this.btnSach);
            this.sideBar.Controls.Add(this.btnDocGia);
            this.sideBar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sideBar.ForeColor = System.Drawing.Color.White;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(300, 810);
            this.sideBar.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(191, 764);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(94, 34);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(13, 764);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(95, 34);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(94, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 16);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "ichimoku.0902@gmail.com";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(93, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 24);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Trần Thu Quỳnh";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(58, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(168, 23);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Quản lý thư viện";
            // 
            // panelContent
            // 
            this.panelContent.ForeColor = System.Drawing.Color.DarkGray;
            this.panelContent.Location = new System.Drawing.Point(306, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1135, 810);
            this.panelContent.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources._186507979_867690547165399_9139087306152454614_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.Gray;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.ForeColor = System.Drawing.Color.White;
            this.btnDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.Location = new System.Drawing.Point(0, 171);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDocGia.Size = new System.Drawing.Size(300, 40);
            this.btnDocGia.TabIndex = 0;
            this.btnDocGia.Text = "Quản lý độc giả";
            this.btnDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Location = new System.Drawing.Point(0, 263);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(300, 40);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSach
            // 
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Location = new System.Drawing.Point(0, 217);
            this.btnSach.Name = "btnSach";
            this.btnSach.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSach.Size = new System.Drawing.Size(300, 40);
            this.btnSach.TabIndex = 1;
            this.btnSach.Text = "Quản lý sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1440, 810);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSach;
    }
}