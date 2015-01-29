using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());

        int numberBinary = number >> 3;
        int result = numberBinary & 1;

        if (result == 1)
        {
            Console.WriteLine(@"The bit of posiiton ""3"" is: 1");
        }
        else
        {
            Console.WriteLine(@"The bit of posiiton ""3"" is: 0");
        }
    }
}