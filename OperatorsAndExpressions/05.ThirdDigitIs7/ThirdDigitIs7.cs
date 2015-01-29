using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please neter an integer:");
        int number = int.Parse(Console.ReadLine());

        if ((number / 100) % 7 == 0)
        {
            Console.WriteLine((number / 100) % 10 == 7);
        }
        else
        {
            Console.WriteLine((number / 100) % 10 == 7);
        }
    }
}