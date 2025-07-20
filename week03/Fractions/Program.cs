using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        //testing getters and setters
        f1.SetTop(2);
        f1.SetBottom(3);
        Console.WriteLine($"Top: {f1.GetTop()}, Bottom: {f1.GetBottom()}");

        //Testing representations
        Console.WriteLine($"{f1.GetFractionString()} = {f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()} = {f3.GetDecimalValue()}");
        Console.WriteLine($"{f4.GetFractionString()} = {f4.GetDecimalValue()}");

        //more test cases
        Console.WriteLine("\nAdditional test cases:");
        Console.WriteLine(new Fraction().GetFractionString());
        Console.WriteLine(new Fraction().GetDecimalValue());
        Console.WriteLine(new Fraction(6).GetFractionString());
        Console.WriteLine(new Fraction(6).GetDecimalValue());
        Console.WriteLine(new Fraction(6, 7).GetFractionString());
        Console.WriteLine(new Fraction(6, 7).GetDecimalValue());
    }
}