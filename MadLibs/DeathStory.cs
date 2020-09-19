using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class DeathStory
    {
        public string Noun { get; set; }

        public string Verb { get; set; }

        public string Place { get; set; }

        public string Adverb { get; set; }

        public string Weapon { get; set; }

        public string Person { get; set; }

        public DateTime MurderTime { get; set; }

        public bool Alive { get; set; }

        public int Age { get; set; }




        public DeathStory()
        {
        }

        public DeathStory(string noun, string verb, string place, string adverb, string weapon, string person, DateTime murderTime, bool alive, int age)
        {
            Noun = noun;
            Verb = verb;
            Place = place;
            Adverb = adverb;
            Weapon = weapon;
            Person = person;
            MurderTime = murderTime;
            Alive = alive;
            Age = age;
        }


    }


}
