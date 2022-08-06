using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Moto.Repositories
{
    public sealed class StaticCollectionMotorcycleRepository : IMotorcycleRepository
    {
        private static List<Motorcycle> _motorcycles = new List<Motorcycle>();

        public void CreateMotorcycle(Motorcycle moto)
        {
            _motorcycles.Add(moto);
        }

        public void DeleteMotorcycle(Guid Id)
        {
            _motorcycles = _motorcycles.Where(moto => moto.Id != Id).ToList();
        }

        public Motorcycle GetMotorcycleById(Guid Id)
        {
            Motorcycle moto = _motorcycles.Find(moto => moto.Id == Id);
            return moto;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            return _motorcycles;
        }

        public void UpdateMotorcycle(Guid id, string name, string model, int year, int odometer)
        {
            foreach (Motorcycle moto in _motorcycles)
            {
                if (moto.Id == id)
                {
                    moto.Name = name;
                    moto.Model = model;
                    moto.Year = year;
                    moto.Odometer = odometer;
                    break;
                }
            }
        }
    }
}
