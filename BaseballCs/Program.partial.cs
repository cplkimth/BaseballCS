using System;
using System.Collections.Generic;
using System.Linq;

namespace Baseball;

public partial class Program
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

    public static List<int> GenerateAnswers()
    {
        var random = new Random(1);
        List<int> answers = new List<int>();
        
        while (true)
        {
            answers.Clear();
            for (int i = 0; i < Digit; i++)
                answers.Add(random.Next(MaxValue));
            
            if (answers.Distinct().Count() == Digit)
                break;
        }

        return answers;
    }

    private static List<int> InputGuesses()
    {
        var guesses = new List<int>();
        for (int i = 0; i < Digit; i++)
        {
            int guess = int.Parse(Console.ReadLine());
            guesses.Add(guess);
        }

        return guesses;
    }

    private static void CalculateResult(Result result, List<int> answers, List<int> guesses)
    {
        for (int i = 0; i < Digit; i++)
        {
            int j = (i + 1) % Digit;
            int k = (i + 2) % Digit;

            if (guesses[i] == answers[i])
                result.strike++;
            else if (guesses[i] == answers[j] || guesses[i] == answers[k])
                result.ball++;
            else
                result.@out++;
        }
    }

    private static void PrintResult(Result result)
    {
        Console.WriteLine($"[S]{result.strike} [B]{result.ball} [O]{result.@out}");
    }

    private static bool IsCorrectResult(Result result)
    {
        return result.strike == Digit;
    }
}