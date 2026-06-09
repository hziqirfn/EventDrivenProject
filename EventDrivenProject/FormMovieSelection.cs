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
    public partial class FormMovieSelection : Form
    {
        public FormMovieSelection()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (currentIndex < movies.Count - 1)
            {
                currentIndex++;
                UpdateMovie();
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateMovie();
            }
        }

        private void UpdateMovie()
        {
            pbposter.Image = movies[currentIndex].Poster;
            lvlmoviename.Text = movies[currentIndex].Name;
        }

        private void pbposter_DoubleClick(object sender, EventArgs e)
        {
            frmMovieDetails details = new frmMovieDetails(movies[currentIndex]);
            details.Show();
            this.Hide();
        }
    }
}
