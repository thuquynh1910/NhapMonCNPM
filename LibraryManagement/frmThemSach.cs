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
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOCQ70B;Initial Catalog=QLTV;Integrated Security=True");
            // SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO SACH VALUES ('"+this.boxMaSach.Text + "', '" + this.boxTenSach.Text + "', '" + this.boxMaSach.Text + "', '" + this.boxTacGia.Text + "', '" + this.boxNhaXuatBan.Text + "', " + this.boxNamXuatBan.Text + ", '" + this.dateNgayNhap.Text + "', " + this.boxKhoangCachXuatBan.Text + ", '" + this.boxMaTinhTrang.Text + "')", con);
            String query = "INSERT INTO SACH VALUES (@MaSach, @TenSach, @Matheloai, @TacGia, @NhaXuatBan, @NamXuatBan, @NgayNhap, @KhoangCachXuatBan, @MaTinhTrang)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@MaSach", this.boxMaSach.Text);
            command.Parameters.AddWithValue("@TenSach", this.boxTenSach.Text);
            command.Parameters.AddWithValue("@Matheloai", this.comboMaTheLoai.Text);
            command.Parameters.AddWithValue("@TacGia", this.boxTacGia.Text);
            command.Parameters.AddWithValue("@NhaXuatBan", this.boxNhaXuatBan.Text);
            command.Parameters.AddWithValue("@NamXuatBan", this.boxNamXuatBan.Text);
            command.Parameters.AddWithValue("@NgayNhap", this.dateNgayNhap.Value.Year.ToString() + '-' + this.dateNgayNhap.Value.Month.ToString() + '-' + this.dateNgayNhap.Value.Date.ToString());
            command.Parameters.AddWithValue("@KhoangCachXuatBan", this.boxKhoangCachXuatBan.Text);
            command.Parameters.AddWithValue("@MaTinhTrang", this.boxMaTinhTrang.Text);
            this.label1.Text = command.ToString();
            // command.ExecuteNonQuery();
            // this.Close();
        }
    }
}
