using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter a side \"a\" of the trapezoid:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a side \"b\" of the trapezoid:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a height \"h\" of the trapezoid:");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The Area of the trapezoid is: {0}", ((a + b) / 2) * h);
    }
}