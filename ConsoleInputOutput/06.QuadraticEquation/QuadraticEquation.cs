using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double third = double.Parse(Console.ReadLine());

        Console.WriteLine("x1 = {0}", (- second - Math.Sqrt(Math.Pow(second, 2) - 4 * first * third)) / (2 * first));
        Console.WriteLine("x2 = {0}", (- second + Math.Sqrt(Math.Pow(second, 2) - 4 * first * third)) / (2 * first));
    }
}