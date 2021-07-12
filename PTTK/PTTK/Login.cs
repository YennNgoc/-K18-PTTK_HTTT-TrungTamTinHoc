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

namespace PTTK
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Account.username = tb_urs.Text;
            Account.password = tb_pwd.Text;
            if (string.IsNullOrWhiteSpace(Account.username) || string.IsNullOrWhiteSpace(Account.password))
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }
            Account.connectString = @"Server=localhost,1433;Database=TT_TinHoc;User ID=" + Account.username + ";Password=" + Account.password;
            SqlConnection con = new SqlConnection(Account.connectString);

            try
            {
                con.Open();
                MessageBox.Show(Account.username + " Connected!", "Login Notify");
                if (Account.username.Contains("QLHV"))
                {
                    Menu_NVQLHocVien fr = new Menu_NVQLHocVien();
                    fr.Show();
                    this.Hide();
                }
                else if (Account.username.Contains("HV"))
                {
                    Menu_HocVien fr = new Menu_HocVien();
                    fr.Show();
                    this.Hide();
                }
                else if (Account.username.Contains("QLLH"))
                {
                    Menu_NVQLLopHoc fr = new Menu_NVQLLopHoc();                    
                    fr.Show();
                    this.Hide();
                }
                else if (Account.username.Contains("NVKT"))
                {
                    Menu_PhongKhaoThi fr = new Menu_PhongKhaoThi();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    Menu_ThuNgan fr = new Menu_ThuNgan();
                    fr.Show();
                    this.Hide();
                }    

                //MessageBox.Show("Connected", "Login Notify");
            }
            catch (SqlException)
            {
                MessageBox.Show("Unsuccessful!", "Login Notify");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text=(" Nhóm 17 \r\n \r\n 18120213 - Võ Đại Nam \r\n 18120214 - Lê Ngọc Bảo Ngân" +
                "\r\n 18120215 - Vũ Yến Ngọc" +
                "\r\n 18120227 - Phạm Văn Minh Phương" +
                "\r\n 18120456 - Lại Bùi Thành Luân");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender,e);
        }
    }
}
