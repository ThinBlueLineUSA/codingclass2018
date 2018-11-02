using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickyTackyToesies
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new 2D character array of size 3, 3
            char[,] board = new char[3, 3];
            //print a description of the game Tic Tac Toe along with rules and instructions
            Console.WriteLine("Today's game is Tic-Tac-Toe. There are two players. Player one will input a coordinate location");
            Console.WriteLine("to place their X, and then player two will put in a location for their O. The first player to get");
            Console.WriteLine("3 in a row wins the game");
            char again = 'y';
            //start a do-while loop for repeating the game
            do
            {
                //initialize a bool variable for victory
                bool victory = true;
                //start another do-while loop for victory of a player while victory is false
                do
                {
                    //prompt player 1 to input their X location
                    Console.Write("\nPlayer 1, please enter the position in which you would like to place your X (x, y): ");
                    string fullpos = Console.ReadLine();
                    string xpos = fullpos.Substring(0, 1);
                    int xposint = int.Parse(xpos);
                    string ypos = fullpos.Substring(3, 1);
                    int yposint = int.Parse(ypos);
                    board[xposint, yposint] = 'X';
                    //fill the corresponding position in the array with an X
                    //print out the current board and prompt player 2 to input their Y location
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        Console.Write("| ");
                        for (int j = 0; j < board.GetLength(1); j++)
                        {

                            Console.Write(board[i, j]);
                            if (board[i, j] < 10)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(" | ");
                        }
                        Console.WriteLine();
                    }
                } while (victory == false);
                Console.Write("Would you like to play again? (y/n):");
                again = Convert.ToChar(Console.ReadLine());
            } while (again == 'y');
        }
    }
}
