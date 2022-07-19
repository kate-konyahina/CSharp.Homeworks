using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class Person
    {
        private string name;
        public House house { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"My name is {name}");
            Console.WriteLine("Data of house:");
            house.ShowData();
            Console.WriteLine("Data of door:");
            house.GetDoor().ShowData();
        }
    }
}
