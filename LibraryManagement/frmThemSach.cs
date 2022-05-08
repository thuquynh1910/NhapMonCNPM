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
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            comboTheLoai.Items.Add("A");
            comboTheLoai.Items.Add("B");
            comboTheLoai.Items.Add("C");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.boxTenSach.Text.Length > 0 && this.boxTacGia.Text.Length > 0 && this.boxNhaXuatBan.Text.Length > 0 && this.boxTriGia.Text.Length > 0 && (this.comboTheLoai.Text == "A" || this.comboTheLoai.Text == "B" || this.comboTheLoai.Text == "C"))
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
