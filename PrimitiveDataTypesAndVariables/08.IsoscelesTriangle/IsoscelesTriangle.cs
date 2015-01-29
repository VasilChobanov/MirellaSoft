using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00A9';

        Console.WriteLine(" " + " " + " " + " " + copyright);
        Console.WriteLine(" " + " " + " " + copyright + " " + copyright);
        Console.WriteLine(" " + " " + copyright + " " + " " + " " + copyright);
        Console.WriteLine(" " + copyright + " " + copyright + " " + copyright + " " + copyright);
    }
}