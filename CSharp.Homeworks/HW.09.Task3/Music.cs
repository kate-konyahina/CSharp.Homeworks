using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    public class Music : Files
    {
        public string Singer { get; set; }
        public int Length { get; set; }

        public Music(string name, string code, string category, int size, string singer, int length) : base(name, code, category, size)
        {
            Singer = singer;
            Length = length;
        }

        public void Play (params Music[] songs)
        {
        for (int i = 0; i < songs.Length; i++)
        {
            Console.WriteLine(songs[i] + " is playing.");
        }
        }

        public void Play()
        {
            Console.WriteLine(Name + " is playing.");
        }
        public void RetrieveInformation()
        {
            Console.WriteLine($"Info: {Name}, code is {Code}, category is {Category}, size is {Size} mb, singer is {Singer}, the length is {Length} seconds");
        }
    }
}
