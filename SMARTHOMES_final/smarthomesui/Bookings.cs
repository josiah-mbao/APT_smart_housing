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
    public partial class Bookings : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        private int userID;

        public Bookings(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        
        private void Bookings_Load(object sender, EventArgs e)
        {
            string query = "SELECT r.Room, b.Arrival, b.Departure, b.Total FROM Bookings AS b INNER JOIN Rooms AS r ON b.RoomID = r.RoomID WHERE b.UserID = @userID;";

            using (OleDbCommand command = new OleDbCommand(query, con))
            {
                command.Parameters.AddWithValue("@userID", userID);

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Remove time from the Arrival and Departure columns
                foreach (DataRow row in dataTable.Rows)
                {
                    row["Arrival"] = ((DateTime)row["Arrival"]).Date;
                    row["Departure"] = ((DateTime)row["Departure"]).Date;
                }

                // Add the Delete button column
                //DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                //{
                    //HeaderText = "Delete",
                    //Text = "Delete", // Set the button text to "Delete"
                    //UseColumnTextForButtonValue = true // Make sure the button shows the Text property value
                //};

                // Add the Delete button column to the dataGridView
                //dataGridView.Columns.Add(deleteButtonColumn);

                //dataGridView.Columns["Room"].DisplayIndex = 0;
                //dataGridView.Columns["Arrival"].DisplayIndex = 1;
                //dataGridView.Columns["Departure"].DisplayIndex = 2;
                //dataGridView.Columns["Total"].DisplayIndex = 3;
                //dataGridView.Columns["Delete"].DisplayIndex = dataGridView.Columns.Count - 1; // Set the display index to the last position

                dataGridView.ReadOnly = true;

                dataGridView.DataSource = dataTable;

                // Auto-size columns to fit content
                dataGridView.AutoResizeColumns();

                // Customize the appearance of the DataGridView
                dataGridView.BorderStyle = BorderStyle.None;
                dataGridView.RowHeadersVisible = false;
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profile profileForm = new profile(userID);
            profileForm.Show();
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

        private void homeButton_Click(object sender, EventArgs e)
        {
            homepage home = new homepage(userID);
            home.Show();
            this.Hide();
        }

        private void bellButton_Click(object sender, EventArgs e)
        {
            Bookings bookingForm = new Bookings(userID);
            bookingForm.Show();
            this.Hide();
        }
    }
}
