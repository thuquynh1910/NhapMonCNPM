using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagement.Model
{
    internal class phieuMuonSachModel
    {
        public String maPhieu { get; set; }
        public String maDocGia { get; set; }
        public String maSach { get; set; }

        public int tinhTrang { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime ngayTra { get; set; }


        public phieuMuonSachModel(String _maDocGia, String _maSach)
        {
            maDocGia = _maDocGia;   
            maSach = _maSach;   
            ngayMuon = DateTime.Now;    
        }


        public String toSqlFormat(DateTime date)
        {
            return date.Year.ToString() + '-' + date.Month.ToString() + '-' + date.Day.ToString();
        }

        public void thuatToan()
        {
            // 
        }

        public void toDatabse()
        {
            SqlConnection con = new SqlConnection(Program.connect);
            String query = "INSERT INTO PHIEUMUONSACH (MaDocGia, MaSach, NgayMuonSach)  OUTPUT INSERTED.MaDocGia VALUES ('" + this.maDocGia + "', '" + this.maSach + "', '" + toSqlFormat(this.ngayMuon) + "');    UPDATE SACH SET SACH.MaTinhTrang = 'TT0002' WHERE SACH.MaSach = '"+this.maSach+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            maDocGia = dt.Rows[0].ItemArray[0].ToString();
        
        }
    }
}
