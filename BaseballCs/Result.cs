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

        private int strike;
        private int ball;
        private int @out;

        public void Calculate(Answer answer, Guess guess)
        {
            for (int i = 0; i < Program.Digit; i++)
            {
                int j = (i + 1) % Program.Digit;
                int k = (i + 2) % Program.Digit;

                if (guess[i] == answer[i])
                    strike++;
                else if (guess[i] == answer[j] || guess[i] == answer[k])
                    ball++;
                else
                    @out++;
            }
        }

        public void Print()
        {
            Console.WriteLine($"[S]{strike} [B]{ball} [O]{@out}");
        }

        public bool IsCorrect()
        {
            return strike == Program.Digit;
        }
    }
}
