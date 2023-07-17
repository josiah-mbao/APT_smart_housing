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
    public partial class room4 : Form
    {
        public room4()
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
    }
}
