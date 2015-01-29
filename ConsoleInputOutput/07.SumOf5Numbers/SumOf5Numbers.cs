using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double third = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double fourth = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double fifth = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the 5 numbers is: {0}", first + second + third + fourth + fifth);
    }
}