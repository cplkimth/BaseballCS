
using System;

namespace BaseballCs
{
    public class Guess : NumberContainer
    {
        public void Input()
        {
            for (int i = 0; i < Program.Digit; i++)
                numbers[i] = int.Parse(Console.ReadLine());
        }

        protected override string GetPrefix()
        {
            return "[추측]";
        }
    }
}