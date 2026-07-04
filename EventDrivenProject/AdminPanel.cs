using EventDrivenProject.DataSet1TableAdapters;
using System.Data;

namespace EventDrivenProject
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load_1(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dataGridView1.DataSource = Helper.db.Users
                .Select(u => new
                {
                    u.UserId,
                    u.Email,
                    u.Password
                })
                .ToList();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnViewSeats_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnResetSeats_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.Show();
        }

        private void btnDeleteUsers_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            int userId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["UserId"].Value
            );

            var user = Helper.db.Users.FirstOrDefault(x => x.UserId == userId);

            if (user != null)
            {
                if (MessageBox.Show("Are you sure want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Helper.db.Users.Remove(user);
                    Helper.db.SaveChanges();
                    MessageBox.Show("User deleted!");
                }
                LoadUsers();
            }
        }

        private void btnViewUsers_Click_1(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnViewSeats_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HallIdTxtBox.Text))
            {
                MessageBox.Show("Please enter Hall ID to view seats.",
                        "Input Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(HallIdTxtBox.Text, out int hallId) || hallId < 1 || hallId > 8)
            {
                MessageBox.Show("Please enter a valid Hall ID (1-8).",
                                "Invalid Hall ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.DataSource = Helper.db.Seats
                .Where(s => s.HallId == hallId)
                .Select(s => new
                {
                    s.SeatId,
                    s.HallId,
                    s.SeatNumber,
                    s.SeatType,
                    s.Price
                })
                .ToList();

            var BookedSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Booked");
            var AvailableSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Available");

            BookedCountTxt.Text = BookedSeatsCount.ToString();
            AvailableCountTxt.Text = AvailableSeatsCount.ToString();
        }

        private void btnResetSeats_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HallIdTxtBox.Text))
            {
                MessageBox.Show("Please enter Hall ID to reset seats.",
                                "Input Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(HallIdTxtBox.Text, out int hallId) || hallId < 1 || hallId > 8)
            {
                MessageBox.Show("Please enter a valid Hall ID (1-8).",
                                "Invalid Hall ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var seats = Helper.db.Seats
                .Where(s => s.HallId == hallId && s.SeatType == "Booked")
                .ToList();

            if (seats.Count == 0)
            {
                MessageBox.Show("There are no booked seats to reset in this hall.",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            foreach (var seat in seats)
            {
                seat.SeatType = "Available";
            }

            Helper.db.SaveChanges();

            MessageBox.Show("Seats reset successfully!");

            dataGridView1.DataSource = Helper.db.Seats
                .Where(s => s.HallId == hallId)
                .Select(s => new
                {
                    s.SeatId,
                    s.HallId,
                    s.SeatNumber,
                    s.SeatType,
                    s.Price
                })
                .ToList();

            var BookedSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Booked");
            var AvailableSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Available");

            BookedCountTxt.Text = BookedSeatsCount.ToString();
            AvailableCountTxt.Text = AvailableSeatsCount.ToString();
        }

        private void AvailableBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HallIdTxtBox.Text))
            {
                MessageBox.Show("Please enter Hall ID to view seats.",
                        "Input Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(HallIdTxtBox.Text, out int hallId) || hallId < 1 || hallId > 8)
            {
                MessageBox.Show("Please enter a valid Hall ID (1-8).",
                                "Invalid Hall ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.DataSource = Helper.db.Seats
                .Where(s => s.HallId == hallId && s.SeatType == "Available")
                .Select(s => new
                {
                    s.SeatId,
                    s.HallId,
                    s.SeatNumber,
                    s.SeatType,
                    s.Price
                })
                .ToList();

            var BookedSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Booked");
            var AvailableSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Available");

            BookedCountTxt.Text = BookedSeatsCount.ToString();
            AvailableCountTxt.Text = AvailableSeatsCount.ToString();
        }

        private void BookedBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HallIdTxtBox.Text))
            {
                MessageBox.Show("Please enter Hall ID to view seats.",
                        "Input Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(HallIdTxtBox.Text, out int hallId) || hallId < 1 || hallId > 8)
            {
                MessageBox.Show("Please enter a valid Hall ID (1-8).",
                                "Invalid Hall ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.DataSource = Helper.db.Seats
                .Where(s => s.HallId == hallId && s.SeatType == "Booked")
                .Select(s => new
                {
                    s.SeatId,
                    s.HallId,
                    s.SeatNumber,
                    s.SeatType,
                    s.Price
                })
                .ToList();
            var BookedSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Booked");
            var AvailableSeatsCount = Helper.db.Seats.Count(s => s.HallId == hallId && s.SeatType == "Available");

            BookedCountTxt.Text = BookedSeatsCount.ToString();
            AvailableCountTxt.Text = AvailableSeatsCount.ToString();
        }
    }
}
