//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.

using System;
using System.Collections.Generic;
using System.Linq;
class HexToDecimal
{
    static void Main(string[] args)
    {
        string hexValue = Console.ReadLine();

        long decimalValue = 0;

        for (int i = 0; i < hexValue.Length; i++)
        {
            char hexDigit = hexValue[i];
            int multiplier = 0;
            switch (hexDigit)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': multiplier = int.Parse(Convert.ToString(hexDigit)); break;
                case 'A': multiplier = 10; break;
                case 'B': multiplier = 11; break;
                case 'C': multiplier = 12; break;
                case 'D': multiplier = 13; break;
                case 'E': multiplier = 14; break;
                case 'F': multiplier = 15; break;
                default:
                    break;
            }

            decimalValue += multiplier * (long)Math.Pow(16, (hexValue.Length - 1 - i));
        }
        Console.WriteLine(decimalValue);
    }
}

