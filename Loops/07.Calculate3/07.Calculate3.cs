//In combinatorics, the number of ways to choose N different members out of a group of N different elements
//(also known as the number of combinations) is calculated by the following formula: formula 
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

//Try to use only two loops.

using System;
using System.Numerics;
class Calculate3
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        //100 > N > K > 1

        // N! / (K! * (N - K)!) = N!/K! / (N - K)!
        //path 1: N!/K!
        //part 2: (N - K)!

        //loop for part1
        BigInteger resultPart1 = 1;

        for (int i = N; i > K; i--)
        {
            resultPart1 *= i;
        }

        //loop for part2
        BigInteger resultPart2 = 1;

        for (int i = 1; i <= (N - K); i++)
        {
            resultPart2 *= i;
        }

        BigInteger resultTotal = resultPart1 / resultPart2;

        Console.WriteLine(resultTotal);
    }
}

