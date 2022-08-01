using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class Film : Files
    {
        public string Director { get; set; }
        public string MainActor { get; set; }

        public string MainActress { get; set; }

        public Film (string name, string code, string category, int size, string director, string mainActor, string mainActress) : base(name, code, category, size)
        {
            Director = director;
            MainActor  = mainActor;
            MainActress = mainActress;
        }

        public void Play(params Film[] films)
        {
            for (int i = 0; i < films.Length; i++)
            {
                Console.WriteLine(films[i] + " is playing.");
            }
        }

        public void Play()
        {
            Console.WriteLine(Name + " is playing.");
        }
        public void RetrieveInformation()
        {
            Console.WriteLine($"Info: {Name}, code is {Code}, category is {Category}, size is {Size} gb, director is {Director}, main actor is {MainActor}, main actress is {MainActress}");
        }
    }
}
