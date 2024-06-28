using System;
using System.Collections.Generic;

namespace Baseball;

public class NumberContainer
{
    protected List<int> _numbers;

    public void Print()
    {
        string prefix = GetPrefix();
        Console.WriteLine(prefix);
        foreach (var answer in _numbers)
            Console.Write($"{answer} ");
        Console.WriteLine();
    }

    protected virtual string GetPrefix() // overridable
    {
        throw new NotImplementedException("NumberContainer.GetPrefix");
    }

    public int Get(int index)
    {
        return _numbers[index];
    }
}