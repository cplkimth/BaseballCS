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
            Console.WriteLine(GetPrefix());
            for (int i = 0; i < Program.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }

        protected virtual string GetPrefix() // overridable, rewritable
        {
            return null;
        }

        public int this[int index] => numbers[index];
    }
}
