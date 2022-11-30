using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Creating a List
        List<string> wordsList = new List<string>() { "House", "Phone", "Water", "Food", "Banana" };

        // Random index number generator
        Random rand = new Random();
        int randomIndex = rand.Next(0, wordsList.Count);
    }
}
