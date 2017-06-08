using System;
using System.Collections.Generic;
using System.Linq;
class MaximalKSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        var arrInt = new int[n];

        for (int i = 0; i < arrInt.Length; i++)
        {
            arrInt[i] = int.Parse(Console.ReadLine());
        }

        //sorting
        for (int j = 0; j < arrInt.Length; j++)
        {
            for (int l = j + 1; l < arrInt.Length; l++)
            {
                if (arrInt[l - 1] > arrInt[l])
                {
                    int swap = arrInt[l];
                    arrInt[l] = arrInt[l - 1];
                    arrInt[l - 1] = swap;
                }
            }
        }

        //summing
        int sum = 0;
        for (int m = arrInt.Length - k; m < arrInt.Length; m++)
        {
            sum += arrInt[m];
        }

        Console.WriteLine(sum);
    }
}

