using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX2D.Cars;

namespace EX2D.Cars
{
    public abstract class Car
    {
        public int speed = 0;
        public virtual int maxspeed { get; } = 0;

        public void Accelerate(int increment)
        {
            while (speed < maxspeed)
            {
                speed += increment;
                if (speed > maxspeed)
                {
                    speed = maxspeed;
                }

                Console.WriteLine("Current speed: {0}", speed);
                Thread.Sleep(2000);
            }

            Console.WriteLine("Max speed reached: {0}", speed);
        }
    }
}
