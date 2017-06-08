using System;
using System.Collections.Generic;
using System.Linq;
class FindSumInArray
{
    static void Main(string[] args)
    {
        var arrN = Console.ReadLine().Split(new char[] {' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToArray();

        int sum = int.Parse(Console.ReadLine());


        int currentSum = 0;
        bool isSumFound = false;

        for (int i = 0; i < arrN.Length; i++)
        {
            currentSum = arrN[i];
            string currrentSequence = arrN[i] + ", ";

            if (currentSum == sum)
            {
                isSumFound = true;
                Console.WriteLine("{0}", currrentSequence.TrimEnd(' ', ','));
            }

            for (int j = i + 1; j < arrN.Length; j++)
            {
                currentSum += arrN[j];
                currrentSequence += arrN[j] + ", ";

                if (currentSum == sum)
                {
                    isSumFound = true;
                    Console.WriteLine("{0}", currrentSequence.TrimEnd(' ', ''));
                }
            }
        }

        if (!isSumFound)
        {
            Console.WriteLine(-1);
        }
    }
}

