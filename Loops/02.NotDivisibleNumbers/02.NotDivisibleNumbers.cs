//Write a program that reads from the console a positive integer N and prints all the numbers
// from 1 to N not divisible by 3 or 7, on a single line, separated by a space.

using System;
class NotDivisibleNumbers
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i <= N; i++)
        {
            if (!(i % 3 == 0) && !(i % 7 == 0))
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}

