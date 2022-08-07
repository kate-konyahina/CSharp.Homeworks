using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ITSalary.Repositories
{
    internal interface IEngineerRepository
{
        void CreateEngineer (Engineer dev);

        void DeleteEngineer (Guid Id);

        void UpdateEngineer (Guid id, string name, DateTime? dayOfBirth, int experience, string technologies, string gitHub);

        void GetSalary (Guid Id);

        void GetResponsibilities(string Name);

        List<Engineer> GetEngineers();

        Engineer GetEngineerById(Guid Id);
    }
}
