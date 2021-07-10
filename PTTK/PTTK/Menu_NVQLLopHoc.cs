using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class Menu_NVQLLopHoc : Form
    {
        public Menu_NVQLLopHoc()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QuanLyHocPhan fr = new QuanLyHocPhan();
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thong_tin_Lop_hoc fr = new Thong_tin_Lop_hoc();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MoLop fr = new MoLop();
            fr.Show();
        }
    }
}
