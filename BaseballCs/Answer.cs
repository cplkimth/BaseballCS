using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

namespace Baseball;

public class Answer : NumberContainer
{
    public void Generate()
    {
        var random = new Random(1);
        _numbers = new List<int>();
        
        while (true)
        {
            _numbers.Clear();
            for (int i = 0; i < Program.Digit; i++)
                _numbers.Add(random.Next(Program.MaxValue));
            
            if (_numbers.Distinct().Count() == Program.Digit)
                break;
        }
    }
}