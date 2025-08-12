using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private LevelSystem _levelSystem = new LevelSystem();

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": DisplayPlayerInfo(); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
                case "7": return;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target times: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.GetPoints();
            
            //Creating enhancement: Level progression
            int gainedLevels = _levelSystem.AddExperience(goal.GetPoints());
            if (gainedLevels > 0)
            {
                Console.WriteLine($"\nLEVEL UP! You reached level {_levelSystem.CurrentLevel}!");
            }
            
            Console.WriteLine($"Event recorded! +{goal.GetPoints()} points");
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
        Console.WriteLine($"Level: {_levelSystem.CurrentLevel} ({_levelSystem.CurrentTitle})");
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_levelSystem.CurrentLevel);
            outputFile.WriteLine(_levelSystem.CurrentExperience);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        
        if (!File.Exists(filename)) return;

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _levelSystem.SetLevel(int.Parse(lines[1]));
        _levelSystem.SetExperience(int.Parse(lines[2]));

        _goals.Clear();
        for (int i = 3; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), 
                        int.Parse(data[3]), int.Parse(data[4])));
                    break;
            }
        }
    }
}