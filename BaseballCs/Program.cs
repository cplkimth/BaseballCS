#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Baseball;

internal partial class Program
{
    public const int MaxValue = 10;
    public const int Digit = 3;

    private static void Main(string[] args)
    {
        // 1. 정답을 생성한다.
        Answer answer = new Answer();
        answer.Generate();
        answer.Print();
        

        var tryCount = 0;

        while (true)
        {
            // 2. 추측을 입력받는다.
            Guess guess = new Guess();
            guess.Input();
            guess.Print();


            // 3. 결과를 계산한다.
            tryCount++;

            Result result = new();
            result.Calculate(answer, guess);
            result.Print();

            
            // 4. 정답과 추측이 일치하면 끝낸다.
            // if (IsCorrectResult(result))
            if (result.IsCorrect())
                break;
        }


        // 5. 도전횟수를 출력한다.
        Console.WriteLine($"[횟수] {tryCount}");
    }
}