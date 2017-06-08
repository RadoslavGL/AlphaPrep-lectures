//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

//Use only one loop.Print the result with 5 digits after the decimal point.

using System;
class Calculate
{
    static void Main(string[] args)
    {
        double N = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double S = 1;
        double nFactorial = 1;

        for (int i = 1; i <= N; i++)
        {
            nFactorial *= i;
            S += nFactorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:f5}",S);
    }
}

