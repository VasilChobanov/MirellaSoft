using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < number; i++)
        {
            double amount = double.Parse(Console.ReadLine());
            sum += amount;
        }
        Console.WriteLine("The sum of your numbers is: {0}", sum);
    }
}