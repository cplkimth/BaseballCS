
using System;

namespace BaseballCs
{
    internal class Guess
    {
        public int[] numbers = new int[Program.Digit];

        public void Input()
        {
            for (int i = 0; i < Program.Digit; i++)
                numbers[i] = int.Parse(Console.ReadLine());
        }

        internal void Print()
        {
            Console.WriteLine("[추측]");
            for (int i = 0; i < Program.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }

        // indexer
        public int this[int index]
        {
            get
            {
                return numbers[index];
            }
        }
    }
}