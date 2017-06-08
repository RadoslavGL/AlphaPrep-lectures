//https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Exams/2016-04-26/3.SumOfEvenDivisors%20-%20Morning/README.md

using System;
using System.Collections.Generic;
using System.Linq;
class SumOfEvenDivisors
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int sum = 0;

        int smallerNumber = Math.Min(A, B);
        int largerNumber = Math.Max(A, B);


        for (int i = smallerNumber; i <= largerNumber; i++)
        {
            for (int j = 2; j <= i; j += 2)
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }
        }

        Console.WriteLine(sum);
    }
}

