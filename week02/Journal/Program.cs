using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._time = DateTime.Now.ToShortTimeString();
                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    
                    
                    Console.WriteLine($"Prompt: {newEntry._promptText}");
                    Console.Write("Your response: ");
                    newEntry._entryText = Console.ReadLine();

                    //added prompt to ask for mood to show creativity and exceed requirements
                    Console.Write("Rate your mood today (1-5): "); 
                    newEntry._mood = Console.ReadLine();
                    
                    journal.AddEntry(newEntry);
                    break;
                    
                case "2":
                    journal.DisplayAll();
                    break;
                    
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully.\n");
                    break;
                    
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully.\n");
                    break;
                    
                case "5":
                    running = false;
                    break;
                    
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}