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
    public partial class NVQL_HocVien : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public NVQL_HocVien()
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
            Update_InfoHV fr = new Update_InfoHV(tb_MaHV.Text);
            fr.Show();
        }
    }
}
