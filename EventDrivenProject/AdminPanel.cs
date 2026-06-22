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
            dataGridView1.DataSource = Helper.db.Seats
                .Select(s => new
                {
                    s.SeatId,
                    s.HallId,
                    s.SeatNumber,
                    s.SeatType,
                    s.Price
                })
                .ToList();
        }

        private void btnResetSeats_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to reset", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var seats = Helper.db.Seats
                    .Where(s => s.SeatType == "Booked")
                    .ToList();

                foreach (var s in seats)
                {
                    s.SeatType = "Available";
                }

                Helper.db.SaveChanges();
                MessageBox.Show("Seats reset successfully!");
            }
        }
    }
}
