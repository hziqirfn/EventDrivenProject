using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDrivenProject
{
    public partial class FormLogin : Form
    {
        // Use |DataDirectory| so the database file can be placed alongside the app binaries
        public static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TicketCinema.mdf;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input before trying to open the database
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Email can't be empty", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Password can't be empty", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                using (SqlConnection conLocal = new SqlConnection(conn))
                {
                    conLocal.Open();

                    // Check email+password together to avoid matching different users
                    string query = "SELECT COUNT(*) FROM [User] WHERE Email = @email AND Password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conLocal))
                    {
                        cmd.Parameters.AddWithValue("@email", textBox1.Text);
                        cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Email or password is incorrect", "Error", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Show the exception so the user (or developer) can see what went wrong at runtime
                MessageBox.Show("An error occurred while trying to log in:\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }
            this.Hide();
            FormMovieSelection f4 = new FormMovieSelection();
            f4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
