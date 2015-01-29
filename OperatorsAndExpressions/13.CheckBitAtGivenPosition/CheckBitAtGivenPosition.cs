using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a bit position:");
        int position = int.Parse(Console.ReadLine());

        int numberBinary = number >> position;
        int result = numberBinary & 1;
        bool check = result == 1;

        Console.WriteLine(check);
    }
}