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
    }
}
