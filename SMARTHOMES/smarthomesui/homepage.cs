using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smarthomesui
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new profile().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new room1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new room2().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new room3().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new room4().Show();
            this.Hide();
        }
    }
}
