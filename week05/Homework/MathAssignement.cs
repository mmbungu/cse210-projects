using System;

public class MathAssignement : Assignement
{
    private string _textBookSection;
    private string _problems;

    public MathAssignement(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\nSection {_textBookSection} Problems {_problems}";
    }
}