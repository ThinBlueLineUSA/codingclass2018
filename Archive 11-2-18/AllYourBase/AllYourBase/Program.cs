﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllYourBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] messages = new string[] { "How are you gentlemen !!", "All your base are belong to us.", "You are on the way to destruction." };

            for (int i = 0; i < messages.Length; i++)
            {
                for (int j = 0; j < messages[i].Length; j++)
                {
                    Console.Write(messages[i][j]);
                    Thread.Sleep(50);
                }
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }
}
