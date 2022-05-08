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
        public static Form formHome;
        public static Panel mainPanel = new Panel();
        public static String taiKhoan = "";
        public static String hoVaTen = "";
        public static String email = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {   
            // init form Login
            formLogin.TopLevel = false;
            formLogin.AutoScroll = true;

           

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
            // add hoVaTen, email
            formHome = new frmHome(hoVaTen, email);
            // init form Home
            formHome.TopLevel = false;
            formHome.AutoScroll = true;
            // add to panel
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(formHome);
            formHome.Show();
        }

        public static bool login(String _email, String _password)
        {
            showHomeForm();
            return true;
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UK1PH6M;Initial Catalog=QUANLYSACH;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM THUTHU WHERE TaiKhoan='" + _email + "' AND MatKhau='" + _password + "'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //if (dt.Rows.Count == 1)
            //{
            //    taiKhoan = email;
            //    hoVaTen = dt.Rows[0]["HoVaTen"].ToString();
            //    email = _email;
            //    showHomeForm();
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
                
        }

    }
}
