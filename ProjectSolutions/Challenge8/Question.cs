using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    public class Question
    {
        private static Random RNG = new Random(); // Make RNG static so it's shared across instances

        public int NumberA { get; set; }
        public int NumberB { get; set; }

        public void GenateRandomNumbers()
        {
            NumberA = RNG.Next(0, 100);
            NumberB = RNG.Next(0, 100);
        }

        public bool CheckAnswer(string InputAnswer)
        {
            int UserAnswer = 0;
            Int32.TryParse(InputAnswer, out UserAnswer);

            int CalculatedAnswer = NumberA + NumberB;
            return CalculatedAnswer == UserAnswer;
        }

    }
}
