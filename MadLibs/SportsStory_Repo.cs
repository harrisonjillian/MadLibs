using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class SportsStory_Repo
    {
        

        public string CreateSportsStory(SportsStory word)
        {
            return $" The last time I played {word.Sport}.  We {word.Verb} \n" +
                $"to {word.Place} to play. The {word.Noun} moved along {word.Adverb}. \n " +
                $"I scored {word.Points} against {word.Person}. Did I win? {word.Win}, \n " +
                $"and I never played again.";
        }
        
      
    }
}

