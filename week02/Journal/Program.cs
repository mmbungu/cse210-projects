using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Journal journal = new Journal();

        Welcome();
        while(true)
        {
            DisplayMenu();
            Console.Write("What would you like to do ? ");
            choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                WriteMenuHandling(journal);
            }
            else if (choice == 2)
            {
                DisplayMenuHandling(journal);
            }
            else if (choice == 3)
            {
                LoadMenuHandling(journal);
            }
            else if (choice == 4)
            {
                SaveToFileMenuHandling(journal);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using this app. See you later !");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, Try again !");
            }
        }
    }

    static void Welcome()
    {
        Console.WriteLine("***************************************");
        Console.WriteLine("*** Welcome to the Journal Program ***");
        Console.WriteLine("***************************************");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    static void WriteMenuHandling(Journal journal)
    {
        Entry entry = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();
        entry._prompt = promptGenerator.GetRandomPrompt();
        entry._date = DateTime.Now.ToShortDateString();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();

        journal.AddEntry(entry);
    }

    static void DisplayMenuHandling(Journal journal)
    {
        foreach (Entry entry in journal._entries)
        {
            entry.Display();
        }
    }

    static void LoadMenuHandling(Journal journal)
    {
        Console.WriteLine("What's the filename ?");
        string filename = Console.ReadLine();

        journal.load(filename);
    }

    static void SaveToFileMenuHandling(Journal journal)
    {
        Console.WriteLine("What's the filename ?");
        string filename = Console.ReadLine();

        journal.saveToFile(filename);
    }

}