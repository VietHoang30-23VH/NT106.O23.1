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
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaiSo1 baiSo1 = new BaiSo1();
            baiSo1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaiSo2 baiSo2 = new BaiSo2();
            baiSo2.Show();
        }
        private void btnBai3_Click(object sender, EventArgs e)
        {
            BaiSo3  baiSo3 = new BaiSo3();
            baiSo3.Show();
        }
        private void btnBai4_Click(object sender, EventArgs e)
        {
            BaoSo4 baiSo4 = new BaoSo4();
            baiSo4.Show();
        }

        private void btnBai31_Click(object sender, EventArgs e)
        {
            BaiSo31 baiSo31 = new BaiSo31();
            baiSo31.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            BaiSo5 baiSo5 = new BaiSo5();
            baiSo5.Show();
        }
        private void btnBai6_Click(object sender, EventArgs e)
        {
            BaiSo6 baiSo6 = new BaiSo6();
            baiSo6.Show();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            BaiSo7 baiSo7 = new BaiSo7();
            baiSo7.Show();
        }
        private void btnBai8_Click_1(object sender, EventArgs e)
        {
            BaiSo8 baiSo8 = new BaiSo8();
            baiSo8.Show();
        }
    }
}
