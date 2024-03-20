using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiThucHanh1
{
    public partial class BaiSo6 : Form
    {
        public BaiSo6()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool check(int a, int b,int c)
        {
            return !(a < 0 || a > 31 || b < 0 || b > 12|| c < 1);
        }
        private void btnKT_Click(object sender, EventArgs e)
        {
            int ngay = int.Parse(txt1.Text);
            int thang = int.Parse(txt2.Text);
            int nam = int.Parse(txt3.Text);
            if (check(ngay, thang, nam) == false)
            {
                MessageBox.Show("Vui lòng nhập lại ngày tháng năm!!!");
            }
            else
            {
                switch (thang)
                {
                    case 1:
                        {
                            if (ngay >= 21) txt4.Text = "Cung Bảo Bình";
                            else txt4.Text = "Cung Ma Kết";
                            break;

                        };
                    case 2:
                        {
                            if (ngay <= 19) txt4.Text = "Cung Bảo Bình";
                            else txt4.Text = "Cung Song Ngư";
                            break;
                        };
                    case 3:
                        {
                            if (ngay <= 20) txt4.Text = "Cung Song Ngư ";
                            else txt4.Text = "Cung Bạch Dương ";
                            break;
                        };
                    case 4:
                        {
                            if (ngay <= 20) txt4.Text = "Cung Bạch Dương ";
                            else txt4.Text = "Cung Kim Ngưu ";
                            break;
                        };
                    case 5:
                        {
                            if (ngay <= 21) txt4.Text = "Cung Kim Ngưu ";
                            else txt4.Text = "Cung Song Tử";
                            break;
                        };
                    case 6:
                        {
                            if (ngay <= 21) txt4.Text = "Cung Song Tử ";
                            else txt4.Text = "Cung Cự Giải ";
                            break;
                        };
                    case 7:
                        {
                            if (ngay <= 22) txt4.Text = "Cung Cự Giải  ";
                            else txt4.Text = "Cung Sư Tử  ";
                            break;
                        };
                    case 8:
                        {
                            if (ngay <= 22) txt4.Text = "Cung Sư Tử ";
                            else txt4.Text = " Cung Xử Nữ";
                            break;
                        };
                    case 9:
                        {
                            if (ngay <= 23) txt4.Text = "Cung Xử Nữ ";
                            else txt4.Text = "Cung Thiên Bình ";
                            break;
                        };
                    case 10:
                        {
                            if (ngay <= 23) txt4.Text = "Cung Thiên Bình ";
                            else txt4.Text = "Cung Thần Nông ";
                            break;
                        };
                    case 11:
                        {
                            if (ngay <= 22) txt4.Text = "Cung Thần Nông ";
                            else txt4.Text = "Cung Nhân Mã ";
                            break;
                        };
                    case 12:
                        {
                            if (ngay <= 21) txt4.Text = "Cung Nhân Mã ";
                            else txt4.Text = "Cung Bảo Bình ";
                            break;
                        };
                    default:
                        txt4.Text = "Vui lòng nhập lại!!";
                        break;
                }
            }
        }
    }
}
