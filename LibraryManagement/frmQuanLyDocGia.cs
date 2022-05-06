using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmQuanLyDocGia : Form
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            Form fromThemDocGia = new frmThemDocGia();
            fromThemDocGia.Show();
        }
    }
}
