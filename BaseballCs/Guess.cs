#region

using System;
using System.Collections.Generic;

#endregion

namespace Baseball;

public class Guess
{
    private List<int> _guesses;

    public void Input()
    {
        _guesses = new List<int>();
        for (var i = 0; i < Program.Digit; i++)
        {
            var guess = int.Parse(Console.ReadLine());
            _guesses.Add(guess);
        }
    }

    public void Print()
    {
        Console.WriteLine("[입력]");
        foreach (var guess in _guesses)
            Console.Write($"{guess} ");
        Console.WriteLine();
    }

    public int Get(int index)
    {
        return _guesses[index];
    }
}