using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class House
    {
        public int Area { get; set; }
        public Door door;

        public House(int area = 200)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }

        public Door GetDoor()
        {
            return door;
        }

        public class Door
        {
            public string Color { get; set; }

            public Door(string color = "brown")
            {
                Color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"I am a door, my color is {Color}");
            }
        }
    }
}
