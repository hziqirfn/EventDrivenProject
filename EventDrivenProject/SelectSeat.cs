using EventDrivenProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDrivenProject
{
    public partial class SelectSeat : Form
    {
        private bool isLoading = false;
        private int hallId;

        public SelectSeat(int hallId)
        {
            InitializeComponent();
            this.hallId = hallId;
            this.Name = "SelectSeat";
            UpdateMovieHall();
        }
        public SelectSeat()
        {
            InitializeComponent();
        }
        private void UpdateMovieHall()
        {
            HallidTextSelectSeat.Text = hallId.ToString();
        }
        private void Seat_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // 🔥 BLOCK AUTO TRIGGERS

            CheckBox cb = sender as CheckBox;
            if (cb == null || !cb.Enabled) return;

            var seat = Helper.db.Seats.FirstOrDefault(s =>
                s.SeatNumber == cb.Text &&
                s.HallId == hallId);

            if (seat == null) return;

            if (cb.Checked)
            {
                cb.BackColor = Color.Yellow;
                seat.SeatType = "Selected";
            }
            else
            {
                cb.BackColor = Color.LightGray;
                seat.SeatType = "Available";
            }

            Helper.db.SaveChanges();
        }
        private void SelectSeat_Load(object sender, EventArgs e)
        {
            isLoading = true;

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox cb && cb.Name.StartsWith("seat"))
                {
                    cb.CheckedChanged += Seat_CheckedChanged;
                }
            }

            var seats = Helper.db.Seats
                .Where(s => s.HallId == hallId)
                .ToList();

            foreach (var seat in seats)
            {
                var control = this.Controls.Find("seat" + seat.SeatNumber, true).FirstOrDefault();

                if (control is CheckBox cb)
                {
                    cb.Text = seat.SeatNumber;

                    if (seat.SeatType == "Booked")
                    {
                        cb.Checked = true;
                        cb.Enabled = false;
                        cb.BackColor = Color.Red;
                    }
                    else if (seat.SeatType == "Selected")
                    {
                        cb.Checked = true;
                        cb.BackColor = Color.Yellow;
                    }
                    else
                    {
                        cb.Checked = false;
                        cb.BackColor = Color.LightGray;
                    }
                }
            }
            isLoading = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form paymentForm = new Payment(hallId);
            paymentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seatA4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
