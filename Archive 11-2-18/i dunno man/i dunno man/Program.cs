using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_dunno_man
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Math(input, input2);

            Console.ReadKey();
        }

        static void Math(int input, int input2)
        {
            int quot = input / input2;
            int rem = input % input2;

            if (quot != 0)
            {
                Math(quot, input2);
            }
            char remchar = (char)(rem);
            Console.Write((0 + remchar));
        }

    }
}
