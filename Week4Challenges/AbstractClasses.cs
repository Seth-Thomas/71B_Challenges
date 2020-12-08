using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenges
{
    abstract class Sport
    {
        public string Baseball { get; set; }
        public string Football { get; set; }
        public string Basketball { get; set; }

        public Sport() { }
        public Sport(string baseball, string football, string basketball)
        {
            Baseball = baseball;
            Football = football;
            Baseball = basketball;
        }

    }

     class Athlete : Sport // DateTime was used instead but didn't work. Is there a way to make that work?
    {
        public bool IsProfessional { get; set; }
        public string DraftDate { get; set; }

        public Athlete() { }
        public Athlete(bool isProfessional, string draftDate, string baseball, string football, string basketball)
            : base(baseball, football, basketball)

        {
            IsProfessional = isProfessional;
            DraftDate = draftDate;

        }
    }
     class Team : Sport
    {
        public string Colors { get; set; }
        public string City { get; set; }
    }
    class RetiredAthlete : Athlete
    {
        public string CareerEarnings { get; set; } // Find out how to make this Int32
        public int YearsPlayed { get; set; }

    }
    class MultiSportAthlete : Athlete
    {
        public int NumSportsPlayed { get; set; }
        public bool HallOfFamer { get; set; }
    }

}



