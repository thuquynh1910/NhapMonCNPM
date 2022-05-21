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
using LibraryManagement.Model;

namespace LibraryManagement
{
    public partial class frmChoMuonSach : Form
    {
        int soSachMuonToiDa = 0;
        int ngayMuonToiDa = 0;
        public frmChoMuonSach()
        {
            InitializeComponent();
        }

        private void frmChoMuonSach_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM QDMUONTRA", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                soSachMuonToiDa = int.Parse(dtbl.Rows[0].ItemArray[0].ToString()) ;
                ngayMuonToiDa = int.Parse(dtbl.Rows[0].ItemArray[1].ToString());
                txtSoNgay.Text = "Trong " + ngayMuonToiDa + " ngày";
                txtSoSach.Text += soSachMuonToiDa;
            }



            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT [MaSach] FROM QUANLYSACH.dbo.SACH WHERE MaTinhTrang = 'TT0003'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // comboMaDocGia.Controls.Add();
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    comboSach.Items.Add(dtbl.Rows[i].ItemArray[0].ToString());
                }
            }

            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(@"SELECT [MaDocGia] FROM
(
SELECT DG.MaDocGia, DG.HoTen, DG.NgaySinh, DG.DiaChi, DG.Email, DG.NgayLapThe, LDG.TenLoaiDocGia, CASE WHEN SDM.SoSachDaMuon IS NULL THEN 0 ELSE SDM.SoSachDaMuon END AS SoSachDaMuon
FROM(
    DOCGIA DG LEFT JOIN(
            SELECT DG.MaDocGia, COUNT(DG.MaDocGia) AS 'SoSachDaMuon'

            FROM DOCGIA DG INNER JOIN PHIEUMUONSACH PMS

            ON DG.MaDocGia = PMS.MaDocGia

            WHERE PMS.NgayTraSach IS NULL AND PMS.NgayMuonSach > dateadd(day, -"+ ngayMuonToiDa.ToString() +@", getdate())

            GROUP BY DG.MaDocGia) SDM

    ON DG.MaDocGia = SDM.MaDocGia
)
INNER JOIN LOAIDOCGIA LDG
ON DG.MaLoaiDocGia = LDG.MaLoaiDocGia) AS BG
WHERE SoSachDaMuon < " + soSachMuonToiDa.ToString(), sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // comboMaDocGia.Controls.Add();
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    comboMaDocGia.Items.Add(dtbl.Rows[i].ItemArray[0].ToString());
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.comboMaDocGia.Text.Length > 0 && this.comboSach.Text.Length > 0 )
            {
                phieuMuonSachModel phieuMuonSach = new phieuMuonSachModel(comboMaDocGia.Text , comboSach.Text);
                phieuMuonSach.thuatToan();
                phieuMuonSach.toDatabse();
                //if (docGia.tuoiDocGia >= 18 && docGia.tuoiDocGia <= 55)
                //{
                //    DialogResult dialogResult = MessageBox.Show("Tuổi độc giả là " + docGia.tuoiDocGia.ToString() + " hợp lệ. Ngày hết hạn là " + docGia.toSqlFormat(docGia.ngayHetHan) + ". Bạn có muốn in thẻ", "Độc giả", MessageBoxButtons.YesNo);
                //    if (dialogResult == DialogResult.Yes)
                //    {
                //        docGia.toDatabse();
                //        var formTheDocGia = new frmTheDocGia(docGia);
                //        formTheDocGia.Show();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Tuổi độc giả là " + docGia.tuoiDocGia.ToString() + ", không hợp lệ, tuổi độc giả phải từ 18 đến 55. Vui lòng nhập lại", "Độc giả", MessageBoxButtons.OK);
                //}

            }
            MessageBox.Show("Cho mượn sách thành công", "Cho mượn sách", MessageBoxButtons.OK);
        }
    }
}
