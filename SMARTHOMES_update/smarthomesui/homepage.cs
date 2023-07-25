using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smarthomesui
{
    public partial class homepage : Form
    {
        private int userID; // Class-level variable to store the userID

        // connection string
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        public homepage(int userID)
        {
            InitializeComponent();
            this.userID = userID; // Store the userID in the class-level variable
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profile profileForm = new profile(userID);
            profileForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            room1 room1Form = new room1(userID);
            room1Form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            room2 room2Form = new room2(userID);
            room2Form.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            room3 room3Form = new room3(userID);
            room3Form.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            room4 room4Form = new room4(userID);
            room4Form.Show();
            this.Hide();
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            string query = "SELECT Room, Owner, Price from Rooms";


        }
    }
}
