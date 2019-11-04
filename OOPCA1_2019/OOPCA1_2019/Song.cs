using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCA1_2019
{
    public enum Genre{ Rock, Pop, Dance, Other }

    class Song
    {
        string title, artist;
        double duration;
        Genre genre;

        
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre Genre { get; set; }

        public Song(string title/*, string artist, double duration, Genre genre*/)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        public void AddGenre(Genre genre)
        {

        }


        public override string ToString()
        {
            return string.Format($"{Title} - {Artist} - {Duration} - {Genre}");
        }


        

        
    }
}
