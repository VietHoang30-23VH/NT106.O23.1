using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class BaiSo7 : Form
    {
        string infor;
        string[] inforProcess;
        public BaiSo7()
        {
            InitializeComponent();
        }
        private bool KiemTraSo(string strings)
        {
            double number;
            return double.TryParse(strings, out number);
        }
        private void btnKT_Click(object sender, EventArgs e)
        {
            infor = txt1.Text.Trim();
            inforProcess = infor.Split(',');

            int check = 0;
            bool limit = true;
          if (KiemTraSo(inforProcess[0].Trim()))
            {
                check++;
            }
          else if (inforProcess.Length < 2) 
             {
                check++;
             }
          else
            {
                for (int i=1; i<inforProcess.Length; i++)
                {
                    if (KiemTraSo(inforProcess[i].Trim()) == false) {
                           check++;
                        break;
                    }
                }
            }
            if (check > 0 )
            {
                MessageBox.Show("Nhập sai!!!");
                txt1.Text = "";
            }
            else
            {
                string studentName = inforProcess[0];
                txt2.Text = studentName;

                double[] scores = inforProcess.Skip(1).Select(s => double.Parse(s.Trim(), CultureInfo.InvariantCulture)).ToArray(); 
                for (int i = 0; i < scores.Length; i++)
                { 
                    txt3.Text += "Môn" + (i+1) + ":" + scores[i] + " ";
                }

                double dtb = scores.Sum() / scores.Length;
                txt4.Text = dtb.ToString("0.00");

                double diemcaonhat = scores.Max();
                txt5.Text = diemcaonhat.ToString("0.00");
                double diemthapnhat = scores.Min();
                txt6.Text = diemthapnhat.ToString("0.00");

                int ctdau = 0; int ctrot = 0;
                for (int i = 0; i < scores.Length; i++)
                {
                    if (scores[i] >= 5)
                    {
                        ctdau++;
                    }
                    else if (scores[i] < 5)
                    {
                        ctrot++;
                    }
                }
                txt7.Text = ctdau.ToString();
                txt8.Text = ctrot.ToString();
                if (dtb >= 8 && scores.All(score => score >= 6.5)) txt9.Text = "Giỏi";
                else if (dtb >= 6.5 && scores.All(score => score >= 5)) txt9.Text = "Khá";
                else if (dtb >= 5 && scores.All(score => score >= 3.5)) txt9.Text = "TB";
                else if (dtb >= 3.5 && scores.All(score => score >= 2)) txt9.Text = "Yếu";
                else txt9.Text = "Kém";

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            int k = 0;
            if (string.IsNullOrEmpty(txt1.Text))
                return;

            if (int.TryParse(txt1.Text, out int value))
            {

                if (value < 0 || value > 10)
                {
                    k++;
                }
            }
            if (k != 0)
            {
                MessageBox.Show("Giá trị phải nằm trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt1.Text = "";
            }

        }
    }
}
