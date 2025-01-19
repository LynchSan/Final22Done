using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace buttonsPractice
{
    internal class emotionAnimation
    {
        // Method to change the image of the given PictureBox using Resources

        //Emotion Animation
        public void ChangeImageLove(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Love; // Access image directly from Resources
        }

        public void ChangeImageSun(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Sun; 
        }

        public void ChangeImageMad(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Mad; // Access image directly from Resources
        }

        public void ChangeImageCry(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Cry; // Access image directly from Resources
        }

        public void ChangeImageDead(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Dead; // Access image directly from Resources
        }

        public void ChangeImageSurprise(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Surprise; // Access image directly from Resources
        }



        //loading animation 
        public void ChangeImageDot1(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.dot1;
        }

        public void ChangeImageDot2(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.dot2;
        }

        public void ChangeImageDot3(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.dot3;
        }

        //Ai gestured pick

        public void ChangeImageHand(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.hand;
        }


    }
}
