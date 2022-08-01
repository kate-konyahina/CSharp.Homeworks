using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Files
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }

        public Files (string name, string code, string category, int size)
        {
            Name = name;
            Code = code;
            Category = category;
            Size = size;
        }
    }
}
