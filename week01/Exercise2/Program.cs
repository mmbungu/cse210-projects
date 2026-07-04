using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your pourcentage ? ");
        int percentage = int.Parse(Console.ReadLine());
        string grade;

        Console.WriteLine($"Your percentage is {percentage}%");

        if(percentage >= 90)
        {

           grade = "A";
           if (percentage < 93)
           {
                grade += "-";
           }
        }
        else if (percentage >= 80)
        {
            grade = "B";
            if (percentage < 83)
            {
                grade += "-";
            }
            else if (percentage >= 87)
            {
                grade += "+";
            }
        }
        else if (percentage >= 70)
        {
            grade = "C";
            if (percentage < 73)
            {
                grade += "-";
            }
            else if (percentage >= 77)
            {
                grade += "+";
            }
        }
        else if (percentage >= 60)
        {
            grade = "D";
            if (percentage < 63)
            {
                grade += "-";
            }
            else if (percentage >= 67)
            {
                grade += "+";
            }
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
        }
    }
}