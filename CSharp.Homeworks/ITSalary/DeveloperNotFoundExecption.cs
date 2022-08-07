using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ITSalary
{
    internal class DeveloperNotFoundExecption : Exception
{
        public DeveloperNotFoundExecption(string message)
           : base(message) 
        {
        }
    }
}
