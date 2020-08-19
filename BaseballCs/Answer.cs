using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballCs
{
    public class Answer : NumberContainer
    {
        public void Generate()
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
    }
}
