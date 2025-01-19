using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace buttonsPractice
{
    public partial class Rps : Form
    {

        // Dictionary to store original sizes and locations of controls
        private Dictionary<Control, (Size originalSize, Point originalLocation)> controlData;
        private Size originalFormSize;




        int pScore = 0;

        int cScore = 0;

        //Declaring it to access its instances.
        private computerRandom computer; //random pick for ai
        private emotionAnimation emotionImage; //changing the Image to make an animated style
        private AiPickedAnimation aiPickedAnimation; //For changing it to rock, paper, scissor images

        /*Made the Rps public to make buttonDebug be access outside Rps then set it to false
         * so it wont accessed by other users except a. this is the whole point of this code
         * to only be accessed by user a
         */
        public Rps(bool enableDebugButton = false)
        {
            InitializeComponent();

            //Create new instances and assign it to its variable. so that we can access the instances inside the variable.
            computer = new computerRandom();
            emotionImage = new emotionAnimation();
            aiPickedAnimation = new AiPickedAnimation(computer);

            //For admin testing sa RPS enables the cheat
            buttonDebug.Enabled = DebugConfig.EnableDebugButton;
            buttonDebug.Visible = DebugConfig.EnableDebugButton;



            // Initialize the resizing data
            controlData = new Dictionary<Control, (Size, Point)>();
            this.Load += Rps_Load; // Hook the Load event to initialize resizing
            this.Resize += Rps_Resize; // Hook the Resize event to handle dynamic resizing

        }

        private void Rps_Load(object sender, EventArgs e)
        {
            // Save the original form size for scaling calculations
            originalFormSize = this.ClientSize;

            // Save the original size and position of each control for scaling
            foreach (Control control in this.Controls)
            {
                controlData[control] = (control.Size, control.Location);
            }
        }

        private void Rps_Resize(object sender, EventArgs e)
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
            Games games = new Games();
            games.Show();
            this.Close();
        }

        private void exitButtonConversion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            computer.GenerateNewChoice();
            outcome.Visible = false;

            emotionImage.ChangeImageHand(pictureBoxAipick);

            playButton.Enabled = false;
            playButton.Visible = false;

            // Show the dots one by one with a delay without blocking the UI thread
            emotionImage.ChangeImageDot1(pictureBoxAi);
            await Task.Delay(200);  // awai task Non-blocking delay kesa sa Thread.Sleep

            emotionImage.ChangeImageDot2(pictureBoxAi);
            await Task.Delay(200);  

            emotionImage.ChangeImageDot3(pictureBoxAi);
            await Task.Delay(200);

            //Re-animate
            emotionImage.ChangeImageDot1(pictureBoxAi);
            await Task.Delay(200);

            emotionImage.ChangeImageDot2(pictureBoxAi);
            await Task.Delay(200);

            emotionImage.ChangeImageDot3(pictureBoxAi);
            await Task.Delay(200);

            emotionImage.ChangeImageLove(pictureBoxAi);

            //Re-animate
            emotionImage.ChangeImageDot1(pictureBoxAi);
            await Task.Delay(200);

            emotionImage.ChangeImageDot2(pictureBoxAi);
            await Task.Delay(200);

            emotionImage.ChangeImageDot3(pictureBoxAi);
            await Task.Delay(200);

            emotionImage.ChangeImageLove(pictureBoxAi);



            if (pScore > cScore)
            {
                emotionImage.ChangeImageMad(pictureBoxAi);
            }



            rockButton.Enabled = true;
            rockButton.Visible = true;

            paperButton.Enabled = true;
            paperButton.Visible = true;
            
            scissorButton.Visible = true;
            scissorButton.Enabled = true;

            playerPickedLabel.Visible = false;
            aiPickedLabel.Visible = false;


        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            string value = "Scissor";

            //Change image of Ai picked
            aiPickedAnimation.CheckAiChoice(pictureBoxAipick);

            pictureBoxAipick.Enabled = true;

            paperButton.Enabled = false;
            paperButton.Visible = false;

            scissorButton.Visible = false;
            scissorButton.Enabled = false;
            playerPickedLabel.Text = "YOU PICKED ROCK";

            playerPickedLabel.Visible = true;
            aiPickedLabel.Visible = true;

            if (computer.RandomChoice == value)
            {
                emotionImage.ChangeImageCry(pictureBoxAi);

                outcome.Text = "YOU WON!!";
                aiPickedLabel.Text = "AI PICKED SCISSOR";
                pScore += 1;
                labelScore.Text = $"SCORE: {pScore}";
                outcome.Visible = true;

                rockButton.Enabled = false;
                rockButton.Visible = false;

                playButton.Enabled = true;
                playButton.Visible = true;

                

            }
            else if (computer.RandomChoice == "Rock")
            {
                emotionImage.ChangeImageSurprise(pictureBoxAi);

                outcome.Text = "YOU TIED...";
                aiPickedLabel.Text = "AI PICKED ROCK";
                outcome.Visible = true;

                rockButton.Enabled = false;
                rockButton.Visible = false;

                playButton.Visible = true;
                playButton.Enabled = true;
            }

            else
            {
                emotionImage.ChangeImageSun(pictureBoxAi);

                outcome.Text = "YOU LOST!!";
                aiPickedLabel.Text = "AI PICKED PAPER";
                cScore += 1;
                labelAiscore.Text = $"AI SCORE: {cScore}";
                outcome.Visible = true;

                rockButton.Enabled = false;
                rockButton.Visible = false;

                playButton.Visible = true;
                playButton.Enabled = true;
            }

            


        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            string value = "Rock";

            aiPickedAnimation.CheckAiChoice(pictureBoxAipick);

            rockButton.Enabled = false;
            rockButton.Visible = false;

            scissorButton.Visible = false;
            scissorButton.Enabled = false;
            playerPickedLabel.Text = "YOU PICKED PAPER";

            playerPickedLabel.Visible = true;
            aiPickedLabel.Visible = true;

            if (computer.RandomChoice == value)
            {
                emotionImage.ChangeImageCry(pictureBoxAi);

                outcome.Text = "YOU WON!!";
                aiPickedLabel.Text = "AI PICKED ROCK";
                pScore += 1;
                labelScore.Text = $"SCORE: {pScore}";
                outcome.Visible = true;

                paperButton.Enabled = false;
                paperButton.Visible = false;

                playButton.Enabled = true;
                playButton.Visible = true;
            }
            else if (computer.RandomChoice == "Paper")
            {
                emotionImage.ChangeImageSurprise(pictureBoxAi);

                outcome.Text = "YOU TIED!!";
                aiPickedLabel.Text = "AI PICKED PAPER";
                outcome.Visible = true;

                paperButton.Enabled = false;
                paperButton.Visible = false;

                playButton.Enabled = true;
                playButton.Visible = true;
            }
            else
            {
                emotionImage.ChangeImageSun(pictureBoxAi);

                outcome.Text = "YOU LOST!!";
                aiPickedLabel.Text = "AI PICKED SCISSOR";
                cScore += 1;
                labelAiscore.Text = $"AI SCORE: {cScore}";
                outcome.Visible = true;


                paperButton.Enabled = false;
                paperButton.Visible = false;


                playButton.Enabled = true;
                playButton.Visible = true;
            }


        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            string value = "Paper";

            aiPickedAnimation.CheckAiChoice(pictureBoxAipick);

            rockButton.Enabled = false;
            rockButton.Visible = false;

            paperButton.Enabled = false;
            paperButton.Visible = false;
            playerPickedLabel.Text = "YOU PICKED SCISSOR";

            playerPickedLabel.Visible = true;
            aiPickedLabel.Visible = true;

            if (computer.RandomChoice == value)
            {
                emotionImage.ChangeImageCry(pictureBoxAi);

                outcome.Text = "YOU WON!!";
                aiPickedLabel.Text = "AI PICKED PAPER";
                pScore += 1;
                labelScore.Text = $"SCORE: {pScore}";
                outcome.Visible = true;

                scissorButton.Enabled = false;
                scissorButton.Visible = false;

                playButton.Enabled = true;
                playButton.Visible = true;
            }
            else if (computer.RandomChoice == "Scissor")
            {
                emotionImage.ChangeImageSurprise(pictureBoxAi);

                outcome.Text = "YOU TIED!!";
                aiPickedLabel.Text = "AI PICKED SCISSOR";
                outcome.Visible = true;

                scissorButton.Enabled = false;
                scissorButton.Visible = false;

                playButton.Visible = true;
                playButton.Enabled = true;
            }
            else
            {
                emotionImage.ChangeImageSun(pictureBoxAi);

                outcome.Text = "YOU LOST!!";
                aiPickedLabel.Text = "AI PICKED ROCK";
                cScore += 1;
                labelAiscore.Text = $"AI SCORE: {cScore}";
                outcome.Visible = true;

                scissorButton.Enabled = false;
                scissorButton.Visible = false;

                playButton.Visible = true;
                playButton.Enabled = true;
            }




        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            aiPickedAnimation.CheckAiChoice(pictureBoxAipick);
        }

        private void pictureBoxAi_Click(object sender, EventArgs e)
        {

        }
    }
}
