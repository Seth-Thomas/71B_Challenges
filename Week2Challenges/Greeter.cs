using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    class Greeter
    {
        public void HowdyThere(string name)
        {
            Console.WriteLine("Hello there, " + name);
        }

        public void Farewell(string name)
        {
            Console.WriteLine("Farewell, " + name);
        }

        public void TimeofDay(string name)
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good morning, " + name);
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good afternoon, " + name);
            }
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 20)
            {
                Console.WriteLine("Good evening, " + name);
            }
            else
            {
                Console.WriteLine("Goodnight, " + name);
            }
        }

    }
}


