using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballCs
{
    public class NumberContainer
    {
        protected int[] numbers = new int[Program.Digit];
        
        public void Print()
        {
            Console.WriteLine("[정답]");
            for (int i = 0; i < Program.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }

        public int this[int index] => numbers[index];
    }
}
