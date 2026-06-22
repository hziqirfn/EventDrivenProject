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
    public partial class Payment : Form
    {
        private int hallId;

        public Payment(int hallId)
        {
            InitializeComponent();
            this.hallId = hallId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CardNumTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (CardNumTxtBox.Text.Length > 16)
            {
                MessageBox.Show("Card number cannot exceed 16 digits.");
                CardNumTxtBox.Text = CardNumTxtBox.Text.Substring(0, 16);
                CardNumTxtBox.SelectionStart = CardNumTxtBox.Text.Length;
                PicBoxCardNum.Image = Properties.Resources.error;
            }
            else if (CardNumTxtBox.Text.Length == 16)
            {
                PicBoxCardNum.Image = Properties.Resources.tick;
            }
            else
            {
                PicBoxCardNum.Image = null;
            }
        }

        private void ExpTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (ExpTxtBox.Text.Length > 5)
            {
                MessageBox.Show("Expiration date cannot exceed 5 characters (MM/YY).");
                PicBoxExp.Image = Properties.Resources.error;
            }
            else if (ExpTxtBox.Text.Length == 5)
            {
                PicBoxExp.Image = Properties.Resources.tick;
            }
            else
            {
                PicBoxExp.Image = null;
            }
        }

        private void CVCTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (CVCTxtBox.Text.Length > 3)
            {
                MessageBox.Show("CVC cannot exceed 3 digits.");
                PicBoxCVC.Image = Properties.Resources.error;
            }
            else if (CVCTxtBox.Text.Length == 3)
            {
                PicBoxCVC.Image = Properties.Resources.tick;
            }
            else
            {
                PicBoxCVC.Image = null;
            }
        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTxtBox.Text.Length > 50)
            {
                MessageBox.Show("Name cannot exceed 50 characters.");
                NameTxtBox.Text = NameTxtBox.Text.Substring(0, 50);
                NameTxtBox.SelectionStart = NameTxtBox.Text.Length;
                PicBoxName.Image = Properties.Resources.error;
            }
            else if (NameTxtBox.Text.Length > 0)
            {
                PicBoxName.Image = Properties.Resources.tick;
            }
            else
            {
                PicBoxName.Image = null;
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var selectedSeats = Helper.db.Seats
                .Where(s => s.HallId == hallId && s.SeatType == "Selected")
                .ToList();

            foreach (var seat in selectedSeats)
            {
                seat.SeatType = "Booked";
            }

            Helper.db.SaveChanges();

            MessageBox.Show("Booking Confirmed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            var seatForm = Application.OpenForms["SelectSeat"];
            seatForm?.Close();

            SelectSeat newSeatForm = new SelectSeat(hallId);
            newSeatForm.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
