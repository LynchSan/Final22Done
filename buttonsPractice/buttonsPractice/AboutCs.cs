using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace buttonsPractice
{
    public partial class AboutCs : Form
    {
        private aboutCsChangeImage aboutChangeImage;

        // Dictionary to store original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;

        public AboutCs()
        {
            InitializeComponent();
            aboutChangeImage = new aboutCsChangeImage();

            // Initialize the resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += AboutCs_Load; // Hook the Load event to initialize resizing
            this.Resize += AboutCs_Resize; // Hook the Resize event to handle dynamic resizing
        }

        private void AboutCs_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void AboutCs_Resize(object sender, EventArgs e)
        {
            // Adjust control sizes and positions dynamically on form resize
            ResizeControls();
        }

        private void ResizeControls()
        {
            // Calculate scaling factors based on current and original form sizes
            float widthScale = (float)this.ClientSize.Width / originalFormSize.Width;
            float heightScale = (float)this.ClientSize.Height / originalFormSize.Height;

            foreach (var kvp in controlData)
            {
                var control = kvp.Key;
                var (originalSize, originalLocation) = kvp.Value;

                // Scale the size of the control
                control.Size = new Size(
                    (int)(originalSize.Width * widthScale),
                    (int)(originalSize.Height * heightScale)
                );

                // Scale the position of the control
                control.Location = new Point(
                    (int)(originalLocation.X * widthScale),
                    (int)(originalLocation.Y * heightScale)
                );
            }
        }

        private void whatButton_Click(object sender, EventArgs e)
        {
            aboutChangeImage.aboutCsChange(aboutCsPicture);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            aboutChangeImage.historyCsChange(aboutCsPicture);
        }

        private void basicButton_Click(object sender, EventArgs e)
        {
            aboutChangeImage.basicCsChange(aboutCsPicture);
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            aboutChangeImage.otherCsChange(aboutCsPicture);
        }

        private void exitButtonOperations_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenu2_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }
    }
}