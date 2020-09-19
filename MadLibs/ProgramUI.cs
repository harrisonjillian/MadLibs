using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class ProgramUI
    {

        public void Run() 
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome to MADLIBS, Select a Story: \n" +
                    "1. Death Story \n" +
                    "2. Fairy Tale Story \n" +
                    "3. Sports Story \n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PlayTheDeathStory();
                        break;

                    case "2":
                        PlayTheFairyTale();
                        break;

                    case "3":
                        PlayTheSportsStory();
                        break;

                    case "4":
                        Console.WriteLine("Bye!");
                        keepRunning = false;
                        break;

                    default:
                        break;


                }
                Console.WriteLine("Press any key to continue");

                Console.ReadKey();


                Console.Clear();

            }
        }
        private void PlayTheDeathStory()
        {
            DeathStory newDeathStory = new DeathStory();
            DeathStory_Repo newDeathRepo = new DeathStory_Repo();

            Console.WriteLine("Please enter an adverb: (example: quickly, softly, well)");
            newDeathStory.Adverb = Console.ReadLine();

            Console.WriteLine("Please enter a MurderTime: example: (1/28/2015) (m/d/year)");
            string dateAsString = Console.ReadLine();
            newDeathStory.MurderTime = DateTime.Parse(dateAsString);

            Console.WriteLine("Please enter a noun");
            newDeathStory.Noun = Console.ReadLine();

            Console.WriteLine("Please enter a person");
            newDeathStory.Person = Console.ReadLine();

            Console.WriteLine("Please enter a place");
            newDeathStory.Place = Console.ReadLine();

            Console.WriteLine("Please enter a verb");
            newDeathStory.Verb = Console.ReadLine();

            Console.WriteLine("Please enter a weapon");
            newDeathStory.Weapon = Console.ReadLine();

            Console.WriteLine("Please enter an age");
            string ageAsString = Console.ReadLine();
            newDeathStory.Age = int.Parse(ageAsString);

            Console.WriteLine("Are they alive? (y/n)");
            string aliveString = Console.ReadLine().ToLower();

            if(aliveString == "y")
            {
                newDeathStory.Alive = true;

            }
            else
            {
                newDeathStory.Alive = false;

            }

            Console.WriteLine(newDeathRepo.CreateDeathStory(newDeathStory));
     

        }

        private void PlayTheFairyTale()
        {
            FairyTale newFairyTale = new FairyTale();
            FairyTale_Repo newFairyRepo = new FairyTale_Repo();



            Console.WriteLine("Please enter an adverb (example: quickly, softly, well)");
            newFairyTale.Adverb = Console.ReadLine();

            Console.WriteLine("Please enter an age");
            string ageAsString = Console.ReadLine();
            newFairyTale.Age = int.Parse(ageAsString);

            Console.WriteLine("Please enter a name");
            newFairyTale.Name = Console.ReadLine();

            Console.WriteLine("Please enter a noun");
            newFairyTale.Noun = Console.ReadLine();

            Console.WriteLine("Please enter a place");
            newFairyTale.Place = Console.ReadLine();

            Console.WriteLine("Please enter a verb");
            newFairyTale.Verb = Console.ReadLine();

            Console.WriteLine("Please enter wedding date example: (1/28/2015) (m/d/year)");
            string dateAsString = Console.ReadLine();
            newFairyTale.WeddingDate = DateTime.Parse(dateAsString);

            Console.WriteLine(newFairyRepo.CreateFairyTale(newFairyTale));

        }

        private void PlayTheSportsStory()
        {
           SportsStory newSportsStory = new SportsStory();

            SportsStory_Repo newSRepo = new SportsStory_Repo();

            Console.WriteLine("Please enter a sport:");
            newSportsStory.Sport = Console.ReadLine();


            Console.WriteLine("Please enter an adverb (example: quickly, softly, well)");
            newSportsStory.Adverb = Console.ReadLine();

            Console.WriteLine("Please enter points");
            string pointAsString = Console.ReadLine();
            newSportsStory.Points = int.Parse(pointAsString);


       
            Console.WriteLine("Did they win? (y/n)");
            string winAsString = Console.ReadLine().ToLower();
            if (winAsString == "y")
            {
                newSportsStory.Win = true;
              
            }
            else
            {
                newSportsStory.Win = false;

            }

            Console.WriteLine("Please enter a name");
            newSportsStory.Person = Console.ReadLine();

            Console.WriteLine("Please enter a noun");
            newSportsStory.Noun = Console.ReadLine();

            Console.WriteLine("Please enter a place");
            newSportsStory.Place = Console.ReadLine();

            Console.WriteLine("Please enter a verb");
            newSportsStory.Verb = Console.ReadLine();



            Console.WriteLine(newSRepo.CreateSportsStory(newSportsStory));

        }

    }
}

