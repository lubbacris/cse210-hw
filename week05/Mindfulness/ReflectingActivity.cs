using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        
        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity() : base(
            "Reflection", 
            "This activity will help you reflect on times when you've shown strength and resilience. Recognize your power and how to apply it elsewhere."
        ) { }

        public override void Run()
        {
            DisplayStartingMessage();
            
            Console.WriteLine("\nConsider the following prompt:");
            Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
            Console.WriteLine("\nPress Enter when you have something in mind...");
            Console.ReadLine();
            
            Console.WriteLine("\nNow ponder on these questions:");
            Console.Write("Starting in... ");
            ShowCountdown(5);
            Console.Clear();
            
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write($"\n> {GetRandomQuestion()} ");
                ShowSpinner(10);
            }
            
            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }

        private string GetRandomQuestion()
        {
            Random rand = new Random();
            return _questions[rand.Next(_questions.Count)];
        }
    }
}