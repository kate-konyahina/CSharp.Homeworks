using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._13.Song
{
    public sealed class Song
    {   
       public enum Genre
        {
            Rock = 0,
            Hiphop = 1,
            Pop = 2
        }

        internal static object GetSongData(object song2)
        {
            throw new NotImplementedException();
        }

        public string GenreP { get; set; }

        public string Title { get; set; }

        public int Minutes { get; set; }

        public string Author { get; set; }

        public int AlbumYear { get; set; }

        public object GetSongData()
        {
            object songjs = new { Title = Title, Minutes = Minutes, AlbumYear = AlbumYear};
            return songjs;
        }
        public void GetGenreInfo() 
        { 
            Console.WriteLine(GenreP);
        }

        public Song(string title, int minutes, string author, int albumYear)
        {
            Title = title;
            Minutes = minutes;
            Author = author;
            AlbumYear = albumYear;
        }

            public Song(string title, int minutes, string author, int albumYear, string genre)
        {
            Title = title;
            Minutes = minutes;
            Author = author;
            AlbumYear = albumYear;
            if (!Enum.IsDefined(typeof(Genre), genre)) 
            {
             
                GenreP = "not set"; 
            }
            else
            { 
                GenreP = genre.ToString();
            }
        }

        public Song(string title, int minutes, string author, int albumYear, int genre)
        {
            Title = title;
            Minutes = minutes;
            Author = author;
            AlbumYear = albumYear;
            if (!Enum.IsDefined(typeof(Genre), genre))
            {

                GenreP = "not set";
            }
            else
            {
                Enum.TryParse(genre.ToString(), out Genre value);
                GenreP = value.ToString();
            }
        }

    }
}
