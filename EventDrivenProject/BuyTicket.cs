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
    public partial class BuyTicket : Form
    {
        private int showId;
        public BuyTicket(int id)
        {
            InitializeComponent();
            showId = id;
            LoadMovies();
        }

        private void LoadMovies()
        {
            var cinema = Helper.db.Cinemas.ToList();
            dataGridView3.DataSource = cinema;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var data = dataGridView3.Rows[e.RowIndex].DataBoundItem as Cinema;

            if (e.RowIndex >= 0)
            {
                label9.Text = data.CinemaName;
                label8.Text = data.Location;
                panel2.Visible = true;

                var date = Helper.db.ShowTimes.ToList();
                var applyDate = date.Where(x => x.MovieId == showId).ToList();
                dataGridView1.DataSource = applyDate;

                label2.Visible = true;
                dataGridView1.Visible = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var data = dataGridView1.Rows[e.RowIndex].DataBoundItem as ShowTime;

            if (e.RowIndex >= 0)
            {
                label11.Text = data.ShowDate.ToString();
                label13.Text = data.StartTime.ToString();
                label19.Text = data.EndTime.ToString();
                panel3.Visible = true;

                var date = Helper.db.Halls.ToList();
                var applyHall = date.Where(x => x.RoomNumber == data.HallId).ToList();
                dataGridView2.DataSource = applyHall;

                label3.Visible = true;
                dataGridView2.Visible = true;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var data = dataGridView2.Rows[e.RowIndex].DataBoundItem as Hall;

            if (e.RowIndex >= 0)
            {
                label17.Text = data.HallName;
                label21.Text = data.HallType;
                label15.Text = data.TotalSeats.ToString();
                panel4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectSeat seat = new SelectSeat();
            seat.Show();
        }
    }
}
