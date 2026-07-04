using EventDrivenProject.models;
using Microsoft.EntityFrameworkCore;
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
        private int cinemaId;
        private int hallId;
        private int movieId;
        private int showId;
        private string cinemaName;
        public BuyTicket(int movieId)
        {
            InitializeComponent();
            this.movieId = movieId;
            LoadMovies();
            button2.Visible = false;
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
            cinemaId = data.CinemaId;

            CinemaIdTxt.Text = data.CinemaId.ToString();
            label9.Text = data.CinemaName;
            label8.Text = data.Location;

            panel2.Visible = true;

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            label2.Visible = true;
            label3.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            button2.Visible = false;

            int currentMovieId = movieId;
            int currentCinemaId = cinemaId;

            var applyDate = (from st in Helper.db.ShowTimes
                            join h in Helper.db.Halls on st.HallId equals h.HallId
                            where st.MovieId == currentMovieId
                               && h.CinemaId == currentCinemaId
                            select st
                        ).ToList();

            dataGridView1.DataSource = applyDate;
            dataGridView1.Visible = true;
            cinemaName = data.CinemaName;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var data = dataGridView1.Rows[e.RowIndex].DataBoundItem as ShowTime;
            showId = data.ShowTimeId;

            label11.Text = data.ShowDate.ToString();
            label13.Text = data.StartTime.ToString();
            label19.Text = data.EndTime.ToString();

            panel3.Visible = true;

            var availableHalls = (
                                from st in Helper.db.ShowTimes
                                join h in Helper.db.Halls on st.HallId equals h.HallId
                                where st.MovieId == movieId
                                   && h.CinemaId == cinemaId
                                select h
                            ).Distinct().ToList();

            dataGridView2.DataSource = availableHalls;

            label3.Visible = true;
            dataGridView2.Visible = true;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var data = dataGridView2.Rows[e.RowIndex].DataBoundItem as Hall;

            hallId = data.HallId;

            if (e.RowIndex >= 0)
            {
                HallIdTxt.Text = hallId.ToString();
                label17.Text = data.HallName;
                label21.Text = data.HallType;
                label15.Text = data.TotalSeats.ToString();
                panel4.Visible = true;
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectSeat seat = new SelectSeat(cinemaId, hallId, cinemaName, showId);
            seat.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
