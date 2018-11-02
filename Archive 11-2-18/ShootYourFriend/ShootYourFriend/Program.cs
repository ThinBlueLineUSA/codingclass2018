using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootYourFriend
{
    class Program
    {
        static void Main(string[] args)
        {
            char Again = 'y';
            Watergun p1 = new Watergun();
            Watergun p2 = new Watergun();

            do
            {
                do
                {
                    Input(p1);
                    Input(p2);
                } while (p1.isWet == false && p2.isWet == false);
                Console.Write("\nWould you like to play again? (y/n): ");
                Again = Convert.ToChar(Console.ReadLine());
            } while (Again != 'n');
        }
        static void Input(Watergun pnum)
        {

            Console.WriteLine("Player " + pnum + ", select your action:");
            Console.WriteLine("1. Fire your water gun");
            Console.WriteLine("2. Refill your water gun");
            Console.Write("\nAction: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the percentage of your tank you want to fire");
                float amount = float.Parse(Console.ReadLine());
                pnum.Shoot(amount);
            }
            else if (choice == 2)
            {
                pnum.Refill();
            }
            
        }
    }
}
