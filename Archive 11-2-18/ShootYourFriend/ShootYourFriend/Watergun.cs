using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootYourFriend
{
    class Watergun
    {
        public float capacity = 1;
        public bool isWet = false;
        public Random rand = new Random();

        public Watergun()
        { }

        public bool Shoot(float amount)
        {
            if (capacity > 0)
            {
                capacity -= amount;
                float percentchance = (amount * .2f) + .2f;
                if (rand.Next(0, 1) < percentchance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Refill()
        {
            capacity += .25f;
        }
    }
}
