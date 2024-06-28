using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;

namespace Baseball;

public class Result
{
    public int strike = 0;
    public int ball = 0;
    public int @out = 0;

    public void Calculate(Answer answer, Guess guess)
    {
        for (int i = 0; i < Program.Digit; i++)
        {
            int j = (i + 1) % Program.Digit;
            int k = (i + 2) % Program.Digit;

            if (guess.Get(i) == answer.Get(i))
                strike++;
            else if (guess.Get(i) == answer.Get(j) || guess.Get(i) == answer.Get(k))
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