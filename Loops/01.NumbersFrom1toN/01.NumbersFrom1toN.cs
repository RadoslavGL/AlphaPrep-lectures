//Write a program that enters from the console a positive integer n and prints 
//all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

using System;
class NumbersFrom1toN
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

