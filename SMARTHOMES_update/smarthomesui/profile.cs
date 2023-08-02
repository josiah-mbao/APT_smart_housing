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
using System.Xml;

namespace smarthomesui
{
    public partial class profile : Form
    {
        private int userID;

        // connection string
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        public profile(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void homeButton_Click_1(object sender, EventArgs e)
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

        


        private void profile_Load(object sender, EventArgs e)
        {
            string query = "SELECT First_Name, Last_Name, Email, Phone_No, Student_ID, Username FROM User_table WHERE UserID = @userID";

            using (OleDbCommand command = new OleDbCommand(query, con))
            {
                command.Parameters.AddWithValue("@userID", userID);

                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve user information from the data reader
                    string First_Name = reader.GetString(0);
                    string Last_Name = reader.GetString(1);
                    string Email = reader.GetString (2);
                    string Phone_No = reader.GetString (3);
                    string Student_ID = reader.GetString (4);
                    string Username = reader.GetString (5);

                    // Populate UI controls with user information
                    firstnameDisplay.Text = First_Name;
                    lastnameDisplay.Text = Last_Name;
                    emailDisplay.Text = Email;
                    phonenoDisplay.Text = Phone_No;
                    studentIDDisplay.Text = Student_ID;
                    usernameDisplay.Text = Username;
                }

                // dispose of the OleDbReader
                reader.Close();

                // Explicitly dispose of the OleDbCommand object
                command.Dispose();
                



            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstnameDisplay_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            profileUpdate profileUpdateForm = new profileUpdate(userID);
            profileUpdateForm.ShowDialog();
            
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
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
