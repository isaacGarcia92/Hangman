using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class HangmanListMethods
    {
        public static string getRandomWord(List<string> list)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, list.Count);

            return list[randomIndex];
        }
    }
}
