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
    public partial class Menu_ThuNgan : Form
    {
        public Menu_ThuNgan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TraCuuHoaDon fr = new TraCuuHoaDon();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LapHoaDon fr = new LapHoaDon();
            fr.Show();
        }
    }
}
