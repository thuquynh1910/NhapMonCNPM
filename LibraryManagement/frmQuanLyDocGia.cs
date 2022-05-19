﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class frmQuanLyDocGia : Form
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            var formThemDocGia = new frmThemDocGia();
            formThemDocGia.ShowDialog();
        }

        private void loadDocGia()
        {
            using (SqlConnection sqlCon  = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT DG.MaDocGia, DG.HoTen, DG.NgaySinh, DG.DiaChi, DG.Email, DG.NgayLapThe, DG.MaLoaiDocGia, LDG.TenLoaiDocGia FROM DOCGIA DG INNER JOIN LOAIDOCGIA LDG ON DG.MaLoaiDocGia = LDG.MaLoaiDocGia ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

                dataGridView1.Columns["MaDocGia"].HeaderText = "Mã độc giả";
                dataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
                dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["NgayLapThe"].HeaderText = "Ngày lập thẻ";
                dataGridView1.Columns["TenLoaiDocGia"].HeaderText = "Tên loại độc giả";
            }
        }

        private void frmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            loadDocGia();
        }

        private void btnChoMuonSach_Click(object sender, EventArgs e)
        {
            var formChoMuonSach = new frmChoMuonSach();
            formChoMuonSach.ShowDialog();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            loadDocGia();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            var formTraSach = new frmTraSach();
            formTraSach.ShowDialog();
        }
    }
}
