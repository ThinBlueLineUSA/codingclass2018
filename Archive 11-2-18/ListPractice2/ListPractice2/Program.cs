using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> IntList = new List<int>();
            int num;
            int i = 0;
            while (i < 16)
            {
                num = int.Parse(Console.ReadLine());
                IntList.Add(num);
                Console.WriteLine(num);
                i++;
            }
        }
    }
}
