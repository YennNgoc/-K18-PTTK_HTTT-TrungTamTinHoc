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
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from HocVien";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHV.DataSource = dt;
            checked_DK.Visible = false;
        }

        private void lịchSửThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from LichSuThi";
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
            cmd.CommandText = "select * from LichSuTotNghiep";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridHV.DataSource = dt;
            checked_DK.Visible = false;
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
            cmd.CommandText = "select * from Lop";cmd.ExecuteNonQuery();
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
