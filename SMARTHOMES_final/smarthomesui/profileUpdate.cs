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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace smarthomesui
{
    public partial class profileUpdate : Form
    {
        private int userID;

        // connection string
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        public profileUpdate(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void profileUpdate_Load(object sender, EventArgs e)
        {
            string query = "SELECT First_Name, Last_Name, Email, Phone_No, Student_ID, Username, Password from User_table WHERE UserID = @userID";

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
                    string Email = reader.GetString(2);
                    string Phone_No = reader.GetString(3);
                    string Student_ID = reader.GetString(4);
                    string Username = reader.GetString(5);
                    string Password = reader.GetString(6);

                    // Populate UI controls with user information
                    firstName.Text = First_Name;
                    lastName.Text = Last_Name;
                    eMail.Text = Email;
                    phoneNo.Text = Phone_No;
                    studentID.Text = Student_ID;
                    username.Text = Username;
                    password.Text = Password;

                }

                // dispose of the OleDbReader
                reader.Close();

                // Explicitly dispose of the OleDbCommand object
                command.Dispose();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstName.Text) || string.IsNullOrWhiteSpace(lastName.Text) || string.IsNullOrWhiteSpace(eMail.Text) ||
                string.IsNullOrWhiteSpace(phoneNo.Text) || string.IsNullOrWhiteSpace(studentID.Text) || string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(confirmPassword.Text))
            {
                MessageBox.Show("Sign up failed", "Fill all the fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text != confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match, Please try again", "Registration unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                confirmPassword.Text = "";
                password.Focus();
            }
            else if (firstName.Text.Length < 2 || lastName.Text.Length < 2)
            {
                MessageBox.Show("First Name and Last Name should be at least 2 characters long.", "Registration unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidPhoneNumber(phoneNo.Text))
            {
                MessageBox.Show("Invalid Phone No. Please enter a valid 10-digit phone number.", "Registration unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNo.Text = "";
                phoneNo.Focus();
            }
            else if (!IsValidStudentID(studentID.Text))
            {
                MessageBox.Show("Invalid Student ID. Please enter a valid 6-digit student ID.", "Registration unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentID.Text = "";
                studentID.Focus();
            }
            else
            {
                string updateQuery = "UPDATE User_table SET First_Name = @firstName, Last_Name = @lastName, Email = @eMail, Phone_No = @phoneNo, Student_ID = @studentID, Username = @username, [Password] = @password WHERE UserID = @userID";

                using (OleDbCommand command = new OleDbCommand(updateQuery, con))
                {
                    command.Parameters.AddWithValue("@firstName", firstName.Text);
                    command.Parameters.AddWithValue("@lastName", lastName.Text);
                    command.Parameters.AddWithValue("@eMail", eMail.Text);
                    command.Parameters.AddWithValue("@phoneNo", phoneNo.Text);
                    command.Parameters.AddWithValue("@studentID", studentID.Text);
                    command.Parameters.AddWithValue("@username", username.Text);
                    command.Parameters.AddWithValue("@password", password.Text);
                    command.Parameters.AddWithValue("@userID", userID);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Your account has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Phone No should be a valid 10-digit number
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private bool IsValidStudentID(string studentID)
        {
            // Student ID should be a valid 6-digit number
            return System.Text.RegularExpressions.Regex.IsMatch(studentID, @"^\d{6}$");
        }
    

    }
}
