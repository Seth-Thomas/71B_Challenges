using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Week4Challenges
{
    [TestClass]
    public class Week4Tests
    {
        [TestMethod]
        public void SportsExamples()
        {
            //var sport = new Sport();
            //sport.Baseball = "Carlos Zambrano";
            //sport.ToString();

            var athlete = new Athlete(true, "July 8th, 1991","baseball", "basketball", "football");
            athlete.Basketball = "James Harden";
            athlete.IsProfessional = true;
            athlete.DraftDate = "June 25th, 2009";

            var team = new Team();
            team.City = "Houston";
            team.Colors = "Red and white";

            var retiredAthlete = new RetiredAthlete();
            retiredAthlete.Football = "Tony Romo";
            retiredAthlete.CareerEarnings = "$127 Million";
            retiredAthlete.DraftDate = "April 26th, 2003";

            var multisportathlete = new MultiSportAthlete();

            List<Sport> competitor = new List<Sport>();
            competitor.Add(retiredAthlete);
            competitor.Add(multisportathlete);
            competitor.Add(team);
            
            





        }
    }
}

    
