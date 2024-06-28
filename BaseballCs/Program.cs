#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Baseball;

internal partial class Program
{
    private static void Main(string[] args)
    {
        // 1. 정답을 생성한다.
        var random = new Random(1);
        List<int> answers = new List<int>();
        
        while (true)
        {
            answers.Clear();
            for (int i = 0; i < Digit; i++)
                answers.Add(random.Next(MaxValue));
            
            if (answers.Distinct().Count() == Digit)
                break;
        }

        PrintNumbers("[정답]", answers);


        var tryCount = 0;

        while (true)
        {
            // 2. 추측을 입력받는다.
            var guesses = new List<int>();
            for (int i = 0; i < Digit; i++)
            {
                int guess = int.Parse(Console.ReadLine());
                guesses.Add(guess);
            }
            
            PrintNumbers("[추측]", guesses);


            // 3. 결과를 계산한다.
            tryCount++;

            Result result = new();

            for (int i = 0; i < Digit; i++)
            {
                int j = (i + 1) % Digit;
                int k = (i + 2) % Digit;

                if (guesses[i] == answers[i])
                    result.strike++;
                else if (guesses[i] == answers[j] || guesses[i] == answers[k])
                    result.ball++;
                else
                    result.@out++;
            }
            Console.WriteLine($"[S]{result.strike} [B]{result.ball} [O]{result.@out}");


            // 4. 정답과 추측이 일치하면 끝낸다.
            if (result.strike == Digit)
                break;
        }


        // 5. 도전횟수를 출력한다.
        Console.WriteLine($"[횟수] {tryCount}");
    }
}