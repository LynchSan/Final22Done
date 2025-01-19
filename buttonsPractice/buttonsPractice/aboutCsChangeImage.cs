using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonsPractice
{
    internal class aboutCsChangeImage
    {
        //To change picturebox in AboutCs

        //Aboutc# image
        public void aboutCsChange(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.whatCs; // Access image directly from Resources
        }

        //C# history image
        public void historyCsChange(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.HistoryCs; // Access image directly from Resources
        }

        //Basic syntax image
        public void basicCsChange(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.CbasicSyntax; // Access image directly from Resources
        }

        //Other info in c# image
        public void otherCsChange(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.otherInfoCs; // Access image directly from Resources
        }
    }
}
