using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter a pozition \"x\":");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a pozition \"y\":");
        double y = double.Parse(Console.ReadLine());

        int xCircle = 1;
        int yCircle = 1;
        double r = 1.5;
        int rectTop = 1;
        int rectLeft = -1;
        int rectWidth = 6;
        int rectHeight = 2;
        int rectBottom = rectTop - rectHeight;
        int rectRight = rectLeft + rectWidth;
        double distance = Math.Sqrt(Math.Pow(x - xCircle, 2) + Math.Pow(y - yCircle, 2));

        Console.WriteLine((distance <= r) && (!(x >= rectLeft && x <= rectRight && y >= rectBottom && y <= rectTop)) ? "Yes" : "No");
    }
}