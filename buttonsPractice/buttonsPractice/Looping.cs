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
    public partial class Looping : Form
    {

        // Dictionary to store original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;

        public Looping()
        {
            InitializeComponent();
            this.textboxSoN.KeyPress += textboxSoN_KeyPress;
            this.textboxFactorial.KeyPress += textboxFactorial_KeyPress;


            // Initialize the resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += Looping_Load; // Hook the Load event to initialize resizing
            this.Resize += Looping_Resize; // Hook the Resize event to handle dynamic resizing

        }

        private void Looping_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void Looping_Resize(object sender, EventArgs e)
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





        // Restrict input to numbers, decimal points, and negative signs FOR SUM OF N
        private void textboxSoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !textboxSoN.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && textboxSoN.SelectionStart == 0 && !textboxSoN.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }

        // Restrict input to numbers, decimal points, and negative signs FOR FACTORIAL OF N
        private void textboxFactorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !textboxFactorial.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && textboxFactorial.SelectionStart == 0 && !textboxFactorial.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }



        private void mainMenuConversion_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            operations.Show();
            this.Close();
        }

        private void exitButtonOperations_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getsumButton_Click(object sender, EventArgs e)
        {

            // Check if input is empty or contains invalid characters
            if (string.IsNullOrEmpty(textboxSoN.Text) || !double.TryParse(textboxSoN.Text, out double input) || input <= 0)
            {
                MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double sum = 0;

            // Loop through numbers 1 to N
            for (int i = 1; i <= input; i++)
            {
                sum += i; // Add the current number to the sum
            }

            labelResult.Text = $"The sum of the first {input} numbers is: {sum}";

        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            // Check if input is empty or contains invalid characters
            if (string.IsNullOrEmpty(textboxFactorial.Text) || !int.TryParse(textboxFactorial.Text, out int N))
            {
                MessageBox.Show("Please enter a valid integer.");
                return;
            }

            // Validate input for negative numbers
            if (N < 0)
            {
                MessageBox.Show("Factorial is not defined for negative numbers.");
                return;
            }

            // Handle cases where the number is too large for factorial calculation
            if (N > 20) // Beyond 20, factorials grow too large for long data type
            {
                MessageBox.Show("The number is too large for factorial calculation. Limit is 20!");
                return;
            }

            // Calculate the factorial using a loop
            long factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;  // Multiply the current number with factorial
            }

            // Display the result in the label
            labelResult.Text = $"The factorial of {N} is {factorial}";

        }

        private void nestedButton_Click(object sender, EventArgs e)
        {
            pyramid pyramid = new pyramid();
            pyramid.Show();
            this.Close();
        }
    }
}
