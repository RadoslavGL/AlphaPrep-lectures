//Using loops write a program that converts an integer number to its binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
class DecimalТoBinary
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string binary = "";
        int remainder;
        
        while (n > 0)
        {
            remainder = n % 2;
            binary = remainder + binary;
            n /= 2;
        }

        Console.WriteLine(binary);
    }
}

