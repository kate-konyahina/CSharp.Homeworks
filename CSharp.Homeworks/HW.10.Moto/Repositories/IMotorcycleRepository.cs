using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Moto.Repositories
{
    internal interface IMotorcycleRepository
    {
        void CreateMotorcycle(Motorcycle moto);

        void DeleteMotorcycle(Guid Id);

        public void UpdateMotorcycle(Guid id, string name, string model, int year, int odometer);

        List <Motorcycle> GetMotorcycles();

        Motorcycle GetMotorcycleById(Guid Id);
    }
}
