#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Baseball;

public partial class Program
{
    private static void Main(string[] args)
    {
        // 1. 정답을 생성한다.
        List<int> answers = GenerateAnswers();
        PrintNumbers("[정답]", answers);


        var tryCount = 0;

        while (true)
        {
            // 2. 추측을 입력받는다.
            List<int> guesses = InputGuesses();
            PrintNumbers("[추측]", guesses);


            // 3. 결과를 계산한다.
            tryCount++;

            Result result = new();
            CalculateResult(result, answers, guesses);
            PrintResult(result);


            // 4. 정답과 추측이 일치하면 끝낸다.
            if (IsCorrectResult(result))
                break;
        }


        // 5. 도전횟수를 출력한다.
        Console.WriteLine($"[횟수] {tryCount}");
    }
}