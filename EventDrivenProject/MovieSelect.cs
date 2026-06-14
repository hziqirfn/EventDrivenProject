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
    public partial class MovieSelect : Form
    {
        List<Movie> movies = new List<Movie>();
        int currentIndex = 0;
        public MovieSelect()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            movies = Helper.db.Movies.ToList();
            UpdateMovie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            currentIndex++;

            if (currentIndex >= movies.Count)
            {
                currentIndex = 0;
            }
            UpdateMovie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            currentIndex--;

            if (currentIndex < 0)
            {
                currentIndex = movies.Count - 1;
            }
            UpdateMovie();
        }

        private void UpdateMovie()
        {
            if (movies.Count == 0) return;

            var movie = movies[currentIndex];
            label4.Text = movie.Title;

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", movie.Image);

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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            MovieDetail details = new MovieDetail(movies[currentIndex]);
            details.ShowDialog();
        }
    }
}
