using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string user_input = Console.ReadLine();
        int grade_percentage = int.Parse(user_input);
        
        string letter;
        string sign = "";
        
        //Determining grade letter
        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        //Determining sign (+, -, or none)
        int last_digit = grade_percentage % 10;
        
        if (letter != "F" && letter != "A")
        {
            if (last_digit >= 7)
            {
                sign = "+";
            }
            else if (last_digit < 3)
            {
                sign = "-";
            }
        }
        
        if (letter == "A" && last_digit >= 7)
        {
            sign = "";
        }
        
        if (letter == "F")
        {
            sign = "";
        }
        
        //Printing results
        Console.WriteLine("===========================================");
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
        
        if (grade_percentage >= 70)
        {
            Console.WriteLine("Job Well Done! You passed!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying!!!");
        }
    }
}