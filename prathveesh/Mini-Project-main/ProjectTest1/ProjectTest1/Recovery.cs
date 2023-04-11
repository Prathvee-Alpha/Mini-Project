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
    public partial class Recovery : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gurav\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");


        public Recovery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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


            string query2 = "SELECT recover FROM register WHERE recover = @recover";

            SqlCommand command2 = new SqlCommand(query2, con);

            command2.Parameters.AddWithValue("@recover", textBox2.Text);

            SqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.HasRows)
            {
                ct++;
                reader2.Close();
            }
            else
            {
                MessageBox.Show("Invalid answer");
                reader2.Close();

            }
            con.Close();
            if (ct == 2)
            {
                Dashboard f4 = new Dashboard();
                f4.Show();
            }
        }

        private void Recovery_Load(object sender, EventArgs e)
        {

        }
    }
}
