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
                    NVQL_HocVien fr = new NVQL_HocVien();
                    fr.Show();
                    this.Hide();
                }
                else if (Account.username.Contains("QLLH"))
                {
                    NVQL__LopHoc fr = new NVQL__LopHoc();
                    fr.Show();
                    this.Hide();
                }
                else if (Account.username.Contains("HV"))
                {
                    HocVien fr = new HocVien();
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
    }
}
