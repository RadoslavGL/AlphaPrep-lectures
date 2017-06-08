//3	    1 2 3
//      2 3 4
//      3 4 5

using System;
class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col < n + row; col++)
            {
                Console.Write("{0} ", col);
            }
            Console.WriteLine();
        }




    }
}

