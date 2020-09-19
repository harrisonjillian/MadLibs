using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class FairyTale
    {
        public string Noun { get; set; }

        public string Verb { get; set; }

        public string Place { get; set; }

        public string Adverb { get; set; }

        public string Name { get; set; }

        public DateTime WeddingDate { get; set; }

        public int Age { get; set; }




        public FairyTale()
        {
        }

        public FairyTale(string noun, string verb, string place, string adverb, string name, DateTime weddingDate, int age)
        {
            Noun = noun;
            Verb = verb;
            Place = place;
            Adverb = adverb;
            Name = name;
            WeddingDate = weddingDate;
            Age = age;
        }


    }

}

