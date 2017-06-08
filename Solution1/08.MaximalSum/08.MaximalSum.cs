//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;
class MaximalSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var arrN = new int[n];
        for (int i = 0; i < arrN.Length; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i < arrN.Length; i++)
        {
            sum += arrN[i];
            if (sum <= 0)
            {
                sum = 0;
            }
            else
            {
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
        }

        Console.WriteLine(maxSum);

    }
}

