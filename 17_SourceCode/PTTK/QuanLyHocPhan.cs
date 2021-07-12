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
    public partial class QuanLyHocPhan : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public QuanLyHocPhan()
        {
            InitializeComponent();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ThemHP";
            cmd.CommandType = CommandType.StoredProcedure;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui long nhap MaHP");
                return;
            }
                
            else
                cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = textBox1.Text;

            if (String.IsNullOrWhiteSpace(tb_Ten.Text))
            {
                MessageBox.Show("Vui long nhap TenHP");
                return;
            }
            else
                cmd.Parameters.Add("@tenhp", SqlDbType.Char, 30).Value = tb_Ten.Text;
            

            if (String.IsNullOrWhiteSpace(cb_nhomMH.Text))
            {
                MessageBox.Show("Vui long nhap NhomHP");
                return;
            }
            else
                cmd.Parameters.Add("@nhomhp", SqlDbType.Char, 8).Value = cb_nhomMH.Text;

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_Xoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "XoaHP";
            cmd.CommandType = CommandType.StoredProcedure;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = textBox1.Text;
            
            cmd.Parameters.Add("@tenhp", SqlDbType.Char, 8).Value = DBNull.Value;    

            if (String.IsNullOrWhiteSpace(cb_nhomMH.Text))
                cmd.Parameters.Add("@nhomhp", SqlDbType.Char, 8).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@nhomhp", SqlDbType.Char, 8).Value = cb_nhomMH.Text;

            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_TraCuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuu";
            cmd.CommandType = CommandType.StoredProcedure;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = textBox1.Text;
           
            cmd.Parameters.Add("@tenhp", SqlDbType.Char, 8).Value = DBNull.Value;
            
            if (String.IsNullOrWhiteSpace(cb_nhomMH.Text))
                cmd.Parameters.Add("@nhomhp", SqlDbType.Char, 8).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@nhomhp", SqlDbType.Char, 8).Value = cb_nhomMH.Text;

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_NVQLLH.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuanLyHocPhan_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select MaNhomMH from NhomMonHoc";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_nhomMH.DataSource = dt;
            cb_nhomMH.DisplayMember = "MaNhomMH";

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "SELECT * FROM MonHoc";
            //cmd.CommandType = CommandType.StoredProcedure;

            cmd1.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            grid_NVQLLH.DataSource = dt1;
        }
    }
}
