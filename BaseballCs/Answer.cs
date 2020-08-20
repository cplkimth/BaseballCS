using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballCs
{
    //public delegate void Duplication(int[] numbers);

    public class Answer : NumberContainer
    {
        public event EventHandler<DuplicatedEventArgs> Duplicated;

        //public void Generate(Duplication onDuplicated)
        public void Generate()
        {
            Random random = new Random();

            while (true)
            {
                for (int i = 0; i < Program.Digit; i++)
                    numbers[i] = random.Next(Program.MaxValue);

                if (numbers[0] != numbers[1] && numbers[1] != numbers[2] && numbers[2] != numbers[0])
                    break;

                if (Duplicated != null)
                    OnDuplicated(numbers);
                //onDuplicated(numbers);
            }
        }

        protected override string GetPrefix()
        {
            return "[정답]";
        }

        protected void OnDuplicated(int[] numbers)
        {
            if (Duplicated != null)
                Duplicated(this, new DuplicatedEventArgs(numbers));
        }
    }

    public class DuplicatedEventArgs : EventArgs
    {
        public DuplicatedEventArgs(int[] numbers)
        {
            Numbers = numbers;
        }

        public int[] Numbers { get; set; }
    }

}
