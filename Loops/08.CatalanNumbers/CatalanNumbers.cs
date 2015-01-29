using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        BigInteger first = 1;
        BigInteger second = 1;
        BigInteger third = 1;
        
        if (number > 1 && number < 100)
        {
            for (int i = 1; i <= 2 * number; i++)
            {
                first *= i;
                if (i > number + 1)
                {
                    continue;
                }
                second *= i;
                if (i > number)
                {
                    continue;
                }
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