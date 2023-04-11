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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            concert c1 = new concert();
            c1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard f4 = new Dashboard();
            f4.Show();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
