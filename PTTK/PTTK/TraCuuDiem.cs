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
    public partial class TraCuuDiem : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public TraCuuDiem()
        {
            InitializeComponent();
            con.Open();
        }


        private void but_Lop_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuDiem";
            cmd.CommandType = CommandType.StoredProcedure;
            
            if (String.IsNullOrWhiteSpace(tb_MaHV.Text))
            {
                MessageBox.Show("Nhap MaHV");
                return;
            }    
                

            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = tb_MaHV.Text;
            
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_PKT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt_info_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuDiemTheoLH";
            cmd.CommandType = CommandType.StoredProcedure;

           
            if (String.IsNullOrWhiteSpace(tb_Lop.Text))
            {
                MessageBox.Show("Nhap Ma Lop");
                return;
            }


            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = tb_MaHV.Text;
            cmd.Parameters.Add("@malop", SqlDbType.Char, 8).Value = tb_Lop.Text;

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_PKT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuDiemTheoNMH";
            cmd.CommandType = CommandType.StoredProcedure;


            if (String.IsNullOrWhiteSpace(tb_NMH.Text))
            {
                MessageBox.Show("Nhap Nhom Mon hoc");
                return;
            }


            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = tb_MaHV.Text;
            cmd.Parameters.Add("@manmh", SqlDbType.Char, 8).Value = tb_NMH.Text;

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_PKT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TraCuuDiem_Load(object sender, EventArgs e)
        {

        }
    }
}
