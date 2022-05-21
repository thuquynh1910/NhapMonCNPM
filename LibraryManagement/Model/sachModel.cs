using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//CREATE TABLE SACH
//(
// MaSach int NOT NULL IDENTITY(1, 1),
// TenSach nvarchar(30),
// Matheloai char(1),
// TacGia nvarchar(50),
// NhaXuatBan nvarchar(100),
// NamXuatBan int,
// NgayNhap datetime,
// KhoangCachXuatBan int,
// MaTinhTrang char(1)
// )

namespace LibraryManagement.Model
{
    public partial class sachModel
    {
        public String maSach { get; set; }
        public String tenSach { get; set; }
        public String maTheLoai { get; set; }
        public String tacGia { get; set; }
        public String nhaXuatBan { get; set; }
        public int namXuatBan { get; set; }
        public DateTime ngayNhap { get; set; }  
        public String maTinhTrang { get; set; }
        public int khoangCachNamXuatBan { get; set; }


        public sachModel(String _tenSach, String _maTheLoai, String _tacGia, String _nhaXuatBan, int _namXuatBan, DateTime _ngayNhap)
        {
            tenSach = _tenSach;
            maTheLoai = _maTheLoai;
            tacGia = _tacGia;
            nhaXuatBan = _nhaXuatBan;
            namXuatBan = _namXuatBan;
            ngayNhap = _ngayNhap;
        }


        public String toSqlFormat(DateTime date)
        {
            return date.Year.ToString() + '-' + date.Month.ToString() + '-' + date.Day.ToString();
        }

        public void thuatToan()
        {
            this.khoangCachNamXuatBan = ngayNhap.Subtract(new DateTime(this.namXuatBan)).Days / 365;
            if (khoangCachNamXuatBan <= 8) maTinhTrang = "T";
            else maTinhTrang = "F";
        }

        public void toDatabse()
        {
            SqlConnection con = new SqlConnection(Program.connect);
            String query = "INSERT INTO QUANLYSACH.dbo.SACH (TenSach, Matheloai, TacGia, NhaXuatBan, NamXuatBan, NgayNhap, KhoangCachXuatBan, MaTinhTrang) OUTPUT INSERTED.MaSach VALUES (N'" + tenSach+"'  ," + maTheLoai.Substring(0, 6) + ",N'" +tacGia+"',N'"+nhaXuatBan+"',"+namXuatBan+",'"+ngayNhap+"',"+khoangCachNamXuatBan+",'"+maTinhTrang+"');";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            maSach = dt.Rows[0].ItemArray[0].ToString();
        }
    }
}
