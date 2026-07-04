using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();

        while(true)
        {
            Console.Write("Enter number: ");
            float number = float.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        Console.WriteLine($"The sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Sum() / numbers.Count}");

        float largest = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is {largest}");

        
    }
}