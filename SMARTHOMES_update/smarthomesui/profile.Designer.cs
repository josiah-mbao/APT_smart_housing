﻿namespace smarthomesui
{
    partial class profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bellButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.profileButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.firstnameDisplay = new System.Windows.Forms.Label();
            this.lastnameDisplay = new System.Windows.Forms.Label();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.studentIDDisplay = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.Label();
            this.emailDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phonenoDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.25552F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.74448F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.03582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.96418F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 1033);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bellButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 99);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bellButton
            // 
            this.bellButton.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.bellButton.IconColor = System.Drawing.Color.Black;
            this.bellButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bellButton.Location = new System.Drawing.Point(1137, 13);
            this.bellButton.Name = "bellButton";
            this.bellButton.Size = new System.Drawing.Size(75, 70);
            this.bellButton.TabIndex = 7;
            this.bellButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 913);
            this.panel1.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.exitButton.IconColor = System.Drawing.Color.Black;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.Location = new System.Drawing.Point(33, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 70);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profileButton.IconColor = System.Drawing.Color.Black;
            this.profileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileButton.Location = new System.Drawing.Point(33, 134);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(75, 70);
            this.profileButton.TabIndex = 5;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click_1);
            // 
            // homeButton
            // 
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.House;
            this.homeButton.IconColor = System.Drawing.Color.Black;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.Location = new System.Drawing.Point(33, 27);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 70);
            this.homeButton.TabIndex = 3;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(193, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.05802F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.94198F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(140, 117);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.90252F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.09748F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1759, 913);
            this.tableLayoutPanel2.TabIndex = 6;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.firstnameDisplay);
            this.panel3.Controls.Add(this.lastnameDisplay);
            this.panel3.Controls.Add(this.usernameDisplay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(549, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1207, 477);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // firstnameDisplay
            // 
            this.firstnameDisplay.AutoSize = true;
            this.firstnameDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameDisplay.Location = new System.Drawing.Point(153, 83);
            this.firstnameDisplay.Name = "firstnameDisplay";
            this.firstnameDisplay.Size = new System.Drawing.Size(251, 50);
            this.firstnameDisplay.TabIndex = 2;
            this.firstnameDisplay.Text = "First Name";
            this.firstnameDisplay.Click += new System.EventHandler(this.firstnameDisplay_Click);
            // 
            // lastnameDisplay
            // 
            this.lastnameDisplay.AutoSize = true;
            this.lastnameDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameDisplay.Location = new System.Drawing.Point(153, 201);
            this.lastnameDisplay.Name = "lastnameDisplay";
            this.lastnameDisplay.Size = new System.Drawing.Size(246, 50);
            this.lastnameDisplay.TabIndex = 1;
            this.lastnameDisplay.Text = "Last Name";
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.usernameDisplay.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameDisplay.ForeColor = System.Drawing.SystemColors.GrayText;
            this.usernameDisplay.Location = new System.Drawing.Point(154, 329);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(185, 43);
            this.usernameDisplay.TabIndex = 0;
            this.usernameDisplay.Text = "username";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.studentIDDisplay);
            this.panel4.Controls.Add(this.studentID);
            this.panel4.Controls.Add(this.emailDisplay);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.phonenoDisplay);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(549, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1207, 424);
            this.panel4.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(328, 322);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(296, 50);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Update Details";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // studentIDDisplay
            // 
            this.studentIDDisplay.AutoSize = true;
            this.studentIDDisplay.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDDisplay.Location = new System.Drawing.Point(565, 205);
            this.studentIDDisplay.Name = "studentIDDisplay";
            this.studentIDDisplay.Size = new System.Drawing.Size(145, 43);
            this.studentIDDisplay.TabIndex = 6;
            this.studentIDDisplay.Text = "808310";
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentID.Location = new System.Drawing.Point(154, 206);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(192, 42);
            this.studentID.TabIndex = 5;
            this.studentID.Text = "Student ID";
            // 
            // emailDisplay
            // 
            this.emailDisplay.AutoSize = true;
            this.emailDisplay.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailDisplay.Location = new System.Drawing.Point(565, 106);
            this.emailDisplay.Name = "emailDisplay";
            this.emailDisplay.Size = new System.Drawing.Size(226, 43);
            this.emailDisplay.TabIndex = 4;
            this.emailDisplay.Text = "......@....com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // phonenoDisplay
            // 
            this.phonenoDisplay.AutoSize = true;
            this.phonenoDisplay.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenoDisplay.Location = new System.Drawing.Point(565, 10);
            this.phonenoDisplay.Name = "phonenoDisplay";
            this.phonenoDisplay.Size = new System.Drawing.Size(161, 43);
            this.phonenoDisplay.TabIndex = 2;
            this.phonenoDisplay.Text = "07..........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone No";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 486);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 424);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.iconPictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(540, 477);
            this.panel6.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 477;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(540, 477);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(33, 252);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 70);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton bellButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton profileButton;
        private FontAwesome.Sharp.IconButton homeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lastnameDisplay;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.Label firstnameDisplay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label phonenoDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label studentIDDisplay;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.Label emailDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}