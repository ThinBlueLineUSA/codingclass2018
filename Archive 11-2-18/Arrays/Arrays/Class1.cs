using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Class1
    {
        Random rand = new Random();
        int num;
        int[] intarray = new int[10];

        for (int i = 0; i < 5; i++)
            {
                num = rand.Next(10);
                Console.WriteLine(num);
                
            }

        
    }
}
