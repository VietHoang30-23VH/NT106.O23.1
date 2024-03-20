using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class BaiSo31 : Form
    {
        private string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
        private string[] Tens = { "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };
        public BaiSo31()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private String ReadTram(long soNhap)
        {
            string strword = "";
            if (soNhap > 99 && soNhap < 1000)
            {
                long a = soNhap / 100;
                strword+= Ones[a - 1] + " trăm ";
                soNhap = soNhap % 100;

            }
            if (soNhap > 19 && soNhap < 100)
            {
                long b = soNhap / 10;
                strword+= Tens[b - 1] + " ";
                soNhap = soNhap % 10;
            }
            if (soNhap > 0 && soNhap < 20)
            {
                strword += Ones[soNhap - 1];
            }

            return strword;
        }
        private String ReadNghin(long soNhap)
        {
            if (soNhap > 999 && soNhap < 1000000)
                return ReadTram(soNhap / 1000) + " nghìn " + ReadTram(soNhap % 1000);
            else return ReadTram(soNhap);
        }
        private String ReadTrieu(long soNhap)
        {
            if (soNhap > 999999 && soNhap < 1000000000)
            {
                return ReadTram(soNhap / 1000000) + " triệu " + ReadNghin(soNhap % 1000000);
            }
            else return ReadNghin(soNhap);
        }
        private String ReadTi(long soNhap)
        {
            if (soNhap > 999999999 && soNhap < 1000000000000)
            {
                return ReadTram(soNhap / 1000000000) + " tỉ " + ReadTrieu(soNhap % 1000000000);
            }
            else return ReadTrieu(soNhap);
        }
        private void btnD_Click(object sender, EventArgs e)
        {
                txt2.Text = ReadTi(long.Parse(txt1.Text));
        }
    }
}
