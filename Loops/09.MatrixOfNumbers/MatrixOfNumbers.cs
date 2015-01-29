using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive number from 1 to 20");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 20)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
                for (int a = i + 1; a < number + i; a++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number!");
        }
    }
}