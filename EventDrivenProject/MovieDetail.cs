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
    public partial class MovieDetail : Form
    {
        private Movie movies;
        public MovieDetail(Movie movie)
        {
            InitializeComponent();
            movies = movie;
            UpdateMovie();
        }

        private void UpdateMovie()
        {
            label11.Text = movies.Title;
            label10.Text = movies.Genre;
            label9.Text = movies.Duration;
            label7.Text = movies.ReleaseDate.ToString();
            label8.Text = movies.Description ?? "-";

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", movies.Image);

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            BuyTicket buy = new BuyTicket(movies.MovieId);
            buy.ShowDialog();
        }
    }
}
