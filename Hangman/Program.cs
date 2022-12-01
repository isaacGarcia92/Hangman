using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Creating a List
        List<string> wordsList = new List<string>() { "HOUSE", "PHONE", "WATER", "FOOD", "BANANA" };

        // Random index number generator
        Random rand = new Random();
        int randomIndex = rand.Next(0, wordsList.Count);
        string randomWord = wordsList[randomIndex];

        // Key declaration
        ConsoleKeyInfo letter;

        // Getting user input
        Console.WriteLine("Write letter or press Enter to exit:");

        do
        {
            letter = Console.ReadKey();
            Console.WriteLine();

            if (letter.Key == ConsoleKey.Enter) break;

            if (randomWord.Contains(letter.Key.ToString()))
            {
                Console.WriteLine($"Letter {letter.Key} was found on the random word");
            }
            else
            {
                Console.WriteLine($"Letter {letter.Key} was not found on the random word");
            }
        }
        while (true);
    }
}
