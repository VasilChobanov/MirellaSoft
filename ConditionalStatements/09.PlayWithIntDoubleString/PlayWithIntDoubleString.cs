using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please enter a number from 1 to 3:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        int choice = int.Parse(Console.ReadLine());

        if (choice >= 1 && choice <= 3)
        {
            if (choice == 1)
            {
                Console.WriteLine("Please enter an integer:");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine(first);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter a double:");
                double second = double.Parse(Console.ReadLine());
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine("Please enter a string:");
                string third = Console.ReadLine();
                Console.WriteLine("{0}*", third);
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

    }
}