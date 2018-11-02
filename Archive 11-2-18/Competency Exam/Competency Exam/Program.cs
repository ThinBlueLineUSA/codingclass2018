using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competency_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {

                Console.WriteLine("\n*************************************************************************************");
                Console.WriteLine("** Enter the number of the action you want the program to perform");
                Console.WriteLine("** 1. Use Conditionals");
                Console.WriteLine("** 2. Use For Loops");
                Console.WriteLine("** 3. Use While loops");
                Console.WriteLine("** 4. Use Arrays");
                Console.WriteLine("** 5. Use Lists");
                Console.WriteLine("** -1. Exit Program");
                Console.WriteLine("*************************************************************************************\n");
                choice = int.Parse(Console.ReadLine());
                
                if (choice == 1)
                {
                    Console.Write("\nEnter your grade level as a number: ");
                    int gradelvl = int.Parse(Console.ReadLine());

                    Console.Write("\nEnter the grade level at which you read: ");
                    int readlvl = int.Parse(Console.ReadLine());

                    if (gradelvl > 8 && gradelvl < 13)
                        Console.WriteLine("\nYou are in high school,");
                    else if (gradelvl > 5 && gradelvl < 9)
                        Console.WriteLine("\nYou are in middle school,");
                    else
                        Console.WriteLine("\nYou are in elementary school,");

                    if (readlvl >= gradelvl)
                        Console.WriteLine("and you are reading at an appropriate level");
                    else
                        Console.WriteLine("and you are not reading at an appropriate level. Go study");
                }

                else if (choice == 2)
                {
                    Console.WriteLine("\nEnter the number you want to count by: ");
                    int countBy = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nEnter the number you want to count up to: ");
                    int countTo = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    for (int i = 0; i <= countTo; i += countBy)
                        Console.WriteLine(i);
                }

                else if (choice == 3)
                {
                    int input = 1;
                    int sum = 0;
                    Console.WriteLine("Enter a number you'd like to add to the sum,");
                    Console.WriteLine("enter 0 to end the loop");
                    while (input != 0)
                    {
                        Console.Write("Enter a value: ");
                        input = int.Parse(Console.ReadLine());
                        sum = sum += input;
                        Console.WriteLine("Current sum = " + sum);

                    }Console.WriteLine("\nYour final sum is " + sum + "\n");
                }
                else if (choice == 4)
                {
                    int[] intarray = new int[10];
                    for (int i = 0; i < intarray.Length; i++)
                    {
                        Console.WriteLine("An array with 10 slots has been created, enter numbers to populate the array");
                        intarray[i] = int.Parse(Console.ReadLine());
                        int valueof = intarray[i];
                        Console.WriteLine(valueof + " has been added");
                    }
                    Console.WriteLine("The array has been filled, here are the numbers:");
                    for(int i = 0; i < intarray.Length; i++)
                    {
                        Console.WriteLine("Spot " + intarray[i] + " = ");
                    }
                }

            } while (choice != -1);
        }
    }
}
