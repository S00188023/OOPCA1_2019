using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCA1_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> titles = new List<Song>();
            //List<Song> artist = new List<Song>();
            //List<Song> duration = new List<Song>();
            //List<Song> genre = new List<Song>();

            Song MasterOfPuppets = new Song("Master of Puppets");
            Song LoseYourself = new Song("Lose Yourself");
            Song Hello = new Song("Hello");
            Song PartyRockAnthem = new Song("Party Rock Anthem");
            Song HighwayToHell = new Song("Highway to Hell");

            titles.Add(MasterOfPuppets);
            titles.Add(LoseYourself);
            titles.Add(Hello);
            titles.Add(PartyRockAnthem);
            titles.Add(HighwayToHell);

            

            titles.Sort();
            titles.Reverse();

            PlayList(titles);


            static void PlayList(List<Song> titles)
            {
                Console.WriteLine("\n{0,-15}{1,-7}{3,-7}{4,-7}{5,-7}", "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

                foreach (Song Title in titles)
                {
                    Console.WriteLine(titles.
                }
            }
        }
    }
}
