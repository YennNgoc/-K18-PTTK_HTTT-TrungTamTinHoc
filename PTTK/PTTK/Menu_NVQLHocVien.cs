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
    public partial class Menu_NVQLHocVien : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public Menu_NVQLHocVien()
        {
            con.Open();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TraCuuHocVien fr = new TraCuuHocVien();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_count = con.CreateCommand();
            cmd_count.CommandText = "select count(*) from HocVien";
            cmd_count.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd_count;
            DataTable dt = new DataTable();
            da.Fill(dt);

            string sttHV = dt.Rows[0].ItemArray[0].ToString();
            sttHV = (1000000 + Convert.ToInt32(sttHV) + 1).ToString().Substring(1, 6);
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ThemHV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ma", SqlDbType.Char, 8).Value = "HV" + sttHV;
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
    }
}
