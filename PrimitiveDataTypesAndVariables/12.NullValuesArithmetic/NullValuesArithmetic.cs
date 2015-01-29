using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? first = null;
        double? second = null;

        Console.WriteLine("The value of \"int\" is: {0}", first);
        Console.WriteLine("The value of \"double\" is: {0}", second);
        Console.WriteLine();
        Console.WriteLine("\"int\" + 5: {0}", first + 5);
        Console.WriteLine("\"int\" + \"null\": {0}", first + null);
    }
}