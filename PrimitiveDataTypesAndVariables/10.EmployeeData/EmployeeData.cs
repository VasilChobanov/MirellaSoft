using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Gosho";
        string lastName = "Goshev";
        byte age = 32;
        string gender = "male";
        long idNumber = 8306112507;
        int employeeNumber = 27569999;

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", idNumber);
        Console.WriteLine("Unique employee number: {0}", employeeNumber);
    }
}