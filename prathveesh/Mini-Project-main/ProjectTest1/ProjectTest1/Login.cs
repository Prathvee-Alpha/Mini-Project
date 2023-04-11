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

namespace ProjectTest1
{
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gurav\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* &*/
            int ct = 0;
            con.Open();

            string query = "SELECT Un FROM register WHERE Un = @username";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@username", textBox1.Text);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                ct++;
                reader.Close();
            }
            else
            {
                MessageBox.Show("Invalid username");
                reader.Close();
            }


            string query2 = "SELECT Pw FROM register WHERE Pw = @password";

            SqlCommand command2 = new SqlCommand(query2, con);

            command2.Parameters.AddWithValue("@password", textBox2.Text);

            SqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.HasRows)
            {
                ct++;
                reader2.Close();
            }
            else
            {
                MessageBox.Show("Invalid password");
                reader2.Close();

            }
            con.Close();
            if (ct == 2)
            {
                Dashboard f4 = new Dashboard();
                f4.Show();
            }

           /*
            Dashboard f4 = new Dashboard();
            f4.Show();
           */
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register f2 = new Register();
            f2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Recovery f3 = new Recovery();
            f3.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
