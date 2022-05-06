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
    public partial class frmHome : Form
    {
        public static Form formQuanLyDocGia = new frmQuanLyDocGia();
        public static Form formQuanLySach = new frmQuanLySach();
        public static Form formThongKe = new frmThongKe();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.sideBar.BackColor = Color.FromArgb(40, 51, 66);
            this.txtEmail.ForeColor = Color.FromArgb(254, 214, 0);

            // init form Quan Ly Doc Gia
            formQuanLyDocGia.TopLevel = false;
            formQuanLyDocGia.AutoScroll = true;

            // init form Quan Ly Sach
            formQuanLySach.TopLevel = false;
            formQuanLySach.AutoScroll = true;

            // init form Thong Ke
            formThongKe.TopLevel = false;
            formThongKe.AutoScroll = true;


            setButtonQuanLyDocGia();
        }

        private void setButtonQuanLyDocGia()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(formQuanLyDocGia);
            formQuanLyDocGia.Show();

            this.btnSach.BackColor = Color.FromArgb(40, 51, 66);
            this.btnDocGia.BackColor = Color.FromArgb(0, 144, 153);
            this.btnThongKe.BackColor = Color.FromArgb(40, 51, 66);
        }

        private void setButtonQuanLySach()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(formQuanLySach);
            formQuanLySach.Show();

            this.btnSach.BackColor = Color.FromArgb(0, 144, 153);
            this.btnDocGia.BackColor = Color.FromArgb(40, 51, 66);
            this.btnThongKe.BackColor = Color.FromArgb(40, 51, 66);
        }

        private void setButtonThongKe()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(formThongKe);
            formThongKe.Show();

            this.btnSach.BackColor = Color.FromArgb(40, 51, 66);
            this.btnDocGia.BackColor = Color.FromArgb(40, 51, 66);
            this.btnThongKe.BackColor = Color.FromArgb(0, 144, 153);
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            setButtonQuanLyDocGia();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            setButtonQuanLySach();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            setButtonThongKe();
        }



    }
}
