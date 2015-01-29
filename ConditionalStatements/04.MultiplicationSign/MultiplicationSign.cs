using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double third = double.Parse(Console.ReadLine());

        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine();
            Console.WriteLine("0");
        }
        else if (first > 0 && second > 0 && third > 0)
        {
            Console.WriteLine();
            Console.WriteLine("+");
        }
        else if (first < 0 && second < 0 && third < 0)
        {
            Console.WriteLine();
            Console.WriteLine("-");
        }
        else
        {
            if (first > 0 && (second < 0 && third < 0) || second > 0 && (first < 0 && third < 0) || third > 0 && (second < 0 && first < 0))
            {
                Console.WriteLine();
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("-");
            }
        }
    }
}