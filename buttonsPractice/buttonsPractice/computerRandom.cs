using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buttonsPractice
{
    internal class computerRandom
    {

        // Rock paper scissors list
        private List<string> options = new List<string> { "Rock", "Paper", "Scissor" };

        // Create random instance
        private Random random = new Random();

        // Property to store the random choice
        public string RandomChoice { get; private set; }


        // Added GenerateNewChoice method
        public void GenerateNewChoice()
        {
            int randomIndex = random.Next(options.Count);
            RandomChoice = options[randomIndex];
        }





    }
}
