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
    public partial class XetTotNghiep : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public XetTotNghiep()
        {
            InitializeComponent();
            con.Open();
            
        }

        private void btn_XetTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TotNghiep";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@masv", SqlDbType.Char, 8).Value = tb_maHV.Text;
            cmd.Parameters.Add("@machungchi", SqlDbType.Char, 8).Value = cb_ChungChi.Text;
            cmd.Parameters.Add("@ngaynhan", SqlDbType.Date).Value = dateTimePicker1.Text ;

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bth_XemLSTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from LichSuTotNghiep";
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XetTotNghiep_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select MaChungChi from ChungChi";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_ChungChi.DataSource = dt;
            cb_ChungChi.DisplayMember = "MaChungChi";
        }
    }
}
