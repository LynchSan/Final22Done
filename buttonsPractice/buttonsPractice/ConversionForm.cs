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
    public partial class ConversionForm : Form
    {

        // Dictionary to store original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;

        public ConversionForm()
        {
            InitializeComponent();

            this.textboxCFK.KeyPress += textboxCFK_KeyPress;
            this.textboxMetric.KeyPress += textboxMetric_KeyPress;
            this.textboxNtoW.KeyPress += textboxNtoW_KeyPress;

            // Initialize the resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += ConversionForm_Load; // Hook the Load event to initialize resizing
            this.Resize += ConversionForm_Resize; // Hook the Resize event to handle dynamic resizing


        }


        private void ConversionForm_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void ConversionForm_Resize(object sender, EventArgs e)
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




        // Restrict input to numbers, decimal points, and negative signs FOR TEMPERATURE
        private void textboxCFK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !textboxCFK.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && textboxCFK.SelectionStart == 0 && !textboxCFK.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }


        // Restrict input to numbers, decimal points, and negative signs FOR METRIC
        private void textboxMetric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !textboxMetric.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && textboxMetric.SelectionStart == 0 && !textboxMetric.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }


        // Restrict input to numbers, decimal points, and negative signs FOR NUM TO WORDS
        private void textboxNtoW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits

            e.Handled = true; // Reject all other input
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertTempButton_Click(object sender, EventArgs e)
        {
            // Trim the input to remove leading or trailing spaces
            string inputText = textboxCFK.Text.Trim();

            // Check if the input is empty or invalid
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Invalid input! Please enter a valid temperature value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution
            }

            // Try parsing the input to a double
            if (double.TryParse(inputText, out double celsius))
            {
                // Convert to Fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;

                // Convert to Kelvin
                double kelvin = celsius + 273.15;

                // Display the results
                labelCFK.Text = $"{celsius}°C is {fahrenheit}°F to fahrenheit and {kelvin}K to Kelvin";
            }
            else
            {
                // If parsing fails, show an error message
                MessageBox.Show("Invalid input! Please enter a valid numeric temperature.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void mainMenuConversion_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            operations.Show();
            this.Close();
        }

        private void exitButtonConversion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxCFK_TextChanged(object sender, EventArgs e)
        {

        }

        private void metricButton_Click(object sender, EventArgs e)
        {
            
            string inputText = textboxMetric.Text.Trim();

            // Check if the input is empty or invalid
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Invalid input! Please enter a valid length value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution
            }

            // Try parsing the input to a double
            if (double.TryParse(inputText, out double cm))
            {
                // Convert to millimeters
                double mm = cm * 10;

                // Convert to meters
                double m = cm / 100;

                // Display the results
                labelCFK.Text = $"{cm}CM is {mm} to Millimeter and {m} to Meter";
            }
            else
            {
                // If parsing fails, show an error message
                MessageBox.Show("Invalid input! Please enter a valid numeric length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numtowordButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textboxNtoW.Text, out int number))
            {
                string result = ConvertNumberToWords(number);
                labelCFK.Text = result;
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid length value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        // Function to convert number to words
        private string ConvertNumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] thousands = { "", "Thousand", "Million", "Billion" };

            string words = "";
            int place = 0;

            while (number > 0)
            {
                if (number % 1000 != 0)
                {
                    words = ConvertHundreds(number % 1000) + thousands[place] + " " + words;
                }
                number /= 1000;
                place++;
            }

            return words.Trim();
        }

        // Convert the hundreds place
        private string ConvertHundreds(int number)
        {
            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string result = "";

            if (number >= 100)
            {
                result += ones[number / 100] + " Hundred ";
                number %= 100;
            }

            if (number >= 20)
            {
                result += tens[number / 10] + " ";
                number %= 10;
            }

            if (number > 0)
            {
                result += ones[number] + " ";
            }

            return result;
        }

    }
}
