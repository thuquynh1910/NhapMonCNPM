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
    public partial class frmQuanLySach : Form
    {
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            Form fromThemSach = new frmThemSach();
            fromThemSach.Show();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            loadSach();
        }

        private void loadSach()
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM QUANLYSACH.dbo.SACH ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

                dataGridView1.Columns["MaSach"].HeaderText = "Mã sách";
                dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
                dataGridView1.Columns["NhaXuatBan"].HeaderText = "Nhà xuất bản";
                dataGridView1.Columns["MaTheLoai"].HeaderText = "Mã thể loại";
                dataGridView1.Columns["TacGia"].HeaderText = "Tác giả";
                dataGridView1.Columns["NamXuatBan"].HeaderText = "Năm xuất bản";
                dataGridView1.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                dataGridView1.Columns["KhoangCachXuatBan"].HeaderText = "Khoảng cách xuất bản";
                dataGridView1.Columns["MaTinhTrang"].HeaderText = "Mã tình trạng";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = boxSearch.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if ((dataGridView1.Rows[i].Cells[0].Value.ToString() + (dataGridView1.Rows[i].Cells[1].Value.ToString())  + (dataGridView1.Rows[i].Cells[2].Value.ToString()) + (dataGridView1.Rows[i].Cells[3].Value.ToString()) + (dataGridView1.Rows[i].Cells[4].Value.ToString()) + (dataGridView1.Rows[i].Cells[5].Value.ToString())).ToLower().Contains(searchValue.ToLower()))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            loadSach();
        }
    }
}
