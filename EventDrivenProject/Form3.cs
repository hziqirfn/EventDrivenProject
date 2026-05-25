using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDrivenProject
{
    public partial class Form3 : Form
    {
        public static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                      AttachDbFilename=C:\Users\haziq\Downloads\EventDrivenProject\EventDrivenProject\TicketCinema.mdf;
                                      Integrated Security = True; TrustServerCertificate=True; Encrypt=False";
        SqlConnection con = new SqlConnection(conn);
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "select Count(*) from [User] where Email = @email";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(@"email", textBox3.Text);

            int count = (int)cmd.ExecuteScalar();

            con.Close();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("First name can't be null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Last name can't be null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Email can't be null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (count == 1)
            {
                MessageBox.Show("Email already exist", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Password can't be null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Confirm password can't be null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (textBox5.Text != textBox4.Text)
            {
                MessageBox.Show("Confirm password not same with password", "Error", MessageBoxButtons.OK);
                return;
            }
            con.Open();

            string insert = "insert into [User] (FirstName, LastName, Email, Password)" + "values(@fn, @ln, @email, @pass)";
            SqlCommand cmd2 = new SqlCommand(insert, con);

            cmd2.Parameters.AddWithValue("@fn", textBox1.Text);
            cmd2.Parameters.AddWithValue("@ln", textBox2.Text);
            cmd2.Parameters.AddWithValue("@email", textBox3.Text);
            cmd2.Parameters.AddWithValue("@pass", textBox4.Text);

            cmd2.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("User registered successfully", "Success", MessageBoxButtons.OK);
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
