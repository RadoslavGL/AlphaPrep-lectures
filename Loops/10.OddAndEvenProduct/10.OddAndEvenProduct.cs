//You are given N integers(given in a single line, separated by a space).

//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                productEven *= numbers[i];
            }
            else
            {
                productOdd *= numbers[i];
            }
        }

        Console.WriteLine(productOdd == productEven ? "yes {0}" : "no {0} {1}", productOdd, productEven);
    }
}

