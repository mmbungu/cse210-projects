using System;

class Program
{
    static void Main(string[] args)
    {
        Program.DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int SquaredNumber = Program.SquareNumber(number);

        Program.DisplayResult(name, SquaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int SquaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {SquaredNumber}");
    }
}