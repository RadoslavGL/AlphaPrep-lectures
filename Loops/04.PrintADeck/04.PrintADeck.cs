using System;
namespace _04.PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            string face = Console.ReadLine();
            string[] faceArr = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int indexFace = Array.IndexOf(faceArr, face);

            for (int i = 0; i <= indexFace; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", faceArr[i]);
            }
            

        }
    }
}
