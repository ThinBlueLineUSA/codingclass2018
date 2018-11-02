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
                    g(3, 3);
                }
                else if (input == 2)
                {
                    g(6, 6);
                }
                else if (input == 3)
                {
                    g(3, 6);
                }
            } while (input != 4);
        }
        static void g(int down, int over)
        {
            for (int i = 0; i < down; i++)
            {
                for (int j = 0; j < over; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}
