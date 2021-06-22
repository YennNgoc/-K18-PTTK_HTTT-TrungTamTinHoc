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
        }

        private void but_TraCuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from MonHoc where MaNhomMH=@maNhomMH";
            cmd.Parameters.Add("@maNhomMH", SqlDbType.Char, 8).Value = cb_nhomMH.Text;
            //Account.id = Convert.ToString(cmd.ExecuteScalar());
            //MessageBox.Show(Account.id);
            //tb_id.Text = Account.id.ToString();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_NVQLLH.DataSource = dt;
            checked_HP.Visible = true;
        }

    }
}
