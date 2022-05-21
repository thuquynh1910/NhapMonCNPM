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
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            // 
            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM THELOAI", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    comboTheLoai.Items.Add(dtbl.Rows[i].ItemArray[0].ToString() + " " + dtbl.Rows[i].ItemArray[1].ToString());
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.boxTenSach.Text.Length > 0 && this.boxTacGia.Text.Length > 0 && this.boxNhaXuatBan.Text.Length > 0 && this.boxTriGia.Text.Length > 0 && this.comboTheLoai.Text.Length > 0)
            {
                sachModel sach = new sachModel(this.boxTenSach.Text, this.comboTheLoai.Text, this.boxTacGia.Text, this.boxNhaXuatBan.Text, int.Parse(this.boxNamXuatBan.Text) , DateTime.Now);
                sach.thuatToan();
                if (sach.khoangCachNamXuatBan >= 8)
                {
                    DialogResult dialogResult = MessageBox.Show("Khoảng cách xuất bản " + sach.khoangCachNamXuatBan + " hợp lệ. Bạn có muốn nhập sách", "Sách", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sach.toDatabse();
                        // var formTheDocGia = new frmTheDocGia(sach);
                        // formTheDocGia.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Khoảng cách xuất bản " + sach.khoangCachNamXuatBan + ", không hợp lệ, phải nhỏ hơn 8 năm. Vui lòng chọn sách khác", "Sách", MessageBoxButtons.OK);
                }

            }
        }
    }
}
