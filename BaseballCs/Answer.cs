﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballCs
{
    class Answer
    {
        public int[] numbers = new int[Program.Digit];

        internal void Generate()
        {
            Random random = new Random(1);

            while (true)
            {
                for (int i = 0; i < Program.Digit; i++)
                    numbers[i] = random.Next(Program.MaxValue);

                if (numbers[0] != numbers[1] && numbers[1] != numbers[2] && numbers[2] != numbers[0])
                    break;
            }
        }

        internal void Print()
        {
            Console.WriteLine("[정답]");
            for (int i = 0; i < Program.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }

        public int this[int index] => numbers[index];

    }
}
