using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignement writingAssignment = new WritingAssignement("John", "Writing", "The Importance of Communication");
        MathAssignement mathAssignment = new MathAssignement("Mary", "Math", "7.3", "8-15");

        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}