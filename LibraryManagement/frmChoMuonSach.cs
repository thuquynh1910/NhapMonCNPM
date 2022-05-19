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
        public frmChoMuonSach()
        {
            InitializeComponent();
        }

        private void frmChoMuonSach_Load(object sender, EventArgs e)
        {
            

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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT MaDocGia FROM DOCGIA", sqlCon);
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
