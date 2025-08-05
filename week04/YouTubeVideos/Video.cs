using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(string commenterName, string commentText)
    {
        _comments.Add(new Comment(commenterName, commentText));
    }

    public int GetNumberOfComments() => _comments.Count;

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");
        
        foreach (var comment in _comments)
        {
            Console.WriteLine($"  - {comment.GetCommentInfo()}");
        }
        Console.WriteLine(new string('-', 40));
    }
}