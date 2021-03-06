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
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            // 
            using (SqlConnection sqlCon = new SqlConnection(Program.connect))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM LOAIDOCGIA", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    comboLoaiDocGia.Items.Add(dtbl.Rows[i].ItemArray[0].ToString() + " " + dtbl.Rows[i].ItemArray[1].ToString());
                }
            }
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connect);
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.boxHoVaTen.Text.Length > 0 && this.boxDiaChi.Text.Length > 0 && this.boxEmail.Text.Length > 0 && this.comboLoaiDocGia.Text.Length > 0)
            {
                docGiaModel docGia = new docGiaModel(this.boxHoVaTen.Text, this.boxDiaChi.Text, this.boxEmail.Text, this.dateNgayLapThe.Value, this.dateNgaySinh.Value, this.comboLoaiDocGia.Text.Substring(0,6));
                docGia.thuatToan();
                if (docGia.tuoiDocGia >= 18 && docGia.tuoiDocGia <= 55)
                {
                    DialogResult dialogResult = MessageBox.Show("Tuổi độc giả là " + docGia.tuoiDocGia.ToString() + " hợp lệ. Bạn có muốn in thẻ", "Độc giả", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        docGia.toDatabse();
                        var formTheDocGia = new frmTheDocGia(docGia);
                        formTheDocGia.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tuổi độc giả là " + docGia.tuoiDocGia.ToString() + ", không hợp lệ, tuổi độc giả phải từ 18 đến 55. Vui lòng nhập lại", "Độc giả", MessageBoxButtons.OK);
                }

            }
               
        }

        private void clearForm()
        {
            this.boxDiaChi.Text = null;
            this.boxEmail.Text = null;
            this.boxHoVaTen.Text = null;
            this.comboLoaiDocGia.Text = null;
            this.dateNgaySinh.Text = null;
        }
    }
}
