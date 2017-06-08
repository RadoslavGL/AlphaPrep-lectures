using System;
class BiggestOf5
{
    static void Main(string[] args)
    {
        double input1 = Convert.ToDouble(Console.ReadLine());
        double biggestNumbers = double.MinValue;

        if (input1 > biggestNumbers)
        {
            biggestNumbers = input1;
        }

        double input2 = Convert.ToDouble(Console.ReadLine());

        if (input2 > biggestNumbers)
        {
            biggestNumbers = input2;
        }

        double input3 = Convert.ToDouble(Console.ReadLine());

        if (input3 > biggestNumbers)
        {
            biggestNumbers = input3;
        }

        double input4 = Convert.ToDouble(Console.ReadLine());

        if (input4 > biggestNumbers)
        {
            biggestNumbers = input4;
        }

        double input5 = Convert.ToDouble(Console.ReadLine());

        if (input5 > biggestNumbers)
        {
            biggestNumbers = input5;
        }

        Console.WriteLine(biggestNumbers);
    }
}

