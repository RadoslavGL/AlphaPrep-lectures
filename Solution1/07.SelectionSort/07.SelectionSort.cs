using System;
using System.Collections.Generic;
using System.Linq;
class SelectionSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var arrN = new int[n];
        for (int i = 0; i < arrN.Length; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        int positionMin;
        int temp;

        for (int i = 0; i < arrN.Length - 1; i++)
        {
            positionMin = i;
            for (int j = i + 1; j < arrN.Length; j++)
            {
                if (arrN[j] < arrN[positionMin])
                {
                    positionMin = j;
                }
            }
            if (positionMin != i)
            {
                temp = arrN[i];
                arrN[i] = arrN[positionMin];
                arrN[positionMin] = temp;
            }
        }

        Console.WriteLine(string.Join("\n", arrN));
    }
}

