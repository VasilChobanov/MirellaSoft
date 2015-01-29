using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please enter a pozition \"x\":");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a pozition \"y\":");
        double y = double.Parse(Console.ReadLine());

        int xCircle = 0;
        int yCircle = 0;
        int r = 2;
        bool check = true;

        double distance = Math.Sqrt(Math.Pow(x - xCircle, 2) + Math.Pow(y - yCircle, 2));
        if (distance <= r)
        {
            Console.WriteLine(check);
        }
        else
        {
            check = false;
            Console.WriteLine(check);
        }
    }
}