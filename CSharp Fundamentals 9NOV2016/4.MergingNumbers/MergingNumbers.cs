using System;
using System.Collections.Generic;
using System.Linq;class MergingNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var numbersArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbersArr[i] = int.Parse(Console.ReadLine());
        }

        string merge = "";
        string sum = "";

        for (int j = 1; j < n; j++)
        {
            merge += Convert.ToString(numbersArr[j] / 10) + Convert.ToString(numbersArr[j - 1] % 10) + " ";
            sum += numbersArr[j] + numbersArr[j - 1] + " ";
        }

        Console.WriteLine(merge.TrimEnd(' '));
        Console.WriteLine(sum.TrimEnd(' '));
    }
}

