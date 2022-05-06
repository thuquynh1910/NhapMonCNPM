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
    public partial class frmMain : Form
    {

        public static Form formLogin = new frmLogin();
        public static Form formHome = new frmHome();
        public static Panel mainPanel = new Panel();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {   
            // init form Login
            formLogin.TopLevel = false;
            formLogin.AutoScroll = true;

            // init form Home
            formHome.TopLevel = false;
            formHome.AutoScroll = true;

            // init main panel
            mainPanel.Size = this.Size;
            mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.Controls.Add(mainPanel);
            


            // start app by login
            showLoginForm();

        }

        private void showLoginForm()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(formLogin);
            formLogin.Show();
        }

        private static void showHomeForm()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(formHome);
            formHome.Show();
        }

        public static bool login(String email, String password)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOCQ70B;Initial Catalog=QLTV;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM THUTHU WHERE TaiKhoan='" + email + "' AND MatKhau='" + password + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                showHomeForm();
                return true;
            }
            else
            {
                return false;
            }
                
        }

    }
}
