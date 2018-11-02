using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twodarray = new int[5, 5];
            for (int i = 0; i < twodarray.GetLength(0); i++)
            {
                for (int j = 0; j < twodarray.GetLength(1); j++)
                {
                    twodarray[i, j] = i * j;
                }
            }

            Print2DArray(twodarray);
            Console.ReadKey();

            /*t[][] jagarray = new int[20][];
            for (int i = 0; i < jagarray.GetLength(0); i++)
            {
                jagarray[i] = new int[i + 1];
                for (int j = 0; j< jagarray[i].Length; j++)
                {
                    jagarray[i][j] = i * j;
                }
            }
            PrintJaggedArray(jagarray);
            Console.ReadKey();*/
        }

        static void Print2DArray(int[,] twodarray)
        {
            for (int i = 0; i < twodarray.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < twodarray.GetLength(1); j++)
                {
                    
                        Console.Write(twodarray[i, j]);
                        if (twodarray[i, j] < 10)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        static void PrintJaggedArray(int[][] jagarray)
        {
            for (int i = 0; i < jagarray.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(jagarray[i][j]);
                    if (jagarray[i][j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" | ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
