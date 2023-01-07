using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First Name? ")
        string first = Console.Readline();

        Console.Write("What is your Last Name? ")
        string last = Console.Readline();

        Console.WriteLine($"Your name is {last}, {first}{last}.")
    }
}