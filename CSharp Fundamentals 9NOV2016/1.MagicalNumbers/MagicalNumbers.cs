//Problem:
//You are given a number that is 3 digits long. Depending on the 2nd digit, you need to perform some calculations.

//If the 2nd digit is even, find the sum of the first two digits and multiply the result by the 3rd digit.
//If the 2nd digit is odd, find the product of the first two digits and divide the result by the 3rd digit.


using System;
using System.Collections.Generic;
using System.Linq;
class MagicalNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int secondDigit = (n % 100) / 10;
        int firstDigit = n / 100;
        int thirdDigit = n % 10;

        double result = 0;

        if (secondDigit % 2 == 0)
        {
            result = (double)(firstDigit + secondDigit) * thirdDigit;
        }
        else
        {
            result = (double)(firstDigit * secondDigit) / thirdDigit;
        }


        Console.WriteLine("{0:f2}", rest);
    }
}

