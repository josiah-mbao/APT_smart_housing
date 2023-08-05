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
    public partial class signup : Form
    {
        // connection string
       

        private int userID;

        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                string relativePath = "database/smarthomesdb.accdb";
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|{relativePath}";
                OleDbConnection con = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter ad = new OleDbDataAdapter();

                con.Open();
                string register = "INSERT INTO User_table (First_Name, Last_Name, Email, Phone_No, Student_ID, Username, [Password]) VALUES ('" + firstName.Text + "', '" + lastName.Text + "', '" + eMail.Text + "','" + phoneNo.Text + "', '" + studentID.Text + "', '" + username.Text + "','" + password.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your account has been successfully created", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
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


        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        
    }
}
