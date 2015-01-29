using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Please enter a value for N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a value for X:");
        int x = int.Parse(Console.ReadLine());
        int fac = 1;
        double result = 1;

        for (int i = 1; i <= n ; i++)
        {
            result += (fac *= i) / Math.Pow(x, i);
        }
        Console.WriteLine("{0:0.00000}", result);
    }
}