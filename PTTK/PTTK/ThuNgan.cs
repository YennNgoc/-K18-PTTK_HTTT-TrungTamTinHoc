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
    public partial class ThuNgan : Form
    {
        SqlConnection con = new SqlConnection(Account.connectString);
        public ThuNgan()
        {
            InitializeComponent();
            con.Open();
        }
    }
}
