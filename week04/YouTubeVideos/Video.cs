using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine("-----------------------------\n");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Comments: {_comments.Count}");
        Console.WriteLine("----------Comments----------\n");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}