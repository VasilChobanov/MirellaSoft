using System;

class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a bit position:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine(@"Please enter a bit / 1 or 0/:");
        int bit = int.Parse(Console.ReadLine());

        if (bit == 1)
        {
            int mask = 1;
            int numberBinary = mask << position;
            int result = numberBinary | number;

            Console.WriteLine(result);
        }
        else
        {
            int mask = 1;
            int numberBinary = ~(mask << position);
            int result = numberBinary & number;

            Console.WriteLine(result);
        }
    }
}
