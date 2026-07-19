// I have added the ability to read scripture from a csv file and display it in a list of scriptures and 
// then pick a random scripture from the list and display it.

using System;
using System.Collections.Generic;

class Program

{

    static void Main(string[] args)

    {

        List<Scripture> libraryScripture = new List<Scripture>();

        // Add Scripture library

        string[] lines = System.IO.File.ReadAllLines("scriptures.csv");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Count() > 4)
            {
                libraryScripture.Add(
                    new Scripture(
                        new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3])),
                        parts[4]
                    )
                );
            }
            else
            {
                libraryScripture.Add(
                    new Scripture(
                        new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2])), 
                        parts[3]
                    )
                );
            }
        }

        // Pick a random scripture from the library
        Random random = new Random();
        Scripture scripture = libraryScripture[random.Next(libraryScripture.Count)];

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayString());

        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string request = Console.ReadLine();

            if (request == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            scripture.HideRandomWords(3);
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayString());

        }

    }

}

