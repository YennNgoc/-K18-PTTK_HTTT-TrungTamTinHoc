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
    public partial class ChinhSuaDiem : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public ChinhSuaDiem()
        {
            InitializeComponent();
            con.Open();
        }

        private void butt_xem_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
                textBox1.Text = dt.Rows[0].ItemArray[5].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt_UPD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "updateDiem";
            cmd.CommandType = CommandType.StoredProcedure;


            if (String.IsNullOrWhiteSpace(tb_Lop.Text))
            {
                MessageBox.Show("Nhap Ma Lop");
                return;
            }


            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = tb_MaHV.Text;
            cmd.Parameters.Add("@malop", SqlDbType.Char, 8).Value = tb_Lop.Text;
            cmd.Parameters.Add("@diem", SqlDbType.Float).Value = tb_DiemMoi.Text;

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
