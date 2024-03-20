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
    public partial class BaiSo8 : Form
    {
        private List<string> danhsachmonan = new List<string> ();
        public BaiSo8()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lb1.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BaiSo8_Load(object sender, EventArgs e)
        {
            foreach(string monan in danhsachmonan)
            {
                lb1.Items.Add(monan);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string monAnMoi = txt1.Text;
            if (!string.IsNullOrEmpty(monAnMoi))
            {
                if (!danhsachmonan.Contains(monAnMoi))
                {
                    danhsachmonan.Add(monAnMoi);
                    lb1.Items.Add(monAnMoi);
                    txt1.Text = "";
                }
                else
                {
                    MessageBox.Show("Món ăn này đã tồn tại trong danh sách rồi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (danhsachmonan.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập thêm món ăn!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Random random =  new Random();
            int index = random.Next(danhsachmonan.Count);
            txt2.Text = danhsachmonan[index];
        }

    }
}
