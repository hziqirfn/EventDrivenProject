using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EventDrivenProject
{
    public partial class FormMovieSelection : Form
    {
        List<Movie> movies = new List<Movie>();
        int currentIndex = 0;

        public FormMovieSelection()
        {
            InitializeComponent();
            LoadMovies();
            UpdateMovie();
        }

        private void LoadMovies()
        {
            movies = new List<Movie>
            {
               
                new Movie { Name = "The Furious", Poster = Properties.Resources.TheSheepDetectives_big },
                new Movie { Name = "The Sheep Detectives", Poster = Properties.Resources.TheSheepDetectives_big },
                new Movie { Name = "Fleak", Poster = Properties.Resources.TheSheepDetectives_big },
                new Movie { Name = "Super Mario Galaxy Movie", Poster = Properties.Resources.TheSheepDetectives_big }
            };
        }

        private void FormMovieSelection_Load(object sender, EventArgs e)
        {
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            if (currentIndex < movies.Count - 1)
            {
                currentIndex++;
                UpdateMovie();
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateMovie();
            }
        }

        private void UpdateMovie()
        {
            if (movies.Count == 0) return;

            pbposter.Image = movies[currentIndex].Poster;
            lvlmoviename.Text = movies[currentIndex].Name;
        }

        private void pbposter_DoubleClick(object sender, EventArgs e)
        {
            if (movies.Count == 0) return;

            FormMovieDetails details = new FormMovieDetails(movies[currentIndex]);
            details.Show();
            this.Hide();
        }
    }

    public class Movie
    {
        public string Name { get; set; }
        public Image Poster { get; set; }
    }
}