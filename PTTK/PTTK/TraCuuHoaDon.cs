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
    public partial class TraCuuHoaDon : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public TraCuuHoaDon()
        {
            InitializeComponent();
            con.Open();
        }

        private void TraCuuHoaDon_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuHD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.Char, 8).Value = Account.username;
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_HD.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
