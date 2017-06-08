using System;
using System.Numerics;
class Demo
{
    static void Main(string[] args)
    {
        //int n = int.Parse(Console.ReadLine());

        //int counter = 1;

        //while (counter <= n)
        //{
        //    Console.WriteLine(counter);
        //    counter++;
        //}

        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //int currectNumber = 1;

        //while (currectNumber <= n)
        //{
        //    sum += currectNumber++;
        //}

        //Console.WriteLine(sum);

        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //int currectNumber = 0;
        //while (++currectNumber <= n)
        //{
        //    sum += currectNumber;
        //}
        //Console.WriteLine(sum);

        //------prime numbers

        //int n = int.Parse(Console.ReadLine());
        //bool isPrime = true;

        //if (n % 2 == 0 && n != 2)
        //{
        //    isPrime = false; 
        //}

        //int possibleDevisor = 3;

        //while (possibleDevisor * possibleDevisor <= n && isPrime)
        //{
        //    if (n % possibleDevisor == 0)
        //    {
        //        isPrime = false;
        //    }
        //    possibleDevisor += 2;
        //}
        //Console.WriteLine(isPrime ? "{0} is prime" : "{0} is not prime, deviseable by {1}", n, possibleDevisor - 1);

        // ----- factorial + break demo

        //int n = int.Parse(Console.ReadLine());

        //int factorial = 1;

        //while (true)
        //{
        //    if (n <= 1)
        //    {
        //        break;
        //    }
        //    factorial *= n;
        //    n--;
        //}
        //Console.WriteLine(factorial);


        //--- Do - While

        //int n = int.Parse(Console.ReadLine());
        //int factorial = 1;
        //do
        //{
        //    factorial *= n;
        //    n--;
        //} while (n > 1);

        //while (false)
        //{
        //    Console.WriteLine("az sym Gosho"); // unreachable
        //}
        //do
        //{
        //    Console.WriteLine("az sym Pesho"); // will run at least once
        //} while (false);

        //int n = int.Parse(Console.ReadLine());
        //BigInteger factorial = 1;
        //do
        //{
        //    factorial *= n;
        //    n--;
        //} while (n > 1);

        //Console.WriteLine(factorial);

        // ----- papagal
        //for (string input = Console.ReadLine(); input != "end"; input = Console.ReadLine())
        //{
        //    Console.WriteLine("You Just Wrote: " + input);
        //}

        // ------ while loop with for
        //for (; true; )
        //{
        //    Console.WriteLine("Gosho");
        //}

        //------ more than one variable
        //for (int i = 0, j = 20; i < 10; i++, j <<= 1)
        //{
        //    Console.WriteLine(j);
        //}


        //// ---- power 

        //while (true)
        //{
        //    Console.WriteLine("pow = ");
        //    int pow = int.Parse(Console.ReadLine());
        //    Console.WriteLine("m = ");
        //    int number = int.Parse(Console.ReadLine());

        //    int result = 1;

        //    for (int i = 0; i < pow; i++)
        //    {
        //        result *= number;
        //    }
        //    Console.WriteLine(result);


        //// ----- diagonal
        //for (int x = 0, y = 0; x < 10; x++, y++)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write('*');
        //}

        // ------ Continue
        int n = 50;
        for (int i = 0; i < n; i++)
        {
            if (i % 5 == 0 || i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }



    }
}

