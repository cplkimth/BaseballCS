using System;
using System.Collections.Generic;

namespace Baseball;

public class NumberContainer
{
    protected List<int> _numbers;

    public void Print()
    {
        Console.WriteLine("[정답]");
        foreach (var answer in _numbers)
            Console.Write($"{answer} ");
        Console.WriteLine();
    }

    public int Get(int index)
    {
        return _numbers[index];
    }
}