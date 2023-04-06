using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTest1
{
    public partial class concert : Form
    {
        public concert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c_details c1 = new c_details();
            c1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket t1 = new Ticket();
            t1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}
