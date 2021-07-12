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

using System.Globalization;

namespace PTTK
{
    public partial class ThongTinHocVien : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        string fr_maHV;
        public ThongTinHocVien(string maHV)
        {
            InitializeComponent();
            textBox2.Visible = false;
            label2.Visible = false;
            fr_maHV = maHV;
        }
        public ThongTinHocVien()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox3.Enabled = false;
        }

        private void Update_InfoHV_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "TraCuuThongTin";
            cmd.CommandType = CommandType.StoredProcedure;

            if (Account.username.Contains("QLHV"))
            {
                cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = fr_maHV;                
            }
            else
            {
                cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = Account.username;
            }
            try { 
            cmd.ExecuteNonQuery();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            textBox1.Text = dt.Rows[0].ItemArray[0].ToString().TrimStart();
            textBox2.Text = dt.Rows[0].ItemArray[1].ToString().Trim();
            textBox3.Text = dt.Rows[0].ItemArray[2].ToString().Trim();
            textBox4.Text = dt.Rows[0].ItemArray[3].ToString().Trim();
            textBox5.Text = dt.Rows[0].ItemArray[4].ToString().Trim();
            textBox6.Text = dt.Rows[0].ItemArray[5].ToString().Trim();
            textBox7.Text = (dt.Rows[0].ItemArray[6] as IFormattable).ToString("dd/MM/yyyy", CultureInfo.CurrentCulture);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text =="1" & String.IsNullOrEmpty( textBox3.Text))
            {
               
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "XoaHV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ma", SqlDbType.Char, 8).Value = fr_maHV;
                
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ChinhSuaThongTin";
           
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mahv", SqlDbType.Char, 8).Value = textBox1.Text;
            cmd.Parameters.Add("@pw", SqlDbType.VarChar, 20).Value = textBox2.Text;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 50).Value = textBox3.Text;
            cmd.Parameters.Add("@cccd", SqlDbType.Char, 12).Value = textBox4.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = textBox5.Text;
            cmd.Parameters.Add("@sdt", SqlDbType.Char, 10).Value = textBox6.Text;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.Date, 8).Value = DateTime.ParseExact(textBox7.Text,"dd/MM/yyyy", CultureInfo.CurrentCulture);


            try
            { 
            cmd.ExecuteNonQuery();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
