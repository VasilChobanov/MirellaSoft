using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine(@"The value of ""a"" is: {0}", a);
        Console.WriteLine(@"The value of ""b"" is: {0}", b);

        int c = a;
        a = b;
        b = c;

        Console.WriteLine();
        Console.WriteLine(@"The value of ""a"" after exchange is: {0}", a);
        Console.WriteLine(@"The value of ""b"" after exchange is: {0}", b);
    }
}