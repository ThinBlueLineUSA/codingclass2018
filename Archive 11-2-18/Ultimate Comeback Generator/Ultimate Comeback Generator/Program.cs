using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ultimate_Comeback_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            char Again = 'y';
            do
            {
                Console.WriteLine("\nWelcome to the Ultimate Comeback generator!");
                Console.WriteLine("Input absolutely any insult and I'll give you a rock solid comeback\n");
                Console.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nWorking...");
                    Thread.Sleep(1400);
                }
                Console.WriteLine("\nHere comes your iron-clad comeback:");
                Thread.Sleep(3000);
                Console.WriteLine("\nNo u");
                Thread.Sleep(1000);
                Console.WriteLine("\nRun the generator again? (y/n)\n");
                Again = Convert.ToChar(Console.ReadLine());
            } while (Again == 'y');
        }
    }
}
