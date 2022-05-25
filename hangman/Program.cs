// OUTLINE:
// make hangman:
//  game setup
//      load words into vector of vectors? (list of list)
//      word length
//      how many guesses
//      debugging mode
//      load words based on word length for game
//  playing the game
//      player guess
//          input validation? word length, validity
//          two forms: letter and word
//      decrement guess when needed
//      win message/lose messages
//      play again
//  evil hangman
//      create keys based on user guess and word
//      put words into vectors based on matching keys
//      chose vector with largest amount of keys
//      use that vector as new words available to be guessed



using System;

namespace Game
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool playAgain = false;
            Hangman hangman = new Hangman("../dictionary.txt");
            Console.WriteLine("Welcome to Hangman!");

            // main game loop
            do {
                bool accepted = false; // for input validation
                do
                {
                    Console.WriteLine("Please input the length of words you would like to guess from [0 - 29]: ");
                    var input = Console.ReadLine();
                    int len;
                    if (int.TryParse(input, out len))
                    {
                        if (len >= 0 && len <= 29)
                        {
                            if (hangman.Words[len].Count == 0)
                            {
                                Console.WriteLine("Sorry, there are no words of this length.");
                            }
                            else
                            {
                                hangman._wordLength = len;
                                accepted = true;
                            }
                        }
                    }
                } while (!accepted);


                List<string> test = hangman.Words[hangman._wordLength];
                foreach(string word in test)
                {
                    Console.WriteLine(word);
                }
            } while (playAgain);
        }
    }
}
