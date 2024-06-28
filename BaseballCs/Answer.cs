using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

namespace Baseball;

public class Answer
{
    private List<int> _answers;

    public void Generate()
    {
        var random = new Random(1);
        _answers = new List<int>();
        
        while (true)
        {
            _answers.Clear();
            for (int i = 0; i < Program.Digit; i++)
                _answers.Add(random.Next(Program.MaxValue));
            
            if (_answers.Distinct().Count() == Program.Digit)
                break;
        }
    }

    public void Print()
    {
        Console.WriteLine("[정답]");
        foreach (var answer in _answers)
            Console.Write($"{answer} ");
        Console.WriteLine();
    }

    public int Get(int index)
    {
        return _answers[index];
    }
}