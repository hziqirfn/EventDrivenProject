using EventDrivenProject.models;
using Microsoft.Data.SqlClient;

namespace EventDrivenProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Email can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Password can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = Helper.db.Users.FirstOrDefault(x => x.Email == textBox1.Text);

            if (data == null)
            {
                MessageBox.Show("Email not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (data.Password != textBox2.Text)
            {
                MessageBox.Show("Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (data != null)
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                if (textBox1.Text.Contains("@admin"))
                {
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                }
                else
                {
                    MovieSelect movieSelect = new MovieSelect();
                    movieSelect.Show();
                }

                return;
            }
            MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp register = new SignUp();
            register.Show();
        }
    }
}
