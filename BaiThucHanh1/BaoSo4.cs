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
    public partial class BaoSo4 : Form
    {
        public BaoSo4()
        {
            InitializeComponent();
        }
        Dictionary<string, double> phim_gia = new Dictionary<string, double>
        {
            { "Đào, phở và piano", 45000 },
            { "Mai", 100000 },
            { "Gặp lại chị bầu", 70000 },
            { "Tarot", 90000 }
        };

        Dictionary<string, string[]> choNgoi = new Dictionary<string, string[]>
        {
            { "A", new string[] { "A1", "A2", "A3", "A4", "A5" } },
            { "B", new string[] { "B1", "B2", "B3", "B4", "B5" } },
            { "C", new string[] { "C1", "C2", "C3", "C4", "C5" } }
        };

        Dictionary<string, string> bookedSeats = new Dictionary<string, string>();
        private void BaoSo4_Load(object sender, EventArgs e)
        {
            foreach (var movie in phim_gia.Keys)
            {
                cmbMovies.Items.Add(movie);
            }

            foreach (var room in choNgoi.Keys)
            {
                foreach (var seat in choNgoi[room])
                {
                    checkedListBoxSeats.Items.Add(seat);
                }
            }
            cmbTicketType.Items.AddRange(new string[] { "Vé vớt", "Vé thường", "Vé VIP" });
        }
        private double TinhTien(string movie, string seat, string ticketType)
        {
            double giaCoBan = phim_gia[movie];

            if (ticketType == "Vé vớt")
            {
                return giaCoBan / 4;
            }
            else if (ticketType == "Vé thường")
            {
                return giaCoBan;
            }
            else if (ticketType == "Vé VIP")
            {
                return giaCoBan * 2;
            }

            return 0; 
        }
        private void btnBookTicket_Click_1(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string selectedMovie = cmbMovies.SelectedItem.ToString();
            string selectedTicketType = cmbTicketType.SelectedItem.ToString();

            List<string> selectedSeats = new List<string>();
            foreach (var seat in checkedListBoxSeats.CheckedItems)
            {
                selectedSeats.Add(seat.ToString());
            }

            double tongTien = 0;
            foreach (var seat in selectedSeats)
            {
                tongTien += TinhTien(selectedMovie, seat, selectedTicketType);
                bookedSeats.Add(seat, customerName);
            }

            string result = $"Họ và tên: {customerName}\r\n" + $"Vé đã chọn: {selectedTicketType}\r\n" +
                            $"Tên phim: {selectedMovie}\r\n" + $"Số ghế đã chọn: {string.Join(", ", selectedSeats)}\r\n" +
                            $"Số tiền cần phải thanh toán: {tongTien.ToString("")}";

            txtOutput.AppendText(result);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            cmbMovies.SelectedIndex = -1;
            checkedListBoxSeats.ClearSelected();
            cmbTicketType.SelectedIndex = -1;
        }
    }
}
