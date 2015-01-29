using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        int first = 5;
        int second = 7;

        if (number % first == 0 && number % second == 0 && number != 0)
        {
            Console.WriteLine(number % first == 0 && number % second == 0 && number != 0);
        }
        else
        {
            Console.WriteLine(number % first == 0 && number % second == 0 && number != 0);
        }
    }
}