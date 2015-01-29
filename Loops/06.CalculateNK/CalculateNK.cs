using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("Please enter a value for N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a value for K:");
        int k = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factK = 1;

        if ((n > k) && (k > 1) && (k < 100) && (n > 1) && (n < 100))
        {
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                if (i > k)
                {
                    continue;
                }
                factK *= i;
            }
            Console.WriteLine(factN / factK);
        }
        else
        {
            Console.WriteLine(@"Please enter a numbers in range /1 - 100/");
        }
    }
}