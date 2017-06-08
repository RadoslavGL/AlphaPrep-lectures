//The first number S is the index of the symbol he should start decoding(starting from 0) and the 
//second number E is the last index of the symbol of the segment he needs to decode(inclusive).
//Additionally if the currently read line is odd you should take every 3rd symbol, otherwise 
//(if it's even) every 4th. Start counting the lines from 1 (one).
//To make things easy, when the subtitles finish Tzacky always adds end instead of the starting index S(see sample tests).

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        string message = "";
        int counter = 0;
        

        while (true)
        {
            int start = 0;
            int finish = 0;
            int step = 0;
            string subs = "";
            string input = Console.ReadLine();
            counter++;
            if (input == "end")
            {
                break;
            }
            else
            {
                start = int.Parse(input);
                
            }

            finish = int.Parse(Console.ReadLine());
            
            counter++;

            subs = Console.ReadLine();
            counter++;

            if (counter % 2 != 0)
            {
                step = 3;
            }
            else
            {
                step = 4;
            }

            if (start < 0)
            {
                start = subs.Length + start;
            }

            if (finish < 0)
            {
                finish = subs.Length + finish;
            }

            for (int i = start; i <= finish && i >= 0 && i <= subs.Length; i += step)
            {
                message += subs[i];
            }

        }

        Console.WriteLine(message);
    }
}

