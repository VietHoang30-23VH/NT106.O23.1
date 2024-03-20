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
    public partial class BaiSo2 : Form
    {
        public BaiSo2()
        {
            InitializeComponent();
        }

        private void BaiSo2_Load(object sender, EventArgs e)
        {

        }
        private void btnTim_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(txt1.Text);
            Console.WriteLine(txt2.Text);
            Console.WriteLine(txt3.Text);
            double LonNhat = Math.Max(double.Parse(txt1.Text), Math.Max(double.Parse(txt2.Text), double.Parse(txt3.Text)));
            double NhoNhat = Math.Min(double.Parse(txt1.Text), Math.Min(double.Parse(txt2.Text), double.Parse(txt3.Text)));
            txt4.Text = LonNhat.ToString().Replace(",", ".");
            txt5.Text = NhoNhat.ToString().Replace(",", ".");
        }   

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
