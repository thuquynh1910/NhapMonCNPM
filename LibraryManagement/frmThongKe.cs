using System;
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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnLoadTheLoai_Click(object sender, EventArgs e)
        {
            if (boxNamTheLoai.Text.Length > 0 && boxThangTheLoai.Text.Length > 0)
            {
                String sqlString = @"
                    SELECT TL.TenTheLoai, GR.SoLuotMuon ,  GR.SoSachDaTra
                    FROM (
                    SELECT S.MaTheLoai, COUNT(S.MaTheLoai) AS SoLuotMuon, COUNT(PMS.NgayTraSach) AS SoSachDaTra
                    FROM SACH S INNER JOIN PHIEUMUONSACH PMS
                    ON S.MaSach = PMS.MaSach 
                    WHERE MONTH(PMS.NgayMuonSach) = " + boxThangTheLoai.Text + @" AND YEAR(PMS.NgayMuonSach) = " + boxNamTheLoai.Text + @"
                    GROUP BY S.MaTheLoai 
                    ) GR INNER JOIN THELOAI TL
                    ON GR.MaTheLoai = TL.MaTheLoai
                ";

                using (SqlConnection sqlCon = new SqlConnection(Program.connect))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlString, sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // comboMaDocGia.Controls.Add();
                    dataGridView1.DataSource = dtbl;

                    dataGridView1.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
                    dataGridView1.Columns["SoLuotMuon"].HeaderText = "Số lượt mươn";
                    dataGridView1.Columns["SoSachDaTra"].HeaderText = "Tỉ lệ trả (%)";

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * 1.0 / int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) * 100).ToString();
                    }
                }

                MessageBox.Show("Tải dữ liệu thành công", "Thống kê", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tháng năm", "Thống kê", MessageBoxButtons.OK);
            }

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadTraTre_Click(object sender, EventArgs e)
        {
            if (boxNamTre.Text.Length > 0 && boxThangTre.Text.Length > 0)
            {
                String sqlString = @"
                    SELECT S.TenSach , PMS.NgayMuonSach, DATEDIFF(day, PMS.NgayTraSach, PMS.NgayMuonSach) - 90 AS SoNgayTraTre
                    FROM SACH S INNER JOIN PHIEUMUONSACH PMS
                    ON S.MaSach = PMS.MaSach 
                    WHERE MONTH(PMS.NgayMuonSach) = " + boxThangTre.Text + @" AND YEAR(PMS.NgayMuonSach) = " + boxNamTre.Text + @" AND PMS.NgayMuonSach IS NOT NULL
                ";

                using (SqlConnection sqlCon = new SqlConnection(Program.connect))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlString, sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // comboMaDocGia.Controls.Add();
                    dataGridView2.DataSource = dtbl;

                    dataGridView2.Columns["TenSach"].HeaderText = "Tên sách";
                    dataGridView2.Columns["NgayMuonSach"].HeaderText = "Ngày mươn";
                    dataGridView2.Columns["SoNgayTraTre"].HeaderText = "Số ngày trả trễ";

                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        if (dataGridView2.Rows[i].Cells["SoNgayTraTre"].Value.ToString() == "")
                        {
                            dataGridView2.Rows[i].Cells["SoNgayTraTre"].Value = "0";
                        } else if (int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()) < 0)
                        {
                            dataGridView2.Rows[i].Cells["SoNgayTraTre"].Value = "0";
                        } 

                        
                    }
                }

                MessageBox.Show("Tải dữ liệu thành công", "Thống kê", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tháng năm", "Thống kê", MessageBoxButtons.OK);
            }
        }
    }
}
