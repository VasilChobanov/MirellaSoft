using System;

class StringsAndObjects
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object helloWorld = first + " " + second;
        string third = (string)helloWorld;

        Console.WriteLine(third);
    }
}