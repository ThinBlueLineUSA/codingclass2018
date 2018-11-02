using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = 8675309;
            Random rand = new Random(seed);

            int[] intarray = new int[10];

            for (int i = 0; i < intarray.Length; i++)
            {
                intarray[i] = rand.Next(0, 9);
            }

            for (int i = 0; i < intarray.Length; i++)
            {
                for (int i2 = 0; i2 < intarray.Length; i2++)
                { 
                    if (intarray[i] > intarray[i2])
                    {
                        int temp = intarray[i2];
                        intarray[i2] = intarray[i];
                        intarray[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            foreach (int item in intarray)
            {
                Console.Write(intarray[item] + ", ");
            }
            Console.ReadLine();
        }
    }
}
