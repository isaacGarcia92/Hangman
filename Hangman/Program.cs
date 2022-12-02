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
        int randomIndex = rand.Next(wordsList.Count);
        string randomWord = wordsList[randomIndex];

        // Key declaration
        ConsoleKey letter;

        // Getting user input
        Console.WriteLine("Write letter or press Enter to exit:");

        do
        {
            letter = Console.ReadKey().Key;
            Console.WriteLine();

            if (letter == ConsoleKey.Enter) break;

            for (int i=0; i<randomWord.Length; i++)
            {
                string trackedWord = "";

                if (randomWord[i] == (char)letter)
                {
                    trackedWord += randomWord[i];
                }
                else
                {
                    trackedWord += "_";
                }

                Console.Write(trackedWord + " ");
            }
            Console.WriteLine();
        }
        while (true);
    }
}
