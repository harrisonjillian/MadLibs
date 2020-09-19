using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class FairyTale_Repo
    {

        public string CreateFairyTale(FairyTale word)
        {
            return $" Once upon a time in {word.Place}, there was a Princess named {word.Name}. \n" +
               $"She lived in a beautiful {word.Noun} but was very lonely.  One day \n"+
               $" a {word.Verb} visitor came to the castle.  It was none other than the {word.Verb} \n" +
               $"Prince named {word.Name} who lived in a different kingdom. They fell in love {word.Adverb} and \n" +
               $"got married on {word.WeddingDate}. She was only {word.Age} years old.";
        }
         
    }




}



