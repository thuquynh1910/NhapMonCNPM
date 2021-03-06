using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.txtLoginResult.Text = "Loading...";
            bool loginResult = frmMain.login(this.boxEmail.Text, this.boxMatKhau.Text);
            if (!loginResult)
            {
                this.txtLoginResult.Text = "Bạn đã nhập sai tài khoản mật khẩu, mời nhập lại";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtLoginResult.Text = "";
            this.BackColor = Color.FromArgb(244, 249, 255);
            this.panelLogin.BackColor = Color.White;
            this.btnLogin.BackColor = Color.FromArgb(5, 117, 230);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát app?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
