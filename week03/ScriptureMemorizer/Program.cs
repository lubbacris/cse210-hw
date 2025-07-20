  //Showed creativity by adding the option for the program to select a random scripture from the library
  using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = CreateScriptureLibrary();
        
        Random random = new Random();
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        // Main program loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are now hidden. Press any key to exit.");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(random.Next(2, 5));
        }
    }

    //Method to create a scripture library for showing creativity and exceeding requirements
    private static List<Scripture> CreateScriptureLibrary()
    {
        List<Scripture> library = new List<Scripture>();
        
        //Adding the scriptures to library
        library.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));

        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        ));

        library.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ who strengthens me."
        ));

        library.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd, I shall not want."
        ));

        library.Add(new Scripture(
            new Reference("Romans", 8, 28),
            "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."
        ));

        return library;
    }
}