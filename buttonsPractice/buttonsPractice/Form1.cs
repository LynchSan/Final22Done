using System.Collections.Generic; //For the dictionary.
using System.Drawing; //to access size,point and all those stuffs
using System.Windows.Forms; //its provided by the system
using System; //its provided by the system

namespace buttonsPractice
{
    public partial class Form1 : Form
    {
        // Available users and passwords made it private so its only accesible here.
        private Dictionary<string, string> groupM = new Dictionary<string, string>
        {
            { "Aldritch", "Aldr" },
            { "Beyonce", "Beyo" },
            { "Danniel", "Dann" },
            { "Harvey", "Harv" },
            { "Vincent", "Vinc" },
            { "Johnn", "John" },
            { "Kenneth", "Kenn" },
            { "Kylle", "Kyll" },
            { "Marc", "Marc" },
            { "Lynch", "Lync" },
            { "User", "User" },
            { "a", "a" }//access cheats for testing.
        };



        // Store the original size and location of each control in structure, so its a group related data.
        private struct ControlData
        {
            public Size OriginalSize; // Stores the control's original size.
            public Point OriginalLocation; // Stores the control's original position.
        }

        //made a Dictionary to hold the original size and location data for all controls.
        private Dictionary<Control, ControlData> controlData; 
        // Stores the original size of the form (without borders)
        private Size originalFormSize;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Ensure the form captures key presses
            this.userInput.KeyDown += userInput_KeyDown; //Hook it to the keydown.

            // Initialize the dictionary to store control data.
            controlData = new Dictionary<Control, ControlData>();

            this.Load += Form1_Load; //Hook to Form1_method
            this.Resize += Form1_Resize;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Save the original size of the form's client area (excluding borders and title bar).
            originalFormSize = this.ClientSize;

            // Iterate through all controls in the form and save their original size and location.
            foreach (Control control in this.Controls)
            {
                controlData[control] = new ControlData
                {
                    OriginalSize = control.Size,
                    OriginalLocation = control.Location
                };
            }
        }

        // Call the method to adjust the size and position of controls.
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        //For making it Flexible
        private void ResizeControls()
        {

            // Calculate the horizontal scale factor as the current width divided by the original width.
            //type cast explicitly from int to float
            float widthScale = (float)this.ClientSize.Width / originalFormSize.Width;
            // Calculate the vertical scale factor as the current height divided by the original height.
            float heightScale = (float)this.ClientSize.Height / originalFormSize.Height;


            // Loop through all controls and adjust their size and position.
            foreach (var kvp in controlData)
            {
                Control control = kvp.Key; // Get the current control.
                ControlData data = kvp.Value; // Get the saved size and location data for the control.

                // Resize the control based on the width and height scale factors.
                control.Size = new Size(
                    (int)(data.OriginalSize.Width * widthScale),  // New width.
                    (int)(data.OriginalSize.Height * heightScale) // New height.
                );

                // Reposition the control based on the width and height scale factors.
                control.Location = new Point(
                    (int)(data.OriginalLocation.X * widthScale),  // New X coordinate.
                    (int)(data.OriginalLocation.Y * heightScale)  // New Y coordinate.
                );
            }
        }

        //Changing the focus to another Inputbox which is passInput.
        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //prevent its default action.
                e.SuppressKeyPress = true;
                passInput.Focus();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputUN = userInput.Text;
            string inputPass = passInput.Text;

            if (!groupM.ContainsKey(inputUN))
            {
                MessageBox.Show($"Username Not Found");
                return;
            }

            string correctPass = groupM[inputUN];

            if (correctPass != inputPass)
            {
                MessageBox.Show($"Incorrect password!");
                return;
            }

            MessageBox.Show("Login successful!");

            DebugConfig.EnableDebugButton = (inputUN == "a" && inputPass == "a");

            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();

            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userInput_TextChanged(object sender, EventArgs e) { }

        private void passInput_TextChanged(object sender, EventArgs e) { }

        private void textUsername_Click(object sender, EventArgs e) { }
    }

    public static class DebugConfig
    {
        //made a class for DebugConfig and i added  a getter and a setter, to get 
        public static bool EnableDebugButton { get; set; } = false;
    }
}
