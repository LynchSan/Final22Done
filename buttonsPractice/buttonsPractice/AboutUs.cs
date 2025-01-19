using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace buttonsPractice
{
    public partial class AboutUs : Form
    {
        private struct ControlData
        {
            public Size OriginalSize;
            public Point OriginalLocation;
        }

        private Dictionary<Control, ControlData> controlData;
        private Size originalFormSize;

        public AboutUs()
        {
            InitializeComponent();

            // Initialize the control data dictionary
            controlData = new Dictionary<Control, ControlData>();

            this.Load += AboutUs_Load;
            this.Resize += AboutUs_Resize;
        }

        private void AboutUs_Load(object sender, EventArgs e)
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

        private void AboutUs_Resize(object sender, EventArgs e)
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

        private void exitButtonMain_Click(object sender, EventArgs e)
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
