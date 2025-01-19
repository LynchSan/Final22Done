using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonsPractice
{
    public partial class Games : Form
    {

        // Dictionary to store original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;

        public Games()
        {
            InitializeComponent();


            // Initialize the resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += Games_Load; // Hook the Load event to initialize resizing
            this.Resize += Games_Resize; // Hook the Resize event to handle dynamic resizing

        }


        private void Games_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void Games_Resize(object sender, EventArgs e)
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






        private void mainMenu2_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void exitButtonConversion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rpsButton_Click(object sender, EventArgs e)
        {
            Rps rps = new Rps();
            rps.Show();
            this.Close();
        }

        private void snakeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
