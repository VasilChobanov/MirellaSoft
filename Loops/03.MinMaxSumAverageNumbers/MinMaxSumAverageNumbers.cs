using System;

class MinMaxSumAverageNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter how many numbers you would like to enter:");
        int check = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your {0} numbers:", check);

        int sum = 0;
        double avg = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 1; i <= check; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine("The min is: {0}", min);
        Console.WriteLine("The max is: {0}", max);
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The avg is: {0:0.00}", avg = (double)sum / check);
    }
}