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

        // Getting user input
        Console.WriteLine("Write letter:");
        string userLetter = Console.ReadLine().ToUpper();

        // Testing is user input exists on random word
        if(randomWord.Contains(userLetter))
        {
            Console.WriteLine($"Letter {userLetter} was found on the random word");
        }
        else
        {
            Console.WriteLine($"Letter {userLetter} was not found on the random word");
        }
    
    }
}
