using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ITSalary
{
    internal class TeamLeader : Engineer
    {
        public TeamLeader(string name, DateTime? dayOfBirth, int experience, string technologies, string gitHub) : base(name, dayOfBirth, experience, technologies, gitHub)
        {
            Salary = baseSalary * 8 + 500;
            Title = "Team Leader";
            Responsibilities = "1.English Intermediate level. 2. Technical education or courses. 3. Development of programs aimed at solving problems. 4. Bug fixing. 5. Participation in working meetings. 6. Code review. 7. Solving complex non-trivial issues. 8. Assisting entry and mid-level employees. 9. Working with priorities, assigning tasks to team members. 10. Communication with clients. 11. Organizing meetings. ";
        }
    }
}
