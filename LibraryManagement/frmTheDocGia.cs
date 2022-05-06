using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Model;

namespace LibraryManagement
{
    public partial class frmTheDocGia : Form
    {
        public docGiaModel docGia;
        public frmTheDocGia(docGiaModel _docGia)
        {
            docGia = _docGia;
            InitializeComponent();
        }

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            txtDiaChi.Text = docGia.diaChi;
            txtHoVaTen.Text = docGia.hoTen;
            txtMaDocGia.Text = docGia.maDocGia.ToString();
            txtMaLoaiDocGia.Text = docGia.maLoaiDocGia;
            txtNgayHetHan.Text = docGia.toSqlFormat(docGia.ngayHetHan);
            txtNgayLapThe.Text = docGia.toSqlFormat(docGia.ngayLapThe);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.btnPrint.Size = new System.Drawing.Size(0, 0);
            this.btnClose.Size = new System.Drawing.Size(0, 0);
            this.Close();
        }
    }
}
