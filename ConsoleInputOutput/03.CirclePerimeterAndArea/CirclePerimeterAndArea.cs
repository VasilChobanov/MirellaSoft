using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Please enter a radius of the circle:");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The perimeter of the circle is: {0:0.00}", perimeter);
        Console.WriteLine("The area of the circle is: {0:0.00}", area);
    }
}