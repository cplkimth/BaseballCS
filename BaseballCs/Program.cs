using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballCs
{
    class Program
    {
        public const int MaxValue = 10;
        public const int Digit = 3;

        static void Main(string[] args)
        {
            // 1. 정답을 생성한다.
            Answer answer = new Answer();
            answer.Generate();
            answer.Print();


            // 3. 결과를 계산한다.
            int tryCount = 0;

            while (true)
            {
                // 2. 추측을 입력받는다.
                Guess guess = new Guess();
                guess.Input();
                guess.Print();

                tryCount++;

                Result result = new Result();
                result.Calculate(answer, guess);
                result.Print();

                // 4. 정답과 추측이 입력하지 않으면 2번으로 돌아간다.
                if (result.IsCorrect())
                    break;
            }

            // 5. 도전횟수를 출력한다.
            Console.WriteLine($"[횟수] {tryCount}");
        }
    }
}
