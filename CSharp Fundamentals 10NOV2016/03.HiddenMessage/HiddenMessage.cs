using System;
using System.Collections.Generic;
using System.Linq;
class HiddenMessage
{
    static void Main(string[] args)
    {
        string message = "";
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            int start = int.Parse(input);
            int step = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            if (start < 0)
            {
                start += line.Length;
            }

            for (int i = start; i >= 0 && i < line.Length; i += step)
            {
                message += line[i];
            }


        }

        Console.WriteLine(message);
    }
}

