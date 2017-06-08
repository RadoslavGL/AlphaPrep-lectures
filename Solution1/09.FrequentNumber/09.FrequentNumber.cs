//Write a program that finds the most frequent number in an array of N elements.
using System;
using System.Collections.Generic;
using System.Linq;
class FrequentNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var arrN = new int[n];

        for (int i = 0; i < arrN.Length; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        int mostFreqNum = 0;
        int reps = 1;
        int maxReps = 1;

        for (int i = 0; i < arrN.Length - 1; i++)
        {
            for (int j = i + 1; j < arrN.Length; j++)
            {
                if (arrN[i] == arrN[j])
                {
                    reps++;

                }
                if (reps > maxReps)
                {
                    maxReps = reps;
                    mostFreqNum = arrN[i];
                }
            }
            reps = 1;

        }

        Console.WriteLine("{0} ({1} times)", mostFreqNum, maxReps);
    }
}

