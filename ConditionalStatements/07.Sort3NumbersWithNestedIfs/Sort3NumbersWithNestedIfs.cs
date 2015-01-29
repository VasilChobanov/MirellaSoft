using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        double third = double.Parse(Console.ReadLine());

        if (first > second && second > third || first > third && third > second)
        {
            if (second > third)
            {
                Console.WriteLine("{0} {1} {2}", first, second, third);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", first, third, second);
            }
        }
        else if (second > first && first > third || second > third && third > first)
        {
            if (first > third)
            {
                Console.WriteLine("{0} {1} {2}", second, first, third);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", second, third, first);
            }
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine("{0} {1} {2}", third, first, second);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", third, second, first);
            }
        }
    }
}