using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());

	    int a = 0;
	    int b = 1;

        Console.Write(0 + ", ");

        for (int i = 0; i < (number - 1); i++)
        {
            int sum = a;
            a = b;
            b = sum + b;
            Console.Write(a + ", ");
        }
    }
}