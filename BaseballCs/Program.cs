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
            // Base Class Library
            Random random = new Random(1);
            int[] answers = new int[Digit];

            while (true)
            {
                for (int i = 0; i < Digit; i++)
                    answers[i] = random.Next(MaxValue); // Ctrl+D

                if (answers[0] != answers[1] && answers[1] != answers[2] && answers[2] != answers[0])
                    break;
            }

            Console.WriteLine("[정답]");
            for (int i = 0; i < Digit; i++)
                Console.Write(answers[i] + " ");
            Console.WriteLine();


            // 3. 결과를 계산한다.
            int tryCount = 0;

            while (true)
            {
                // 2. 추측을 입력받는다.
                // C+S+L
                int[] guesses = new int[Digit];
                for (int i = 0; i < Digit; i++)
                    guesses[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("[추측]");
                for (int i = 0; i < Digit; i++)
                    Console.Write(guesses[i] + " ");
                Console.WriteLine();


                tryCount++;

                int strike = 0;
                int ball = 0;
                int @out = 0;

                for (int i = 0; i < Digit; i++)
                {
                    int j = (i + 1) % Digit;
                    int k = (i + 2) % Digit;

                    if (guesses[i] == answers[i])
                        strike++;
                    else if (guesses[i] == answers[j] || guesses[i] == answers[k])
                        ball++;
                    else
                        @out++;

                }

                Console.WriteLine($"[S]{strike} [B]{ball} [O]{@out}");

                // 4. 정답과 추측이 입력하지 않으면 2번으로 돌아간다.
                if (strike == Digit)
                    break;
            }

            // 5. 도전횟수를 출력한다.
            Console.WriteLine($"[횟수] {tryCount}");
        }
    }
}
