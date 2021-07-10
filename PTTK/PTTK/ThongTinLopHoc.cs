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
    public partial class Thong_tin_Lop_hoc : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public Thong_tin_Lop_hoc()
        {
            InitializeComponent(); 
            con.Open();
        }

        private void butt_Xem_Click(object sender, System.EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "XemThongTinLop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@malop", SqlDbType.Char, 8).Value = tb_MaLop.Text;

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_Lop.DataSource = dt;
                tb_SiSo.Text = dt.Rows[0].ItemArray[2].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Thong_tin_Lop_hoc_Load(object sender, System.EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Lop";           

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_Lop.DataSource = dt;

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "CapNhapSL";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@malop", SqlDbType.Char, 8).Value = tb_MaLop.Text;
            cmd.Parameters.Add("@slcp", SqlDbType.Int).Value = tb_them.Text;

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt_TraCuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "LocLop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@hocki", SqlDbType.Int).Value = cb_HK.Text;
            cmd.Parameters.Add("@nam", SqlDbType.Char,4).Value = dt_Khoa.Text;
           
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_Lop.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
