using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.Model
{
    public partial class docGiaModel
    {
        public String maDocGia  { get; set; }
        public String hoTen { get; set; }
        public String diaChi { get; set; }
        public String email { get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayLapThe { get; set; }
        public String maLoaiDocGia { get; set; }
        public int tuoiDocGia { get; set; }


        public docGiaModel(String _hoTen, String _diaChi, String _email, DateTime _ngayLapThe, DateTime _ngaySinh, String _maLoaDocGia)
        {
            hoTen = _hoTen;
            diaChi = _diaChi;
            email = _email;
            ngayLapThe = _ngayLapThe;
            ngaySinh = _ngaySinh;
            maLoaiDocGia = _maLoaDocGia;
        }
            

        public String toSqlFormat(DateTime date)
        {
            return date.Year.ToString() + '-' + date.Month.ToString() + '-' + date.Day.ToString();
        }

        public void thuatToan()
        {
            this.tuoiDocGia = ngayLapThe.Subtract(ngaySinh).Days / 365;
        }

        public void toDatabse()
        {
            SqlConnection con = new SqlConnection(Program.connect);
            String query = "INSERT INTO DOCGIA (HoTen, NgaySinh, DiaChi, email, NgayLapThe, MaLoaiDocGia) OUTPUT INSERTED.MaDocGia VALUES(N'" + this.hoTen + "', '" + this.toSqlFormat(this.ngaySinh) + "'  ,N'" + this.diaChi + "','" + this.email + "','" + this.toSqlFormat(this.ngayLapThe) + "' ,'" + this.maLoaiDocGia + "'); ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            SqlDataAdapter checkId = new SqlDataAdapter("SELECT * FROM QUANLYSACH.dbo.DOCGIA", con);
            dt = new DataTable();
            checkId.Fill(dt);
            maDocGia = dt.Rows[0].ItemArray[0].ToString();
        }
    }
}
