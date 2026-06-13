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
    public partial class FormMovieDetails : Form
    {
        private Movie movie;
        public FormMovieDetails(Movie movie)
        {
            InitializeComponent();

            this.movie = movie;

            lblmoviename.Text = movie.Name;
            pbposter.Image = movie.Poster;
        }

        private void FormMovieDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
