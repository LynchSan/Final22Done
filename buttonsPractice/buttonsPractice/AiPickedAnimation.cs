using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonsPractice
{
    internal class AiPickedAnimation
    {

        private computerRandom computer;

        // Constructor to initialize computerRandom object
        public AiPickedAnimation(computerRandom computerRandom)
        {
            computer = computerRandom;  // Initialize the computerRandom object
        }

        public void CheckAiChoice(PictureBox pictureBox)  // Added PictureBox parameter
        {
            if (computer.RandomChoice == "Rock")
            {
                ChangeImageRock(pictureBox);  // Pass PictureBox to the method
            }
            else if (computer.RandomChoice == "Paper")
            {
                ChangeImagePaper(pictureBox); // Pass PictureBox to the method
            }
            else
            {
                ChangeImageScissor(pictureBox); // Pass PictureBox to the method
            }
        }


        public void ChangeImageRock(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Rock; // Access image directly from Resources
        }
        public void ChangeImagePaper(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Paper; // Access image directly from Resources
        }
        public void ChangeImageScissor(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Scissor; // Access image directly from Resources
        }


    }
}
