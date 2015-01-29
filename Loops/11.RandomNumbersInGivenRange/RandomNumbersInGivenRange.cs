using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a min amount:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a max amount:");
        int max = int.Parse(Console.ReadLine());
        Random randomNumber = new Random();

        for (int i = 0; i < number; i++)
        {
            Console.Write(randomNumber.Next(min, max + 1) + " ");
        }
    }
}