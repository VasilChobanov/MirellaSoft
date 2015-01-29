using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        char jack = '\u004A';
        char queen = '\u0051';
        char king = '\u004B';
        char ace = '\u0041';
        char clubs = '\u2663';
        char hearts = '\u2665';
        char diamonds = '\u2666';
        char spades = '\u2660';

        for (int i = 0; i <= 14; i++)
        {
            switch (i)
            {
                case 1: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 2, spades, clubs, hearts, diamonds); break;
                case 2: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 3, spades, clubs, hearts, diamonds); break;
                case 3: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 4, spades, clubs, hearts, diamonds); break;
                case 4: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 5, spades, clubs, hearts, diamonds); break;
                case 5: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 6, spades, clubs, hearts, diamonds); break;
                case 6: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 7, spades, clubs, hearts, diamonds); break;
                case 7: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 8, spades, clubs, hearts, diamonds); break;
                case 8: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 9, spades, clubs, hearts, diamonds); break;
                case 9: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 10, spades, clubs, hearts, diamonds); break;
                case 10: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", 11, spades, clubs, hearts, diamonds); break;
                case 11: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", jack, spades, clubs, hearts, diamonds); break;
                case 12: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", queen, spades, clubs, hearts, diamonds); break;
                case 13: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", king, spades, clubs, hearts, diamonds); break;
                case 14: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", ace, spades, clubs, hearts, diamonds); break;
            }
        }

    }
}