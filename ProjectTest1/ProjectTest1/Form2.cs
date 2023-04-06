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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gurav\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }
        string email = "@gmail.com";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ("@gmail.com" == textBox3.Text)
            {
                //con.Open();
                //string query = "insert into register (Email, Fn, Ln, Un, Pw, recover) values ('"+ textBox3.Text +"','"+ textBox4.Text +"', '"+ textBox5.Text +"','"+ textBox1.Text +"','"+ textBox2.Text +"','"+ textBox7.Text +"')";
                //SqlCommand com = new SqlCommand(query, con);
                //com.ExecuteNonQuery();
                MessageBox.Show("Registered successfully");
                //con.Close();
            }
            else
            {
                MessageBox.Show("Registered not successfully");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
