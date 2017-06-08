using System;
using System.Collections.Generic;
using System.Linq;
class MixingNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var numbersArr = new int[n];

        for (int i = 0; i < numbersArr.Length; i++)
        {
            numbersArr[i] = int.Parse(Console.ReadLine());
        }

        string mixing = "";
        string substracting = "";

        for (int j = 1; j < numbersArr.Length; j++)
        {
            mixing += ((numbersArr[j - 1] % 10) * (numbersArr[j] / 10)) + " ";
            substracting += Math.Abs(numbersArr[j - 1] - numbersArr[j]) + " ";
        }

        Console.WriteLine(mixing.TrimEnd(' '));
        Console.WriteLine(substracting.TrimEnd(' '));
    }
}

