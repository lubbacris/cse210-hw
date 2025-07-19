using System.Collections.Generic;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        //Iterating through each job in the list
        foreach (Job job in _jobs)
        {
            //calling the Display method on each job
            job.Display(); 
        }
    }
}