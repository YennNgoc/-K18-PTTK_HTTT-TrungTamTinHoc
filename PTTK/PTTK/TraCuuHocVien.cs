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
    public partial class TraCuuHocVien : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public TraCuuHocVien()
        {
            InitializeComponent();
            con.Open();
        }

        private void but_TraCuuHV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_MaHV.Text) )
            {
                MessageBox.Show("Vui long cung cap MaHV");
                return;
            }
            ThongTinHocVien fr = new ThongTinHocVien(tb_MaHV.Text);
            fr.Show();
        }

        private void butt_info_Click(object sender, EventArgs e)
        {
            string sttHV = (1000000 + Convert.ToInt32(tb_tongsoHV.Text) + 1).ToString().Substring(1, 6);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ThemHV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ma", SqlDbType.Char, 8).Value = "HV"+ sttHV;
            cmd.Parameters.Add("@ten", SqlDbType.Char, 8).Value = "";
            cmd.Parameters.Add("@pass", SqlDbType.Char, 8).Value = "1";
            cmd.Parameters.Add("@cccd", SqlDbType.Char, 8).Value = "";
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Char, 8).Value = "01/01/2019";
            cmd.Parameters.Add("@email", SqlDbType.Char, 8).Value = "";
            cmd.Parameters.Add("@sdt", SqlDbType.Char, 8).Value = "";

            try
            {
                cmd.ExecuteNonQuery();                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ThongTinHocVien fr = new ThongTinHocVien("HV" + sttHV);
            fr.Show();
        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void NVQL_HocVien_Load(object sender, EventArgs e)
        {
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select count(*) from HocVien";
            //cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            tb_tongsoHV .Text = dt.Rows[0].ItemArray[0].ToString();


            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "select * from HocVien";
            //cmd.CommandType = CommandType.StoredProcedure;

            cmd2.ExecuteNonQuery();

            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            grid_NVQLHV.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NVQL_HocVien_Load(sender,e);
        }
    }
}
