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
    public partial class frmQuyDinh : Form
    {
        int soSachMuonToiDa = 0;
        int ngayMuonToiDa = 0;
        int tuoiToiThieu = 0;
        int tuoiToiDa = 0;
        int soNgayMuon = 0;

        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            loadQuyDinhMuonTra();
            loadQuyDinhDocGia();
        }

        private void loadQuyDinhMuonTra()
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM QDMUONTRA", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                soSachMuonToiDa = int.Parse(dtbl.Rows[0].ItemArray[0].ToString());
                ngayMuonToiDa = int.Parse(dtbl.Rows[0].ItemArray[1].ToString());
                boxSoNgayMuon.Text = ngayMuonToiDa.ToString();
                boxSoSachMuon.Text = soSachMuonToiDa.ToString();
                // boxSa.Text = "Trong " + ngayMuonToiDa + " ngày";
                // txtSoSach.Text += soSachMuonToiDa;
            }
        }

        private void loadQuyDinhDocGia()
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM QDTHEDOCGIA", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                tuoiToiThieu = int.Parse(dtbl.Rows[0].ItemArray[0].ToString());
                tuoiToiDa = int.Parse(dtbl.Rows[0].ItemArray[1].ToString());
                soNgayMuon = int.Parse(dtbl.Rows[0].ItemArray[2].ToString());
                boxTuoiToiThieu.Text = tuoiToiThieu.ToString();
                boxTuoiToiDa.Text = tuoiToiDa.ToString();
                boxThoiGianSuDung.Text = soNgayMuon.ToString();
                // boxSa.Text = "Trong " + ngayMuonToiDa + " ngày";
                // txtSoSach.Text += soSachMuonToiDa;
            }
        }

        private void btnLoadDG_Click(object sender, EventArgs e)
        {
            loadQuyDinhDocGia();
        }

        private void btnLoadMT_Click(object sender, EventArgs e)
        {
            loadQuyDinhMuonTra();
        }

        private void btnUpdateMT_Click(object sender, EventArgs e)
        {
            if (boxSoNgayMuon.Text.Length > 0 && boxSoSachMuon.Text.Length > 0)
                using (SqlConnection sqlCon = new SqlConnection(Program.connect))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(@"
                        DELETE FROM QDMUONTRA
                        INSERT INTO QUANLYSACH.dbo.QDMUONTRA(SoSachMuonToiDa, NgayMuonToiDa) 
                        VALUES (" + boxSoSachMuon.Text + ", " + boxSoNgayMuon.Text + ");", 
                        sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    DialogResult dialogResult = MessageBox.Show("Cập nhật quy định độc giả thành công!", "Cập nhật", MessageBoxButtons.OK);
                }
        }

        private void btnUpdateDG_Click(object sender, EventArgs e)
        {
            if (boxTuoiToiThieu.Text.Length > 0 && boxSoSachMuon.Text.Length > 0 && boxThoiGianSuDung.Text.Length > 0)
                using (SqlConnection sqlCon = new SqlConnection(Program.connect))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(@"
                        DELETE FROM QDTHEDOCGIA
                        INSERT INTO QUANLYSACH.dbo.QDTHEDOCGIA(TuoiToiThieu, TuoiToiDa, ThoiGianSuDung) 
                        VALUES (" + boxTuoiToiThieu.Text + ", " + boxTuoiToiDa.Text + ", "+ boxThoiGianSuDung.Text + ");",
                        sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    DialogResult dialogResult = MessageBox.Show("Cập nhật quy định độc giả thành công!", "Cập nhật", MessageBoxButtons.OK);
                }
        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            if (boxThemTheLoai.Text.Length > 0)
            {
                using (SqlConnection sqlCon = new SqlConnection(Program.connect))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(@"
                        INSERT INTO THELOAI (TenTheLoai) VALUES ('"+ boxThemTheLoai.Text + @"');
                        ",
                        sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    DialogResult dialogResult = MessageBox.Show("Thêm thể loại thành công!", "Cập nhật", MessageBoxButtons.OK);
                }
                boxThemTheLoai.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thể loại", "Cập nhật", MessageBoxButtons.OK);
            }
        }
    }
}
