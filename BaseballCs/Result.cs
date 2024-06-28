using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;

namespace Baseball;

public class Result
{
    private int _strike = 0;
    private int _ball = 0;
    private int _out = 0;

    public void Calculate(Answer answer, Guess guess)
    {
        for (int i = 0; i < Program.Digit; i++)
        {
            int j = (i + 1) % Program.Digit;
            int k = (i + 2) % Program.Digit;

            if (guess.Get(i) == answer.Get(i))
                _strike++;
            else if (guess.Get(i) == answer.Get(j) || guess.Get(i) == answer.Get(k))
                _ball++;
            else
                _out++;
        }
    }

    public void Print()
    {
        Console.WriteLine($"[S]{_strike} [B]{_ball} [O]{_out}");
    }

    public bool IsCorrect()
    {
        return _strike == Program.Digit;
    }
}