using System;

class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        int input;
        
        //Getting numbers from the user
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        //Computimg the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        //Computing the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        //Finding the maximum number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        
        //Stretch Challenge
        int smallest_positive = int.MaxValue;
        bool found_positive = false;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest_positive)
            {
                smallest_positive = number;
                found_positive = true;
            }
        }
        if (found_positive)
        {
            Console.WriteLine($"The smallest positive number is: {smallest_positive}");
        }
        
        numbers.Sort();
        Console.WriteLine("The sorted list is as follows:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}