using System;
using System.Collections.Generic;
using System.Linq;
class JumpJump
{
    static void Main(string[] args)
    {
        string instructions = Console.ReadLine();

        int index = 0;
        string message = "Fell off the dancefloor at {0}!";

        while (index >= 0 && index < instructions.Length)
        {
            char ch = instructions[index];
            if (ch == '^')
            {
                message = "Jump, Jump, DJ Tomekk kommt at {0}!";
                break;
            }
            else if (ch == '0')
            {
                message = "Too drunk to go on after {0}!";
                break;
            }


            else if ((ch - '0') % 2 == 0)
            {
                index += (ch - '0');
            }
            else
            {
                index -= (ch - '0');
            }

        }

        Console.WriteLine(message, index);

    }
}

