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
    public partial class NVQL__LopHoc : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public NVQL__LopHoc()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select MaNhomMH from NhomMonHoc";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_nhomMH.DataSource = dt;
            cb_nhomMH.DisplayMember = "MaNhomMH";

            checked_HP.Visible = true;
            cmd.CommandText = "SELECT * FROM MonHoc";
            //cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            grid_NVQLLH.DataSource = dt1;

        }

        private void but_TraCuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ThemHP";
            cmd.CommandType = CommandType.StoredProcedure;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@mahp", SqlDbType.Char, 8).Value = textBox1.Text;
            if (String.IsNullOrWhiteSpace(textBox2.Text))
                cmd.Parameters.Add("@tenhp", SqlDbType.Char, 8).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@tenhp", SqlDbType.Char, 8).Value = textBox2.Text;
            
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
            catch(Exception ex)
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
            if (String.IsNullOrWhiteSpace(textBox2.Text))
                cmd.Parameters.Add("@tenhp", SqlDbType.Char, 8).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@tenhp", SqlDbType.Char, 8).Value = textBox2.Text;

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

        private void but_Mo_Click(object sender, EventArgs e)
        {
            //int i = 0;

            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)grid_NVQLLH.Rows[grid_NVQLLH.CurrentRow.Index].Cells[0];

            //MessageBox.Show(ch1.Value.ToString());

            if (ch1.Value == null)
                ch1.Value = false;
            if (ch1.Value.ToString() == "True")
            {
                MessageBox.Show(grid_NVQLLH.Rows[grid_NVQLLH.CurrentRow.Index].Cells[1].Value.ToString());
                MessageBox.Show(grid_NVQLLH.Rows[grid_NVQLLH.CurrentRow.Index].Cells[2].Value.ToString());

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "XoaHP";
                //cmd.CommandType = CommandType.StoredProcedure;
            }




        }

        private void NVQL__LopHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
