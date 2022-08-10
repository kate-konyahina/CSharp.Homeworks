
using HW._13.Song;
using Newtonsoft.Json;


Song song1 = new Song("Build a Bridge", 156, "Limp Bizkit", 1998, 1);

song1.GetGenreInfo();

Song song2 = new Song("Hello", 198, "Adel", 2012);

object songjs2 = song2.GetSongData();

 var result = JsonConvert.SerializeObject(songjs2, Formatting.Indented);
    Console.WriteLine(result);


