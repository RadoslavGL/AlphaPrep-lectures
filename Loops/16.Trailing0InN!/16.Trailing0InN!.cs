using System;
using System.Collections.Generic;
using System.Linq;
class Trailing0InN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int pow = 1;
        int counterZeros = 0;

        while (Math.Pow(5, pow) <= n )
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % (int)Math.Pow(5, pow) == 0)
                {
                    counterZeros++;
                }
            }
            pow++;
        }

       

        Console.WriteLine(counterZeros);
    }
}

