using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class BaiSo5 : Form
    {
        public BaiSo5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == 0) 
            {
                int number = int.Parse(txt2.Text) - int.Parse(txt1.Text);
                String[] bang = new String[10];
                for(int i=1;i<=10;i++)
                {
                bang[i-1] += number + "x" + i +"=" + number * i;;
                }
                txt3.Text = string.Join(Environment.NewLine, bang);
            }
            if (cb1.SelectedIndex ==1)
            {
                long num2 = long.Parse(txt1.Text) - long.Parse(txt2.Text);
                long giaithua = 1;
                String[] ketqua = new String[2];
                if (num2 == 0 || num2 ==1)
                {
                    giaithua = 1;
                }
                for(int i=2;i<=num2;i++)
                {
                    giaithua = giaithua * i;
                }
                ketqua[0]=$" Phép tính giai thừa của ({txt1.Text} - {txt2.Text})! = {giaithua} ";
                long sum_multi = 0;
                for (int i=1;i<=int.Parse(txt2.Text);i++)
                {
                    sum_multi +=(long)( Math.Pow(int.Parse(txt1.Text), i));
                }
                ketqua[1] = $"{long.Parse(txt1.Text)}^1 + ... + {long.Parse(txt1.Text)} ^{long.Parse(txt2.Text)} = {sum_multi}";
                txt3.Text = string.Join(Environment.NewLine, ketqua);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
