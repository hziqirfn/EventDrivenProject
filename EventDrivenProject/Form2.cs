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
    public partial class Form2 : Form
    {
        public static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                      AttachDbFilename=C:\Users\haziq\Downloads\EventDrivenProject\EventDrivenProject\TicketCinema.mdf;
                                      Integrated Security = True; TrustServerCertificate=True; Encrypt=False";
        SqlConnection con = new SqlConnection(conn);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "select Count(*) from [User] where Email = @email";
            SqlCommand cmd = new SqlCommand(query, con);

            string query2 = "select Count(*) from [User] where Password = @pass";
            SqlCommand cmd2 = new SqlCommand(query2, con);

            cmd.Parameters.AddWithValue(@"email", textBox1.Text);
            cmd2.Parameters.AddWithValue(@"pass", textBox2.Text);

            int count = (int)cmd.ExecuteScalar();
            int count2 = (int)cmd2.ExecuteScalar();

            con.Close();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Email can't be null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (count == 0)
            {
                MessageBox.Show("Email not exist", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Password can't be null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (count2 == 0)
            {
                MessageBox.Show("Password is wrong", "Error", MessageBoxButtons.OK);
                return;
            }
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
