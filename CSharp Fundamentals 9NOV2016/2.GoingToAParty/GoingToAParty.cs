//Problem:

//Following the directions
//You will start from the first symbol of the directions(which is at position 0)
//Step on a lower latin letter:
//take it's position P in the latin alphabet('a' is 1, 'b' is 2 and so on)
//move forward by P positions
//Step on a upper latin letter:
//take it's position P in the latin alphabet('A' is 1, 'B' is 2 and so on)
//move backward by P positions
//Step on a party symbol '^':
//print Djor and Djano are at the party at POSITION!, where POSITION at which they stepped on the party symbol '^'
//Getting lost

//If a step sends you at an index that is outside of the directions(negative or too large index), 
//print Djor and Djano are lost at POSITION!, where POSITION is the index that is outside the description.


using System;
using System.Collections.Generic;
using System.Linq;
class GoingToAParty
{
    static void Main(string[] args)
    {
        string directions = Console.ReadLine();
        int position = 0;
        bool isLost = false;


        while ((char)directions[position] != '^')
        {
            if ((int)directions[position] >= 97 && (int)directions[position] <= 122)
            {
                position += (int)directions[position] - 96;
            }
            else
            {
                position -= (int)directions[position] - 64;
            }

            if (position < 0 || position >= directions.Length)
            {
                isLost = true;
                break;
            }
        }

        if (isLost == false)
        {
            Console.WriteLine("Djor and Djano are at the party at {0}!", position);
        }
        else
        {
            Console.WriteLine("Djor and Djano are lost at {0}!", position);
        }
    }
}

