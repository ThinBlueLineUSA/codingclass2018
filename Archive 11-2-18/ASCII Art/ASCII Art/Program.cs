using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClassLibrary1
{
    public static void Main(string[] args)
    {
        int input = 0;
        do
        {
            Console.WriteLine("\n***********************************************************************************************");
            Console.WriteLine("** Welcome to the Shape Generator! Please select from the list below the shape you want to see ");
            Console.WriteLine("** 1. 1x1 Square");
            Console.WriteLine("** 2. 3x3 Square");
            Console.WriteLine("** 3. 5x5 Square");
            Console.WriteLine("** 4. Right Triangle");
            Console.WriteLine("** 5. Flipped Right Triangle");
            Console.WriteLine("** 6. Small Pyramid - currently under construction");
            Console.WriteLine("** 7. Negative Line");
            Console.WriteLine("** 8. Flipped Negative Line");
            Console.WriteLine("** 9. Negative X");
            Console.WriteLine("** 0. Exit Program");
            Console.WriteLine("************************************************************************************************");

            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }

            else if (input == 2)
            {
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }

            else if (input == 3)
            {
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }

            else if (input == 4)
            {
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == i || j == i - 1 || j == i - 2 || j == i - 3 || j == i - 4)
                            Console.Write("X");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            else if (input == 5)
            {
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (4 - j == i || 5 - j == i || 6 - j == i || 7 - j == i || 8 - j == i)
                            Console.Write("X");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            else if (input == 6)
            {
                Console.WriteLine();
                    Console.WriteLine();
                
            }

            else if (input == 7)
            {
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == i)
                            Console.Write(" ");
                        else
                            Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }

            else if (input == 8)
            {
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (4 - j == i)
                            Console.Write(" ");
                        else
                            Console.Write("X");
                    }
                    Console.WriteLine();
                }

            }

            else if (input == 9)
            {
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == i || 4 - j == i)
                            Console.Write(" ");
                        else
                            Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }

        } while (input != 0);
        }
}
