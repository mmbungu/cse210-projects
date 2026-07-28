using System;

public class WritingAssignement : Assignement
{
    private string _title;

    public WritingAssignement(string studentName, string topic, string title): base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }
}