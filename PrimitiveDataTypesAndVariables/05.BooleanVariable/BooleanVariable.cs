using System;

class BooleanVariable
{
    static void Main()
    {
        Console.WriteLine(@"Please enter your Gendre: ""male"" or ""female""");

        string gendre = Console.ReadLine();
        string defaultGendre = "female";
        bool isFemale = (gendre == defaultGendre);

        Console.WriteLine("If my gendre is Female: {0}", isFemale);
    }
}