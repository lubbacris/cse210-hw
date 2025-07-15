using System;

class Program
{
    static void Main(string[] args)
    {
    //Initializing random number generator
        Random random_generator = new Random();
        
        string play_again = "yes";
        
        while (play_again == "yes")
        {
            int magic_number = random_generator.Next(1, 101);
            int guess_count = 0;
            
            Console.WriteLine("The magic number is between 1 and 100. Try to guess it!");
            
            int guess = 0;
            
            while (guess != magic_number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guess_count++;
                
                if (guess < magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed correctly!");
                    
                    //Stretch Challenge 1: Show guess count
                    Console.WriteLine($"It took you {guess_count} guesses.");
                }
            }
            
            //Stretch Challenge 2: Ask to play again
            Console.Write("Would you like to play again? (yes/no) ");
            play_again = Console.ReadLine().ToLower();
        }
        
        Console.WriteLine("Thanks for playing!");
    }
}