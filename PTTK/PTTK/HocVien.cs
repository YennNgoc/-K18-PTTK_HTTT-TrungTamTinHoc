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
    public partial class HocVien : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        
        public HocVien()
        {
            InitializeComponent();
            con.Open();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinHocVien fr = new ThongTinHocVien();
            fr.Show();

        }

        private void lịchSửThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuDiem_HV";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = Account.username;
            //SqlParameter returnParameter = cmd.Parameters.Add("@role", SqlDbType.VarChar, 20);
            //returnParameter.Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHV.DataSource = dt;
            checked_DK.Visible = false;
        }

        private void chứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuLSTN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = Account.username;
            try {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridHV.DataSource = dt;
                checked_DK.Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void danhSáchLớpMởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Lop";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHV.DataSource = dt;
            checked_DK.Visible = false;
        }

        private void đăngKýHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Lop";
            //cmd.CommandText = "DKHP";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = textBox1.Text;
            //cmd.Parameters.Add("@pw", SqlDbType.VarChar, 20).Value = textBox2.Text;

            cmd.ExecuteNonQuery();
            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHV.DataSource = dt;
            checked_DK.Visible = true;
        }

        private void kếtQuảĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Lop";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHV.DataSource = dt;
            checked_DK.Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Close();
            System.Environment.Exit(0);
        }

    }
}
