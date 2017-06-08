using System;
class IntDoubleString
{
    static void Main(string[] args)
    {
        string typeOfValue = Console.ReadLine();

        if (typeOfValue == "integer")
        {
            int valueInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(valueInt + 1);
        }
        else if (typeOfValue == "real")
        {
            double valueReal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(valueReal + 1);
        }
        else if (typeOfValue == "text")
        {
            string valueText = Console.ReadLine();
            Console.WriteLine(valueText + '*');
        }
    }
}

