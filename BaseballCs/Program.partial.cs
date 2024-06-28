using System;
using System.Collections.Generic;

namespace Baseball;

internal partial class Program
{
    public const int MaxValue = 10;
    public const int Digit = 3;

    private static void PrintNumbers(string prefix, List<int> numbers)
    {
        Console.WriteLine(prefix);
        foreach (var number in numbers)
            Console.Write($"{number} ");
        Console.WriteLine();
    }    
}