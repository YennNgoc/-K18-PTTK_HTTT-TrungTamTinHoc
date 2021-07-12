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
    public partial class MoLop : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public MoLop()
        {
            InitializeComponent();
            con.Open();
        }

        private void MoLop_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select MaNhomMH from NhomMonHoc";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_nhomMH.DataSource = dt;
            cb_nhomMH.DisplayMember = "MaNhomMH";
        }

        private void but_TraCuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuu";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = DBNull.Value;
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from NhanVien";
            
            
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

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ThemLop";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Char, 8).Value = tb_malop.Text;
            cmd.Parameters.Add("@mamh", SqlDbType.Char, 8).Value = tb_mamh.Text;
            cmd.Parameters.Add("@magv", SqlDbType.Char, 8).Value = tb_magv.Text;
            cmd.Parameters.Add("@ngaymo", SqlDbType.Date).Value = dateTimePicker1.Value.ToString();
            cmd.Parameters.Add("@sl", SqlDbType.Int).Value = tb_sl.Text;

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
