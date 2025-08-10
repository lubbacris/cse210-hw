using System;
using System.Threading;

namespace MindfulnessApp
{
    class Program
    {
        //Exceeded requirements by doing the following:
        //Added activity statistics tracking
        //Added animations with dynamic spinners
        //Enhanced user experience with better prompts and timing
        //Added session summary at program exit
        //Implemented input validation for menu selections
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activities Menu\n");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("\nSelect an activity: ");
                
                string choice = Console.ReadLine();
                
                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => null,
                    _ => null
                };
                
                if (activity == null) 
                {
                    if (choice == "4") 
                    {
                        Activity.DisplayActivityLog();
                        Console.WriteLine("\nThank you for practicing mindfulness!");
                        Thread.Sleep(3000);
                        break;
                    }
                    Console.WriteLine("Invalid selection. Please try again.");
                    Thread.Sleep(1500);
                    continue;
                }
                
                activity.Run();
            }
        }
    }
}