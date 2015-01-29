using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a bit position:");
        int position = int.Parse(Console.ReadLine());

        int numberBinary = number >> position;
        int result = numberBinary & 1;

        if (result == 1)
        {
            Console.WriteLine(@"The bit of posiiton ""{0}"" is: 1", position);
        }
        else
        {
            Console.WriteLine(@"The bit of posiiton ""{0}"" is: 0", position);
        }
    }
}