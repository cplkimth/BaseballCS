#region

using System;
using System.Collections.Generic;

#endregion

namespace Baseball;

public class Guess : NumberContainer
{
    public void Input()
    {
        _numbers = new List<int>();
        for (var i = 0; i < Program.Digit; i++)
        {
            var guess = int.Parse(Console.ReadLine());
            _numbers.Add(guess);
        }
    }
}