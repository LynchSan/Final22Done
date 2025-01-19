using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using buttonsPractice;



//Credits to victoriazakharo for this snake program!!
//Code Cloned repository from https://github.com/victoriazakharo
//I just cloned the code to add  snake game




namespace Snake
{
    public partial class SnakeForm : Form
    {
        // Constants for game dimensions and score display
        private const int WIDTH = 12;
        private const int HEIGHT = 16;
        private const string SCORE_STRING = "Score: {0}";

        // Game field background color
        private readonly Color m_BackgroundColor = Color.Black;

        // Game-related variables
        private readonly Game m_Game;
        private readonly Bitmap m_GameField;
        private readonly Graphics m_GameGraphics;

        // Variables for resizing functionality
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;

        public SnakeForm()
        {
            InitializeComponent();

            // Initialize the game field and graphics
            m_GameField = new Bitmap(WIDTH * Piece.SIDE, HEIGHT * Piece.SIDE);
            m_GameGraphics = Graphics.FromImage(m_GameField);
            m_GameGraphics.PageUnit = GraphicsUnit.Pixel;

            // Set the client size based on the game field dimensions
            ClientSize = new Size(m_GameField.Width, m_GameField.Height + m_RestartBtn.Height);

            // Initialize the game logic
            m_Game = new Game(WIDTH, HEIGHT);

            // Start the game timer
            m_Timer.Start();

            // Initialize resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += SnakeForm_Load; // Hook the Load event to initialize resizing
            this.Resize += SnakeForm_Resize; // Hook the Resize event to handle dynamic resizing
        }

        private void SnakeForm_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void SnakeForm_Resize(object sender, EventArgs e)
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

        // Update the score label with the current game score
        private void UpdateScore()
        {
            scoreLbl.Text = string.Format(SCORE_STRING, m_Game.GetScore());
        }

        // Handle game updates on each timer tick
        private void OnTimerTick(object sender, EventArgs e)
        {
            // Update the score if the snake has grown
            if (m_Game.SnakeHasGrown())
            {
                UpdateScore();
            }

            // Check if the game is lost
            if (m_Game.Lost())
            {
                m_Timer.Stop(); // Stop the game timer
                m_RestartBtn.Enabled = true; // Enable the restart button
                logoutButton2.Enabled = true; // Enable the logout button
            }

            // Redraw the game field
            Invalidate();
        }

        // Handle key presses to control the snake's direction
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    m_Game.ChangeSnakeDIrection(Direction.Left);
                    break;
                case Keys.Right:
                    m_Game.ChangeSnakeDIrection(Direction.Right);
                    break;
                case Keys.Up:
                    m_Game.ChangeSnakeDIrection(Direction.Up);
                    break;
                case Keys.Down:
                    m_Game.ChangeSnakeDIrection(Direction.Down);
                    break;
            }
        }

        // Handle the Paint event to draw the game field
        private void OnPaint(object sender, PaintEventArgs e)
        {
            m_GameGraphics.Clear(m_BackgroundColor); // Clear the game field
            m_Game.Draw(m_GameGraphics); // Draw the game state
            e.Graphics.DrawImage(m_GameField, 0, m_RestartBtn.Height); // Render the game field on the form
        }

        // Restart the game when the restart button is clicked
        private void OnRestartBtnClick(object sender, EventArgs e)
        {
            m_RestartBtn.Enabled = false; // Disable the restart button
            logoutButton2.Enabled = false; // Disable the logout button
            m_Game.Restart(); // Restart the game
            UpdateScore(); // Reset the score label
            m_Timer.Start(); // Restart the game timer
        }

        // Handle logout button click to return to the games menu
        private void logoutButton2_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show(); // Show the games menu
            this.Close(); // Close the current form
        }
    }
}
