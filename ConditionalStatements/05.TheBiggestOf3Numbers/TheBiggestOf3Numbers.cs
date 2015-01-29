using System;

class TheBiggestOf3Numbers
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
            Console.WriteLine("The biggest number is: {0}", first);
        }
        else if (second > first && first > third || second > third && third > first)
        {
            Console.WriteLine("The biggest number is: {0}", second);
        }
        else
        {
            Console.WriteLine("The biggest number is: {0}", third);
        }
    }
}