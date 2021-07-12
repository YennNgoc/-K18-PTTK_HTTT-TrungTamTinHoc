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
    public partial class Menu_HocVien : Form
    {
        public Menu_HocVien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ThongTinHocVien fr = new ThongTinHocVien();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QuanLyHocTap fr = new QuanLyHocTap();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           DangKyHocPhan fr = new DangKyHocPhan();
            fr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DangKyHocPhan fr = new DangKyHocPhan();
            fr.Show();
        }
    }
}
