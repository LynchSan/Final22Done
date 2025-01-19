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
    public partial class pyramid : Form
    {

        // Dictionary to store original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;


        public pyramid()
        {
            InitializeComponent();
            this.textboxPyramid.KeyPress += textboxPyramid_KeyPress;

            // Initialize the resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += pyramid_Load; // Hook the Load event to initialize resizing
            this.Resize += pyramid_Resize; // Hook the Resize event to handle dynamic resizing


        }

        private void pyramid_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void pyramid_Resize(object sender, EventArgs e)
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





        // Restrict input to numbers for pyramid height
        private void textboxPyramid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits

            e.Handled = true; // Reject all other input
        }


        // Button click event to generate pyramids
        private void pyramidButton_Click(object sender, EventArgs e)
        {

            try
            {
                int N = int.Parse(textboxPyramid.Text);

                if (N > 15)
                {
                    MessageBox.Show("The limit is 15 sorry!!");
                    return;
                }

                if (N <= 0)
                {
                    MessageBox.Show("Please enter a positive number.");
                    return;
                }

                // Full Pyramid
                StringBuilder fullPyramid = new StringBuilder();
                for (int i = 1; i <= N; i++)
                {
                    fullPyramid.AppendLine(new string(' ', N - i) + new string('*', 2 * i - 1));
                }

                // Half Pyramid
                StringBuilder halfPyramid = new StringBuilder();
                for (int i = 1; i <= N; i++)
                {
                    halfPyramid.AppendLine(new string('*', i));
                }

                // Inverted Pyramid
                StringBuilder invertedPyramid = new StringBuilder();
                for (int i = N; i >= 1; i--)
                {
                    invertedPyramid.AppendLine(new string(' ', N - i) + new string('*', 2 * i - 1));
                }

                // Display the pyramids in labels
                labelP1.Text = $"{fullPyramid}";
                labelP2.Text = $"{halfPyramid}";
                labelP3.Text = $"{invertedPyramid}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void mainMenuPyramid_Click(object sender, EventArgs e)
        {
            Looping looping = new Looping();
            looping.Show();
            this.Close();
        }

        private void exitButtonPyramid_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}