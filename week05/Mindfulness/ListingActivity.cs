using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt inspired recently?",
            "Who are some of your personal heroes?"
        };
        
        private int _itemCount;

        public ListingActivity() : base(
            "Listing", 
            "This activity will help you reflect on positive things in your life by having you list items in a specific area."
        ) { }

        public override void Run()
        {
            DisplayStartingMessage();
            
            Console.WriteLine("\nList as many responses as you can to:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("\nStarting in... ");
            ShowCountdown(5);
            Console.WriteLine();
            
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                _itemCount++;
            }
            
            Console.WriteLine($"\nYou listed {_itemCount} items!");
            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }
    }
}