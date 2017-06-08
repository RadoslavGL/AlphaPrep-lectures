//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
class CompareCharArrays
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        int lengthSmaller = Math.Min(str1.Length, str2.Length);
        int i = 0;

        bool isEqual = true;

        while (i < lengthSmaller)
        {
            if ((int)str1[i] > (int)str2[i])
            {
                Console.WriteLine(">");
                isEqual = false;
                break;
            }
            else if ((int)str1[i] < (int)str2[i])
            {
                Console.WriteLine("<");
                isEqual = false;
                break;
            }
            i++;
        }

        if (str1.Length > str2.Length && isEqual == true)
        {
            Console.WriteLine(">");
            isEqual = false;
        }
        else if (str1.Length < str2.Length && isEqual == true)
        {
            Console.WriteLine("<");
            isEqual = false;
        }


        if (isEqual)
        {
            Console.WriteLine("=");
        }

    }
}

