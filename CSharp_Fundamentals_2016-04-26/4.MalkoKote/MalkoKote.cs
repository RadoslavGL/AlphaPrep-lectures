using System;
using System.Collections.Generic;
using System.Linq;
class MalkoKote
{
    static void Main(string[] args)
    {
        ////size - between 10 and 86
        //int S = int.Parse(Console.ReadLine());
        //char C = char.Parse(Console.ReadLine());

        //int height = S;

        ////ears: space - char - 1 + (s - 10)/4 spaces - char
        //string ears = ' ' + new string(C, 1) + new string(' ', (1 + (S - 10) / 4)) + new string(C, 1);
        //Console.WriteLine(ears);

        ////Head
        //v 

        int P = int.Parse(Console.ReadLine());
        int pBinLen = Convert.ToString(P, 2).Length;
        Console.WriteLine(pBinLen);
    }
}

