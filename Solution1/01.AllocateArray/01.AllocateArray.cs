// #1 Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 
//and then prints the obtained array on the console.

// #2 Write a program that reads two integer arrays of size N from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //#1
        //int n = int.Parse(Console.ReadLine());
        //var intArr = new int[n];

        //for (int i = 0; i < intArr.Length; i++)
        //{
        //    intArr[i] = i * 5;
        //}

        //foreach (var number in intArr)
        //{
        //    Console.WriteLine(number);
        //}

        //#2
        int n = int.Parse(Console.ReadLine());
        var arr1 = new int[n];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        var arr2 = new int[n];

        for (int j   = 0; j < arr2.Length; j++)
        {
            arr2[j] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        int k = 0;
        while (k < arr1.Length && isEqual)
        {
            if (arr1[k] != arr2[k])
            {
                isEqual = false;
            }
            k++;
        }

        Console.WriteLine(isEqual ? "Equal" : "Not equal");
    }
}

