//Write a program that enters 3 real numbers and prints them sorted in descending order.

using System;
class Sort3Numbers
{
    static void Main(string[] args)
    {
        double input1 = Convert.ToDouble(Console.ReadLine());
        double input2 = Convert.ToDouble(Console.ReadLine());
        double input3 = Convert.ToDouble(Console.ReadLine());

        if (input1 > input2 && input1 > input3)
        {
            if (input2 > input3)
            {
                Console.WriteLine("{0} {1} {2}", input1, input2, input3);
            }
            else
            {
                Console.WriteLine("{0} {2} {1}", input1, input2, input3);
            }
        }
        else if (input2 > input1 && input2 > input3)
        {
            if (input1 > input3)
            {
                Console.WriteLine("{1} {0} {2}", input1, input2, input3);
            }
            else
            {
                Console.WriteLine("{1} {2} {0}", input1, input2, input3);
            }
        }
        else
        {
            if (input1 > input2)
            {
                Console.WriteLine("{2} {0} {1}", input1, input2, input3);
            }
            else
            {
                Console.WriteLine("{2} {1} {0}", input1, input2, input3);
            }
        }


    }
}

