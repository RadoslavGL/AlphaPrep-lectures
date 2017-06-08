//Write a program that calculates N! / K! for given N and K.
using System;
using System.Numerics;
class CalculateAgain
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        BigInteger sum = 1;

        for (int i = K + 1; i <= N; i++)
        {
            sum *= i;
        }
        Console.WriteLine(sum);
    }
}

