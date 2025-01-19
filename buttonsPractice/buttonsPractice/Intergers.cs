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
    public partial class Integers : Form
    {

        // Dictionary to store original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;



        public Integers()
        {
            InitializeComponent();
            this.textboxPnz.KeyPress += textboxPnz_KeyPress;
            this.textboxOe.KeyPress += textboxOe_KeyPress;
            this.textboxPnp.KeyPress += textboxPnp_KeyPress;

            // Initialize the resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += Integers_Load; // Hook the Load event to initialize resizing
            this.Resize += Integers_Resize; // Hook the Resize event to handle dynamic resizing


        }


        private void Integers_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void Integers_Resize(object sender, EventArgs e)
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








        // Restrict input to numbers, decimal points, and negative signs FOR POSITIVE/NEGATIVE/ZERO
        private void textboxPnz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !textboxPnz.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && textboxPnz.SelectionStart == 0 && !textboxPnz.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }

        // Restrict input to numbers, decimal points, and negative signs FOR ODD/EVEN
        private void textboxOe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !textboxOe.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && textboxOe.SelectionStart == 0 && !textboxOe.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }

        // Restrict input to numbers, decimal points, and negative signs FOR PRIMARY/NOT PRIMARY
        private void textboxPnp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !textboxPnp.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && textboxPnp.SelectionStart == 0 && !textboxPnp.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }


        private void Intergers_Load(object sender, EventArgs e)
        {

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

        private void pnzButton_Click(object sender, EventArgs e)
        {
            string inputText = textboxPnz.Text.Trim();

            // Check if the input is invalid (just a '-' sign)
            if (inputText == "-")
            {
                MessageBox.Show("Input cannot be just a '-' sign. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing the input to an integer
            if (int.TryParse(inputText, out int input))
            {
                if (input < 0)
                {
                    labelResult.Text = $"The number {input} is Negative Number";
                }
                else if (input > 0)
                {
                    labelResult.Text = $"The number {input} is Positive Number";
                }
                else
                {
                    labelResult.Text = $"The number {input} is Zero";
                }
            }
            else
            {
                // Handle cases where the input is not a valid integer
                MessageBox.Show("Please enter a valid integer number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void oeButton_Click(object sender, EventArgs e)
        {
            string inputText = textboxOe.Text.Trim();

            // Check if the input is invalid (just a '-' sign)
            if (inputText == "-")
            {
                MessageBox.Show("Input cannot be just a '-' sign. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing the input to an integer
            if (int.TryParse(inputText, out int inputoe))
            {
                if (inputoe % 2 == 0)
                {
                    labelResult.Text = $"The number {inputoe} is Even Number";
                }
                else
                {
                    labelResult.Text = $"The number {inputoe} is Odd";
                }
            }
            else
            {
                // Handle cases where the input is not a valid integer
                MessageBox.Show("Please enter a valid integer number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnpButton_Click(object sender, EventArgs e)
        {
            string inputText = textboxPnp.Text.Trim();

            // Check if the input is invalid (just a '-' sign)
            if (inputText == "-")
            {
                MessageBox.Show("Input cannot be just a '-' sign. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing the input to an integer
            if (int.TryParse(inputText, out int input))
            {
                if (input < 2)
                {
                    labelResult.Text = $"The number {input} is Not Primary (prime numbers are greater than 1).";
                }
                else if (IsPrime(input))
                {
                    labelResult.Text = $"The number {input} is Primary.";
                }
                else
                {
                    labelResult.Text = $"The number {input} is Not Primary.";
                }
            }
            else
            {
                // Handle cases where the input is not a valid integer
                MessageBox.Show("Please enter a valid integer number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //check if a number is prime
        private bool IsPrime(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
