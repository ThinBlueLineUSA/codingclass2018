using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Valid;
            //call for a random number
            Random rand = new Random();
            //initialize a variable for the random number
            int compnum;
            //initialize a variable for the user input
            int truinput;
            string input;
            //initialize a variable for the number of guesses the user used
            int guesses;
            //initialize a variable for the user to play again
            char Again = 'y';
            //start a do while loop for playing again or not
            do
            {
                //create a random number between 0 and 1000 for the user to guess at
                compnum = rand.Next(0, 1001);
                //prompt the user for a guess
                guesses = 0;
                Console.WriteLine("The computer has generated a random number between 0 and 1000. Try and guess what it is:");
                //start a do while loop for the guessing process
                do
                {
                    input = Console.ReadLine();
                    if (int.TryParse(input, out truinput))
                    {
                        Valid = true;
                    }
                    else
                    {
                        Valid = false;
                    }
                    //if the guess is higher than the number
                    if (Valid == true)
                    {
                        if (truinput > compnum)
                        {
                            //tell the user that their guess is too high
                            Console.WriteLine("Your guess was too high, guess again");
                        }
                        //if the guess is lower than the number
                        else if (truinput < compnum)
                        {
                            //tell the user that their guess is too low
                            Console.WriteLine("Your guess was too low, guess again");
                        }
                        //if the guess is equal to the random number
                        else if (truinput == compnum)
                        {
                            //tell the user that their guess was correct
                            Console.WriteLine("\nCongratulations, you got it!");
                        }
                    }
                    else if (Valid == false)
                    {
                        Console.WriteLine("That's not a number, you silly thing, try again");
                    }
                    //add 1 to the guess counter
                    guesses++;
                    //do while the guess is not equal to the number
                } while (truinput != compnum);
                //congratulate the user on guessing correctly and tell them how many guesses it took them
                Console.WriteLine("It took you " + guesses + " guesses to find the computer's number\n");
                //ask the user if they'd like to play again
                Console.WriteLine("Would you like to play again? (y/n): ");
                Again = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            } while (Again == 'y');
        }
    }
}
