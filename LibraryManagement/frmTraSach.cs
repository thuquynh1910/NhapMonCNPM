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
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            boxMaDocGia.Text = "";
            boxMaSach.Text = "";
            boxNgayMuon.Text = "";
            boxTreHan.Text = "";
            boxTienPhat.Text = "";
            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT [MaPhieu] FROM PHIEUMUONSACH WHERE NgayTraSach IS NULL", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // comboMaDocGia.Controls.Add();
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    comboMaPhieu.Items.Add(dtbl.Rows[i].ItemArray[0].ToString());
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {   
            if (comboMaPhieu.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã phiếu", "", MessageBoxButtons.OK);
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(Program.connect))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PHIEUMUONSACH WHERE MaPhieu = '" + comboMaPhieu.Text +"'", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    if (dtbl.Rows[0].ItemArray[4] == null)
                    {
                        MessageBox.Show("Phiếu đã trả sách", "", MessageBoxButtons.OK); 
                        btnTraSach.Enabled = false;
                    }
                    else
                    {
                        boxMaDocGia.Text = dtbl.Rows[0].ItemArray[1].ToString();
                        boxMaSach.Text = dtbl.Rows[0].ItemArray[2].ToString();
                        boxNgayMuon.Text = dtbl.Rows[0].ItemArray[3].ToString();
                        TimeSpan han = DateTime.Now.Subtract(DateTime.Parse(dtbl.Rows[0].ItemArray[3].ToString()));
                        if (han.Days  < 90)
                        {
                            boxTreHan.Text = "0";
                        }
                        else
                        {
                            boxTreHan.Text = (han.Days - 90).ToString();
                            boxTienPhat.Text = ((han.Days - 90 )*1000).ToString(); ;
                        }
                    }
                }
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(Program.connect);
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("UPDATE PHIEUMUONSACH SET PHIEUMUONSACH.NgayTraSach = GETDATE() WHERE PHIEUMUONSACH.MaPhieu = '" + comboMaPhieu.Text + "'   UPDATE SACH SET SACH.MaTinhTrang = 'TT0003' WHERE SACH.MaSach = '"+ this.boxMaSach.Text +"'", sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            if (this.boxTreHan.Text == "0")
            {
                MessageBox.Show("Đã trả sách", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Độc giả nợ " + this.boxTienPhat.Text , "", MessageBoxButtons.OK);
            }
        }
    }
}
