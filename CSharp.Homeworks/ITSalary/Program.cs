// See https://aka.ms/new-console-template for more information

using HW12.ITSalary;
using HW12.ITSalary.Repositories;

IEngineerRepository engineerRepository;
engineerRepository = new StaticCollectionEngineerRepository();

Junior dev1 = new Junior("Piotr Klimov", null, 1, ".Net, Unity", "http//GitHub3");
Architect dev2 = new Architect("Ivan Ivanou", null, 12, ".Net, WPF, Blazor, ASP.Net", "http//GitHub1");
Senior dev3 = new Senior("Pavel Pavlov", null, 7, ".Net, Xamarin", "http//GitHub2");


engineerRepository.CreateEngineer(dev1);
engineerRepository.CreateEngineer(dev2);
engineerRepository.CreateEngineer(dev3);

engineerRepository.GetEngineers();

engineerRepository.GetResponsibilities("Piotr Klimov");

try
{
    engineerRepository.GetResponsibilities("Maria Belousova");
}
catch (Exception DeveloperNotFoundException)
{
    Console.WriteLine("{0} Exception caught.", DeveloperNotFoundException);
}


