using FontAwesome.Sharp;
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

    public partial class room2 : Form
    {
        private int userID;
        private int roomID = 2;

        // connection string
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int timespent;

        public room2(int userID)
        {
            InitializeComponent();
            this.userID = userID; // Store the userID in the class-level variable
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            homepage home = new homepage(userID);
            home.Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profile profileForm = new profile(userID);
            profileForm.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void room2_Load(object sender, EventArgs e)
        {
            // Set the minimum date to the current date
            arrivalDate.MinDate = DateTime.Today;
            departureDate.MinDate = DateTime.Today.AddDays(1);

            // Set the maximum date to 5 days from the current date
            arrivalDate.MaxDate = DateTime.Today.AddDays(30);
            departureDate.MaxDate = DateTime.Today.AddDays(30);

            checkInDate = arrivalDate.Value;
            checkOutDate = departureDate.Value;

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
                    if (roomID == 2)
                    {
                        room2TitleLabel.Text = roomName;
                        room2Label.Text = roomName;

                        owner2Label.Text = owner;
                        price2Label.Text = $"Ksh {price.ToString()}";
                    }



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

            using (OleDbConnection newCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb"))
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

            using (OleDbConnection newCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb"))
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


        private void button1_Click(object sender, EventArgs e)
        {
            // Get the necessary room information
            string roomName = room2Label.Text;
            string owner = owner2Label.Text;
            decimal price = Convert.ToDecimal(price2Label.Text.Replace("Ksh ", "").Replace(" per night", ""));

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

        private void arrivalDate_ValueChanged(object sender, EventArgs e)
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
    }
}
