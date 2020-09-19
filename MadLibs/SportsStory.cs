using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class SportsStory
    {
        public string Noun { get; set; }

        public string Verb { get; set; }

        public string Place { get; set; }

        public string Adverb { get; set; }

        public string Sport { get; set; }

        public string Person { get; set; }

        public bool Win { get; set; }

        public int Points { get; set; }




        public SportsStory()
        {
        }

        public SportsStory(string noun, string verb, string place, string adverb, string sport, string person, bool win, int points)
        {
            Noun = noun;
            Verb = verb;
            Place = place;
            Adverb = adverb;
            Sport = sport;
            Person = person;
            Win = win;
            Points = points;
        }


    }

}

