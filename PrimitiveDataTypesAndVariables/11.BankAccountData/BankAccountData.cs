using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = null;
        string middleName = null;
        string lastName = null;
        decimal moneyAmount = 0M;
        string bank = null;
        string iban = null;
        uint? firstCard = null;
        uint? secondCard = null;
        uint? tirthCard = null;

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Middle Name: {0}", middleName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Amount: {0}", moneyAmount);
        Console.WriteLine("Bank: {0}", bank);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit Card Number: {0}", firstCard);
        Console.WriteLine("Credit Card Number: {0}", secondCard);
        Console.WriteLine("Credit Card Number: {0}", tirthCard);
    }
}