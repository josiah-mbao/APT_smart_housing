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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace smarthomesui
{
    public partial class confirmation : Form
    {
        // connection string
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private string roomName;
        private string owner;
        private decimal price, totalCost;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        
        private int userID, roomID;
        
        

        public confirmation(string roomName, string owner, decimal price, DateTime checkInDate, DateTime checkOutDate, int userID, int roomID)
        {
            InitializeComponent();

            this.roomName = roomName;
            this.owner = owner;
            this.price = price;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.userID = userID;
            this.roomID =roomID;
           
            


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirmation_Load(object sender, EventArgs e)
        {
            // Calculate the total cost
            int numberOfNights = ((int)(checkOutDate.Date - checkInDate.Date).TotalDays) + 1;
            this.totalCost = numberOfNights * price;

            // Populate the labels with the information
            roomLabel.Text = roomName;
            //ownerLabel.Text = owner;
            //priceLabel.Text = $"Ksh {price.ToString()} per night";
            arrivalLabel.Text = checkInDate.ToShortDateString();
            departureLabel.Text = checkOutDate.ToShortDateString();
            totalLabel.Text = $"Ksh {totalCost.ToString()}";
            daysLabel.Text = numberOfNights.ToString();

            // Format the total cost as a currency
            string formattedTotalCost = totalCost.ToString("Ksh");


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb"))
            {
                con.Open();
                string register = "INSERT INTO Bookings (UserID, RoomID, Arrival, Departure, Total) VALUES ('"+ userID + "', '" + roomID + "','" + checkInDate + "', '" + checkOutDate +"', '" + this.totalCost + "')";
                cmd = new OleDbCommand(register, con);
               
                //cmd.Parameters.AddWithValue("@total", totalCost);
                
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("You have successfully booked the room", "Booking Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.Close();
            }
        }
    }
}
