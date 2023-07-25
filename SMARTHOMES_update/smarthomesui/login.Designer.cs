using System;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace smarthomesui
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // connection string
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Documents\\smarthomesdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.signIn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            resources.ApplyResources(this.iconButton1, "iconButton1");
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 36;
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            // 
            // iconButton2
            // 
            resources.ApplyResources(this.iconButton2, "iconButton2");
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 36;
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // signIn
            // 
            resources.ApplyResources(this.signIn, "signIn");
            this.signIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signIn.Name = "signIn";
            this.signIn.UseVisualStyleBackColor = false;
            this.signIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.signIn);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.password);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM User_table WHERE Username= '" + username.Text + "' and Password= '" + password.Text + "'";
            cmd = new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                // Store the verified username in a variable
                string verifiedUsername = username.Text;

                con.Close();

                // Reuse the existing connection and execute another query to fetch the UserID using the verified username
                con.Open();
                string getUserID = "SELECT ID FROM User_table WHERE Username= @verifiedUsername";
                cmd = new OleDbCommand(getUserID, con);
                cmd.Parameters.AddWithValue("@verifiedUsername", verifiedUsername);

                // Execute the second query to fetch the UserID
                OleDbDataReader dr2 = cmd.ExecuteReader();  

                if (dr2.Read())
                {
                    // Fetch the UserID from the data reader and store it in a variable
                    int userID = dr2.GetInt32(0);
                    con.Close();

                    // Open the homepage form and pass the userID as a parameter
                    homepage home = new homepage(userID);
                    home.Show();
                    this.Hide();
                }


                
            }

            else
            {
                MessageBox.Show("Invalid Credentials. Try again");

                username.Text = "";
                password.Text = "";
                username.Focus();
            }


            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Sign in failed");
            }
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signup().Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private EventHandler iconButton2_Click;
        private EventHandler textBox1_TextChanged_1;
        private EventHandler iconButton1_Click;
        private EventHandler pictureBox1_Click;

        public EventHandler Form1_Load { get; private set; }
    }
}

