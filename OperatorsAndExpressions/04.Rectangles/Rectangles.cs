using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter the width of the rectangle:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the rectangle:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The Perimeter of the rectangle is: {0}", 2 * (width + height));
        Console.WriteLine("The Area of the rectangle is: {0}", width * height);
    }
}