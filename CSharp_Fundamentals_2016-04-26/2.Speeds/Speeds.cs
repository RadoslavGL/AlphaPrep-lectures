//https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Exams/2016-04-26/2.Speeds/README.md
using System;
using System.Collections.Generic;
using System.Linq;
class Speeds
{
    static void Main(string[] args)
    {
        int nCars = int.Parse(Console.ReadLine());

        var speedArr = new ulong [nCars];
        for (int i = 0; i < speedArr.Length; i++)
        {
            speedArr[i] = ulong.Parse(Console.ReadLine());
        }

        ulong currentGroup = 1;
        ulong maxGroup = 0;

        ulong currentSpeed = 0;
        ulong maxSpeed = 0;

        for (int j = 1; j < speedArr.Length; j++)
        {

            if (j == 1)
            {
                currentSpeed = (ulong)speedArr[0];
            }

            if (speedArr[j] > speedArr[j-1])
            {
                currentGroup++;
                currentSpeed += (ulong)speedArr[j];

                if (currentGroup > maxGroup)
                {
                    maxGroup = currentGroup;
                    maxSpeed = currentSpeed;
                }
                else if (currentGroup == maxGroup)
                {
                    if (currentSpeed > (ulong)maxSpeed)
                    {
                        maxSpeed = (ulong)currentSpeed;
                    }
                }

            }
            else
            {
                

                if (currentGroup > maxGroup)
                {
                    maxGroup = currentGroup;
                    maxSpeed = currentSpeed;
                }
                else if (currentGroup == maxGroup)
                {
                    if (currentSpeed > maxSpeed)
                    {
                        maxSpeed = (ulong)currentSpeed;
                    }
                }

                currentGroup = 1;
                currentSpeed = (ulong)speedArr[j];
            }
        }

        Console.WriteLine(maxSpeed);
    }
}

