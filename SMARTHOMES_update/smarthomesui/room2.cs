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

        // connection string
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

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
            string query = "SELECT ID, Room, Owner, Price from Rooms";

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
    }
}
