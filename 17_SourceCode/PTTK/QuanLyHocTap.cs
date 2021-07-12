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
    public partial class QuanLyHocTap : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public QuanLyHocTap()
        {
            InitializeComponent();
            con.Open();
        }

        private void QuanLyHocTap_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuDiem_HV";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = Account.username;
            try { 
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_HV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt_Chungchi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuLSTN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = Account.username;
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_HV.DataSource = dt;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt_TraCuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraDiemTheoLop";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = Account.username;
            cmd.Parameters.Add("@hocki", SqlDbType.Int).Value = comboBox1.Text ;
            cmd.Parameters.Add("@nam", SqlDbType.Char, 4).Value = dateTimePicker1.Text;
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_HV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
