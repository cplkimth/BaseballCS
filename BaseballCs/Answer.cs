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

                OnDuplicated(numbers);
            }
        }

        protected override string GetPrefix()
        {
            return "[정답]";
        }

        #region Duplicated event things for C# 3.0
        public event EventHandler<DuplicatedEventArgs> Duplicated;

        protected virtual void OnDuplicated(DuplicatedEventArgs e)
        {
            if (Duplicated != null)
                Duplicated(this, e);
        }

        private DuplicatedEventArgs OnDuplicated(int[] numbers)
        {
            DuplicatedEventArgs args = new DuplicatedEventArgs(numbers);
            OnDuplicated(args);

            return args;
        }

        private DuplicatedEventArgs OnDuplicatedForOut()
        {
            DuplicatedEventArgs args = new DuplicatedEventArgs();
            OnDuplicated(args);

            return args;
        }

        public class DuplicatedEventArgs : EventArgs
        {
            public int[] Numbers { get; set; }

            public DuplicatedEventArgs()
            {
            }

            public DuplicatedEventArgs(int[] numbers)
            {
                Numbers = numbers;
            }
        }
        #endregion
    }
}
