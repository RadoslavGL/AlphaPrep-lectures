//Write a program that calculates the greatest common divisor(GCD) of given two integers A and B.

//Use the Euclidean algorithm(find it in Internet).

using System;
using System.Collections.Generic;
using System.Linq;
class GCD
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
        int A = numbers[0];
        int B = numbers[1]; 

        int remainder = int.MinValue;

        while (A > 0 && B > 0)
        {
            if (A > B)
            {
                remainder = A % B;
                A = B;
                B = remainder;
            }
            else
            {
                remainder = B % A;
                B = A;
                A = remainder;
            }
        }

        Console.WriteLine(A == 0 ? B : A);

    }
}

