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
    }
}
