using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ITSalary
{
    internal class Junior : Engineer
    {
        public Junior(string name, DateTime? dayOfBirth, int experience, string technologies, string gitHub) : base(name, dayOfBirth, experience, technologies, gitHub)
        {
            Salary = baseSalary;
            Title = "Junior developer";
            Responsibilities = "1.English Intermediate level. 2. Technical education or courses. 3. Development of programs aimed at solving problems under the supervision of senior colleagues. 4. Bug fixing. 5. Participation in working meetings.";
        }

    }
}
