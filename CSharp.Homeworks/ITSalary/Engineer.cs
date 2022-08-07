using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ITSalary
{
    public class Engineer
{
        public static int baseSalary = 500;

        public string Responsibilities = "1.English Intermediate level. 2. Technical education or courses."; 

        public int Salary { get; set; }

        public string Title { get; set; }

        public Guid Id { get; set; }    

        public string Name { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public int Experience { get; set; }
     

        public string Technologies { get; set; }

        public string GitHub { get; set; }
        
        public Engineer(string name, DateTime? dayOfBirth, int experience, string technologies, string gitHub)
        {
            Id = Guid.NewGuid() ;
            Name = name;
            DayOfBirth = dayOfBirth;
            Experience = experience;
            Technologies = technologies;
            GitHub = gitHub;
            Title = "Engineer";
        }
    }
}
