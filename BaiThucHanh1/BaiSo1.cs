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
    public partial class BaiSo1 : Form
    {
        public BaiSo1()
        {
            InitializeComponent();
        }

        private void BaiSo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(txt1.Text) + int.Parse(txt2.Text);
            txt3.Text = sum.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    if (!int.TryParse(txt1.Text, out int check))
                    {
                        MessageBox.Show("Vui lòng nhập số nguyên thỏa yêu cầu!");
                    }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
                    if (!int.TryParse(txt2.Text, out int check))
                    {

                        MessageBox.Show("Vui lòng nhập số nguyên thỏa yêu cầu!");
                    }
        }
    }
}
