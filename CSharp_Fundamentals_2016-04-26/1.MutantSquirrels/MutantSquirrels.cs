using System;
using System.Collections.Generic;
using System.Linq;
class MutantSquirrels
{
    static void Main(string[] args)
    {
        ulong nTrees = ulong.Parse(Console.ReadLine());
        uint nBrances = uint.Parse(Console.ReadLine());
        uint nSquirels = uint.Parse(Console.ReadLine());
        uint nTails = uint.Parse(Console.ReadLine());

        ulong result = nBrances * nSquirels * nTails * nTrees;

        const ulong multiplier = 376439;
        const double devisor = 7.00;

        Console.WriteLine("{0:f3}", result % 2 == 0 ?
            result * multiplier :
            result / devisor);

    }
}

