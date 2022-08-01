using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class ComputerProgram : Files
    {
        public ComputerProgram(string name, string code, string category, int size) : base(name, code, category, size)
        {
        }
    }
}
