using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    class Program //This is where things prompt the user
    {
        static void Main(string[] args)
        {
            Greeter heyPerson = new Greeter();

            Console.WriteLine("What is your name");

            string name = Console.ReadLine();


            heyPerson.HowdyThere(name);
            heyPerson.Farewell(name);
            heyPerson.TimeofDay(name);


            Console.ReadLine();


        }
    }
}
