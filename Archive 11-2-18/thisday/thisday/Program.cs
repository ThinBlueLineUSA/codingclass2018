using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisday
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = 1;
            int stuff;
            do
            {
                stuff = rand.Next();
                Console.Write(stuff);
            } while (i == 1);
        }
    }
}
