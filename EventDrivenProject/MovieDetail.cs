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

            this.Load += (s, e) => UpdateMovie();
        }

        private void UpdateMovie()
        {

            Hallidlabel.Text = movies.MovieId.ToString();
            lbltxtmoviename.Text = movies.Title;
            lbltextgenre.Text = movies.Genre;
            lbltxtduration.Text = movies.Duration;
            lbltxtrelease.Text = movies.ReleaseDate?.ToString("dd/MM/yyyy") ?? "-";
            lbltxtdescription.Text = movies.Description ?? "-";

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



        private void lbltxtmoviename_Click(object sender, EventArgs e)
        {

        }

        private void lbltextgenre_Click(object sender, EventArgs e)
        {

        }

        private void lbltxtduration_Click(object sender, EventArgs e)
        {

        }

        private void lbltxtrelease_Click(object sender, EventArgs e)
        {

        }

        private void lbltxtdescription_Click(object sender, EventArgs e)
        {

        }

        private void btnbuyticket_Click(object sender, EventArgs e)
        {
            //this.Hide();
            BuyTicket buy = new BuyTicket(movies.MovieId);
            buy.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hallidlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
