﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public room2(int userID)
        {
            InitializeComponent();
            this.userID = userID; // Store the userID in the class-level variable
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

        
    }
}
