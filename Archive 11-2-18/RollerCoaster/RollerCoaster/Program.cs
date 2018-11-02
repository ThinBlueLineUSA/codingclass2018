using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("\n*****************************************************************************");
                Console.WriteLine("** 1. Put rider in random seat");
                Console.WriteLine("** 2. List available seats");
                Console.WriteLine("** 3. Run ride and list seats that were filled");
                Console.WriteLine("** 4. Exit amusement park");
                Console.WriteLine("*****************************************************************************");
                input = int.Parse(Console.ReadLine());
                int[] seats = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

                if (input == 1) ;
                {

                }
            } while (input != 4);
        }
    }
}
