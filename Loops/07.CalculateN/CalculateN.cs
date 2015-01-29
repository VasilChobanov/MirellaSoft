using System;
using System.Numerics;

class CalculateN
{
    static void Main()
    {
        Console.WriteLine("Please enter a value for N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a value for K:");
        int k = int.Parse(Console.ReadLine());
        BigInteger first = 1;
        BigInteger second = 1;
        BigInteger third = 1;

        if (n > k && n > 1 && k > 1 && n < 100 && k < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                first *= i;
                if (i > k)
                {
                    continue;
                }
                second *= i;
            }
            for (int i = 1; i <= (n - k); i++)
            {
                third *= i;
            }
            Console.WriteLine(first / (second * third));
        }
        else
        {
            Console.WriteLine(@"Please enter a numbers in range /1 - 100/");
        }
    }
}