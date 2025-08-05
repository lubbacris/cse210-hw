using System;

class Program
{
    static void Main()
    {
        //Base object
        Assignment simple = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simple.GetSummary());
        Console.WriteLine();

        //MathAssignment
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        //WritingAssignment
        WritingAssignment writing = new WritingAssignment(
            "Mary Waters", 
            "European History", 
            "The Causes of World War II"
        );
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}