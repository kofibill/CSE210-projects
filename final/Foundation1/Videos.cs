using System;

public class Videos
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comments> _comments = new List<Comments>();

    public Videos(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public void Comments(Comments comments)
    {
        _comments.Add(comments);
    }

    public int NumberOfComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title:{_title} <> Author: {_author} <> Length: {_seconds} seconds");
        Console.WriteLine();
        int commentCount = NumberOfComments();
        Console.WriteLine($"Number of comments: {commentCount}");

        foreach (Comments comment in _comments)
        {
            comment.DisplayInfo();
        }    
    }
}