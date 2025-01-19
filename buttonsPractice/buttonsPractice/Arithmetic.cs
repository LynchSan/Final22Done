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
    public partial class Arithmetic : Form
    {
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;

        public Arithmetic()
        {
            InitializeComponent();
            this.enterNum1A.KeyDown += enterNum1A_KeyDown; //hook userInput.KeyDown to method userInput_KeyDown 

            // Hook KeyPress event for enterNum1A
            this.enterNum1A.KeyPress += enterNum1A_KeyPress;

            // Hook KeyPress event for enterNum2A
            this.enterNum2A.KeyPress += enterNum2A_KeyPress;

            // Initialize resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += Arithmetic_Load_ResizeSetup; // Hook Load event for resize setup
            this.Resize += Arithmetic_ResizeControls; // Hook Resize event to handle dynamic resizing
        }

        private void Arithmetic_Load_ResizeSetup(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void Arithmetic_ResizeControls(object sender, EventArgs e)
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

        // Restrict input to numbers, decimal points, and negative signs
        private void enterNum1A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !enterNum1A.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && enterNum1A.SelectionStart == 0 && !enterNum1A.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }

        //First TextBox
        private void enterNum1A_TextChanged(object sender, EventArgs e)
        {

        }

        //For next TextBox if hit enter
        private void enterNum1A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                enterNum2A.Focus(); //Move focus to the next TextBox /passInput/
            }
        }

        private void labelEnterNum1_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuArithmetic_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            operations.Show();
            this.Close();
        }

        // Restrict input to numbers, decimal points, and negative signs
        private void enterNum2A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Allow control keys (e.g., backspace)
            if (char.IsDigit(e.KeyChar)) return;   // Allow digits
            if (e.KeyChar == '.' && !enterNum2A.Text.Contains(".")) return; // Allow one decimal point
            if (e.KeyChar == '-' && enterNum2A.SelectionStart == 0 && !enterNum2A.Text.Contains("-")) return; // Allow one negative sign at the start

            e.Handled = true; // Reject all other input
        }

        //second TextBox
        private void enterNum2A_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButtonArithmetic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arithmeticButtonAll_Click(object sender, EventArgs e)
        {
            string input1 = enterNum1A.Text.Trim();
            string input2 = enterNum2A.Text.Trim();

            // Check if the inputs are invalid (empty, only spaces, or just a '-' sign)
            if (string.IsNullOrEmpty(input1) || input1 == "-" || string.IsNullOrEmpty(input2) || input2 == "-")
            {
                MessageBox.Show("Invalid input! Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            // Try parsing the inputs to integers
            if (int.TryParse(input1, out int num1A) && int.TryParse(input2, out int num2A))
            {
                // Perform arithmetic operations
                int sum = num1A + num2A;
                int difference = num1A - num2A;
                int multiplication = num1A * num2A;
                int division = num2A != 0 ? num1A / num2A : 0; // Avoid division by zero
                int modulus = num2A != 0 ? num1A % num2A : 0;  // Avoid modulus by zero

                // Display results
                sumLabelA.Text = $"The Sum is: {sum}";
                diffLabelA.Text = $"The Difference is: {difference}";
                multiLabelA.Text = $"The Product is: {multiplication}";
                diviLabelA.Text = num2A != 0 ? $"The Quotient is: {division}" : "Cannot divide by zero!";
                moduLabelA.Text = num2A != 0 ? $"The Modulus is: {modulus}" : "Cannot perform modulus by zero!";
            }
            else
            {
                // If parsing fails, show an error message
                MessageBox.Show("Invalid input! Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sumLabelA_Click(object sender, EventArgs e)
        {

        }

        private void Arithmetic_Load(object sender, EventArgs e)
        {

        }
    }
}
