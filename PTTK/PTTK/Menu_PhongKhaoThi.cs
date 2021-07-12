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
    public partial class Menu_PhongKhaoThi : Form
    {
        
        public Menu_PhongKhaoThi()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            XetTotNghiep fr = new XetTotNghiep();
            fr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_PhongKhaoThi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TraCuuDiem fr = new TraCuuDiem();
            fr.Show();
        }
        private void ChinhSua_Click(object sender, EventArgs e)
        {
            ChinhSuaDiem fr = new ChinhSuaDiem();
            fr.Show();
        }
        private void MoLichThi_Click(object sender, EventArgs e)
        {
            MoLichThi fr = new MoLichThi();
            fr.Show();
        }
    }
}
