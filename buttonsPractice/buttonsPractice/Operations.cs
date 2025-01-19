using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonsPractice
{
    public partial class Operations : Form
    {
        // Dictionary to store the original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;

        // Original size of the form
        private Size originalFormSize;

        public Operations()
        {
            InitializeComponent();

            // Initialize the control data dictionary
            controlData = new Dictionary<Control, (Size, Point)>();

            // Hook the Load and Resize events
            this.Load += Operations_Load;
            this.Resize += Operations_Resize;
        }

        // Initialize control data on form load
        private void Operations_Load(object sender, EventArgs e)
        {
            // Save the original form size
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        // Handle form resizing to adjust controls
        private void Operations_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        // Adjust control sizes and positions dynamically
        private void ResizeControls()
        {
            // Calculate scaling factors
            float widthScale = (float)this.ClientSize.Width / originalFormSize.Width;
            float heightScale = (float)this.ClientSize.Height / originalFormSize.Height;

            foreach (var kvp in controlData)
            {
                var control = kvp.Key;
                var (originalSize, originalLocation) = kvp.Value;

                // Scale the control size
                control.Size = new Size(
                    (int)(originalSize.Width * widthScale),
                    (int)(originalSize.Height * heightScale)
                );

                // Scale the control location
                control.Location = new Point(
                    (int)(originalLocation.X * widthScale),
                    (int)(originalLocation.Y * heightScale)
                );
            }
        }


        private void arithmeticButton_Click(object sender, EventArgs e)
        {
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.Show();
            this.Close();
        }

        private void mainMenu2_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void exitButtonOperations_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conversionButton_Click(object sender, EventArgs e)
        {
            ConversionForm conversionForm = new ConversionForm();
            conversionForm.Show();
            this.Close();
        }

        private void loopingButton_Click(object sender, EventArgs e)
        {
            Looping looping = new Looping();
            looping.Show();
            this.Close();
        }

        private void aaiButtons_Click(object sender, EventArgs e)
        {
            Integers integers = new Integers();
            integers.Show();
            this.Close();
        }
    }
}
