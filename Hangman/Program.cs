using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Creating a List
        List<string> wordsList = new List<string>() { "SERENDIPITY", "ANACHRONISM", "WINKLEPICKER", "SCRUMPTIOUS", "VERISIMILITUDE" };

        // Random index number generator
        Random rand = new Random();
        int randomIndex = rand.Next(wordsList.Count);
        string randomWord = wordsList[randomIndex];

        // Key declaration
        ConsoleKey letter;

        // Guessed letters list
        List<string> guessedLetters = new List<string>();

        // User chances
        int userChances = randomWord.Length;

        // Introduction text and getting user input
        Console.WriteLine($"Let's play the hangman game! You have {randomWord.Length} chances to win");
        Console.WriteLine("Write a letter or press Enter to exit:");

        // Displaying game at the beginning
        for(int i=0; i<randomWord.Length; i++)
        {
            Console.Write("_" + " ");
        }

        Console.WriteLine();

        do
        {
            letter = Console.ReadKey().Key;
            Console.Clear();
            guessedLetters.Add(letter.ToString());

            // Counter tracker
            int correctLetterCounter = 0;

            if (letter == ConsoleKey.Enter)
            {
                Console.WriteLine("Thanks for playing!");
                break;
            };

            // Evaluating if letters list contain every random word letter.
            for (int i=0; i<randomWord.Length; i++)
            {

                if (guessedLetters.Contains(randomWord[i].ToString()))
                {
                    Console.Write(randomWord[i] + " ");
                    correctLetterCounter++;
                }
                
                else
                {
                    Console.Write("_" + " ");
                }
                
                // End of program if all letters are guessed.
                if (correctLetterCounter == randomWord.Length)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations, you guessed the word! Thanks for playing!");
                    return;
                }
            }

            // Displaying user chances tracker.
            Console.WriteLine();
            if (!randomWord.Contains(letter.ToString()))
            {
                Console.WriteLine("Wrong guess!");
                userChances--;
                Console.WriteLine($"You have {userChances} chances left");
            }
            
            // End of program if user runs out of guesses.
            if (userChances <= 0)
            {
                Console.WriteLine("You loose! Thanks for playing!");
                Console.WriteLine($"The word is: {randomWord}");
                break;
            }
            Console.WriteLine();
        }
        while (true);
    }
}
