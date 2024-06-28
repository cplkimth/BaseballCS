#region

using System;

#endregion

namespace Baseball;

internal class Program
{
    public const int MaxValue = 10;
    public const int Digit = 3;

    private static void Main(string[] args)
    {
        // 1. 정답을 생성한다.
        var random = new Random(1);
        int answer0;
        int answer1;
        int answer2;

        while (true)
        {
            answer0 = random.Next(MaxValue);
            answer1 = random.Next(MaxValue);
            answer2 = random.Next(MaxValue);

            if (answer0 != answer1 && answer1 != answer2 && answer2 != answer0)
                break;
        }

        Console.WriteLine("[정답]");
        Console.Write(answer0 + " ");
        Console.Write(answer1 + " ");
        Console.Write(answer2 + " ");
        Console.WriteLine();


        var tryCount = 0;

        while (true)
        {
            // 2. 추측을 입력받는다.
            int guess0 = int.Parse(Console.ReadLine());
            int guess1 = int.Parse(Console.ReadLine());
            var guess2 = int.Parse(Console.ReadLine());

            Console.WriteLine("[추측]");
            Console.Write(guess0 + " ");
            Console.Write(guess1 + " ");
            Console.Write(guess2 + " ");
            Console.WriteLine();


            // 3. 결과를 계산한다.
            tryCount++;

            var strike = 0;
            var ball = 0;
            var @out = 0;

            if (guess0 == answer0)
                strike++;
            else if (guess0 == answer1 || guess0 == answer2)
                ball++;
            else
                @out++;

            if (guess1 == answer1)
                strike++;
            else if (guess1 == answer2 || guess1 == answer0)
                ball++;
            else
                @out++;

            if (guess2 == answer2)
                strike++;
            else if (guess2 == answer0 || guess2 == answer1)
                ball++;
            else
                @out++;

            Console.WriteLine($"[S]{strike} [B]{ball} [O]{@out}");


            // 4. 정답과 추측이 일치하면 끝낸다.
            if (strike == Digit)
                break;
        }


        // 5. 도전횟수를 출력한다.
        Console.WriteLine($"[횟수] {tryCount}");
    }
}