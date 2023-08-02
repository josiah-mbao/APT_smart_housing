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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private int userID;

        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (username.Text == "" && password.Text == "" && firstName.Text == "" && lastName.Text == "" && eMail.Text == "" && confirmPassword.Text == "" && phoneNo.Text == "" && studentID.Text == "")
            {
                MessageBox.Show("Sign up failed", "Fill all the fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text == confirmPassword.Text)
            {
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

            else
            {
                MessageBox.Show("Passwords do not match, Please try again", "Registration unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                confirmPassword.Text = "";
                password.Focus();  
            }
                
                
            
            
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
