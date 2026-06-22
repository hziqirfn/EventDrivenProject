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

            movies = new List<Movie>
    {
        new Movie
        {
            MovieId = 1,
            Title = "Polong",
            Genre = "Horror / Supernatural",
            Duration = "1h 45m",
            ReleaseDate = new DateOnly(2026, 4, 10),
            Description = "A mysterious spirit known as Polong begins haunting a small village, feeding on fear and controlling its victims through dark possession.",
            Image = "Polong_big.jpg"
        },

        new Movie
        {
            MovieId = 2,
            Title = "The Furious",
            Genre = "Action / Crime",
            Duration = "2h 10m",
            ReleaseDate = new DateOnly(2023, 6, 15),
            Description = "An underground racer gets pulled into a high-stakes criminal syndicate where speed is the only way to survive.",
            Image = "TheFurious_big.jpg"
        },

        new Movie
        {
            MovieId = 4,
            Title = "The Sheep Detectives",
            Genre = "Comedy / Mystery",
            Duration = "1h 50m",
            ReleaseDate = new DateOnly(2025, 3, 20),
            Description = "A group of unlikely animal detectives uncover bizarre farm mysteries that escalate into a nationwide conspiracy.",
            Image = "TheSheepDetectives_big.jpg"
        },

        new Movie
        {
            MovieId = 8,
            Title = "The Super Mario Galaxy Movie",
            Genre = "Animation / Adventure / Sci-Fi",
            Duration = "1h 58m",
            ReleaseDate = new DateOnly(2026, 4, 10),
            Description = "Mario embarks on a cosmic journey across galaxies to rescue Princess Peach and stop a universal threat led by cosmic forces.",
            Image = "TheSuperMarioGalaxyMovie_big.jpg"
        }
    };

            currentIndex = 0;
            UpdateMovie();
        }


        private void UpdateMovie()
        {
            if (movies.Count == 0) return;

            var movie = movies[currentIndex];
            lblmoviename.Text = movie.Title;

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", movie.Image);

            if (pbmovie.Image != null)
            {
                pbmovie.Image.Dispose();
                pbmovie.Image = null;
            }

            if (File.Exists(imagePath))
            {
                pbmovie.Image = Image.FromFile(imagePath);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            MovieDetail details = new MovieDetail(movies[currentIndex]);
            details.ShowDialog();
        }

        private void lblmoviename_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            currentIndex++;

            if (currentIndex >= movies.Count)
            {
                currentIndex = 0;
            }
            UpdateMovie();
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            currentIndex--;

            if (currentIndex < 0)
            {
                currentIndex = movies.Count - 1;
            }
            UpdateMovie();
        }

        private void MovieSelect_Load(object sender, EventArgs e)
        {

        }

        private void pbmovie_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
