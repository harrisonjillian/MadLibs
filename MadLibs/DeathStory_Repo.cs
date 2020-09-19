using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{

    public class DeathStory_Repo
    {
 
        public string CreateDeathStory(DeathStory word)
        {

            string story = $" On {word.MurderTime}, a {word.Adverb} evening, I was leaving from \n" +
                $"the {word.Place}. {word.Person} ran out in front of me and I {word.Verb} \n" +
                $"him with a {word.Weapon}. Did they live? {word.Alive}. I was {word.Age} when this happened. " +
                $"Shh, please don't tell anyone."; 

            return story;

        }

      


    }
}
