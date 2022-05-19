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
        public int maPhieu { get; set; }
        public int maDocGia { get; set; }
        public int maSach { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime ngayTra { get; set; }


        public phieuMuonSachModel(int _maDocGia, int _maSach)
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
            this.ngayTra = ngayMuon.AddMonths(3);
        }

        public void toDatabse()
        {
            SqlConnection con = new SqlConnection(Program.connect);
            String query = "INSERT INTO PHIEUMUONSACH (MaDocGia, MaSach, NgayMuonSach, NgayTraSach) VALUES ('" + this.maDocGia + "', '" + this.maSach + "', '" + toSqlFormat(this.ngayMuon) + "','" + toSqlFormat(this.ngayTra) + "'); ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            SqlDataAdapter checkId = new SqlDataAdapter("SELECT * FROM PHIEUMUONSACH", con);
            dt = new DataTable();
            checkId.Fill(dt);
            maDocGia = dt.Rows.Count;
        
        }
    }
}
