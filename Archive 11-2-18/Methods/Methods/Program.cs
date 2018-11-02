using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("** Enter the number of the action you want performed");
                Console.WriteLine("** 1. Create a 3x3 square");
                Console.WriteLine("** 2. Create a 6x6 square");
                Console.WriteLine("** 3. Create a 6x3 rectangle");
                Console.WriteLine("** 4. Exit Program");
                Console.WriteLine("*****************************************************************");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    a3x3();
                }
                else if (input == 2)
                {
                    a6x6();
                }
                else if (input == 3)
                {
                    a6x3();
                }
            } while (input != 4);
        }
        static void a3x3()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void a6x6()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void a6x3()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    
    }
}
