using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < intarray.Length; i++)
            {
                intarray[i] = rand.Next(0, 9);
            }
            int n = intarray.Length;
            for (int i = 0; i < intarray.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (intarray[i] < intarray[min])
                        min = j;
                }
                if (min != i)
                {
                    int temp = intarray[i];
                    intarray[i] = intarray[min];
                    intarray[min] = temp;
                }
            }
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.WriteLine(intarray[i]);
            }
            Console.ReadLine();
        }
    }
}
