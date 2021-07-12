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
    public partial class MoLichThi : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public MoLichThi()
        {
            InitializeComponent();
            con.Open();
        }

        private void btn_MoLichThi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "MoLichThi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@malh", SqlDbType.Char, 8).Value = tb_maLop.Text;
            cmd.Parameters.Add("@diadiem", SqlDbType.VarChar, 20).Value = tb_DiaDiem.Text;
            cmd.Parameters.Add("@ngaythi", SqlDbType.VarChar, 50).Value = tb_gio.Text;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XemLichThi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from LichSuThi";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = Account.username;
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
