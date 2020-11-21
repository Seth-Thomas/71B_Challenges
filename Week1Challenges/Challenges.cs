using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void Supercalifragilisticexpialidocius()
        {
            string name = "Supercalifragilisticexpialidocius";
            foreach (char letter in name)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not a i");
                }
            }
        }


        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Seth";
            string lastName = "Thomas";
            int age = 29;

            {
                Console.WriteLine(age + 7);
                Console.WriteLine(age - 7);
                Console.WriteLine(age * 7);
                Console.WriteLine(age / 7);
                Console.WriteLine(age % 7);
            }
        }


        [TestMethod]
        public void HoursOfSleep()
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int hours = 4;
            if (hours >= 10)
            {
                Console.WriteLine("Wow that's alot of sleep");
            }
            else if (hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be well rested");
            }
            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep");
            }
        }


        [TestMethod]
        public void Arrays()
        {
            string[] favBooksMovies = { "Remember the Titans ", "Interstellar", "Black Panther", "The Truman Show" };

        }

        [TestMethod]
        public void CreatingAListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Today;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 1, 2));
            listOfDates.Add(new DateTime(2020, 12, 25));




        }

        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine("It is a day to be good on");
                    break;
                case "Okay":
                    Console.WriteLine("Hopefully it will get better for you");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("Please enter something above");
                    break;
            }
        }


    }

}
