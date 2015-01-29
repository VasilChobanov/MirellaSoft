using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine(first > second ? "The bigger number is: " + first : "The bigger number is: " + second);
    }
}