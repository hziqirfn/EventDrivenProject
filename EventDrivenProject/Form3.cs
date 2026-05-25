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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
