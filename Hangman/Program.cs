﻿using System;
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

        // Guessed letters list
        List<string> guessedLetters = new List<string>();

        do
        {
            letter = Console.ReadKey().Key;
            Console.WriteLine();
            guessedLetters.Add(letter.ToString());

            // Counter tracker
            int counter = 0;

            if (letter == ConsoleKey.Enter) break;

            for (int i=0; i<randomWord.Length; i++)
            {

                if (guessedLetters.Contains(randomWord[i].ToString()))
                {
                    Console.Write(randomWord[i] + " ");
                    counter++;
                }
                if (!guessedLetters.Contains(randomWord[i].ToString()))
                {
                    Console.Write("_" + " ");
                }
                if (counter == randomWord.Length)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations, you guessed the word!");
                    return;
                }
            }
            Console.WriteLine();
        }
        while (true);
    }
}
