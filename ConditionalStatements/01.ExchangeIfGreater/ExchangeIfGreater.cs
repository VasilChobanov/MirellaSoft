using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double c = a;
            a = b;
            b = c;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
	    {
            Console.WriteLine("{0} {1}", a, b);
	    }
    }
}