using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter four digits number:");
        int number = int.Parse(Console.ReadLine());

        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        Console.WriteLine("The sum of the numbers is: {0}", a + b + c + d);
        Console.WriteLine("The number in reversed order is: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("The last digit in the first position: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", a, c, b, d);
    }
}