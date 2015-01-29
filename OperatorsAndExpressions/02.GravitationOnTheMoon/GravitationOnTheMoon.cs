using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Please enter a your weight:");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Your weight on the Moon will be: {0}", weight * 0.17);
    }
}