using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ITSalary
{
    internal class Architect : Engineer
    {
        public Architect(string name, DateTime? dayOfBirth, int experience, string technologies, string gitHub) : base(name, dayOfBirth, experience, technologies, gitHub)
        {
            Salary = baseSalary * 12 + 1000;
            Title = "Architect";
            Responsibilities = "1.English Intermediate level. 2. Technical education or courses. 3. Development of programs aimed at solving problems. 4. Participation in working meetings. 5. Code review. 6. Solving complex non-trivial issues. 7. Assisting other employees. 8. Working with priorities, assigning tasks to team members. 9. Communication with clients. 10. System design. 11. Documentation development. "; 
        }
     }
 }
