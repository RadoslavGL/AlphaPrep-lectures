using System;
using System.Collections.Generic;
using System.Linq;
class MythicalNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstDigit = n / 100;
        int secondDigit = (n % 100) / 10;
        int thirdDigit = n % 10;

        double result = 0;

        if (thirdDigit == 0 )
        {
            result = (double)firstDigit * secondDigit;
        }
        else if (thirdDigit > 0 && thirdDigit < 6)
        {
            result = (double)(firstDigit * secondDigit) / thirdDigit;
        }
        else
        {
            result = (double)(firstDigit + secondDigit) * thirdDigit;
        }

        Console.WriteLine("{0:f2}", result);
    }
}

