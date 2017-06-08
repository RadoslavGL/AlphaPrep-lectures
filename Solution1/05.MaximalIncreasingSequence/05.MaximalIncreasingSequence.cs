using System;
using System.Collections.Generic;
using System.Linq;
class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var arrInt = new int[n];
        for (int i = 0; i < arrInt.Length; i++)
        {
            arrInt[i] = int.Parse(Console.ReadLine());
        }

        int sequence = 1;
        int maxSequence = 0;

        for (int i = 1; i < arrInt.Length; i++)
        {
            if (arrInt[i] > arrInt[i - 1])
            {
                sequence++;
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                }
            }
            else
            {
                sequence = 1;
            }
        }

        Console.WriteLine(maxSequence);
    }
}

