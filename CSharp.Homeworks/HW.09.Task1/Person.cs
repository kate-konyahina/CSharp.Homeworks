using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    internal class Person
    {
        protected string name;
        protected int age;

        internal Person(string name)
        {
            this.name = name;
        }
       public void SetAge(int n)
        {
            this.age = n;
        }

        public virtual void Greet()
        {
            Console.WriteLine(name + " : Hello!");
        }
    }
}
