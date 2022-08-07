using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ITSalary.Repositories
{
    public sealed class StaticCollectionEngineerRepository : IEngineerRepository
    {
        private static List<Engineer> _engineers = new List<Engineer>();

        public void CreateEngineer(Engineer dev)
        {
            _engineers.Add(dev);
        }

        public void DeleteEngineer(Guid Id)
        {
                _engineers = _engineers.Where(dev => dev.Id != Id).ToList(); ;
        }

        public void GetSalary(Guid Id)
        {
            Engineer dev = _engineers.Find(dev => dev.Id == Id);
            if (dev == null)
            {
                throw new DeveloperNotFoundExecption("Developer is not found.");
            }
            else
            Console.WriteLine(dev.Salary);
        }

        public void GetResponsibilities(string Name)
        {
            Engineer dev = _engineers.Find(dev => dev.Name == Name);
            if (dev == null)
            {
                throw new DeveloperNotFoundExecption("Developer is not found.");
            }
            else
                Console.WriteLine(dev.Responsibilities);
        }

        public List<Engineer> GetEngineers()
        {
            List<Engineer> sorted = _engineers.OrderByDescending(x => x.Experience).ToList();
            foreach (Engineer dev in sorted)
            Console.WriteLine($"Company: SaM Solutions, Full Name: {dev.Name}, Experience: {dev.Experience}, Title: {dev.Title}, Salary: {dev.Salary} USD, GitHub: {dev.GitHub}.");
            return sorted;     
        }

        public Engineer GetEngineerById(Guid Id)
        {
            Engineer dev = _engineers.Find(dev => dev.Id == Id);
            return dev;
        }

        public void UpdateEngineer(Guid id, string name, DateTime? dayOfBirth, int experience, string technologies, string gitHub)
        {
            foreach (Engineer dev in _engineers)
            {
                if (dev.Id == id)
                {
                    dev.Name = name;
                    dev.DayOfBirth = dayOfBirth;
                    dev.Experience = experience;
                    dev.Technologies = technologies;
                    dev.GitHub = gitHub;
                    break;
                }
            }
        }
    }
}
