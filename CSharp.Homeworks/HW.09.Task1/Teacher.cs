﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    internal class Teacher : Person
    {
        internal Teacher (string name) : base(name)
        {

        }
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
