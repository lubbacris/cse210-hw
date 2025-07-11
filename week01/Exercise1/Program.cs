using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Adding line divider for better visibility
        Console.WriteLine("====================================================>");
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.WriteLine(first_name);
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine(last_name);
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}