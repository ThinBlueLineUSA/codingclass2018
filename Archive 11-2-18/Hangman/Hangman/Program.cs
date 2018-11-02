using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Get ready to play some Hangman, you egg");
            Console.WriteLine("Here's what's gonna happen");
            Console.WriteLine("I'm going to think of a random word with 2 - 10 letters");
            Console.WriteLine("You can guess the letters and then try to guess the word");
            Console.WriteLine("You are allowed only 6 incorrect guesses");
            Console.WriteLine("If at any time you would like to guess the word instead of a letter, type in \"guess\"");
            Console.WriteLine("If you can guess the word before reaching the incorrect guess limit, you win");
            Console.WriteLine("If not, well, that sucks");
            Console.WriteLine("\nWell, here we go");
            string[] words = new string[20] { "jump", "view", "crack", "bashful", "battle", "head", "boiling", "heat", "memory", "known", "sweet", "loving", "boorish", "meeting", "expansion", "board", "foregoing", "steam", "internal", "panicky" };
            char Again = 'y';
            do
            {
                int guesses = 6;
                char guess;
                string wordguess;
                int whichword = rand.Next(0, 20);
                string thisword = words[whichword];
                for (int i = 0; i < thisword.Length; i++)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine("\n");

                do
                {
                    guess = Convert.ToChar(Console.ReadLine());
                    for (int i = 0; i < thisword.Length; i++)
                    {
                        if(thisword[i] == guess)
                        {
                            Console.Write(guess + " ");
                        }
                        else
                        {
                            Console.Write("_ ");
                        }


                    }
                    
                    
                } while (guesses > 0);
                Console.WriteLine("\nSorry, you didn't get it");

                Console.WriteLine("\nWould you like to play again? (y/n)\n");
                Again = Convert.ToChar(Console.ReadLine());
            } while (Again == 'y');
        }
    }
}
