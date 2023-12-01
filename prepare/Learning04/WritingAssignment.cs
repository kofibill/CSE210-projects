using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) :base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_studentName} {_topic} {_title} by {_studentName}";
    }

}