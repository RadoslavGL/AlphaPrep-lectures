//Write a program that reads from the console a sequence of N real numbers and returns 
//the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point).


using System;
namespace _03.MMSAOfNNumbers
{
    class MMSAOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;

                if (input > maxValue)
                {
                    maxValue = input;
                }

                if (input < minValue)
                {
                    minValue = input;
                }

            }

            Console.WriteLine("min={0:f2}", minValue);
            Console.WriteLine("max={0:f2}", maxValue);
            Console.WriteLine("sum={0:f2}", sum);
            double avgValue = (double)sum / n;
            Console.WriteLine("avg={0:f2}", avgValue);


        }
    }
}
