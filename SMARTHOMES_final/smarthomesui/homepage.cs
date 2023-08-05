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

        private void button1_Click(object sender, EventArgs e)
        {


            // Create an instance of the Room1 form and pass the roomID as a parameter to its constructor
            room1 room1Form = new room1(userID);
            room1Form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            string relativePath = "database/smarthomesdb.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|{relativePath}";
            OleDbConnection con = new OleDbConnection(connectionString);

            string query = "SELECT RoomID, Room, Owner, Price from Rooms";

            using (OleDbCommand command = new OleDbCommand(query, con))
            {
                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    
                        int roomID = reader.GetInt32(0);
                        string roomName = reader.GetString(1);

                        string owner = reader.GetString(2);
                        decimal price = reader.GetDecimal(3);

                        // Check the RoomID and update the corresponding labels with the room information
                        if (roomID == 1)
                        {
                            room1.Text = roomName;

                            owner1.Text = owner;
                            price1.Text = $"Ksh {price.ToString()}";
                        }

                        else if (roomID == 2)
                        {
                            room2.Text = roomName;
                            owner2.Text = owner;
                            price2.Text = $"Ksh {price.ToString()}";
                        }
                        else if (roomID == 3)
                        {
                            room3.Text = roomName;
                        
                            owner3.Text = owner;
                            price3.Text = $"Ksh {price.ToString()}";
                        }
                        else if (roomID == 4)
                        {
                            room4.Text = roomName;
                            
                            owner4.Text = owner;
                            price4.Text = $"Ksh {price.ToString()}";
                        }
                    
                }
                // dispose of the OleDbReader
                reader.Close();

                // Explicitly dispose of the OleDbCommand object
                command.Dispose();
                con.Close();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bellButton_Click(object sender, EventArgs e)
        {
            Bookings bookingForm = new Bookings(userID);
            bookingForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform log-out actions here if needed (e.g., clearing user session data)

                // Navigate back to the login page
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            room2 room2Form = new room2(userID);
            room2Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            room3 room3Form = new room3(userID);
            room3Form.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            room4 room4Form = new room4(userID);
            room4Form.Show();
            this.Hide();
        }
    }
}
