using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballCs
{
    public class Result
    {
        // naming convention

        public int Strike;
        public int Ball;
        public int Out;

        internal void Calculate(Answer answer, Guess guess)
        {
            for (int i = 0; i < Program.Digit; i++)
            {
                int j = (i + 1) % Program.Digit;
                int k = (i + 2) % Program.Digit;

                if (guess[i] == answer[i])
                    Strike++;
                else if (guess[i] == answer[j] || guess[i] == answer[k])
                    Ball++;
                else
                    Out++;
            }
        }

        internal void Print()
        {
            Console.WriteLine($"[S]{Strike} [B]{Ball} [O]{Out}");
        }

        internal bool IsCorrect()
        {
            return Strike == Program.Digit;
        }
    }
}
