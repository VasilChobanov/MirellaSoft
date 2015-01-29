using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool check = true;

        if (number > 1)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
            }
            Console.WriteLine(check);
        }
        else
        {
            check = false;
            Console.WriteLine(check);
        }      
    }
}