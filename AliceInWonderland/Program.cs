using System;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to search for.");
            string userInput = Console.ReadLine();
            userInput.ToLower();
            bool foundWord = WordFinder.Search(userInput);
            Console.WriteLine(foundWord);
        }
    }
}
