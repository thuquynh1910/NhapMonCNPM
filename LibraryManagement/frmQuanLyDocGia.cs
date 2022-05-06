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
    public partial class frmQuanLyDocGia : Form
    {

        String connect = @"Data Source=DESKTOP-UK1PH6M;Initial Catalog=QUANLYSACH;Integrated Security=True";
        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            Form fromThemDocGia = new frmThemDocGia();
            fromThemDocGia.Show();
        }

        private void frmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection sqlCon = new SqlConnection(connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM QUANLYSACH.dbo.DOCGIA", sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataDocGia.DataSource = dataTable;
                dataDocGia.Columns["MaDocGia"].HeaderText = "Mã độc giả";
                dataDocGia.Columns["HoTen"].HeaderText = "Họ và tên";
                dataDocGia.Columns["email"].HeaderText = "Email";
                dataDocGia.Columns["NgayLapThe"].HeaderText = "Ngày lập thẻ";
                dataDocGia.Columns["MaLoaiDocGia"].HeaderText = "Mã loại độc giả";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (boxSearch.Text.Length > 0)
            {
                String searchValue = boxSearch.Text;  
                int rowIndex = 0;
                try
                {
                    foreach (DataGridViewRow row in dataDocGia.Rows)
                    {
                        if (row.Cells[2].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            dataDocGia.Rows[row.Index].Selected = true;
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
            
        }
    }
}
