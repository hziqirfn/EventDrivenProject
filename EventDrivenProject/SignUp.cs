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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventDrivenProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("First Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Last Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Email can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Password can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Confirm Password can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox5.Text != textBox4.Text)
            {
                MessageBox.Show("Password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = Helper.db.Users.FirstOrDefault(x => x.Email == textBox3.Text);

            if (data != null)
            {
                MessageBox.Show("Email already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var keep = new User()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Email = textBox3.Text,
                Password = textBox4.Text
            };

            if (keep != null)
            {
                Helper.db.Users.Add(keep);
                Helper.db.SaveChanges();

                MessageBox.Show("Register user successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Login login = new Login();
                login.Show();
                return;
            }
            MessageBox.Show("Register user failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
