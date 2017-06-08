using System;
using System.Collections.Generic;
using System.Linq;
class MaximalSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var intArr = new int[n];

        for (int i = 0; i < intArr.Length; i++)
        {
            intArr[i] = int.Parse(Console.ReadLine());
        }

        int sequenceLength = 1;
        int maxSequence = 0;

        for (int i = 1; i < intArr.Length; i++)
        {
            if (intArr[i] == intArr[i - 1])
            {
                sequenceLength++;
                if (sequenceLength > maxSequence)
                {
                    maxSequence = sequenceLength;
                }
            }
            else
            {
                sequenceLength = 1;
            }
        }

        Console.WriteLine(maxSequence);

    }
}

