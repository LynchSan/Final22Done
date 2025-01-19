using Snake;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace buttonsPractice
{
    public partial class MainMenuForm : Form
    {
        
        private struct ControlData
        {
            public Size OriginalSize;
            public Point OriginalLocation;
        }

        private Dictionary<Control, ControlData> controlData;
        private Size originalFormSize;

        public MainMenuForm()
        {
            InitializeComponent();

            // Initialize the control data dictionary
            controlData = new Dictionary<Control, ControlData>();

            this.Load += MainMenuForm_Load;
            this.Resize += MainMenuForm_Resize;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Save the original size of the form
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control
            foreach (Control control in this.Controls)
            {
                controlData[control] = new ControlData
                {
                    OriginalSize = control.Size,
                    OriginalLocation = control.Location
                };
            }
        }

        private void MainMenuForm_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            float widthScale = (float)this.ClientSize.Width / originalFormSize.Width;
            float heightScale = (float)this.ClientSize.Height / originalFormSize.Height;

            foreach (var kvp in controlData)
            {
                Control control = kvp.Key;
                ControlData data = kvp.Value;

                // Scale size
                control.Size = new Size(
                    (int)(data.OriginalSize.Width * widthScale),
                    (int)(data.OriginalSize.Height * heightScale)
                );

                // Scale location
                control.Location = new Point(
                    (int)(data.OriginalLocation.X * widthScale),
                    (int)(data.OriginalLocation.Y * heightScale)
                );
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void operationsButton_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            operations.Show();
            this.Close();
        }

        private void welcomeText_Click(object sender, EventArgs e) { }

        private void pictureArithmetic_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void exitButton_Click(object sender, EventArgs e) { }

        private void exitButtonMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gamesButton_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Close();
        }

        private void csButton_Click(object sender, EventArgs e)
        {
            AboutCs aboutCs = new AboutCs();
            aboutCs.Show();
            this.Close();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Close();
        }
    }
}
