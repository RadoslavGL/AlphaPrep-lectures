//Using loops write a program that converts a binary integer number to its decimal form.

//The input is entered as string. The output should be a variable of type long.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _11.BinarytoDecimal
{
    class BinarytoDecimal
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger binaryValue = BigInteger.Parse(input);

            BigInteger decimalValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                decimalValue += (binaryValue % 10) * (BigInteger)Math.Pow(2, (double)i);
                binaryValue /= 10;
            }
            Console.WriteLine(decimalValue);
        }
    }
}
