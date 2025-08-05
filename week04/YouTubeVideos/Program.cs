using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creating videos
        Video video1 = new Video("Python for Beginners", "P for Python", 547);
        Video video2 = new Video("Intermediate C# programming", "Code Ninja", 461);
        Video video3 = new Video("HTML5 & CSS3 A to Z", "Web Weaver", 832);
        Video video4 = new Video("Flutter for Pros", "Missy Web Apps", 559);
        
        //Adding comments to video1
        video1.AddComment("Lewis Mac", "Amazing tutorial!");
        video1.AddComment("Agent Smith", "Brilliant & helpful explanations!");
        video1.AddComment("Neo Morpheus", "Please make a tutorial on adding a GUI to my python app.");
        
        //Adding comments to video2
        video2.AddComment("Emily Tyson", "WOW! You make C# look so weasy.");
        video2.AddComment("Mike Wilson", "Very clear explanations and a lot of examples to make the concepts more understandable.");
        video2.AddComment("Sarah Connor", "Would like part 2 of this video. This was quite interesting");
        
        //Adding comments to video3
        video3.AddComment("David Lee", "Very good real world use cases.");
        video3.AddComment("Karen Chan", "Explain more in detail and include more examples.");
        video3.AddComment("Tom Ford", "Please make future videos longer.");
        
        //Adding comments to video4
        video4.AddComment("Chris Seegal", "Great examples!");
        video4.AddComment("Jessica Stallon", "I can't see Flutter for beginners on your channel, please make one or share link of where we can see it.");
        video4.AddComment("Alex Rush", "Perfect! Nothing to add or remove i've learnt a lot!");
        video4.AddComment("Olivia Twist", "Why do we have to pay for the subscription? Great tutorials though.");
        
        //Creating video list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        
        //Displaying all video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}