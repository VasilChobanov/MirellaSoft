using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 1 integer and 2 floating-point numbers:");

        int firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        string hex = String.Format("{0:X}", firstNumber);
        string bin = Convert.ToString(firstNumber, 2).PadLeft(10, '0');

        Console.WriteLine("|{0, -10}|{1}|{2, 10:0.00}|{3, -10:0.000}|", hex, bin, secondNumber, thirdNumber);
    }
}