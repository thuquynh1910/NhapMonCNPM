
namespace LibraryManagement
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtLoginResult = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.Label();
            this.boxMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogin.Location = new System.Drawing.Point(545, 358);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(245, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLogin.Controls.Add(this.btnExit);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.txtTitle);
            this.panelLogin.Controls.Add(this.txtLoginResult);
            this.panelLogin.Controls.Add(this.txtMatKhau);
            this.panelLogin.Controls.Add(this.boxMatKhau);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Controls.Add(this.boxEmail);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(290, 140);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(860, 530);
            this.panelLogin.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(540, 112);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(276, 29);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "Đăng nhập để tiếp tục";
            this.txtTitle.Click += new System.EventHandler(this.frmLogin_Load);
            // 
            // txtLoginResult
            // 
            this.txtLoginResult.ForeColor = System.Drawing.Color.Red;
            this.txtLoginResult.Location = new System.Drawing.Point(541, 294);
            this.txtLoginResult.Name = "txtLoginResult";
            this.txtLoginResult.Size = new System.Drawing.Size(249, 61);
            this.txtLoginResult.TabIndex = 6;
            this.txtLoginResult.Text = "loginResult";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoSize = true;
            this.txtMatKhau.Location = new System.Drawing.Point(541, 233);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(79, 19);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.Text = "Mật khẩu:";
            // 
            // boxMatKhau
            // 
            this.boxMatKhau.Location = new System.Drawing.Point(545, 255);
            this.boxMatKhau.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.boxMatKhau.Name = "boxMatKhau";
            this.boxMatKhau.PasswordChar = '*';
            this.boxMatKhau.Size = new System.Drawing.Size(245, 27);
            this.boxMatKhau.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(541, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(54, 19);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email:";
            // 
            // boxEmail
            // 
            this.boxEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.boxEmail.Location = new System.Drawing.Point(545, 186);
            this.boxEmail.MaxLength = 30;
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(245, 27);
            this.boxEmail.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(751, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label txtMatKhau;
        private System.Windows.Forms.TextBox boxMatKhau;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label txtLoginResult;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}