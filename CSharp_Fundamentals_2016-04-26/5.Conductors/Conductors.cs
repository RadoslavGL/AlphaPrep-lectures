//https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Exams/2016-04-26/5.Conductors/README.md

using System;
using System.Collections.Generic;
using System.Linq;
class Conductors
{
    static void Main(string[] args)
    {
        int P = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        var numArr = new int[M];

        for (int i = 0; i < M; i++)
        {
            numArr[i] = int.Parse(Console.ReadLine());
        }

        int pBinLen = Convert.ToString(P, 2).Length;

        //only 1s for the length P
        int pMask = (int)Math.Pow(2, pBinLen) - 1;

        for (int j = 0; j < M; j++)
        {
            for (int k = 0; k < 32 - pBinLen; k++)
            {
                int pShifted = P << k;
                if ((numArr[j] & pShifted) == pShifted)
                {
                    numArr[j] = numArr[j] & (~(pMask << k));
                }
            }
        }

        Console.WriteLine(string.Join("\n", numArr));
    }
}

