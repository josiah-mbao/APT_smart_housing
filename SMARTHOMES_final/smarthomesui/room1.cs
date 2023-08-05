using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smarthomesui
{
    public partial class room1 : Form
    {
        // Class-level variable to store the userID
        private int userID;

        private int roomID = 1;
        // connection string
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int timespent;

        public room1(int userID)
        {
            InitializeComponent();
            this.userID = userID; // Store the userID in the class-level variable
            

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homepage home = new homepage(userID);
            home.Show();
            this.Hide();
        }

        private void profileButton_Click_1(object sender, EventArgs e)
        {
            profile profileForm = new profile(userID);
            profileForm.Show();
            this.Hide();
        }

        private void room1_Load(object sender, EventArgs e)
        {
            // Set the minimum date to the current date
            arrivalDate.MinDate = DateTime.Today;
            departureDate.MinDate = DateTime.Today.AddDays(1); 

            // Set the maximum date to 5 days from the current date
            arrivalDate.MaxDate = DateTime.Today.AddDays(30);
            departureDate.MaxDate = DateTime.Today.AddDays(30);

            checkInDate = arrivalDate.Value;
            checkOutDate = departureDate.Value;

            string query = "SELECT Room, Owner, Price from Rooms WHERE RoomID = @roomID";

            string relativePath = "database/smarthomesdb.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|{relativePath}";
            OleDbConnection con = new OleDbConnection(connectionString);

            using (OleDbCommand command = new OleDbCommand(query, con))
                {
                    // Add the @roomID parameter and set its value
                    command.Parameters.AddWithValue("@roomID", roomID);

                    con.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        
                        string roomName = reader.GetString(0);

                        string owner = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);


                        room1TitleLabel.Text = roomName;
                        room1Label.Text = roomName;

                        owner1Label.Text = owner;
                        price1Label.Text = $"Ksh {price.ToString()} per night";


                    }
                    // dispose of the OleDbReader
                    reader.Close();

                    // Explicitly dispose of the OleDbCommand object
                    command.Dispose();
                    con.Close();
                }
            

            
        }

        private void calctimespent(DateTime checkInDate, DateTime checkOutDate)
        {
            // Check if both arrivalDate and departureDate have valid values before comparing them
            if (checkInDate != null && checkOutDate != null)
            {
                timespent = (checkOutDate.Date - checkInDate.Date).Days + 1;
            }

        }

        private bool IsRoomAvailable(int roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            string query = "SELECT Arrival, Departure FROM Bookings WHERE RoomID = @roomID";

            string relativePath = "database/smarthomesdb.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|{relativePath}";

            using (OleDbConnection newCon = new OleDbConnection(connectionString))
            {

                using (OleDbCommand command = new OleDbCommand(query, newCon))
                {

                    command.Parameters.AddWithValue("@roomID", roomID);

                    newCon.Open();

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime arrival = reader.GetDateTime(0).Date;
                            DateTime departure = reader.GetDateTime(1).Date;

                            // Check for overlapping date range
                            if (checkInDate.Date <= departure && checkOutDate.Date >= arrival)
                            {
                                
                                return false; // Room is not available
                            }
                        }
                    }

                    
                    return true; // Room is available
                }
            }
            
        }

        private bool UserHasExistingBooking(int userID, DateTime checkInDate, DateTime checkOutDate)
        {
            string query = "SELECT Arrival, Departure FROM Bookings WHERE UserID = @userID";

            string relativePath = "database/smarthomesdb.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|{relativePath}";
            

            using (OleDbConnection newCon = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, newCon))
                {
                    command.Parameters.AddWithValue("@userID", userID);

                    newCon.Open();

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime arrival = reader.GetDateTime(0);
                            DateTime departure = reader.GetDateTime(1);

                            // Check for overlapping date range
                            if (checkInDate <= departure && checkOutDate >= arrival)
                            {
                                return true; // User already has a booking for the selected date range
                            }
                        }
                    }
                }
            }

            return false; // User does not have any existing booking for the selected date range
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alertButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void price1Label_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the necessary room information
            string roomName = room1Label.Text;
            string owner = owner1Label.Text;
            decimal price = Convert.ToDecimal(price1Label.Text.Replace("Ksh ", "").Replace(" per night", ""));

            calctimespent(checkInDate, checkOutDate);
            try
            {
                //Check if the room is available for booking during the selected date range
                if (timespent <= 5)
                {
                    if (departureDate.Value < arrivalDate.Value)
                    {
                        MessageBox.Show("Departure date cannot be before the arrival date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        departureDate.Value = arrivalDate.Value.AddDays(1); // Reset the departure date to be one day after the arrival date
                    }

                    else
                    {
                        if (IsRoomAvailable(roomID, checkInDate, checkOutDate))
                        {
                            if (!UserHasExistingBooking(userID, checkInDate, checkOutDate))
                            {
                                //Allow the booking
                                //Perform the booking and insert the information into the bookings table
                                confirmation confirmationForm = new confirmation(roomName, owner, price, checkInDate, checkOutDate, userID, roomID);
                                confirmationForm.ShowDialog();

                                homepage homepageForm = new homepage(userID);
                                homepageForm.Show();
                                this.Close();

                            }

                            else
                            {
                                MessageBox.Show("You have already booked a room within this timeframe. Please choose different dates.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }



                        }
                        else
                        {
                            //Inform the user that the room is unavailable
                            MessageBox.Show("The room is already booked during the selected date range. Please choose different dates or a different room.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You can only book a maximum of 5 nights per week.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    departureDate.Value = arrivalDate.Value.AddDays(1); // Reset the departure date to be one day after the arrival date
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void owner1Label_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkInDate = arrivalDate.Value;
        }

        private void departureDate_ValueChanged(object sender, EventArgs e)
        {
            checkOutDate = departureDate.Value;
        }

        private void bellButton_Click(object sender, EventArgs e)
        {
            Bookings bookingForm = new Bookings(userID);
            bookingForm.Show();
            this.Hide();
        }
    }
}

