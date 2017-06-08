//Using loops write a program that converts an integer number to its hexadecimal representation.
using System;
class DecimalToHex
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long remainder;
        string hexadecimalValue = "";

        while (n > 0)
        {
            remainder = n % 16;

            switch (remainder)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: hexadecimalValue = remainder + hexadecimalValue; break;
                case 10: hexadecimalValue = 'A' + hexadecimalValue; break;
                case 11: hexadecimalValue = 'B' + hexadecimalValue; break;
                case 12: hexadecimalValue = 'C' + hexadecimalValue; break;
                case 13: hexadecimalValue = 'D' + hexadecimalValue; break;
                case 14: hexadecimalValue = 'E' + hexadecimalValue; break;
                case 15: hexadecimalValue = 'F' + hexadecimalValue; break;

                default:
                    break;
            }

            n /= 16;
        }

        Console.WriteLine(hexadecimalValue);
    }
}

