using System;
using System.Collections.Generic;
using Hangman;

class Program
{
    static void Main(string[] args)
    {
        List<string> wordsList = new List<string>() { "House", "Phone", "Water", "Food", "Banana" };
        Console.WriteLine(HangmanListMethods.getRandomWord(wordsList));
    }
}
