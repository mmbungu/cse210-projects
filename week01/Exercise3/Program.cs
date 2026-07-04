using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1, 11);
        int inputNumber;
        int guessCount = 0;

        while(true)
        {
            Console.Write("What's your magic number: ");
            inputNumber = int.Parse(Console.ReadLine());
            guessCount++;

            if (inputNumber > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (inputNumber < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You found it ! the magic number was {magicNumber} and you found it after {guessCount} times");
                
                Console.Write("Would you play again (yes/no) ? ");
                string retry = Console.ReadLine();

                if (retry == "no")
                {
                    break;
                }

                magicNumber = randomGenerator.Next(1, 11);
                guessCount = 0;
            }
        }
    }
}