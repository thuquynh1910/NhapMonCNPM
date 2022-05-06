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
            this.comboLoaiDocGia.Items.Add("A");
            this.comboLoaiDocGia.Items.Add("B");
            this.comboLoaiDocGia.Items.Add("C");
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VOCQ70B;Initial Catalog=SACH;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO SACH VALUES ('M1', 'Tuoi tre dang gia bao nhieu', 'A', 'Roise Nguyen', 'Nha xuat ban hoi nha van', 2016, '24/04/2022')", con);
           
            this.Close();
        }
    }
}
