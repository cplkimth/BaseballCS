using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballCs
{
    class Program
    {
        const int MaxValue = 10;
        const int Digit = 3;

        static void Main(string[] args)
        {
            // 1. 정답을 생성한다.
            int[] answers = GenerateAnswers();

            PrintNumbers("[정답]", answers);


            // 3. 결과를 계산한다.
            int tryCount = 0;

            while (true)
            {
                // 2. 추측을 입력받는다.
                int[] guesses = InputGuesses();

                PrintNumbers("[추측]", guesses);

                tryCount++;

                Result result = new Result();

                CalculateResult(result, answers, guesses);

                Console.WriteLine($"[S]{result.Strike} [B]{result.Ball} [O]{result.Out}");

                // 4. 정답과 추측이 입력하지 않으면 2번으로 돌아간다.
                if (IsCorect(result))
                    break;
            }

            // 5. 도전횟수를 출력한다.
            Console.WriteLine($"[횟수] {tryCount}");
        }

        private static bool IsCorect(Result result)
        {
            return result.Strike == Digit;
        }

        private static void CalculateResult(Result result, int[] answers, int[] guesses)
        {
            for (int i = 0; i < Digit; i++)
            {
                int j = (i + 1) % Digit;
                int k = (i + 2) % Digit;

                if (guesses[i] == answers[i])
                    result.Strike++;
                else if (guesses[i] == answers[j] || guesses[i] == answers[k])
                    result.Ball++;
                else
                    result.Out++;
            }
        }

        private static int[] InputGuesses()
        {
            int[] guesses = new int[Digit];

            for (int i = 0; i < Digit; i++)
                guesses[i] = int.Parse(Console.ReadLine());

            return guesses;
        }

        private static int[] GenerateAnswers()
        {
            Random random = new Random(1);
            int[] answers = new int[Digit];

            while (true)
            {
                for (int i = 0; i < Digit; i++)
                    answers[i] = random.Next(MaxValue); // Ctrl+D

                if (answers[0] != answers[1] && answers[1] != answers[2] && answers[2] != answers[0])
                    break;
            }

            return answers;
        }

        private static void PrintNumbers(string prefix, int[] numbers)
        {
            Console.WriteLine(prefix);
            for (int i = 0; i < Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}
