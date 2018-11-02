using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i == 1)
            {
                string original, reverse = "";
                int Length;
                Console.Write("Enter A Statement : ");
                original = Console.ReadLine();
                Length = original.Length - 1;
                while (Length >= 0)
                {
                    reverse = reverse + original[Length];
                    Length--;
                }
                Console.WriteLine("Reverse Is {0}", reverse);
                Console.ReadLine();
            }
        }
    }
}
