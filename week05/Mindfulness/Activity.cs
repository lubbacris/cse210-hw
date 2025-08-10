using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;
        protected static int _totalActivities;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity\n");
            Console.WriteLine(_description);
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nGet ready...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\n\nWell done!!");
            ShowSpinner(3);
            Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
            ShowSpinner(3);
            _totalActivities++;
        }

        public void ShowSpinner(int seconds)
        {
            List<string> animations = new List<string> { "|", "/", "-", "\\" };
            int index = 0;
            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            while (DateTime.Now < endTime)
            {
                Console.Write(animations[index]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                index = (index + 1) % animations.Count;
            }
        }

        public void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        
        public static void DisplayActivityLog()
        {
            Console.WriteLine($"\nTotal mindfulness sessions completed: {_totalActivities}");
        }

        public abstract void Run();
    }
}