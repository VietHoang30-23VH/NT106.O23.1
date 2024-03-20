using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class BaiSo3 : Form
    {
        public BaiSo3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txt2.Text) > 9)
            {
                MessageBox.Show("Lỗi nhập!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] donvi = { "Không","Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            int So = int.Parse(txt2.Text);
            string words = "";
            words+= donvi[So];
            textBox1.Text = words;
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txt2.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
