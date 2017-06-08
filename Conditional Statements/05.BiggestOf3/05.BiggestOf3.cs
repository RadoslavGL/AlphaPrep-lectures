//Write a program that finds the biggest of three numbers that are read from the console.
using System;
class BiggestOf3
{
    static void Main(string[] args)
    {
        double input1 = double.Parse(Console.ReadLine());
        double maxValue = double.MinValue;
        if (input1 > maxValue)
        {
            maxValue = input1;
        }
        double input2 = double.Parse(Console.ReadLine());
        if (input2 > maxValue)
        {
            maxValue = input2;
        }
        double input3 = double.Parse(Console.ReadLine());
        if (input3 > maxValue)
        {
            maxValue = input3;
        }

        Console.WriteLine(maxValue);
    }
}

