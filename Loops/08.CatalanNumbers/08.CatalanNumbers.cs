//In combinatorics, the Catalan numbers are calculated by the following formula: 
//https://en.wikipedia.org/wiki/Catalan_number

using System.Numerics;
using System;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger catalanNumber = 1;
        BigInteger upperPart = 1;
        BigInteger lowerPart = 1;

        for (int j = n + 1; j <= 2 * n; j++)
        {
            upperPart *= j;
        }

        for (int i = 1; i <= n; i++)
        {
            lowerPart *= i + 1;
        }

        catalanNumber = upperPart / lowerPart;
        Console.WriteLine(catalanNumber);
    }
}
